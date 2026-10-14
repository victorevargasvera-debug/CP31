using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200008E RID: 142
	internal class ClipboardOperationInfo
	{
		// Token: 0x060006F5 RID: 1781 RVA: 0x0001BFBA File Offset: 0x0001A1BA
		internal ClipboardOperationInfo(global::Infragistics.Windows.DataPresenter.DataPresenterBase owner)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(owner);
			this._owner = owner;
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0001BFCF File Offset: 0x0001A1CF
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
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

		// Token: 0x060006F8 RID: 1784 RVA: 0x0001C030 File Offset: 0x0001A230
		internal bool ClearCellContents()
		{
			global::Infragistics.Windows.DataPresenter.CellValueProviderSource source;
			global::Infragistics.Windows.DataPresenter.ICellValueProvider cellValueProvider = this.GetCellValueProvider(global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents, out source);
			return this.ClearCellContents(cellValueProvider, source);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0001C050 File Offset: 0x0001A250
		private bool ClearCellContents(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider, global::Infragistics.Windows.DataPresenter.CellValueProviderSource source)
		{
			if (provider == null || provider.FieldCount < 1 || provider.RecordCount < 1)
			{
				return false;
			}
			if (!this.ContainsModifiableFields(provider))
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ClearValues(provider);
			global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction action = new global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction(provider, true, this.GetSelectionTarget(source));
			return this._owner.History.PerformAction(action, global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ClearCellsOperationContext);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0001C0AC File Offset: 0x0001A2AC
		private static void ClearValues(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider)
		{
			if (provider != null)
			{
				int fieldCount = provider.FieldCount;
				global::Infragistics.Windows.DataPresenter.Field[] fields = global::Infragistics.Windows.DataPresenter.CellRangeValueProvider.GetFields(provider);
				global::Infragistics.Windows.DataPresenter.ClipboardFieldArrayProvider clipboardFieldArrayProvider = new global::Infragistics.Windows.DataPresenter.ClipboardFieldArrayProvider(fields);
				bool isTreeView = provider.FieldLayout.DataPresenter.IsTreeView;
				int i = 0;
				int recordCount = provider.RecordCount;
				while (i < recordCount)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord record = provider.GetRecord(i);
					if (record != null)
					{
						if (isTreeView)
						{
							fields = clipboardFieldArrayProvider.GetFields(record.FieldLayout);
						}
						for (int j = 0; j < fieldCount; j++)
						{
							global::Infragistics.Windows.DataPresenter.CellValueHolder value = provider.GetValue(i, j);
							if (value != null)
							{
								object value2 = null;
								record.CoerceNullEditValue(fields[j], ref value2);
								value.Initialize(value2, false);
							}
						}
					}
					i++;
				}
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0001C158 File Offset: 0x0001A358
		internal bool ContainsModifiableFields(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider)
		{
			if (this._owner.IsTreeView)
			{
				int recordCount = provider.RecordCount;
				int fieldCount = provider.FieldCount;
				global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.Field> hashSet = new global::System.Collections.Generic.HashSet<global::Infragistics.Windows.DataPresenter.Field>();
				for (int i = 0; i < recordCount; i++)
				{
					for (int j = 0; j < fieldCount; j++)
					{
						global::Infragistics.Windows.DataPresenter.CellValueHolder value = provider.GetValue(i, j);
						if (value != null)
						{
							global::Infragistics.Windows.DataPresenter.Field fieldForRecord = provider.GetFieldForRecord(j, i);
							if (hashSet.Add(fieldForRecord) && !global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ShouldSkipFieldModification(fieldForRecord))
							{
								return true;
							}
						}
					}
				}
			}
			else
			{
				int k = 0;
				int fieldCount2 = provider.FieldCount;
				while (k < fieldCount2)
				{
					global::Infragistics.Windows.DataPresenter.Field field = provider.GetField(k);
					if (!global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ShouldSkipFieldModification(field))
					{
						return true;
					}
					k++;
				}
			}
			return false;
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0001C204 File Offset: 0x0001A404
		internal static bool ConvertToCellValue(global::Infragistics.Windows.DataPresenter.ICellValueProvider provider, global::System.Collections.Generic.IList<object> originalDataItems, bool honorShouldSkipFieldModification, bool checkEditableCells, out global::Infragistics.Windows.DataPresenter.RowColumnIndex stopAtCell, global::Infragistics.Windows.DataPresenter.ClipboardOperation? operation, global::Infragistics.Windows.DataPresenter.RecordManager defaultRecordManager, out bool hadConversionErrors)
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
			global::System.Collections.Generic.IEqualityComparer<object> dataItemEqualityComparerResolved = dataPresenter.DataItemEqualityComparerResolved;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, bool> dictionary2 = honorShouldSkipFieldModification ? new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, bool>() : null;
			global::Infragistics.Windows.DataPresenter.Field[] fields = global::Infragistics.Windows.DataPresenter.CellRangeValueProvider.GetFields(provider);
			global::Infragistics.Windows.DataPresenter.ClipboardFieldArrayProvider clipboardFieldArrayProvider = new global::Infragistics.Windows.DataPresenter.ClipboardFieldArrayProvider(fields);
			bool isTreeView = provider.FieldLayout.DataPresenter.IsTreeView;
			for (int i = 0; i < recordCount; i++)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = provider.GetRecord(i);
				bool flag = dataRecord == null || global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsSameDataItem(dataRecord.DataItem, originalDataItems[i], dataItemEqualityComparerResolved);
				if (dataRecord == null && defaultRecordManager != null)
				{
					dataRecord = defaultRecordManager.CurrentAddRecord;
				}
				if (flag && dataRecord != null)
				{
					flag = !global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(dataRecord);
				}
				if (dataRecord != null && isTreeView)
				{
					fields = clipboardFieldArrayProvider.GetFields(dataRecord.FieldLayout);
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
							global::Infragistics.Windows.DataPresenter.Field fieldForRecord = provider.GetFieldForRecord(j, i);
							if (dictionary2 != null)
							{
								bool flag2;
								if (!dictionary2.TryGetValue(fieldForRecord, out flag2))
								{
									flag2 = (dictionary2[fieldForRecord] = global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ShouldSkipFieldModification(fieldForRecord));
								}
								if (flag2)
								{
									value.Ignore = true;
									goto IL_328;
								}
							}
							if (checkEditableCells && dataRecord != null && !dataRecord.GetIsEditingAllowed(fieldForRecord))
							{
								clipboardError = new global::Infragistics.Windows.DataPresenter.ClipboardError?(global::Infragistics.Windows.DataPresenter.ClipboardError.ReadOnlyCell);
								bool allowEditResolved;
								if (!dictionary.TryGetValue(fieldForRecord, out allowEditResolved))
								{
									allowEditResolved = fieldForRecord.AllowEditResolved;
									dictionary[fieldForRecord] = allowEditResolved;
									defaultDisplayErrorMessage = true;
								}
							}
							if (clipboardError == null && value.IsDisplayText)
							{
								global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(fieldForRecord);
								global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolder clipboardCellValueHolder = value as global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolder;
								if (clipboardCellValueHolder != null)
								{
									string a = cachedConverter.ConvertCellValue(clipboardCellValueHolder.OriginalValue, out ex);
									if (ex == null && string.Equals(a, clipboardCellValueHolder.OriginalDisplayText))
									{
										if (cachedConverter.ValidateValue(clipboardCellValueHolder.OriginalValue, out ex))
										{
											value.Initialize(clipboardCellValueHolder.OriginalValue, false);
											goto IL_328;
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
											dataRecord.CoerceNullEditValue(fieldForRecord, ref obj);
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
									switch (clipboardOperationInfo.RaiseClipboardError(operation.Value, clipboardError.Value, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue, true, ex, defaultDisplayErrorMessage, dataRecord, fieldForRecord))
									{
									case global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.ClearCellAndContinue:
										if (dataRecord != null)
										{
											object value3 = null;
											dataRecord.CoerceNullEditValue(fieldForRecord, ref value3);
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
					IL_328:;
				}
			}
			return true;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001C558 File Offset: 0x0001A758
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

		// Token: 0x060006FE RID: 1790 RVA: 0x0001C5D0 File Offset: 0x0001A7D0
		internal bool CopyToClipboard()
		{
			global::Infragistics.Windows.DataPresenter.CellValueProviderSource cellValueProviderSource;
			global::Infragistics.Windows.DataPresenter.ICellValueProvider cellValueProvider = this.GetCellValueProvider(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Copy, out cellValueProviderSource);
			return this.CopyToClipboard(cellValueProvider);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
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

		// Token: 0x06000700 RID: 1792 RVA: 0x0001C638 File Offset: 0x0001A838
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
			global::Infragistics.Windows.DataPresenter.ClipboardFieldArrayProvider clipboardFieldArrayProvider = new global::Infragistics.Windows.DataPresenter.ClipboardFieldArrayProvider(array);
			int j = 0;
			int recordCount = provider.RecordCount;
			while (j < recordCount)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = provider.GetRecord(j);
				if (record != null)
				{
					global::Infragistics.Windows.DataPresenter.Field[] fields = clipboardFieldArrayProvider.GetFields(record.FieldLayout);
					for (int k = 0; k < fieldCount; k++)
					{
						object cellValue = record.GetCellValue(fields[k], true);
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

		// Token: 0x06000701 RID: 1793 RVA: 0x0001C81A File Offset: 0x0001AA1A
		internal static string GetClipboardDataFormat(global::System.Type type)
		{
			return type.FullName;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0001C824 File Offset: 0x0001AA24
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

		// Token: 0x06000703 RID: 1795 RVA: 0x0001C858 File Offset: 0x0001AA58
		internal static global::Infragistics.Windows.DataPresenter.Field[] GetFieldsForClipboard(global::Infragistics.Windows.DataPresenter.Cell[] cells, int fieldCount)
		{
			global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[fieldCount];
			int num = cells.Length / fieldCount;
			for (int i = 0; i < fieldCount; i++)
			{
				for (int j = 0; j < num; j++)
				{
					int num2 = i + j * fieldCount;
					if (cells[num2] != null)
					{
						global::Infragistics.Windows.DataPresenter.Field field = cells[num2].Field;
						if (field.IsFieldMapped)
						{
							field = field.MappedTreeField;
						}
						array[i] = field;
						break;
					}
				}
			}
			return array;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0001C8BC File Offset: 0x0001AABC
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

		// Token: 0x06000705 RID: 1797 RVA: 0x0001C8E8 File Offset: 0x0001AAE8
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

		// Token: 0x06000706 RID: 1798 RVA: 0x0001C916 File Offset: 0x0001AB16
		internal static string GetText(global::Infragistics.Windows.DataPresenter.CellValueHolder cvh)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(cvh);
			return global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetText(cvh.Value);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0001C92C File Offset: 0x0001AB2C
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

		// Token: 0x06000708 RID: 1800 RVA: 0x0001C960 File Offset: 0x0001AB60
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

		// Token: 0x06000709 RID: 1801 RVA: 0x0001C98D File Offset: 0x0001AB8D
		internal static bool IsDeleted(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return cell == null || global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(cell.Record);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0001C99F File Offset: 0x0001AB9F
		internal static bool IsDeleted(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			return record == null || !record.IsStillValid;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001C9AF File Offset: 0x0001ABAF
		internal static bool IsSameDataItem(object item1, object item2, global::System.Collections.Generic.IEqualityComparer<object> comparer)
		{
			if (object.ReferenceEquals(item1, item2))
			{
				return true;
			}
			item1 = global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(item1);
			item2 = global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(item2);
			return comparer.Equals(item1, item2);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001C9D4 File Offset: 0x0001ABD4
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

		// Token: 0x0600070D RID: 1805 RVA: 0x0001CA1C File Offset: 0x0001AC1C
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

		// Token: 0x0600070E RID: 1806 RVA: 0x0001CAA4 File Offset: 0x0001ACA4
		internal global::Infragistics.Windows.DataPresenter.ClipboardErrorAction RaiseClipboardError(global::Infragistics.Windows.DataPresenter.ClipboardOperation operation, global::Infragistics.Windows.DataPresenter.ClipboardError error, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction defaultAction, bool canContinue, global::System.Exception exception)
		{
			return this.RaiseClipboardError(operation, error, defaultAction, canContinue, exception, true, null, null);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0001CAC4 File Offset: 0x0001ACC4
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

		// Token: 0x06000710 RID: 1808 RVA: 0x0001CB71 File Offset: 0x0001AD71
		internal static bool ShouldSkipFieldModification(global::Infragistics.Windows.DataPresenter.Field f)
		{
			return f == null || f.DisallowModificationViaClipboard || f.IsPlaceholderForTreeView;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0001CB8C File Offset: 0x0001AD8C
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
					if (clipboardEncoding is global::Infragistics.Windows.DataPresenter.DataPresenterClipboardEncoding)
					{
						dataObject.SetData("Infragistics.Windows.DataPresenter.ClipboardDataVersion", "15.1");
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

		// Token: 0x06000712 RID: 1810 RVA: 0x0001CC04 File Offset: 0x0001AE04
		private global::Infragistics.Windows.DataPresenter.Cell[] CreateRectangularArray(global::Infragistics.Windows.DataPresenter.Cell[] cells, bool allowSparse, out int fieldCount, out bool isSparse)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, object> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, object>();
			int num = 0;
			global::Infragistics.Windows.DataPresenter.Record record = null;
			bool isTreeView = this._owner.IsTreeView;
			for (int i = 0; i < cells.Length; i++)
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = cells[i];
				if (cell.Record != record)
				{
					record = cell.Record;
					num++;
				}
				global::Infragistics.Windows.DataPresenter.Field field = cells[i].Field;
				if (isTreeView && field.IsFieldMapped)
				{
					field = field.MappedTreeField;
				}
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
			if (isTreeView)
			{
				fieldLayout = this._owner.DefaultFieldLayout;
			}
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
						if (isTreeView && field2.IsFieldMapped)
						{
							field2 = field2.MappedTreeField;
						}
						array[num4 * fieldCount + array2[field2.NavigationIndex]] = cell2;
					}
				}
			}
			return array;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0001CDB4 File Offset: 0x0001AFB4
		private global::Infragistics.Windows.DataPresenter.DataRecord[] GetAllRecordsForPaste(global::Infragistics.Windows.DataPresenter.DataRecord anchorRecord, int rowCount)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(anchorRecord, global::Infragistics.Windows.DataPresenter.RecordType.DataRecord))
			{
				list.Add(anchorRecord);
				rowCount--;
			}
			if (rowCount > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Record record in this._owner.GetCrossLevelRecordsInRange(anchorRecord, true))
				{
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(record, global::Infragistics.Windows.DataPresenter.RecordType.DataRecord))
					{
						list.Add(record as global::Infragistics.Windows.DataPresenter.DataRecord);
						rowCount--;
						if (rowCount <= 0)
						{
							break;
						}
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0001CE44 File Offset: 0x0001B044
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
				global::Infragistics.Windows.DataPresenter.DataRecord[] selectedFieldRecords = this.GetSelectedFieldRecords(owner, false, operation);
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
				global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.Cell>(array2, this._owner.IsTreeView ? global::Infragistics.Windows.DataPresenter.TreeCellVisiblePositionComparer.Instance : global::Infragistics.Windows.DataPresenter.CellVisiblePositionComparer.Instance);
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
					if (!this._owner.IsTreeView && !global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsInSameFieldLayout(array2))
					{
						return null;
					}
					source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.SelectedCells;
					global::Infragistics.Windows.DataPresenter.Field[] fieldsForClipboard = global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetFieldsForClipboard(array2, fieldCount);
					return new global::Infragistics.Windows.DataPresenter.GridCellRangeValueProvider(array2, fieldsForClipboard);
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
					if (!this._owner.IsTreeView && !this.IsInSameFieldLayout(array4))
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
						global::Infragistics.Windows.DataPresenter.Cell[] cells = new global::Infragistics.Windows.DataPresenter.Cell[]
						{
							this._owner.ActiveCell
						};
						return new global::Infragistics.Windows.DataPresenter.GridCellRangeValueProvider(cells, global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetFieldsForClipboard(cells, 1));
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

		// Token: 0x06000715 RID: 1813 RVA: 0x0001D0C0 File Offset: 0x0001B2C0
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

		// Token: 0x06000716 RID: 1814 RVA: 0x0001D118 File Offset: 0x0001B318
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
			case global::Infragistics.Windows.DataPresenter.ClipboardError.InvalidSelectedFieldRecords:
				result = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("ClipboardError_InvalidSelectedFieldRecordsMessage");
				break;
			default:
				result = string.Empty;
				break;
			}
			return result;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0001D2AC File Offset: 0x0001B4AC
		private static global::Infragistics.Windows.DataPresenter.Field[] GetNavigationOrderFields(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			if (fl.AlignmentFieldLayout != null)
			{
				fl = fl.AlignmentFieldLayout;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = fl.StyleGenerator;
			if (styleGenerator == null)
			{
				return new global::Infragistics.Windows.DataPresenter.Field[0];
			}
			return styleGenerator.GridFieldMap.GetNavigationOrderFields();
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0001D2F4 File Offset: 0x0001B4F4
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
				if (selectedItems.HasFields)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout targetFieldLayout = this.GetTargetFieldLayout(global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste);
					global::Infragistics.Windows.DataPresenter.DataRecord[] selectedFieldRecords = this.GetSelectedFieldRecords(targetFieldLayout, true, global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste);
					if (selectedFieldRecords == null || selectedFieldRecords.Length == 0)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.DataRecord anchorRecord = selectedFieldRecords[0];
					global::Infragistics.Windows.DataPresenter.Field[] array = (from global::Infragistics.Windows.DataPresenter.Field f in selectedItems.Fields
					where f.NavigationIndex >= 0
					select f).ToArray<global::Infragistics.Windows.DataPresenter.Field>();
					global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.Field>(array, global::Infragistics.Windows.DataPresenter.FieldNavigationIndexComparer.Instance);
					if (array.Length > 0)
					{
						source = global::Infragistics.Windows.DataPresenter.CellValueProviderSource.SelectedFields;
						return this.GetPasteCellValueProvider(cellValues, anchorRecord, new int?(array[0].NavigationIndex));
					}
				}
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
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0001D594 File Offset: 0x0001B794
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

		// Token: 0x0600071A RID: 1818 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
		private global::Infragistics.Windows.DataPresenter.ICellValueProvider GetPasteCellValueProvider(global::Infragistics.Windows.DataPresenter.CellValueHolder[,] cellValues, global::Infragistics.Windows.DataPresenter.Record anchorRecord)
		{
			return this.GetPasteCellValueProvider(cellValues, anchorRecord, null);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0001D5E8 File Offset: 0x0001B7E8
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
				switch (this._owner.SelectionDepthMode)
				{
				case global::Infragistics.Windows.DataPresenter.SelectionDepthMode.VisibleOnly:
					array = this.GetVisibleRecordsForPaste(dataRecord, num2);
					goto IL_109;
				case global::Infragistics.Windows.DataPresenter.SelectionDepthMode.All:
					array = this.GetAllRecordsForPaste(dataRecord, num2);
					goto IL_109;
				}
				array = global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetRecords(dataRecord, num2, true, true, false);
			}
			IL_109:
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

		// Token: 0x0600071C RID: 1820 RVA: 0x0001D770 File Offset: 0x0001B970
		private string GetPreferredPasteFormat(global::System.Windows.IDataObject dataObject)
		{
			if (dataObject.GetDataPresent(typeof(global::Infragistics.Windows.DataPresenter.ClipboardData)) && dataObject.GetDataPresent("Infragistics.Windows.DataPresenter.ClipboardDataVersion"))
			{
				object data = dataObject.GetData("Infragistics.Windows.DataPresenter.ClipboardDataVersion", false);
				if (data != null && object.Equals(data, "15.1"))
				{
					return global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetClipboardDataFormat(typeof(global::Infragistics.Windows.DataPresenter.ClipboardData));
				}
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

		// Token: 0x0600071D RID: 1821 RVA: 0x0001D808 File Offset: 0x0001BA08
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

		// Token: 0x0600071E RID: 1822 RVA: 0x0001D8AC File Offset: 0x0001BAAC
		private global::Infragistics.Windows.DataPresenter.DataRecord[] GetSelectedFieldRecords(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool firstOnly, global::Infragistics.Windows.DataPresenter.ClipboardOperation operation)
		{
			if (this._owner.IsTreeView)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this._owner.ViewableRecords;
				int i = 0;
				int scrollCount = viewableRecords.ScrollCount;
				while (i < scrollCount)
				{
					global::Infragistics.Windows.DataPresenter.Record recordAtScrollPosition = viewableRecords.GetRecordAtScrollPosition(i);
					if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(recordAtScrollPosition, global::Infragistics.Windows.DataPresenter.RecordType.DataRecord))
					{
						list.Add(recordAtScrollPosition as global::Infragistics.Windows.DataPresenter.DataRecord);
						if (firstOnly)
						{
							break;
						}
					}
					i++;
				}
				return list.ToArray();
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._owner.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = (dataRecord != null) ? dataRecord.RecordManager : this._owner.RecordManager;
			if (recordManager == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords2 = recordManager.Sorted.ViewableRecords;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
			bool flag = recordManager.ContainsFieldLayout(fieldLayout);
			foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)viewableRecords2))
			{
				if (record.FieldLayout == fieldLayout)
				{
					flag = true;
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = record as global::Infragistics.Windows.DataPresenter.DataRecord;
					if (dataRecord2 != null && dataRecord2.IsDataRecord)
					{
						list2.Add(dataRecord2);
						if (firstOnly)
						{
							break;
						}
					}
				}
			}
			if (!flag)
			{
				this.RaiseClipboardError(operation, global::Infragistics.Windows.DataPresenter.ClipboardError.InvalidSelectedFieldRecords, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop, false, null);
				return null;
			}
			return list2.ToArray();
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0001D9EC File Offset: 0x0001BBEC
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

		// Token: 0x06000720 RID: 1824 RVA: 0x0001DA9C File Offset: 0x0001BC9C
		private global::Infragistics.Windows.DataPresenter.DataRecord[] GetVisibleRecordsForPaste(global::Infragistics.Windows.DataPresenter.DataRecord anchorRecord, int rowCount)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
			int num = anchorRecord.OverallScrollPosition;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this._owner.ViewableRecords;
			if (num < 0)
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = anchorRecord.ParentRecord;
				while (parentRecord != null && num < 0)
				{
					num = parentRecord.OverallScrollPosition;
					parentRecord = parentRecord.ParentRecord;
				}
				if (num < 0)
				{
					return null;
				}
				num++;
			}
			int i = num;
			int scrollCount = viewableRecords.ScrollCount;
			while (i < scrollCount)
			{
				global::Infragistics.Windows.DataPresenter.Record recordAtScrollPosition = viewableRecords.GetRecordAtScrollPosition(i);
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(recordAtScrollPosition, global::Infragistics.Windows.DataPresenter.RecordType.DataRecord))
				{
					list.Add(recordAtScrollPosition as global::Infragistics.Windows.DataPresenter.DataRecord);
					rowCount--;
					if (rowCount <= 0)
					{
						break;
					}
				}
				i++;
			}
			return list.ToArray();
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0001DB3C File Offset: 0x0001BD3C
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

		// Token: 0x06000722 RID: 1826 RVA: 0x0001DB78 File Offset: 0x0001BD78
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

		// Token: 0x06000723 RID: 1827 RVA: 0x0001DBC0 File Offset: 0x0001BDC0
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

		// Token: 0x06000724 RID: 1828 RVA: 0x0001DC04 File Offset: 0x0001BE04
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
			if (!this.ContainsModifiableFields(pasteCellValueProvider))
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

		// Token: 0x06000725 RID: 1829 RVA: 0x0001DD00 File Offset: 0x0001BF00
		private bool ShouldAddFormat(global::System.Windows.IDataObject dataObject, string clipboardFormat)
		{
			global::System.Windows.DataObjectSettingDataEventArgs dataObjectSettingDataEventArgs = new global::System.Windows.DataObjectSettingDataEventArgs(dataObject, clipboardFormat);
			this._owner.RaiseEvent(dataObjectSettingDataEventArgs);
			return !dataObjectSettingDataEventArgs.CommandCancelled;
		}

		// Token: 0x04000233 RID: 563
		internal const string VersionFormat = "Infragistics.Windows.DataPresenter.ClipboardDataVersion";

		// Token: 0x04000234 RID: 564
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _owner;

		// Token: 0x04000235 RID: 565
		private static readonly object PasteOperationContext = global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste;

		// Token: 0x04000236 RID: 566
		private static readonly object ClearCellsOperationContext = global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents;
	}
}
