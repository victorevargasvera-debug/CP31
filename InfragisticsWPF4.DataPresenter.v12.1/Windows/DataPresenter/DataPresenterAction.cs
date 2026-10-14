using System;
using System.Collections.Generic;
using System.ComponentModel;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000063 RID: 99
	internal abstract class DataPresenterAction : global::Infragistics.Windows.Helpers.ActionHistory.ActionBase
	{
		// Token: 0x06000571 RID: 1393 RVA: 0x00013FDE File Offset: 0x000121DE
		internal DataPresenterAction(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(dp, "dp");
			this._dp = dp;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x00013FF8 File Offset: 0x000121F8
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dp;
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00014000 File Offset: 0x00012200
		protected internal virtual void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00014002 File Offset: 0x00012202
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		internal bool CanPerformInternal(object context)
		{
			return this.CanPerform(context);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0001400B File Offset: 0x0001220B
		protected static bool IsValid(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return field != null && field.Owner != null && field.Index >= 0;
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00014028 File Offset: 0x00012228
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

		// Token: 0x06000577 RID: 1399 RVA: 0x00014089 File Offset: 0x00012289
		internal static global::Infragistics.Windows.DataPresenter.DataRecord GetDataItemRecord(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			if (rm == null)
			{
				return null;
			}
			return rm.ParentDataRecord;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00014098 File Offset: 0x00012298
		internal static object GetRecordDataItem(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataItemRecord = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetDataItemRecord(record);
			if (dataItemRecord == null)
			{
				return null;
			}
			return dataItemRecord.DataItem;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000140B7 File Offset: 0x000122B7
		internal static object GetRecordDataItem(global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			return global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetDataItemRecord(rm));
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000140C4 File Offset: 0x000122C4
		internal virtual global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			return this;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000140C7 File Offset: 0x000122C7
		protected internal virtual void OnRecordsUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords)
		{
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000140C9 File Offset: 0x000122C9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		internal global::Infragistics.Windows.Helpers.ActionHistory.ActionBase PerformInternal(object context)
		{
			return this.Perform(context);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000140D4 File Offset: 0x000122D4
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

		// Token: 0x0600057E RID: 1406 RVA: 0x0001420C File Offset: 0x0001240C
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

		// Token: 0x0600057F RID: 1407 RVA: 0x00014314 File Offset: 0x00012514
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

		// Token: 0x06000580 RID: 1408 RVA: 0x00014438 File Offset: 0x00012638
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

		// Token: 0x06000581 RID: 1409 RVA: 0x000144A8 File Offset: 0x000126A8
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

		// Token: 0x0400018D RID: 397
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dp;
	}
}
