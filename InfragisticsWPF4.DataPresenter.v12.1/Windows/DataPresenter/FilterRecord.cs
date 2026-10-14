using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200014A RID: 330
	public class FilterRecord : global::Infragistics.Windows.DataPresenter.DataRecord
	{
		// Token: 0x060012BB RID: 4795 RVA: 0x00050F8C File Offset: 0x0004F18C
		internal FilterRecord(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection) : base(fieldLayout, parentCollection)
		{
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x00050F96 File Offset: 0x0004F196
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsIfNeeded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x060012BD RID: 4797 RVA: 0x00050F99 File Offset: 0x0004F199
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00050F9C File Offset: 0x0004F19C
		internal override global::Infragistics.Windows.DataPresenter.CellCollection CreateCellCollection()
		{
			return new global::Infragistics.Windows.DataPresenter.FilterCellCollection(this);
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x00050FA4 File Offset: 0x0004F1A4
		// (set) Token: 0x060012C0 RID: 4800 RVA: 0x00050FCC File Offset: 0x0004F1CC
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

		// Token: 0x060012C1 RID: 4801 RVA: 0x00050FD8 File Offset: 0x0004F1D8
		public override global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord()
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = base.ParentCollection.ViewableRecords;
			if (viewableRecords != null)
			{
				return viewableRecords.GetAssociatedFilterRecord(this);
			}
			return null;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00050FFD File Offset: 0x0004F1FD
		internal override global::Infragistics.Windows.DataPresenter.CellClickAction GetCellClickActionResolved(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return global::Infragistics.Windows.DataPresenter.CellClickAction.EnterEditModeIfAllowed;
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00051000 File Offset: 0x0004F200
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

		// Token: 0x060012C4 RID: 4804 RVA: 0x0005104C File Offset: 0x0004F24C
		public override object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.CellValueType cellValueType)
		{
			return this.GetCellValue(field, true);
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00051056 File Offset: 0x0004F256
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

		// Token: 0x060012C6 RID: 4806 RVA: 0x00051074 File Offset: 0x0004F274
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

		// Token: 0x060012C7 RID: 4807 RVA: 0x00051094 File Offset: 0x0004F294
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

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x000510DD File Offset: 0x0004F2DD
		internal override bool HasChildrenInternal
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x000510E0 File Offset: 0x0004F2E0
		public override bool IsDataRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x000510E3 File Offset: 0x0004F2E3
		protected internal override bool IsSelectable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x060012CB RID: 4811 RVA: 0x000510E6 File Offset: 0x0004F2E6
		public override bool IsSpecialRecord
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x000510EC File Offset: 0x0004F2EC
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

		// Token: 0x060012CD RID: 4813 RVA: 0x00051170 File Offset: 0x0004F370
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

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x000511C3 File Offset: 0x0004F3C3
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::Infragistics.Windows.DataPresenter.RecordType RecordType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord;
			}
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x000511C8 File Offset: 0x0004F3C8
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

		// Token: 0x060012D0 RID: 4816 RVA: 0x0005121A File Offset: 0x0004F41A
		internal override bool ShouldCollapseCell(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return field != null && field.Index >= 0 && this.ShouldCollapseEmptyCellsResolved && field.FilterOperandUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterOperandUIType.None;
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00051240 File Offset: 0x0004F440
		public override bool ShouldCollapseEmptyCellsResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				return fieldLayout != null && fieldLayout.IsEmptyCellCollapsingSupportedByView && (base.ShouldCollapseEmptyCells ?? true);
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x0005127A File Offset: 0x0004F47A
		public override string ToString()
		{
			return "FilterRecord: " + this.Description;
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0005128C File Offset: 0x0004F48C
		internal override global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableChildRecordsIfNeeded
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x0005128F File Offset: 0x0004F48F
		public override global::System.Windows.Visibility VisibilityResolved
		{
			get
			{
				return base.VisibilityResolved;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00051297 File Offset: 0x0004F497
		public new global::Infragistics.Windows.DataPresenter.FilterCellCollection Cells
		{
			get
			{
				return base.Cells as global::Infragistics.Windows.DataPresenter.FilterCellCollection;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x000512A4 File Offset: 0x0004F4A4
		public bool HasActiveFilters
		{
			get
			{
				return this._cachedHasActiveFilters;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060012D7 RID: 4823 RVA: 0x000512AC File Offset: 0x0004F4AC
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

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x000512CB File Offset: 0x0004F4CB
		internal global::System.Windows.Visibility VisibilityResolvedBase
		{
			get
			{
				return base.VisibilityResolved;
			}
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x000512D3 File Offset: 0x0004F4D3
		public void ClearActiveFilters()
		{
			this.ClearActiveFilters(false);
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000512DC File Offset: 0x0004F4DC
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

		// Token: 0x060012DB RID: 4827 RVA: 0x000513EA File Offset: 0x0004F5EA
		public void RefreshActiveFilters()
		{
			this.Filters.BumpVersion();
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x000513F8 File Offset: 0x0004F5F8
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

		// Token: 0x060012DD RID: 4829 RVA: 0x0005144C File Offset: 0x0004F64C
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

		// Token: 0x04000719 RID: 1817
		private bool _cachedHasActiveFilters;

		// Token: 0x0400071A RID: 1818
		private global::Infragistics.Windows.Internal.PropertyValueTracker _filterVersionTracker;
	}
}
