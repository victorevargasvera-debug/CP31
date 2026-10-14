using System;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000068 RID: 104
	internal abstract class DataPresenterAction : global::Infragistics.Windows.Helpers.ActionHistory.ActionBase
	{
		// Token: 0x060005EC RID: 1516 RVA: 0x000163AE File Offset: 0x000145AE
		internal DataPresenterAction(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dp, "dp");
			this._dp = dp;
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x000163C8 File Offset: 0x000145C8
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dp;
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000163D0 File Offset: 0x000145D0
		protected internal virtual void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000163D2 File Offset: 0x000145D2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		internal bool CanPerformInternal(object context)
		{
			return this.CanPerform(context);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000163DB File Offset: 0x000145DB
		protected static bool IsValid(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return field != null && field.Owner != null && field.IsValid;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000163F0 File Offset: 0x000145F0
		internal static global::Infragistics.Windows.DataPresenter.DataRecord GetDataItemRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = dataRecord as global::Infragistics.Windows.DataPresenter.FilterRecord;
				if (filterRecord != null)
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetDataItemRecord(filterRecord.RecordManager);
				}
				global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = dataRecord as global::Infragistics.Windows.DataPresenter.HeaderRecord;
				if (headerRecord != null)
				{
					return null;
				}
				return dataRecord;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = record as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
				if (expandableFieldRecord != null)
				{
					return global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetDataItemRecord(expandableFieldRecord.ParentRecord);
				}
				if (record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
				{
					return null;
				}
				return null;
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00016451 File Offset: 0x00014651
		internal static global::Infragistics.Windows.DataPresenter.DataRecord GetDataItemRecord(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			if (rm == null)
			{
				return null;
			}
			return rm.ParentDataRecord;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00016460 File Offset: 0x00014660
		internal static object GetRecordDataItem(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataItemRecord = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetDataItemRecord(record);
			if (dataItemRecord == null)
			{
				return null;
			}
			return dataItemRecord.DataItem;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0001647F File Offset: 0x0001467F
		internal static object GetRecordDataItem(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			return global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetDataItemRecord(rm));
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0001648C File Offset: 0x0001468C
		internal virtual global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			return this;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0001648F File Offset: 0x0001468F
		protected internal virtual void OnRecordsUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords)
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00016491 File Offset: 0x00014691
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		internal global::Infragistics.Windows.Helpers.ActionHistory.ActionBase PerformInternal(object context)
		{
			return this.Perform(context);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0001649C File Offset: 0x0001469C
		internal static bool ProcessRecordUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords, ref object dataItem, ref global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
			if (dataItem != null && oldDataTimeToRecords.TryGetValue(dataItem, out dataRecord))
			{
				if (record is global::Infragistics.Windows.DataPresenter.FilterRecord)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager = record.RecordManager;
					if (((recordManager != null) ? recordManager.ParentRecord : null) == null)
					{
						return false;
					}
					global::Infragistics.Windows.DataPresenter.Field field = recordManager.Field;
					if (!global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(field))
					{
						return false;
					}
					int num = dataRecord.ChildRecords.IndexOf(field);
					if (num < 0)
					{
						return false;
					}
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = dataRecord.ChildRecords[num];
					global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = expandableFieldRecord.ChildRecordManager.ViewableRecords.GetSpecialRecord(global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord) as global::Infragistics.Windows.DataPresenter.FilterRecord;
					if (filterRecord == null || filterRecord.FieldLayout != record.FieldLayout)
					{
						return false;
					}
					record = filterRecord;
				}
				else if (record is global::Infragistics.Windows.DataPresenter.DataRecord)
				{
					if (dataRecord.FieldLayout != record.FieldLayout)
					{
						return false;
					}
					record = dataRecord;
				}
				else
				{
					if (!(record is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord))
					{
						return record is global::Infragistics.Windows.DataPresenter.GroupByRecord && false;
					}
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord2 = (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)record;
					int num2 = (expandableFieldRecord2.Field != null) ? dataRecord.ChildRecords.IndexOf(expandableFieldRecord2.Field) : -1;
					if (num2 < 0)
					{
						return false;
					}
					record = dataRecord.ChildRecords[num2];
				}
				dataItem = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(record);
				return true;
			}
			return false;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x000165D4 File Offset: 0x000147D4
		internal static void SelectCells(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellKey> modifiedCells, bool scrollIntoView, bool activateFirstCell)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Cell> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Cell>();
			foreach (global::Infragistics.Windows.DataPresenter.CellKey cellKey in modifiedCells)
			{
				if (!global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(cellKey.Record))
				{
					global::Infragistics.Windows.DataPresenter.Cell cell = cellKey.Cell;
					if (cell.IsSelectable)
					{
						list.Add(cell);
					}
				}
			}
			if (list.Count == 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = list[0].Field.Owner;
			if (owner == null)
			{
				return;
			}
			int maxSelectedCellsResolved = owner.MaxSelectedCellsResolved;
			if (maxSelectedCellsResolved < list.Count)
			{
				list.RemoveRange(maxSelectedCellsResolved, list.Count - maxSelectedCellsResolved);
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(dp);
			selectedItemHolder.Cells.InternalAddRange(list);
			if (dp.SelectNewSelection(typeof(global::Infragistics.Windows.DataPresenter.Cell), selectedItemHolder))
			{
				if (activateFirstCell)
				{
					list[0].IsActive = true;
				}
				if (scrollIntoView && dp.ActiveCell != null)
				{
					dp.BringCellIntoView(list[0]);
				}
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x000166DC File Offset: 0x000148DC
		internal static void SelectFields(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellKey> modifiedCells, global::Infragistics.Windows.DataPresenter.ICellValueProvider values, bool scrollIntoView, bool activateFirstCell)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			int i = 0;
			int fieldCount = values.FieldCount;
			while (i < fieldCount)
			{
				global::Infragistics.Windows.DataPresenter.Field field = values.GetField(i);
				if (global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(field))
				{
					list.Add(field);
				}
				i++;
			}
			if (list.Count == 0)
			{
				return;
			}
			if (list[0].Owner == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(dp);
			selectedItemHolder.Fields.InternalAddRange(list);
			selectedItemHolder.Records.InternalClear();
			selectedItemHolder.Cells.InternalClear();
			if (dp.SelectNewSelection(typeof(global::Infragistics.Windows.DataPresenter.Field), selectedItemHolder))
			{
				global::Infragistics.Windows.DataPresenter.Cell cell = null;
				if (activateFirstCell || scrollIntoView)
				{
					foreach (global::Infragistics.Windows.DataPresenter.CellKey cellKey in modifiedCells)
					{
						global::Infragistics.Windows.DataPresenter.DataRecord record = cellKey.Record;
						if (record.IsEnabledResolved && record.IsStillValid)
						{
							cell = cellKey.Cell;
							break;
						}
					}
				}
				if (cell != null)
				{
					if (activateFirstCell)
					{
						cell.IsActive = true;
					}
					if (scrollIntoView)
					{
						dp.BringCellIntoView(cell);
					}
				}
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00016800 File Offset: 0x00014A00
		internal static void SelectRecords(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.CellKey> modifiedCells, bool scrollIntoView, bool activateFirstRecord)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>();
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = null;
			foreach (global::Infragistics.Windows.DataPresenter.CellKey cellKey in modifiedCells)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord record = cellKey.Record;
				if (dataRecord != record)
				{
					dataRecord = record;
					list.Add(record);
				}
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterAction.SelectRecords(dp, list, scrollIntoView, activateFirstRecord);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00016870 File Offset: 0x00014A70
		internal static void SelectRecords(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> recordsToSelect, bool scrollIntoView, bool activateFirstRecord)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
			int i = 0;
			int count = recordsToSelect.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = recordsToSelect[i];
				if (dataRecord != null && !global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(dataRecord) && dataRecord.IsSelectable)
				{
					list.Add(dataRecord);
				}
				i++;
			}
			if (list.Count == 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = list[0].FieldLayout;
			if (fieldLayout == null)
			{
				return;
			}
			int maxSelectedRecordsResolved = fieldLayout.MaxSelectedRecordsResolved;
			if (maxSelectedRecordsResolved < list.Count)
			{
				list.RemoveRange(maxSelectedRecordsResolved, list.Count - maxSelectedRecordsResolved);
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(dp);
			selectedItemHolder.Records.InternalAddRange(list);
			if (dp.SelectNewSelection(typeof(global::Infragistics.Windows.DataPresenter.Record), selectedItemHolder))
			{
				if (activateFirstRecord)
				{
					dp.ActiveCell = null;
					list[0].IsActive = true;
				}
				if (scrollIntoView && dp.ActiveRecord != null)
				{
					dp.BringRecordIntoView(dp.ActiveRecord);
				}
			}
		}

		// Token: 0x040001C5 RID: 453
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dp;
	}
}
