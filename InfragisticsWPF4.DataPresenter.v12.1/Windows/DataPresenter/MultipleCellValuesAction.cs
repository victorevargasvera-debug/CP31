using System;
using System.Collections.Generic;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000067 RID: 103
	internal class MultipleCellValuesAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x06000592 RID: 1426 RVA: 0x00014887 File Offset: 0x00012A87
		internal MultipleCellValuesAction(global::Infragistics.Windows.DataPresenter.ICellValueProvider valueProvider, bool useConverter, global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget preferSelectionTarget) : base(valueProvider.FieldLayout.DataPresenter)
		{
			this._values = valueProvider;
			this._useConverter = useConverter;
			this._preferSelectionTarget = preferSelectionTarget;
			this.StoreOriginalDataItems();
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x000148B8 File Offset: 0x00012AB8
		protected internal override void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
			int i = 0;
			int recordCount = this._values.RecordCount;
			while (i < recordCount)
			{
				global::Infragistics.Windows.DataPresenter.Record record = this._values.GetRecord(i);
				descendantInfo.AddRecord(record);
				i++;
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000148F4 File Offset: 0x00012AF4
		protected internal override bool CanPerform(object context)
		{
			bool flag = false;
			int i = 0;
			int recordCount = this._values.RecordCount;
			while (i < recordCount)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = this._values.GetRecord(i);
				if (!global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(record))
				{
					flag = true;
					break;
				}
				i++;
			}
			bool flag2 = false;
			int j = 0;
			int fieldCount = this._values.FieldCount;
			while (j < fieldCount)
			{
				global::Infragistics.Windows.DataPresenter.Field field = this._values.GetField(j);
				if (global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(field))
				{
					flag2 = true;
					break;
				}
				j++;
			}
			return flag && flag2;
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0001497C File Offset: 0x00012B7C
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = this._values.GetRecord(0) as global::Infragistics.Windows.DataPresenter.FilterRecord;
			if (filterRecord != null && filterRecord.FieldLayout == fieldLayout && filterRecord.Filters.GetRecordFilterScopeResolved(fieldLayout) == global::Infragistics.Windows.DataPresenter.RecordFilterScope.AllRecords)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000149C0 File Offset: 0x00012BC0
		protected internal override void OnRecordsUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords)
		{
			int i = 0;
			int count = this._originalDataItems.Count;
			while (i < count)
			{
				object obj = this._originalDataItems[i];
				if (obj != null)
				{
					global::Infragistics.Windows.DataPresenter.Record record = this._values.GetRecord(i);
					if (global::Infragistics.Windows.DataPresenter.DataPresenterAction.ProcessRecordUndeleted(oldDataTimeToRecords, ref obj, ref record))
					{
						this._values.ReplaceRecord(i, (global::Infragistics.Windows.DataPresenter.DataRecord)record);
						this._originalDataItems[i] = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(record);
					}
				}
				i++;
			}
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x00014A34 File Offset: 0x00012C34
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			if (!this.CanPerform(context))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (dataPresenter == null)
			{
				return null;
			}
			int recordCount = this._values.RecordCount;
			if (recordCount < 1)
			{
				return null;
			}
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.ICellValueProvider currentCellValues = this._values.GetCurrentCellValues(flag);
			global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction multipleCellValuesAction = new global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction(currentCellValues, flag, this._preferSelectionTarget);
			bool flag2 = global::Infragistics.Windows.UndoManager.IsUndoRedoContext(context);
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellKey> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellKey>();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellKey> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellKey>();
			int fieldCount = this._values.FieldCount;
			bool[] array = new bool[fieldCount];
			global::Infragistics.Windows.DataPresenter.ClipboardOperation? clipboardOperation = global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.GetClipboardOperation(context);
			if (!flag2)
			{
				for (int i = 0; i < fieldCount; i++)
				{
					global::Infragistics.Windows.DataPresenter.Field field = this._values.GetField(i);
					array[i] = global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ShouldSkipFieldModification(field);
				}
			}
			bool checkEditableCells = true;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this._values.GetRecord(0).RecordManager;
			global::Infragistics.Windows.DataPresenter.RowColumnIndex rowColumnIndex;
			bool flag3;
			if (!global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.ConvertToCellValue(this._values, this._originalDataItems, array, checkEditableCells, out rowColumnIndex, clipboardOperation, recordManager, out flag3))
			{
				return null;
			}
			bool flag4 = false;
			global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo clipboardOperationInfo = dataPresenter.ClipboardOperationInfo;
			global::Infragistics.Windows.DataPresenter.ClipboardErrorAction? clipboardErrorAction = null;
			bool flag5 = false;
			bool flag6 = false;
			bool flag7 = false;
			switch (dataPresenter.UpdateMode)
			{
			case global::Infragistics.Windows.DataPresenter.UpdateMode.OnRecordChangeOrLostFocus:
			case global::Infragistics.Windows.DataPresenter.UpdateMode.OnRecordChange:
				flag7 = true;
				break;
			case global::Infragistics.Windows.DataPresenter.UpdateMode.OnCellChangeOrLostFocus:
			case global::Infragistics.Windows.DataPresenter.UpdateMode.OnCellChange:
				flag6 = true;
				break;
			}
			bool flag8 = false;
			if ((clipboardOperation == global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste || flag2) && global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.ShouldActivateFirstCell(this._values, dataPresenter.ActiveCell))
			{
				flag8 = true;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list3 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
			global::Infragistics.Windows.DataPresenter.Record record = (recordCount == 1) ? this._values.GetRecord(0) : null;
			if (record != null)
			{
				record.SuspendFiltering();
			}
			try
			{
				int j = 0;
				while (j < recordCount)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._values.GetRecord(j);
					int count = list.Count;
					if (dataRecord != null || recordManager == null)
					{
						goto IL_1CA;
					}
					dataRecord = recordManager.CurrentAddRecord;
					if (dataRecord == null || dataRecord.IsAddRecordTemplate)
					{
						goto IL_1CA;
					}
					IL_51A:
					j++;
					continue;
					IL_1CA:
					bool flag9 = dataRecord != null && dataRecord.IsAddRecord;
					bool flag10 = dataRecord != null && dataRecord.IsAddRecordTemplate;
					if (flag10 && clipboardOperation == global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents)
					{
						goto IL_51A;
					}
					bool flag11 = dataPresenter.SuspendInitializeRecordFor(dataRecord);
					bool flag12 = false;
					bool flag13 = false;
					try
					{
						for (int k = 0; k < fieldCount; k++)
						{
							if (rowColumnIndex != null && rowColumnIndex.Equals(j, k))
							{
								flag5 = true;
								flag4 = true;
								break;
							}
							if (dataRecord != null)
							{
								global::Infragistics.Windows.DataPresenter.CellValueHolder value = this._values.GetValue(j, k);
								if (value != null)
								{
									global::Infragistics.Windows.DataPresenter.Field field2 = this._values.GetField(k);
									if (!value.Ignore)
									{
										bool isAddRecordTemplate = dataRecord.IsAddRecordTemplate;
										int num = list3.Count;
										if (flag10 && list.Count > 0)
										{
											num++;
										}
										bool flag14 = global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SetCellValue(dataRecord, field2, value.Value, this._useConverter, num, clipboardOperation, clipboardOperationInfo, out clipboardErrorAction);
										if (flag14 && isAddRecordTemplate && !dataRecord.IsAddRecordTemplate)
										{
											list3.Add(dataRecord);
										}
										if (!flag14 && clipboardErrorAction == global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.ClearCellAndContinue)
										{
											if (clipboardOperation != global::Infragistics.Windows.DataPresenter.ClipboardOperation.ClearContents && clipboardOperation != global::Infragistics.Windows.DataPresenter.ClipboardOperation.Cut)
											{
												object value2 = null;
												dataRecord.CoerceNullEditValue(field2, ref value2);
												flag14 = global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SetCellValue(dataRecord, field2, value2, true, 0, clipboardOperation, clipboardOperationInfo, out clipboardErrorAction);
											}
											if (clipboardErrorAction == global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.ClearCellAndContinue)
											{
												clipboardErrorAction = new global::Infragistics.Windows.DataPresenter.ClipboardErrorAction?(global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue);
											}
										}
										if (clipboardErrorAction != null)
										{
											flag5 = true;
										}
										if (flag14)
										{
											flag13 = (flag13 || field2.SortStatus != global::Infragistics.Windows.Controls.SortStatus.NotSorted);
											global::Infragistics.Windows.DataPresenter.CellKey item = new global::Infragistics.Windows.DataPresenter.CellKey(dataRecord, field2);
											if (!flag10)
											{
												list.Add(item);
											}
											else
											{
												list2.Add(item);
											}
											if (flag8)
											{
												flag8 = false;
												dataRecord.Cells[field2].IsActive = true;
											}
											if (flag6 && !flag9)
											{
												global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.UpdateRecord(dataRecord, clipboardOperation, clipboardOperationInfo, out clipboardErrorAction);
											}
										}
										else if (clipboardErrorAction == global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue)
										{
											value.Ignore = true;
										}
										if (clipboardErrorAction == global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop || clipboardErrorAction == global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Revert)
										{
											flag4 = true;
											break;
										}
									}
								}
							}
						}
						flag12 = (list.Count > count);
						if (!flag12 && flag10 && !dataRecord.IsAddRecordTemplate)
						{
							flag12 = true;
						}
						if (flag12 && (flag7 || flag9) && clipboardErrorAction != global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Revert && (!dataRecord.IsActive || recordCount > 1))
						{
							global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.UpdateRecord(dataRecord, clipboardOperation, clipboardOperationInfo, out clipboardErrorAction);
							if (clipboardErrorAction == global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop || clipboardErrorAction == global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Revert)
							{
								flag4 = true;
							}
						}
					}
					finally
					{
						if (!flag11)
						{
							dataPresenter.ResumeInitializeRecordFor(dataRecord);
							if (flag12)
							{
								dataRecord.FireInitializeRecord(true, flag13);
							}
						}
					}
					if (!flag4)
					{
						goto IL_51A;
					}
					break;
				}
				if (list.Count == 0 && list3.Count == 0)
				{
					return null;
				}
				if (clipboardErrorAction == global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Revert)
				{
					for (int l = list3.Count - 1; l >= 0; l--)
					{
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = list3[l];
						if (dataRecord2.IsAddRecord)
						{
							dataRecord2.CancelEdit();
							list3.RemoveAt(l);
						}
					}
					if (list3.Count > 0)
					{
						global::Infragistics.Windows.DataPresenter.UndeleteRecordsAction undeleteRecordsAction;
						int num2;
						clipboardOperationInfo.DataPresenter.DeleteRecords(list3.ToArray(), false, false, out undeleteRecordsAction, out num2);
					}
					foreach (global::Infragistics.Windows.DataPresenter.CellKey cellKey in list)
					{
						global::Infragistics.Windows.DataPresenter.CellValueHolder value3 = currentCellValues.GetValue(cellKey);
						cellKey.Record.SetCellValue(cellKey.Field, value3.Value, flag, false, true, global::Infragistics.Windows.DataPresenter.DataRecord.UndoValueMissing, false);
					}
					return null;
				}
				global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.InitializeIgnoreState(currentCellValues, true);
				int m = 0;
				int count2 = list.Count;
				while (m < count2)
				{
					global::Infragistics.Windows.DataPresenter.CellValueHolder value4 = currentCellValues.GetValue(list[m]);
					if (value4 != null)
					{
						value4.Ignore = false;
					}
					m++;
				}
				global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget selectionTarget = global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget.Cells;
				if (!flag5 && !flag3)
				{
					if (list3.Count > 0)
					{
						selectionTarget = global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget.Records;
					}
					else if (this._preferSelectionTarget == global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget.Records)
					{
						selectionTarget = global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget.Records;
					}
					else if (this._preferSelectionTarget == global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget.Fields)
					{
						selectionTarget = global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget.Fields;
					}
				}
				multipleCellValuesAction._preferSelectionTarget = selectionTarget;
				if (clipboardOperation == global::Infragistics.Windows.DataPresenter.ClipboardOperation.Paste || flag2)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellKey> list4 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellKey>(list);
					list4.AddRange(list2);
					if (selectionTarget == global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget.Records)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterAction.SelectRecords(dataPresenter, list4, true, true);
					}
					else if (selectionTarget == global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget.Fields)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterAction.SelectFields(dataPresenter, list4, this._values, true, true);
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterAction.SelectCells(dataPresenter, list4, true, list.Count == 1);
					}
				}
			}
			finally
			{
				if (record != null)
				{
					global::Infragistics.Windows.DataPresenter.SingleCellValueAction.ResumeRecordFiltering(record);
				}
			}
			if (!dataPresenter.IsUndoEnabled)
			{
				return global::Infragistics.Windows.Helpers.ActionHistory.NoUndoAction;
			}
			if (list3.Count > 0)
			{
				return new global::Infragistics.Windows.DataPresenter.DataPresenterCompositeAction(new global::Infragistics.Windows.DataPresenter.DataPresenterAction[]
				{
					multipleCellValuesAction,
					new global::Infragistics.Windows.DataPresenter.DeleteRecordsAction(dataPresenter, list3.ToArray(), false)
				});
			}
			return multipleCellValuesAction;
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x000151E8 File Offset: 0x000133E8
		public override string ToString()
		{
			return string.Format("MultipleCellValuesAction - {0}x{1}", this._values.FieldCount, this._values.RecordCount);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00015214 File Offset: 0x00013414
		private static bool SetCellValue(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, int recordOnTopOffset, global::Infragistics.Windows.DataPresenter.ClipboardOperation? operation, global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo clipInfo, out global::Infragistics.Windows.DataPresenter.ClipboardErrorAction? errorAction)
		{
			global::Infragistics.Windows.DataPresenter.DataErrorInfo dataErrorInfo = null;
			global::System.Exception exception = null;
			errorAction = null;
			try
			{
				bool flag = record.SetCellValue(field, value, useConverter, out dataErrorInfo);
				if (!flag && dataErrorInfo == null)
				{
					return true;
				}
				if (dataErrorInfo == null && record.IsAddRecordTemplate && !record.OnEditValueChanged(false, recordOnTopOffset))
				{
					if (operation != null)
					{
						errorAction = new global::Infragistics.Windows.DataPresenter.ClipboardErrorAction?(clipInfo.RaiseClipboardError(operation.Value, global::Infragistics.Windows.DataPresenter.ClipboardError.InsertRecordError, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop, false, null, false, record, null));
					}
					else
					{
						errorAction = new global::Infragistics.Windows.DataPresenter.ClipboardErrorAction?(global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop);
					}
					return false;
				}
				if (flag && dataErrorInfo == null)
				{
					return true;
				}
			}
			catch (global::System.Exception ex)
			{
				exception = ex;
			}
			if (dataErrorInfo != null)
			{
				exception = dataErrorInfo.Exception;
			}
			if (operation != null)
			{
				errorAction = new global::Infragistics.Windows.DataPresenter.ClipboardErrorAction?(clipInfo.RaiseClipboardError(operation.Value, global::Infragistics.Windows.DataPresenter.ClipboardError.SetCellValueError, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue, true, exception, true, record, field));
			}
			else
			{
				if (dataErrorInfo != null)
				{
					clipInfo.DataPresenter.RaiseDataError(dataErrorInfo);
				}
				errorAction = new global::Infragistics.Windows.DataPresenter.ClipboardErrorAction?(global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop);
			}
			return false;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x00015318 File Offset: 0x00013518
		private static bool ShouldActivateFirstCell(global::Infragistics.Windows.DataPresenter.ICellValueProvider values, global::Infragistics.Windows.DataPresenter.Cell activeCell)
		{
			if (activeCell == null)
			{
				return true;
			}
			int fieldCount = values.FieldCount;
			int num = -1;
			global::Infragistics.Windows.DataPresenter.Field field = activeCell.Field;
			for (int i = 0; i < fieldCount; i++)
			{
				if (values.GetField(i) == field)
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				return true;
			}
			int recordCount = values.RecordCount;
			int num2 = -1;
			global::Infragistics.Windows.DataPresenter.DataRecord record = activeCell.Record;
			for (int j = 0; j < recordCount; j++)
			{
				if (values.GetRecord(j) == record)
				{
					num2 = j;
					break;
				}
			}
			if (num2 < 0)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.CellValueHolder value = values.GetValue(num2, num);
			return value == null || value.Ignore;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x000153B4 File Offset: 0x000135B4
		private void StoreOriginalDataItems()
		{
			this._originalDataItems = new global::System.Collections.Generic.List<object>();
			int i = 0;
			int recordCount = this._values.RecordCount;
			while (i < recordCount)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = this._values.GetRecord(i);
				object recordDataItem = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(record);
				this._originalDataItems.Add(recordDataItem);
				i++;
			}
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00015404 File Offset: 0x00013604
		private static bool UpdateRecord(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.ClipboardOperation? operation, global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo clipInfo, out global::Infragistics.Windows.DataPresenter.ClipboardErrorAction? errorAction)
		{
			errorAction = null;
			global::Infragistics.Windows.DataPresenter.DataErrorInfo dataErrorInfo;
			bool result = record.Update(out dataErrorInfo);
			if (dataErrorInfo != null)
			{
				if (operation != null)
				{
					errorAction = new global::Infragistics.Windows.DataPresenter.ClipboardErrorAction?(clipInfo.RaiseClipboardError(operation.Value, global::Infragistics.Windows.DataPresenter.ClipboardError.UpdateRecordError, global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Continue, true, dataErrorInfo.Exception, true, record, null));
				}
				else
				{
					clipInfo.DataPresenter.RaiseDataError(dataErrorInfo);
					errorAction = new global::Infragistics.Windows.DataPresenter.ClipboardErrorAction?(global::Infragistics.Windows.DataPresenter.ClipboardErrorAction.Stop);
				}
			}
			return result;
		}

		// Token: 0x04000195 RID: 405
		internal const bool UseConverterForUndo = false;

		// Token: 0x04000196 RID: 406
		private global::Infragistics.Windows.DataPresenter.ICellValueProvider _values;

		// Token: 0x04000197 RID: 407
		private bool _useConverter;

		// Token: 0x04000198 RID: 408
		private global::Infragistics.Windows.DataPresenter.MultipleCellValuesAction.SelectionTarget _preferSelectionTarget;

		// Token: 0x04000199 RID: 409
		private global::System.Collections.Generic.List<object> _originalDataItems;

		// Token: 0x02000068 RID: 104
		internal enum SelectionTarget
		{
			// Token: 0x0400019B RID: 411
			Cells,
			// Token: 0x0400019C RID: 412
			Records,
			// Token: 0x0400019D RID: 413
			Fields
		}
	}
}
