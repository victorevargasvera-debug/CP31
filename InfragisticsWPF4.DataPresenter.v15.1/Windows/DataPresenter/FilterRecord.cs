using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000166 RID: 358
	public class FilterRecord : global::Infragistics.Windows.DataPresenter.DataRecord
	{
		// Token: 0x06001633 RID: 5683 RVA: 0x00062D14 File Offset: 0x00060F14
		internal FilterRecord(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection) : base(fieldLayout, parentCollection)
		{
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x00062D1E File Offset: 0x00060F1E
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsIfNeeded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x00062D21 File Offset: 0x00060F21
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x00062D24 File Offset: 0x00060F24
		internal override global::Infragistics.Windows.DataPresenter.CellCollection CreateCellCollection()
		{
			return new global::Infragistics.Windows.DataPresenter.FilterCellCollection(this);
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x00062D2C File Offset: 0x00060F2C
		// (set) Token: 0x06001638 RID: 5688 RVA: 0x00062D54 File Offset: 0x00060F54
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override string Description
		{
			get
			{
				string description = base.Description;
				if (!string.IsNullOrEmpty(description))
				{
					return description;
				}
				return global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("SR_FilterRecordDescription");
			}
			set
			{
				base.Description = value;
			}
		}

		// Token: 0x06001639 RID: 5689 RVA: 0x00062D60 File Offset: 0x00060F60
		public override global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord()
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = base.ParentCollection.ViewableRecords;
			if (viewableRecords != null)
			{
				return viewableRecords.GetAssociatedFilterRecord(this);
			}
			return null;
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x00062D85 File Offset: 0x00060F85
		internal override global::Infragistics.Windows.DataPresenter.CellClickAction GetCellClickActionResolved(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return global::Infragistics.Windows.DataPresenter.CellClickAction.EnterEditModeIfAllowed;
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x00062D88 File Offset: 0x00060F88
		public override object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field, bool useConverter)
		{
			if (field == null)
			{
				throw new global::System.ArgumentNullException("Field");
			}
			if (field.Owner != base.FieldLayout)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_28"));
			}
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = this.Cells[field];
			return filterCell.ValueInternal;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x00062DD4 File Offset: 0x00060FD4
		public override object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.CellValueType cellValueType)
		{
			return this.GetCellValue(field, true);
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x00062DDE File Offset: 0x00060FDE
		internal override global::System.Type GetEditAsTypeResolved(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			if (field.FilterOperandUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterOperandUIType.UseFieldEditor)
			{
				return base.GetEditAsTypeResolved(field);
			}
			return field.FilterEditAsTypeResolved;
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x00062DFC File Offset: 0x00060FFC
		internal override global::System.Type GetEditorTypeResolved(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			if (field.FilterOperandUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterOperandUIType.UseFieldEditor)
			{
				return base.GetEditorTypeResolved(field);
			}
			return field.FilterEditorTypeResolved;
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x00062E1C File Offset: 0x0006101C
		internal override bool GetIsEditingAllowed(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return false;
			}
			switch (field.FilterOperandUITypeResolved)
			{
			case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.None:
			case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Disabled:
				return false;
			default:
				return !(null == this.GetEditorTypeResolved(field)) && base.IsEnabledResolved;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x00062E65 File Offset: 0x00061065
		internal override bool HasChildrenInternal
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x00062E68 File Offset: 0x00061068
		public override bool IsDataRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x00062E6B File Offset: 0x0006106B
		protected internal override bool IsSelectable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x00062E6E File Offset: 0x0006106E
		public override bool IsSpecialRecord
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00062E74 File Offset: 0x00061074
		internal override void OnActiveRecordChanged()
		{
			base.OnActiveRecordChanged();
			if (!base.IsActive)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Cell cell in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell>)this.Cells))
				{
					global::Infragistics.Windows.DataPresenter.FilterCell filterCell = (global::Infragistics.Windows.DataPresenter.FilterCell)cell;
					bool flag = false;
					global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger filterEvaluationTriggerResolved = filterCell.Field.FilterEvaluationTriggerResolved;
					if (filterEvaluationTriggerResolved == global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.OnLeaveRecord || filterEvaluationTriggerResolved == global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.OnEnterKeyOrLeaveRecord)
					{
						filterCell.RecordFilter.ParentCollection.ApplyPendingFilters();
						flag = true;
					}
					if (flag)
					{
						break;
					}
				}
			}
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x00062EF8 File Offset: 0x000610F8
		protected override void OnHasListenersChanged()
		{
			base.OnHasListenersChanged();
			if (base.HasListeners)
			{
				if (this._filterVersionTracker == null)
				{
					this._filterVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this.Filters, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.VersionProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.VerifyActiveFilters));
				}
				this.VerifyActiveFilters();
				return;
			}
			this._filterVersionTracker = null;
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x00062F4B File Offset: 0x0006114B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::Infragistics.Windows.DataPresenter.RecordType RecordType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord;
			}
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x00062F50 File Offset: 0x00061150
		internal override bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, out global::Infragistics.Windows.DataPresenter.DataErrorInfo errorInfo, bool dontSetDataChanged)
		{
			if (field == null)
			{
				throw new global::System.ArgumentNullException("Field");
			}
			if (field.Owner != base.FieldLayout)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_28"));
			}
			errorInfo = null;
			global::Infragistics.Windows.DataPresenter.FilterCell filterCell = this.Cells[field];
			filterCell.ValueInternal = value;
			return true;
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x00062FA2 File Offset: 0x000611A2
		internal override bool ShouldCollapseCell(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return field != null && field.Index >= 0 && this.ShouldCollapseEmptyCellsResolved && field.FilterOperandUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterOperandUIType.None;
		}

		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x00062FC8 File Offset: 0x000611C8
		public override bool ShouldCollapseEmptyCellsResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				return fieldLayout != null && fieldLayout.IsEmptyCellCollapsingSupportedByView && (base.ShouldCollapseEmptyCells ?? true);
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00063002 File Offset: 0x00061202
		public override string ToString()
		{
			return "FilterRecord: " + this.Description;
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x00063014 File Offset: 0x00061214
		internal override global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableChildRecordsIfNeeded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x00063017 File Offset: 0x00061217
		public override global::System.Windows.Visibility VisibilityResolved
		{
			get
			{
				return base.VisibilityResolved;
			}
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x0006301F File Offset: 0x0006121F
		public new global::Infragistics.Windows.DataPresenter.FilterCellCollection Cells
		{
			get
			{
				return base.Cells as global::Infragistics.Windows.DataPresenter.FilterCellCollection;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x0006302C File Offset: 0x0006122C
		public bool HasActiveFilters
		{
			get
			{
				return this._cachedHasActiveFilters;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x00063034 File Offset: 0x00061234
		internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection Filters
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = base.RecordManager;
				if (recordManager == null)
				{
					return null;
				}
				return recordManager.RecordFiltersResolved;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00063053 File Offset: 0x00061253
		internal global::System.Windows.Visibility VisibilityResolvedBase
		{
			get
			{
				return base.VisibilityResolved;
			}
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x0006305B File Offset: 0x0006125B
		public void ClearActiveFilters()
		{
			this.ClearActiveFilters(false);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00063064 File Offset: 0x00061264
		internal void ClearActiveFilters(bool raiseEvents)
		{
			if (this.HasActiveFilters)
			{
				if (base.IsActive)
				{
					global::Infragistics.Windows.DataPresenter.FilterCell filterCell = base.DataPresenter.ActiveCell as global::Infragistics.Windows.DataPresenter.FilterCell;
					if (filterCell != null)
					{
						if (filterCell.IsInEditMode)
						{
							filterCell.EndEditMode(false, true);
						}
						global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter filterCellValuePresenter = filterCell.AssociatedCellValuePresenter as global::Infragistics.Windows.DataPresenter.FilterCellValuePresenter;
						if (filterCellValuePresenter != null)
						{
							filterCellValuePresenter.ClearOperandList();
						}
					}
				}
				global::Infragistics.Windows.DataPresenter.FilterCellCollection cells = this.Cells;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordFilter> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordFilter>();
				global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFilterCollection = null;
				global::Infragistics.Windows.DataPresenter.FilterCell filterCell2 = null;
				int i = 0;
				int count = this.Cells.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DataPresenter.FilterCell filterCell3 = cells[i];
					if (filterCell3.HasActiveFilters)
					{
						if (filterCell2 == null)
						{
							filterCell2 = filterCell3;
							recordFilterCollection = filterCell3.RecordFilter.ParentCollection;
						}
						global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = filterCell3.RecordFilter.Clear(raiseEvents, false);
						if (recordFilter != null && raiseEvents)
						{
							list.Add(recordFilter);
						}
					}
					i++;
				}
				if (dataPresenter != null && list.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.RecordFiltersAction action = new global::Infragistics.Windows.DataPresenter.RecordFiltersAction(list.ToArray(), recordFilterCollection.Owner, filterCell2, dataPresenter);
					dataPresenter.History.AddUndoActionInternal(action);
				}
			}
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00063172 File Offset: 0x00061372
		public void RefreshActiveFilters()
		{
			this.Filters.BumpVersion();
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x00063180 File Offset: 0x00061380
		internal static bool DoesAnyFieldAllowFiltering(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, out bool hasVisibleFields)
		{
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = fieldLayout.Fields;
			hasVisibleFields = false;
			int i = 0;
			int count = fields.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.Field field = fields[i];
				if (field.IsVisibleInCellArea)
				{
					hasVisibleFields = true;
					if (field.AllowRecordFilteringResolved && global::Infragistics.Windows.DataPresenter.FilterOperandUIType.None != field.FilterOperandUITypeResolved)
					{
						return true;
					}
				}
				i++;
			}
			return false;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000631D4 File Offset: 0x000613D4
		internal void VerifyActiveFilters()
		{
			global::Infragistics.Windows.DataPresenter.FilterCellCollection cells = this.Cells;
			bool flag = false;
			int i = 0;
			int count = this.Cells.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DataPresenter.FilterCell filterCell = cells[i];
				if (filterCell.HasActiveFilters)
				{
					flag = true;
					break;
				}
				i++;
			}
			if (flag != this._cachedHasActiveFilters)
			{
				this._cachedHasActiveFilters = flag;
				base.RaisePropertyChangedEvent("HasActiveFilters");
			}
		}

		// Token: 0x040008CB RID: 2251
		private bool _cachedHasActiveFilters;

		// Token: 0x040008CC RID: 2252
		private global::Infragistics.Windows.Internal.PropertyValueTracker _filterVersionTracker;
	}
}
