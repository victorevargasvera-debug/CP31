using System;
using System.Collections.Generic;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200006D RID: 109
	internal class RecordFiltersAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x060005B6 RID: 1462 RVA: 0x00016153 File Offset: 0x00014353
		internal RecordFiltersAction(global::Infragistics.Windows.DataPresenter.RecordFilter[] filters, object filtersOwner, global::Infragistics.Windows.DataPresenter.FilterCell cell, global::Infragistics.Windows.DataPresenter.DataPresenterBase dp) : base(dp)
		{
			this._filters = filters;
			this._recordManager = (filtersOwner as global::Infragistics.Windows.DataPresenter.RecordManager);
			this._cell = cell;
			this.CacheParentDataItem();
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0001617D File Offset: 0x0001437D
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

		// Token: 0x060005B8 RID: 1464 RVA: 0x000161BC File Offset: 0x000143BC
		protected internal override bool CanPerform(object context)
		{
			return this._filters.Length != 0 && (this._recordManager == null || this._recordManager.ParentRecord == null || this._recordManager.ParentRecord.IsStillValid);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x000161F1 File Offset: 0x000143F1
		internal override global::Infragistics.Windows.DataPresenter.DataPresenterAction OnCustomizationsChanged(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.CustomizationType customizationType)
		{
			if (this._recordManager == null && fieldLayout == this.GetFieldLayout() && (customizationType & global::Infragistics.Windows.DataPresenter.CustomizationType.RecordFilters) != global::Infragistics.Windows.DataPresenter.CustomizationType.None)
			{
				return null;
			}
			return base.OnCustomizationsChanged(fieldLayout, customizationType);
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00016214 File Offset: 0x00014414
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

		// Token: 0x060005BB RID: 1467 RVA: 0x000162BC File Offset: 0x000144BC
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

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00016414 File Offset: 0x00014614
		private bool RestoreWithUndelete
		{
			get
			{
				return this._recordManager == null;
			}
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0001641F File Offset: 0x0001461F
		private void CacheParentDataItem()
		{
			this._recordManagerDataItem = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(this._recordManager);
			this._cellDataItem = ((this._cell != null) ? global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(this._cell.Record) : null);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00016454 File Offset: 0x00014654
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

		// Token: 0x040001A6 RID: 422
		private global::Infragistics.Windows.DataPresenter.RecordFilter[] _filters;

		// Token: 0x040001A7 RID: 423
		private object _recordManagerDataItem;

		// Token: 0x040001A8 RID: 424
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x040001A9 RID: 425
		private global::Infragistics.Windows.DataPresenter.FilterCell _cell;

		// Token: 0x040001AA RID: 426
		private object _cellDataItem;
	}
}
