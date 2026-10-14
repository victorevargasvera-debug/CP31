using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000072 RID: 114
	internal class RecordFiltersAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x06000631 RID: 1585 RVA: 0x0001854F File Offset: 0x0001674F
		internal RecordFiltersAction(global::Infragistics.Windows.DataPresenter.RecordFilter[] filters, object filtersOwner, global::Infragistics.Windows.DataPresenter.FilterCell cell, global::Infragistics.Windows.DataPresenter.DataPresenterBase dp) : base(dp)
		{
			this._filters = filters;
			this._recordManager = (filtersOwner as global::Infragistics.Windows.DataPresenter.RecordManager);
			this._cell = cell;
			this.CacheParentDataItem();
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00018579 File Offset: 0x00016779
		protected internal override void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
			if (!this.RestoreWithUndelete)
			{
				return;
			}
			if (this._recordManager != null)
			{
				descendantInfo.AddRecord(this._recordManager.ParentRecord);
			}
			if (this._cell != null)
			{
				descendantInfo.AddRecord(this._cell.Record);
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x000185B8 File Offset: 0x000167B8
		protected internal override bool CanPerform(object context)
		{
			return this._filters.Length != 0 && (this._recordManager == null || this._recordManager.ParentRecord == null || this._recordManager.ParentRecord.IsStillValid);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x000185ED File Offset: 0x000167ED
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			if (this._recordManager == null && fieldLayout == this.GetFieldLayout() && (customizationType & global::Infragistics.Windows.DataPresenter.CustomizationType.RecordFilters) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00018610 File Offset: 0x00016810
		protected internal override void OnRecordsUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords)
		{
			if (!this.RestoreWithUndelete)
			{
				return;
			}
			if (this._recordManager != null)
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = this._recordManager.ParentRecord;
				if (global::Infragistics.Windows.DataPresenter.DataPresenterAction.ProcessRecordUndeleted(oldDataTimeToRecords, ref this._recordManagerDataItem, ref parentRecord))
				{
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)parentRecord;
					this._recordManager = expandableFieldRecord.ChildRecordManager;
				}
			}
			if (this._cellDataItem != null && global::Infragistics.Windows.DataPresenter.DataPresenterAction.IsValid(this._cell.Field))
			{
				global::Infragistics.Windows.DataPresenter.Record record = this._cell.Record;
				if (global::Infragistics.Windows.DataPresenter.DataPresenterAction.ProcessRecordUndeleted(oldDataTimeToRecords, ref this._cellDataItem, ref record))
				{
					global::Infragistics.Windows.DataPresenter.FilterRecord filterRecord = (global::Infragistics.Windows.DataPresenter.FilterRecord)record;
					this._cell = filterRecord.Cells[this._cell.Field];
				}
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x000186B8 File Offset: 0x000168B8
		protected internal override global::Infragistics.Windows.Helpers.ActionHistory.ActionBase Perform(object context)
		{
			if (!this.CanPerform(context))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFilterCollection = null;
			if (this._recordManager != null)
			{
				recordFilterCollection = this._recordManager.RecordFilters;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.GetFieldLayout();
				if (fieldLayout != null)
				{
					recordFilterCollection = fieldLayout.RecordFilters;
				}
			}
			if (recordFilterCollection == null)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordFilter> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordFilter>();
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordFilter, global::Infragistics.Windows.DataPresenter.RecordFilter> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordFilter, global::Infragistics.Windows.DataPresenter.RecordFilter>();
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter in this._filters)
			{
				global::Infragistics.Windows.DataPresenter.Field field = recordFilter.Field;
				if (field != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter2 = recordFilterCollection[field];
					if (recordFilter2 == null)
					{
						recordFilter2 = new global::Infragistics.Windows.DataPresenter.RecordFilter(field);
					}
					global::Infragistics.Windows.DataPresenter.RecordFilter item = recordFilter2.Clone(true, recordFilter2.ParentCollection, true);
					list.Add(item);
					dictionary[recordFilter] = recordFilter2;
				}
			}
			int num = 0;
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.RecordFilter, global::Infragistics.Windows.DataPresenter.RecordFilter> keyValuePair in dictionary)
			{
				if (keyValuePair.Value.InitializeFrom(keyValuePair.Key, true, true))
				{
					num++;
				}
			}
			if (this._cell != null && !global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(this._cell))
			{
				this._cell.IsActive = true;
			}
			return new global::Infragistics.Windows.DataPresenter.RecordFiltersAction(list.ToArray(), recordFilterCollection.Owner, this._cell, base.DataPresenter);
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00018810 File Offset: 0x00016A10
		private bool RestoreWithUndelete
		{
			get
			{
				return this._recordManager == null;
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001881B File Offset: 0x00016A1B
		private void CacheParentDataItem()
		{
			this._recordManagerDataItem = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(this._recordManager);
			this._cellDataItem = ((this._cell != null) ? global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(this._cell.Record) : null);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00018850 File Offset: 0x00016A50
		private global::Infragistics.Windows.DataPresenter.FieldLayout GetFieldLayout()
		{
			if (this._recordManager != null)
			{
				return this._recordManager.FieldLayout;
			}
			foreach (global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter in this._filters)
			{
				global::Infragistics.Windows.DataPresenter.Field field = recordFilter.Field;
				if (field != null && field.Owner != null)
				{
					return field.Owner;
				}
			}
			return null;
		}

		// Token: 0x040001DF RID: 479
		private global::Infragistics.Windows.DataPresenter.RecordFilter[] _filters;

		// Token: 0x040001E0 RID: 480
		private object _recordManagerDataItem;

		// Token: 0x040001E1 RID: 481
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x040001E2 RID: 482
		private global::Infragistics.Windows.DataPresenter.FilterCell _cell;

		// Token: 0x040001E3 RID: 483
		private object _cellDataItem;
	}
}
