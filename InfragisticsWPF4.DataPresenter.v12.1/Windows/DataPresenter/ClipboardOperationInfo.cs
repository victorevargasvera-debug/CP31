using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000089 RID: 137
	internal class ClipboardOperationInfo
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x0001994E File Offset: 0x00017B4E
		internal ClipboardOperationInfo(global::Infragistics.Windows.DataPresenter.DataPresenterBase owner)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(owner);
			this._owner = owner;
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00019963 File Offset: 0x00017B63
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0001996C File Offset: 0x00017B6C
		internal bool CanPerformOperation(global::Infragistics.Windows.DataPresenter.ClipboardOperation operation)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout targetFieldLayout = this.GetTargetFieldLayout(operation);
			if (targetFieldLayout == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.AllowClipboardOperations allowClipboardOperations;
			switch (operation)
			{
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Cut:
				allowClipboardOperations = global::Infragistics.Windows.DataPresenter.AllowClipboardOperations.Cut;
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Copy:
				allowClipboardOperations = global::Infragistics.Windows.DataPresenter.AllowClipboardOperations.Copy;
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste:
				allowClipboardOperations = global::Infragistics.Windows.DataPresenter.AllowClipboardOperations.Paste;
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents:
				allowClipboardOperations = global::Infragistics.Windows.DataPresenter.AllowClipboardOperations.ClearContents;
				break;
			default:
				return false;
			}
			global::Infragistics.Windows.DataPresenter.AllowClipboardOperations allowClipboardOperationsResolved = targetFieldLayout.AllowClipboardOperationsResolved;
			return allowClipboardOperations == (allowClipboardOperations & allowClipboardOperationsResolved);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000199C4 File Offset: 0x00017BC4
		internal bool ClearCellContents()
		{
			global::Infragistics.Windows.DataPresenter.CellValueProviderSource source;
			global::Infragistics.Windows.DataPresenter.ICellValueProvider cellValueProvider = this.GetCellValueProvider(global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents, out source);
			return this.ClearCellContents(cellValueProvider, source);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000199E4 File Offset: 0x00017BE4
		private bool ClearCellContents(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider, global::Infragistics.Windows.DataPresenter.CellValueProviderSource source)
		{
			if (provider == null || provider.FieldCount < 1 || provider.RecordCount < 1)
			{
				return false;
			}
			if (!global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ContainsModifiableFields(provider))
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ClearValues(provider);
			global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction action = new global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction(provider, true, this.GetSelectionTarget(source));
			return this._owner.History.PerformAction(action, global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ClearCellsOperationContext);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00019A40 File Offset: 0x00017C40
		private static void ClearValues(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider)
		{
			if (provider != null)
			{
				int fieldCount = provider.FieldCount;
				global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[fieldCount];
				for (int i = 0; i < fieldCount; i++)
				{
					array[i] = provider.GetField(i);
				}
				int j = 0;
				int recordCount = provider.RecordCount;
				while (j < recordCount)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord record = provider.GetRecord(j);
					if (record != null)
					{
						for (int k = 0; k < fieldCount; k++)
						{
							global::Infragistics.Windows.DataPresenter.CellValueHolder value = provider.GetValue(j, k);
							if (value != null)
							{
								object value2 = null;
								record.CoerceNullEditValue(array[k], ref value2);
								value.Initialize(value2, false);
							}
						}
					}
					j++;
				}
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00019AD0 File Offset: 0x00017CD0
		internal static bool ContainsModifiableFields(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider)
		{
			int i = 0;
			int fieldCount = provider.FieldCount;
			while (i < fieldCount)
			{
				global::Infragistics.Windows.DataPresenter.Field field = provider.GetField(i);
				if (!global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ShouldSkipFieldModification(field))
				{
					return true;
				}
				i++;
			}
			return false;
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00019B04 File Offset: 0x00017D04
		internal static bool ConvertToCellValue(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider, global::System.Collections.Generic.IList<object> originalDataItems, bool[] skipFields, bool checkEditableCells, out global::Infragistics.Windows.DataPresenter.RowColumnIndex stopAtCell, global::Infragistics.Windows.DataPresenter.ClipboardOperation? operation, global::Infragistics.Windows.DataPresenter.RecordManager defaultRecordManager, out bool hadConversionErrors)
		{
			stopAtCell = null;
			hadConversionErrors = false;
			int recordCount = provider.RecordCount;
			int fieldCount = provider.FieldCount;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, bool> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, bool>();
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = provider.FieldLayout;
			if (fieldLayout == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayout.DataPresenter;
			global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo clipboardOperationInfo = dataPresenter.ClipboardOperationInfo;
			global::System.Exception ex = null;
			global::Infragistics.Windows.DataPresenter.ClipboardError? clipboardError = null;
			bool defaultDisplayErrorMessage = false;
			for (int i = 0; i < recordCount; i++)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = provider.GetRecord(i);
				bool flag = dataRecord == null || global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsSameDataItem(dataRecord.DataItem, originalDataItems[i]);
				if (dataRecord == null && defaultRecordManager != null)
				{
					dataRecord = defaultRecordManager.CurrentAddRecord;
				}
				if (flag && dataRecord != null)
				{
					flag = !global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(dataRecord);
				}
				for (int j = 0; j < fieldCount; j++)
				{
					global::Infragistics.Windows.DataPresenter.CellValueHolder value = provider.GetValue(i, j);
					if (value != null)
					{
						if (!flag)
						{
							value.Ignore = true;
						}
						if (!value.Ignore)
						{
							if (skipFields != null && skipFields[j])
							{
								value.Ignore = true;
							}
							else
							{
								global::Infragistics.Windows.DataPresenter.Field field = provider.GetField(j);
								if (checkEditableCells && dataRecord != null && !dataRecord.GetIsEditingAllowed(field))
								{
									clipboardError = new global::Infragistics.Windows.DataPresenter.ClipboardError?(global::Infragistics.Windows.DataPresenter.ClipboardError.ReadOnlyCell);
									bool allowEditResolved;
									if (!dictionary.TryGetValue(field, out allowEditResolved))
									{
										allowEditResolved = field.AllowEditResolved;
										dictionary[field] = allowEditResolved;
										defaultDisplayErrorMessage = true;
									}
								}
								if (clipboardError == null && value.IsDisplayText)
								{
									global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field);
									global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolder clipboardCellValueHolder = value as global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolder;
									if (clipboardCellValueHolder != null)
									{
										string a = cachedConverter.ConvertCellValue(clipboardCellValueHolder.OriginalValue, out ex);
										if (ex == null && string.Equals(a, clipboardCellValueHolder.OriginalDisplayText))
										{
											if (cachedConverter.ValidateValue(clipboardCellValueHolder.OriginalValue, out ex))
											{
												value.Initialize(clipboardCellValueHolder.OriginalValue, false);
												goto IL_2B4;
											}
											ex = null;
										}
									}
									if (clipboardError == null)
									{
										object value2 = value.Value;
										object obj = cachedConverter.ConvertDisplayText((value2 != null) ? value2.ToString() : null, out ex);
										if (ex != null)
										{
											clipboardError = new global::Infragistics.Windows.DataPresenter.ClipboardError?(global::Infragistics.Windows.DataPresenter.ClipboardError.ConversionError);
											defaultDisplayErrorMessage = true;
										}
										else if (cachedConverter.ValidateValue(obj, out ex))
										{
											if (dataRecord != null)
											{
												dataRecord.CoerceNullEditValue(field, ref obj);
											}
											value.Initialize(obj, false);
										}
										else
										{
											clipboardError = new global::Infragistics.Windows.DataPresenter.ClipboardError?(global::Infragistics.Windows.DataPresenter.ClipboardError.ValidationError);
											defaultDisplayErrorMessage = true;
										}
									}
								}
								if (clipboardError != null)
								{
									hadConversionErrors = true;
									value.Ignore = true;
									if (operation != null)
									{
										switch (clipboardOperationInfo.RaiseClipboardError(operation.Value, clipboardError.Value, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue, true, ex, defaultDisplayErrorMessage, dataRecord, field))
										{
										case global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.ClearCellAndContinue:
											if (dataRecord != null)
											{
												object value3 = null;
												dataRecord.CoerceNullEditValue(field, ref value3);
												value.Ignore = false;
												value.Value = value3;
											}
											break;
										case global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop:
											stopAtCell = new global::Infragistics.Windows.DataPresenter.RowColumnIndex(i, j);
											return true;
										case global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Revert:
											return false;
										}
									}
									ex = null;
									clipboardError = null;
									defaultDisplayErrorMessage = false;
								}
							}
						}
					}
					IL_2B4:;
				}
			}
			return true;
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00019DE4 File Offset: 0x00017FE4
		internal static void ConvertToDisplayText(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider)
		{
			int recordCount = provider.RecordCount;
			int fieldCount = provider.FieldCount;
			for (int i = 0; i < recordCount; i++)
			{
				for (int j = 0; j < fieldCount; j++)
				{
					global::Infragistics.Windows.DataPresenter.CellValueHolder value = provider.GetValue(i, j);
					if (value != null && !value.IsDisplayText)
					{
						global::Infragistics.Windows.DataPresenter.Field field = provider.GetField(j);
						global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field);
						string value2 = cachedConverter.ConvertCellValue(value.Value);
						value.Initialize(value2, true);
					}
				}
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00019E5C File Offset: 0x0001805C
		internal bool CopyToClipboard()
		{
			global::Infragistics.Windows.DataPresenter.CellValueProviderSource cellValueProviderSource;
			global::Infragistics.Windows.DataPresenter.ICellValueProvider cellValueProvider = this.GetCellValueProvider(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Copy, out cellValueProviderSource);
			return this.CopyToClipboard(cellValueProvider);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00019E7C File Offset: 0x0001807C
		private bool CopyToClipboard(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider)
		{
			global::System.Windows.IDataObject dataObject = this.CreateDataObject(provider, false);
			if (dataObject == null)
			{
				return false;
			}
			bool result;
			try
			{
				result = global::Infragistics.Windows.Helpers.ClipboardHelper.SetDataObject(dataObject, true);
			}
			catch (global::System.Exception exception)
			{
				this.RaiseClipboardError(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Copy, global::Infragistics.Windows.DataPresenter.ClipboardError.Exception, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop, false, exception);
				result = false;
			}
			return result;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00019EC4 File Offset: 0x000180C4
		private global::System.Windows.IDataObject CreateDataObject(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider, bool isDragDrop)
		{
			if (provider == null || provider.FieldCount < 1 || provider.RecordCount < 1)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = provider.FieldLayout;
			bool flag = fieldLayout != null && fieldLayout.CopyFieldLabelsToClipboardResolved;
			global::System.Collections.Generic.IDictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellValueHolder> dictionary = flag ? new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellValueHolder>() : null;
			int fieldCount = provider.FieldCount;
			global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[fieldCount];
			for (int i = 0; i < fieldCount; i++)
			{
				global::Infragistics.Windows.DataPresenter.Field field = provider.GetField(i);
				array[i] = field;
				if (dictionary != null)
				{
					dictionary[field] = new global::Infragistics.Windows.DataPresenter.CellValueHolder(field.Label, false);
				}
			}
			int j = 0;
			int recordCount = provider.RecordCount;
			while (j < recordCount)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = provider.GetRecord(j);
				if (record != null)
				{
					for (int k = 0; k < fieldCount; k++)
					{
						object cellValue = record.GetCellValue(array[k], true);
						global::Infragistics.Windows.DataPresenter.CellValueHolder value = provider.GetValue(j, k);
						value.Initialize(cellValue, false);
					}
				}
				j++;
			}
			global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection clipboardCellValueHolderCollection = new global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection(provider, dictionary);
			global::Infragistics.Windows.DataPresenter.Events.ClipboardCopyingEventArgs clipboardCopyingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.ClipboardCopyingEventArgs(clipboardCellValueHolderCollection);
			this._owner.RaiseClipboardCopying(clipboardCopyingEventArgs);
			if (clipboardCopyingEventArgs.Cancel)
			{
				return null;
			}
			global::System.Windows.IDataObject dataObject = global::Infragistics.Windows.Helpers.ClipboardHelper.CreateDataObject();
			if (dataObject == null)
			{
				return null;
			}
			clipboardCellValueHolderCollection.ConvertToDisplayText();
			clipboardCellValueHolderCollection.ConvertLabelsToText();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.ClipboardEncoding, object> encodings = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.ClipboardEncoding, object>();
			string[] array2 = new string[]
			{
				global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetClipboardDataFormat(typeof(global::Infragistics.Windows.DataPresenter.ClipboardData)),
				global::System.Windows.DataFormats.Html,
				global::System.Windows.DataFormats.CommaSeparatedValue,
				global::System.Windows.DataFormats.Text,
				global::System.Windows.DataFormats.UnicodeText
			};
			foreach (string format in array2)
			{
				this.AddClipboardData(dataObject, format, clipboardCellValueHolderCollection, flag, encodings);
			}
			global::System.Windows.DataObjectCopyingEventArgs dataObjectCopyingEventArgs = new global::System.Windows.DataObjectCopyingEventArgs(dataObject, isDragDrop);
			this._owner.RaiseEvent(dataObjectCopyingEventArgs);
			if (dataObjectCopyingEventArgs.CommandCancelled)
			{
				return null;
			}
			return dataObject;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001A08D File Offset: 0x0001828D
		internal static string GetClipboardDataFormat(global::System.Type type)
		{
			return type.FullName;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001A098 File Offset: 0x00018298
		internal static global::Infragistics.Windows.DataPresenter.ClipboardOperation? GetClipboardOperation(object context)
		{
			if (context == global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.PasteOperationContext)
			{
				return new global::Infragistics.Windows.DataPresenter.ClipboardOperation?(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste);
			}
			if (context == global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ClearCellsOperationContext)
			{
				return new global::Infragistics.Windows.DataPresenter.ClipboardOperation?(global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents);
			}
			return null;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001A0CC File Offset: 0x000182CC
		internal static void GetRowColumnCount(global::Infragistics.Windows.DataPresenter.CellValueHolder[,] cellValues, out int rowCount, out int columnCount)
		{
			if (cellValues == null)
			{
				rowCount = (columnCount = 0);
				return;
			}
			rowCount = cellValues.GetLength(0);
			columnCount = cellValues.GetLength(1);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001A0F8 File Offset: 0x000182F8
		private global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget GetSelectionTarget(global::Infragistics.Windows.DataPresenter.CellValueProviderSource source)
		{
			switch (source)
			{
			case global::Infragistics.Windows.DataPresenter.CellValueProviderSource.SelectedRecords:
			case global::Infragistics.Windows.DataPresenter.CellValueProviderSource.ActiveRecord:
				return global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget.Records;
			case global::Infragistics.Windows.DataPresenter.CellValueProviderSource.SelectedFields:
				return global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget.Fields;
			}
			return global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget.Cells;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001A126 File Offset: 0x00018326
		internal static string GetText(global::Infragistics.Windows.DataPresenter.CellValueHolder cvh)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(cvh);
			return global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetText(cvh.Value);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001A13C File Offset: 0x0001833C
		internal static string GetText(object value)
		{
			string text = null;
			if (value != null)
			{
				text = (global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(string), null, null) as string);
			}
			if (text == null)
			{
				text = string.Empty;
			}
			return text;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001A170 File Offset: 0x00018370
		internal static void InitializeIgnoreState(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider, bool ignore)
		{
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.CellValueHolder> valueEnumerator = provider.GetValueEnumerator();
			if (valueEnumerator != null)
			{
				while (valueEnumerator.MoveNext())
				{
					global::Infragistics.Windows.DataPresenter.CellValueHolder cellValueHolder = valueEnumerator.Current;
					cellValueHolder.Ignore = ignore;
				}
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001A19D File Offset: 0x0001839D
		internal static bool IsDeleted(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return cell == null || global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(cell.Record);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001A1AF File Offset: 0x000183AF
		internal static bool IsDeleted(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return record == null || !record.IsStillValid;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001A1BF File Offset: 0x000183BF
		internal static bool IsSameDataItem(object item1, object item2)
		{
			if (object.ReferenceEquals(item1, item2))
			{
				return true;
			}
			item1 = global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(item1);
			item2 = global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(item2);
			return item1 == item2;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001A1E0 File Offset: 0x000183E0
		internal bool PerformOperation(global::System.Windows.Input.ICommand command)
		{
			global::Infragistics.Windows.DataPresenter.ClipboardOperation operation;
			if (command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Cut)
			{
				operation = global::Infragistics.Windows.DataPresenter.ClipboardOperation.Cut;
			}
			else if (command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Copy)
			{
				operation = global::Infragistics.Windows.DataPresenter.ClipboardOperation.Copy;
			}
			else if (command == global::Infragistics.Windows.DataPresenter.DataPresenterCommands.Paste)
			{
				operation = global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste;
			}
			else
			{
				if (command != global::Infragistics.Windows.DataPresenter.DataPresenterCommands.ClearCellContents)
				{
					return false;
				}
				operation = global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents;
			}
			return this.PerformOperation(operation);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001A228 File Offset: 0x00018428
		internal bool PerformOperation(global::Infragistics.Windows.DataPresenter.ClipboardOperation operation)
		{
			if (!this.CanPerformOperation(operation))
			{
				return false;
			}
			switch (operation)
			{
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Cut:
			{
				if (!this._owner.VerifyOperationIsAllowed(global::Infragistics.Windows.DataPresenter.UIOperation.ClearCellContents))
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.CellValueProviderSource source;
				global::Infragistics.Windows.DataPresenter.ICellValueProvider cellValueProvider = this.GetCellValueProvider(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Cut, out source);
				if (!this.CopyToClipboard(cellValueProvider))
				{
					return false;
				}
				this.ClearCellContents(cellValueProvider, source);
				return true;
			}
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Copy:
				return this.CopyToClipboard();
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste:
				return this.PerformPaste();
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents:
				return this._owner.VerifyOperationIsAllowed(global::Infragistics.Windows.DataPresenter.UIOperation.ClearCellContents) && this.ClearCellContents();
			default:
				return false;
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0001A2B0 File Offset: 0x000184B0
		internal global::Infragistics.Windows.DataPresenter.ClipboardErrorAction RaiseClipboardError(global::Infragistics.Windows.DataPresenter.ClipboardOperation operation, global::Infragistics.Windows.DataPresenter.ClipboardError error, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction defaultAction, bool canContinue, global::System.Exception exception)
		{
			return this.RaiseClipboardError(operation, error, defaultAction, canContinue, exception, true, null, null);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001A2D0 File Offset: 0x000184D0
		internal global::Infragistics.Windows.DataPresenter.ClipboardErrorAction RaiseClipboardError(global::Infragistics.Windows.DataPresenter.ClipboardOperation operation, global::Infragistics.Windows.DataPresenter.ClipboardError error, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction defaultAction, bool canContinue, global::System.Exception exception, bool defaultDisplayErrorMessage, global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			string errorMessage = this.GetErrorMessage(operation, error, exception, canContinue, record, field);
			global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationErrorEventArgs clipboardOperationErrorEventArgs = new global::Infragistics.Windows.DataPresenter.Events.ClipboardOperationErrorEventArgs(operation, error, record, field, errorMessage, exception, canContinue);
			clipboardOperationErrorEventArgs.Action = defaultAction;
			clipboardOperationErrorEventArgs.DisplayErrorMessage = defaultDisplayErrorMessage;
			this._owner.RaiseClipboardOperationError(clipboardOperationErrorEventArgs);
			global::Infragistics.Windows.DataPresenter.ClipboardErrorAction clipboardErrorAction = clipboardOperationErrorEventArgs.Action;
			if ((!canContinue && clipboardErrorAction == global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.ClearCellAndContinue) || clipboardErrorAction == global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue)
			{
				clipboardErrorAction = defaultAction;
			}
			if (clipboardOperationErrorEventArgs.DisplayErrorMessage && !string.IsNullOrEmpty(clipboardOperationErrorEventArgs.Message))
			{
				string message = clipboardOperationErrorEventArgs.Message;
				string errorCaption = this.GetErrorCaption(operation);
				global::System.Windows.MessageBoxButton button = clipboardOperationErrorEventArgs.CanContinueWithRemainingCells ? global::System.Windows.MessageBoxButton.OKCancel : global::System.Windows.MessageBoxButton.OK;
				global::System.Windows.MessageBoxResult messageBoxResult = global::Infragistics.Windows.Utilities.ShowMessageBox(this._owner, message, errorCaption, button, global::System.Windows.MessageBoxImage.Exclamation);
				if (messageBoxResult == global::System.Windows.MessageBoxResult.Cancel)
				{
					clipboardErrorAction = global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop;
				}
			}
			return clipboardErrorAction;
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0001A37D File Offset: 0x0001857D
		internal static bool ShouldSkipFieldModification(global::Infragistics.Windows.DataPresenter.Field f)
		{
			return f == null || f.DisallowModificationViaClipboard;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0001A390 File Offset: 0x00018590
		private bool AddClipboardData(global::System.Windows.IDataObject dataObject, string format, global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection cellValues, bool includeHeader, global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.ClipboardEncoding, object> encodings)
		{
			if (!this.ShouldAddFormat(dataObject, format))
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.ClipboardEncoding clipboardEncoding = global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.CreateEncoding(this._owner, dataObject, format);
			if (clipboardEncoding != null)
			{
				object clipboardData;
				if (encodings == null || !encodings.TryGetValue(clipboardEncoding, out clipboardData))
				{
					clipboardData = clipboardEncoding.GetClipboardData(cellValues, includeHeader);
					if (encodings != null)
					{
						encodings.Add(clipboardEncoding, clipboardData);
					}
				}
				if (clipboardData != null)
				{
					dataObject.SetData(format, clipboardData);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0001A3F0 File Offset: 0x000185F0
		private global::Infragistics.Windows.DataPresenter.Cell[] CreateRectangularArray(global::Infragistics.Windows.DataPresenter.Cell[] cells, bool allowSparse, out int fieldCount, out bool isSparse)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, object> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, object>();
			int num = 0;
			global::Infragistics.Windows.DataPresenter.Record record = null;
			for (int i = 0; i < cells.Length; i++)
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = cells[i];
				if (cell.Record != record)
				{
					record = cell.Record;
					num++;
				}
				global::Infragistics.Windows.DataPresenter.Field field = cells[i].Field;
				if (!dictionary.ContainsKey(field))
				{
					dictionary.Add(field, null);
				}
			}
			fieldCount = dictionary.Count;
			if (num * fieldCount == cells.Length)
			{
				isSparse = false;
				return cells;
			}
			if (num == 0 || fieldCount == 0)
			{
				isSparse = false;
				return new global::Infragistics.Windows.DataPresenter.Cell[0];
			}
			isSparse = true;
			if (!allowSparse)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Cell[] array = new global::Infragistics.Windows.DataPresenter.Cell[0];
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = cells[0].Record.FieldLayout;
			if (fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.Field[] navigationOrderFields = global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetNavigationOrderFields(fieldLayout);
				if (navigationOrderFields != null)
				{
					int[] array2 = new int[navigationOrderFields.Length];
					int num2 = 0;
					for (int j = 0; j < navigationOrderFields.Length; j++)
					{
						global::Infragistics.Windows.DataPresenter.Field key = navigationOrderFields[j];
						int num3;
						if (dictionary.ContainsKey(key))
						{
							num3 = num2++;
						}
						else
						{
							num3 = -1;
						}
						array2[j] = num3;
					}
					array = new global::Infragistics.Windows.DataPresenter.Cell[num * fieldCount];
					record = null;
					int num4 = -1;
					foreach (global::Infragistics.Windows.DataPresenter.Cell cell2 in cells)
					{
						if (cell2.Record != record)
						{
							record = cell2.Record;
							num4++;
						}
						global::Infragistics.Windows.DataPresenter.Field field2 = cell2.Field;
						array[num4 * fieldCount + array2[field2.NavigationIndex]] = cell2;
					}
				}
			}
			return array;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0001A554 File Offset: 0x00018754
		private global::Infragistics.Windows.DataPresenter.ICellValueProvider GetCellValueProvider(global::Infragistics.Windows.DataPresenter.ClipboardOperation operation, out global::Infragistics.Windows.DataPresenter.CellValueProviderSource source)
		{
			source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.Unknown;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems = this._owner.SelectedItems;
			if (selectedItems == null)
			{
				return null;
			}
			switch (operation)
			{
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Cut:
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Copy:
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste:
				if (selectedItems.HasMixedSelection)
				{
					this.RaiseClipboardError(operation, global::Infragistics.Windows.DataPresenter.ClipboardError.MixedSelection, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop, false, null);
					return null;
				}
				break;
			}
			if (selectedItems.HasFields)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout owner = selectedItems.Fields[0].Owner;
				global::Infragistics.Windows.DataPresenter.DataRecord[] selectedFieldRecords = this.GetSelectedFieldRecords(owner, false);
				if (selectedFieldRecords == null || selectedFieldRecords.Length == 0)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.Field[] array = selectedItems.Fields.ToArray();
				global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.Field>(array, global::Infragistics.Windows.DataPresenter.FieldNavigationIndexComparer.Instance);
				source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.SelectedFields;
				return new global::Infragistics.Windows.DataPresenter.RecordCellRangeValueProvider(selectedFieldRecords, array);
			}
			else if (selectedItems.HasCells)
			{
				global::Infragistics.Windows.DataPresenter.Cell[] array2 = selectedItems.Cells.ToArray();
				global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.Cell>(array2, global::Infragistics.Windows.DataPresenter.CellVisiblePositionComparer.Instance);
				bool flag = operation == global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents;
				int fieldCount;
				bool flag2;
				array2 = this.CreateRectangularArray(array2, flag, out fieldCount, out flag2);
				if (!flag && flag2)
				{
					if (operation == global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste)
					{
						return null;
					}
					this.RaiseClipboardError(operation, global::Infragistics.Windows.DataPresenter.ClipboardError.NonRectangularSelection, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop, false, null);
					return null;
				}
				else
				{
					if (!global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsInSameFieldLayout(array2))
					{
						return null;
					}
					source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.SelectedCells;
					return new global::Infragistics.Windows.DataPresenter.GridCellRangeValueProvider(array2, fieldCount);
				}
			}
			else
			{
				if (selectedItems.HasRecords)
				{
					foreach (global::Infragistics.Windows.DataPresenter.Record record in selectedItems.Records)
					{
						if (!(record is global::Infragistics.Windows.DataPresenter.DataRecord))
						{
							return null;
						}
					}
					global::Infragistics.Windows.DataPresenter.Record[] array3 = selectedItems.Records.ToArray();
					global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.Record>(array3, global::Infragistics.Windows.DataPresenter.RecordVisiblePositionComparer.Instance);
					global::Infragistics.Windows.DataPresenter.DataRecord[] array4 = new global::Infragistics.Windows.DataPresenter.DataRecord[array3.Length];
					array3.CopyTo(array4, 0);
					if (!this.IsInSameFieldLayout(array4))
					{
						return null;
					}
					source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.SelectedRecords;
					return new global::Infragistics.Windows.DataPresenter.RecordCellRangeValueProvider(array4, global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetNavigationOrderFields(array3[0].FieldLayout));
				}
				if (operation == global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste)
				{
					return null;
				}
				if (!selectedItems.HasSelection)
				{
					if (this._owner.ActiveCell != null)
					{
						source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.ActiveCell;
						return new global::Infragistics.Windows.DataPresenter.GridCellRangeValueProvider(new global::Infragistics.Windows.DataPresenter.Cell[]
						{
							this._owner.ActiveCell
						}, 1);
					}
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._owner.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord != null)
					{
						source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.ActiveRecord;
						return new global::Infragistics.Windows.DataPresenter.RecordCellRangeValueProvider(new global::Infragistics.Windows.DataPresenter.DataRecord[]
						{
							dataRecord
						}, global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetNavigationOrderFields(dataRecord.FieldLayout));
					}
				}
				return null;
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0001A790 File Offset: 0x00018990
		private string GetErrorCaption(global::Infragistics.Windows.DataPresenter.ClipboardOperation operation)
		{
			string text;
			switch (operation)
			{
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Cut:
				text = "ClipboardError_CutTitle";
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Copy:
				text = "ClipboardError_CopyTitle";
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste:
				text = "ClipboardError_PasteTitle";
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents:
				text = "ClipboardError_ClearContentsTitle";
				break;
			default:
				text = null;
				break;
			}
			if (text == null)
			{
				return string.Empty;
			}
			return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(text);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0001A7E8 File Offset: 0x000189E8
		private string GetErrorMessage(global::Infragistics.Windows.DataPresenter.ClipboardOperation operation, global::Infragistics.Windows.DataPresenter.ClipboardError error, global::System.Exception exception, bool canContinue, global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field)
		{
			string text = (exception != null) ? exception.Message : string.Empty;
			string text2 = (field != null) ? global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetText(field.Label ?? field.Name) : string.Empty;
			string result;
			switch (error)
			{
			case global::Infragistics.Windows.DataPresenter.ClipboardError.MixedSelection:
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ClipboardError_MixedSelectionMessage");
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardError.NonRectangularSelection:
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ClipboardError_NonRectangularSelectionMessage");
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardError.NotEnoughColumns:
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ClipboardError_NotEnoughColumnsMessage");
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardError.NotEnoughRows:
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ClipboardError_NotEnoughRowsMessage");
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardError.ReadOnlyCell:
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ClipboardError_ReadOnlyCellMessage", new object[]
				{
					text2
				});
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardError.ConversionError:
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ClipboardError_ConversionErrorMessage", new object[]
				{
					text2,
					text
				});
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardError.ValidationError:
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ClipboardError_ValidationErrorMessage", new object[]
				{
					text
				});
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardError.SetCellValueError:
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ClipboardError_SetCellValueErrorMessage", new object[]
				{
					text
				});
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardError.UpdateRecordError:
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ClipboardError_UpdateRecordErrorMessage");
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardError.InsertRecordError:
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ClipboardError_InsertRecordErrorMessage");
				break;
			case global::Infragistics.Windows.DataPresenter.ClipboardError.Exception:
			{
				string name;
				if (canContinue)
				{
					name = "ClipboardError_ExceptionMessageCanContinue";
				}
				else
				{
					name = "ClipboardError_ExceptionMessageCannotContinue";
				}
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(name, new object[]
				{
					text
				});
				break;
			}
			default:
				result = string.Empty;
				break;
			}
			return result;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0001A968 File Offset: 0x00018B68
		private static global::Infragistics.Windows.DataPresenter.Field[] GetNavigationOrderFields(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = fl.StyleGenerator;
			if (styleGenerator == null)
			{
				return new global::Infragistics.Windows.DataPresenter.Field[0];
			}
			return styleGenerator.GridFieldMap.GetNavigationOrderFields();
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0001A994 File Offset: 0x00018B94
		private global::Infragistics.Windows.DataPresenter.ICellValueProvider GetPasteCellValueProvider(global::Infragistics.Windows.DataPresenter.CellValueHolder[,] cellValues, global::Infragistics.Windows.DataPresenter.Cell targetCell, out global::Infragistics.Windows.DataPresenter.CellValueProviderSource source)
		{
			source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.Unknown;
			if (cellValues == null || cellValues.Length == 0)
			{
				return null;
			}
			if (targetCell != null)
			{
				if (global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(targetCell))
				{
					return null;
				}
				return this.GetPasteCellValueProvider(cellValues, targetCell);
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.ICellValueProvider cellValueProvider = this.GetCellValueProvider(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste, out source);
				if (cellValueProvider != null)
				{
					int num;
					int num2;
					global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetRowColumnCount(cellValues, out num, out num2);
					int fieldCount = cellValueProvider.FieldCount;
					int recordCount = cellValueProvider.RecordCount;
					if (fieldCount > 0 && recordCount > 0 && fieldCount >= num2 && recordCount >= num && fieldCount % num2 == 0 && recordCount % num == 0)
					{
						for (int i = 0; i < recordCount; i++)
						{
							for (int j = 0; j < fieldCount; j++)
							{
								cellValueProvider.SetValue(i, j, cellValues[i % num, j % num2].Clone());
							}
						}
						return cellValueProvider;
					}
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems = this._owner.SelectedItems;
				if (selectedItems == null)
				{
					return null;
				}
				if (selectedItems.HasCells)
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = selectedItems.Cells[0];
					foreach (global::Infragistics.Windows.DataPresenter.Cell cell2 in selectedItems.Cells)
					{
						if (global::Infragistics.Windows.DataPresenter.CellVisiblePositionComparer.Instance.Compare(cell2, cell) < 0)
						{
							cell = cell2;
						}
					}
					source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.SelectedCells;
					return this.GetPasteCellValueProvider(cellValues, cell);
				}
				if (selectedItems.HasRecords)
				{
					global::Infragistics.Windows.DataPresenter.Record record = selectedItems.Records[0];
					foreach (global::Infragistics.Windows.DataPresenter.Record record2 in selectedItems.Records)
					{
						if (global::Infragistics.Windows.DataPresenter.RecordVisiblePositionComparer.Instance.Compare(record2, record) < 0)
						{
							record = record2;
						}
					}
					source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.SelectedRecords;
					return this.GetPasteCellValueProvider(cellValues, record);
				}
				if (!selectedItems.HasFields)
				{
					if (!selectedItems.HasSelection)
					{
						if (this._owner.ActiveCell != null)
						{
							source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.ActiveCell;
							return this.GetPasteCellValueProvider(cellValues, this._owner.ActiveCell);
						}
						if (this._owner.ActiveRecord != null)
						{
							source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.ActiveRecord;
							return this.GetPasteCellValueProvider(cellValues, this._owner.ActiveRecord);
						}
					}
					return null;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout targetFieldLayout = this.GetTargetFieldLayout(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste);
				global::Infragistics.Windows.DataPresenter.DataRecord[] selectedFieldRecords = this.GetSelectedFieldRecords(targetFieldLayout, true);
				if (selectedFieldRecords == null || selectedFieldRecords.Length == 0)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.DataRecord anchorRecord = selectedFieldRecords[0];
				global::Infragistics.Windows.DataPresenter.Field[] array = selectedItems.Fields.ToArray();
				global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.Field>(array, global::Infragistics.Windows.DataPresenter.FieldNavigationIndexComparer.Instance);
				source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.SelectedFields;
				return this.GetPasteCellValueProvider(cellValues, anchorRecord, new int?(array[0].NavigationIndex));
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0001AC00 File Offset: 0x00018E00
		private global::Infragistics.Windows.DataPresenter.ICellValueProvider GetPasteCellValueProvider(global::Infragistics.Windows.DataPresenter.CellValueHolder[,] cellValues, global::Infragistics.Windows.DataPresenter.Cell anchorCell)
		{
			global::Infragistics.Windows.DataPresenter.Field field = anchorCell.Field;
			int navigationIndex = field.NavigationIndex;
			if (navigationIndex < 0)
			{
				return null;
			}
			return this.GetPasteCellValueProvider(cellValues, anchorCell.Record, new int?(navigationIndex));
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0001AC34 File Offset: 0x00018E34
		private global::Infragistics.Windows.DataPresenter.ICellValueProvider GetPasteCellValueProvider(global::Infragistics.Windows.DataPresenter.CellValueHolder[,] cellValues, global::Infragistics.Windows.DataPresenter.Record anchorRecord)
		{
			return this.GetPasteCellValueProvider(cellValues, anchorRecord, null);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0001AC54 File Offset: 0x00018E54
		private global::Infragistics.Windows.DataPresenter.ICellValueProvider GetPasteCellValueProvider(global::Infragistics.Windows.DataPresenter.CellValueHolder[,] cellValues, global::Infragistics.Windows.DataPresenter.Record anchorRecord, int? firstFieldIndex)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = anchorRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord == null)
			{
				return null;
			}
			int num = (firstFieldIndex == null) ? 0 : firstFieldIndex.Value;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = anchorRecord.FieldLayout;
			if (fieldLayout == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Field[] navigationOrderFields = global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetNavigationOrderFields(fieldLayout);
			int num2;
			int num3;
			global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetRowColumnCount(cellValues, out num2, out num3);
			if (navigationOrderFields.Length - num < num3)
			{
				global::Infragistics.Windows.DataPresenter.ClipboardErrorAction clipboardErrorAction = this.RaiseClipboardError(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste, global::Infragistics.Windows.DataPresenter.ClipboardError.NotEnoughColumns, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue, true, null);
				if (clipboardErrorAction != global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue)
				{
					return null;
				}
			}
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.DataRecord[] array;
			if (dataRecord is global::Infragistics.Windows.DataPresenter.FilterRecord)
			{
				if (num2 > 1)
				{
					global::Infragistics.Windows.DataPresenter.ClipboardErrorAction clipboardErrorAction2 = this.RaiseClipboardError(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste, global::Infragistics.Windows.DataPresenter.ClipboardError.NotEnoughRows, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue, true, null, false, dataRecord, null);
					if (clipboardErrorAction2 != global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue)
					{
						return null;
					}
				}
				array = new global::Infragistics.Windows.DataPresenter.DataRecord[]
				{
					dataRecord
				};
				num2 = 1;
			}
			else if (dataRecord.IsAddRecord)
			{
				array = new global::Infragistics.Windows.DataPresenter.DataRecord[]
				{
					dataRecord
				};
				flag = true;
			}
			else
			{
				if (dataRecord.IsSpecialRecord)
				{
					return null;
				}
				array = global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetRecords(dataRecord, num2, true, true, false);
			}
			if (array == null)
			{
				return null;
			}
			if (array.Length < num2 && !flag)
			{
				bool flag2 = array.Length > 0;
				global::Infragistics.Windows.DataPresenter.ClipboardErrorAction clipboardErrorAction3 = this.RaiseClipboardError(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste, global::Infragistics.Windows.DataPresenter.ClipboardError.NotEnoughRows, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue, flag2, null);
				if (!flag2 || clipboardErrorAction3 != global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue)
				{
					return null;
				}
			}
			int num4 = global::System.Math.Min(navigationOrderFields.Length - num, num3);
			global::Infragistics.Windows.DataPresenter.Field[] array2 = new global::Infragistics.Windows.DataPresenter.Field[num4];
			for (int i = 0; i < num4; i++)
			{
				array2[i] = navigationOrderFields[i + num];
			}
			return new global::Infragistics.Windows.DataPresenter.RecordCellRangeValueProvider(array, array2, cellValues, flag);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001ADA0 File Offset: 0x00018FA0
		private string GetPreferredPasteFormat(global::System.Windows.IDataObject dataObject)
		{
			if (dataObject.GetDataPresent(typeof(global::Infragistics.Windows.DataPresenter.ClipboardData)))
			{
				return global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetClipboardDataFormat(typeof(global::Infragistics.Windows.DataPresenter.ClipboardData));
			}
			if (dataObject.GetDataPresent(global::System.Windows.DataFormats.UnicodeText))
			{
				return global::System.Windows.DataFormats.UnicodeText;
			}
			if (dataObject.GetDataPresent(global::System.Windows.DataFormats.Text))
			{
				return global::System.Windows.DataFormats.Text;
			}
			if (dataObject.GetDataPresent(global::System.Windows.DataFormats.CommaSeparatedValue))
			{
				return global::System.Windows.DataFormats.CommaSeparatedValue;
			}
			return string.Empty;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001AE10 File Offset: 0x00019010
		private static global::Infragistics.Windows.DataPresenter.DataRecord[] GetRecords(global::Infragistics.Windows.DataPresenter.DataRecord anchorRecord, int recordCount, bool ignoreSpecialRecords, bool ignoreAddRecordTemplate, bool alwaysIncludeAnchor)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
			int visibleIndex = anchorRecord.VisibleIndex;
			if (visibleIndex >= 0)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = anchorRecord.FieldLayout;
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = anchorRecord.ParentCollection.ViewableRecords;
				int num = viewableRecords.Count - visibleIndex;
				for (int i = 0; i < num; i++)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = viewableRecords[i + visibleIndex] as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord != null && dataRecord.FieldLayout == fieldLayout && ((dataRecord == anchorRecord && alwaysIncludeAnchor) || ((!ignoreAddRecordTemplate || !dataRecord.IsAddRecordTemplate) && (!ignoreSpecialRecords || !dataRecord.IsSpecialRecord))))
					{
						list.Add(dataRecord);
						if (list.Count == recordCount)
						{
							break;
						}
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001AEB4 File Offset: 0x000190B4
		private global::Infragistics.Windows.DataPresenter.DataRecord[] GetSelectedFieldRecords(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool firstOnly)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._owner.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = (dataRecord != null) ? dataRecord.RecordManager : this._owner.RecordManager;
			if (recordManager == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = recordManager.Sorted.ViewableRecords;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
			foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)viewableRecords))
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = record as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord2 != null && dataRecord2.IsDataRecord && dataRecord2.FieldLayout == fieldLayout)
				{
					list.Add(dataRecord2);
					if (firstOnly)
					{
						break;
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001AF6C File Offset: 0x0001916C
		private global::Infragistics.Windows.DataPresenter.FieldLayout GetTargetFieldLayout(global::Infragistics.Windows.DataPresenter.ClipboardOperation operation)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems = this._owner.SelectedItems;
			if (selectedItems.HasCells)
			{
				return selectedItems.Cells[0].Field.Owner;
			}
			if (selectedItems.HasRecords)
			{
				return selectedItems.Records[0].FieldLayout;
			}
			if (this._owner.ActiveCell != null)
			{
				return this._owner.ActiveCell.Field.Owner;
			}
			if (this._owner.ActiveRecord != null)
			{
				return this._owner.ActiveRecord.FieldLayout;
			}
			if (selectedItems.HasFields)
			{
				return selectedItems.Fields[0].Owner;
			}
			return null;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001B01C File Offset: 0x0001921C
		private bool IsInSameFieldLayout(global::Infragistics.Windows.DataPresenter.DataRecord[] dataRecords)
		{
			if (dataRecords != null && dataRecords.Length > 1)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dataRecords[0].FieldLayout;
				for (int i = 1; i < dataRecords.Length; i++)
				{
					if (dataRecords[i].FieldLayout != fieldLayout)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001B058 File Offset: 0x00019258
		private static bool IsInSameFieldLayout(global::Infragistics.Windows.DataPresenter.Cell[] cells)
		{
			if (cells != null && cells.Length > 1)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
				foreach (global::Infragistics.Windows.DataPresenter.Cell cell in cells)
				{
					if (cell != null)
					{
						global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = cell.Record.FieldLayout;
						if (fieldLayout == null)
						{
							fieldLayout = fieldLayout2;
						}
						else if (fieldLayout != fieldLayout2)
						{
							return false;
						}
					}
				}
			}
			return true;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001B0A0 File Offset: 0x000192A0
		private bool PerformPaste()
		{
			global::System.Windows.IDataObject dataObject = null;
			try
			{
				dataObject = global::Infragistics.Windows.Helpers.ClipboardHelper.GetDataObject();
			}
			catch (global::System.Exception exception)
			{
				this.RaiseClipboardError(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste, global::Infragistics.Windows.DataPresenter.ClipboardError.Exception, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop, false, exception);
				return false;
			}
			return this.PerformPaste(dataObject, false, null);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001B0E4 File Offset: 0x000192E4
		private bool PerformPaste(global::System.Windows.IDataObject dataObject, bool isDragDrop, global::Infragistics.Windows.DataPresenter.Cell targetCell)
		{
			if (dataObject == null)
			{
				return false;
			}
			string text = this.GetPreferredPasteFormat(dataObject);
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			global::System.Windows.DataObjectPastingEventArgs dataObjectPastingEventArgs = new global::System.Windows.DataObjectPastingEventArgs(dataObject, isDragDrop, text);
			this._owner.RaiseEvent(dataObjectPastingEventArgs);
			if (dataObjectPastingEventArgs.CommandCancelled)
			{
				return false;
			}
			dataObject = dataObjectPastingEventArgs.DataObject;
			if (dataObject == null)
			{
				return false;
			}
			text = dataObjectPastingEventArgs.FormatToApply;
			if (!dataObject.GetDataPresent(text))
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.ClipboardEncoding clipboardEncoding = global::Infragistics.Windows.DataPresenter.ClipboardEncodingFactory.CreateEncoding(this._owner, dataObject, text);
			if (clipboardEncoding == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.CellValueHolder[,] cellValues = clipboardEncoding.GetCellValues(text, dataObject);
			global::Infragistics.Windows.DataPresenter.CellValueProviderSource source;
			global::Infragistics.Windows.DataPresenter.ICellValueProvider pasteCellValueProvider = this.GetPasteCellValueProvider(cellValues, targetCell, out source);
			if (pasteCellValueProvider == null)
			{
				return false;
			}
			if (!global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ContainsModifiableFields(pasteCellValueProvider))
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.CellValueHolderCollection cellValueHolderCollection = new global::Infragistics.Windows.DataPresenter.CellValueHolderCollection(pasteCellValueProvider);
			if (cellValueHolderCollection == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.Events.ClipboardPastingEventArgs clipboardPastingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.ClipboardPastingEventArgs(cellValueHolderCollection, dataObject);
			this._owner.RaiseClipboardPasting(clipboardPastingEventArgs);
			if (clipboardPastingEventArgs.Cancel)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction action = new global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction(cellValueHolderCollection.ValueProvider, true, this.GetSelectionTarget(source));
			return this._owner.History.PerformAction(action, global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.PasteOperationContext);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001B1E0 File Offset: 0x000193E0
		private bool ShouldAddFormat(global::System.Windows.IDataObject dataObject, string clipboardFormat)
		{
			global::System.Windows.DataObjectSettingDataEventArgs dataObjectSettingDataEventArgs = new global::System.Windows.DataObjectSettingDataEventArgs(dataObject, clipboardFormat);
			this._owner.RaiseEvent(dataObjectSettingDataEventArgs);
			return !dataObjectSettingDataEventArgs.CommandCancelled;
		}

		// Token: 0x040001F5 RID: 501
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _owner;

		// Token: 0x040001F6 RID: 502
		private static readonly object PasteOperationContext = global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste;

		// Token: 0x040001F7 RID: 503
		private static readonly object ClearCellsOperationContext = global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents;
	}
}
