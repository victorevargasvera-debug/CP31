using System;
using System.ComponentModel;
using System.Text;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000130 RID: 304
	public class FilterCell : global::Infragistics.Windows.DataPresenter.Cell
	{
		// Token: 0x0600106A RID: 4202 RVA: 0x00046A92 File Offset: 0x00044C92
		internal FilterCell(global::Infragistics.Windows.DataPresenter.FilterRecord record, global::Infragistics.Windows.DataPresenter.Field field) : base(record, field)
		{
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x00046A9C File Offset: 0x00044C9C
		internal override bool IsTabStop
		{
			get
			{
				switch (base.Field.FilterOperandUITypeResolved)
				{
				case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.None:
				case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Disabled:
					return false;
				default:
					return base.IsTabStop;
				}
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00046AD0 File Offset: 0x00044CD0
		internal override void OnActiveCellChanged()
		{
			base.OnActiveCellChanged();
			if (!base.IsActive)
			{
				global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger filterEvaluationTriggerResolved = base.Field.FilterEvaluationTriggerResolved;
				if (filterEvaluationTriggerResolved != global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.OnLeaveCell && filterEvaluationTriggerResolved != global::Infragistics.Windows.DataPresenter.FilterEvaluationTrigger.OnEnterKeyOrLeaveCell)
				{
					return;
				}
				this.RecordFilter.ParentCollection.ApplyPendingFilters();
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00046B10 File Offset: 0x00044D10
		internal override bool IsSelectable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x00046B14 File Offset: 0x00044D14
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("FilterCell: ");
			stringBuilder.Append(base.Field.ToString());
			stringBuilder.Append(", ");
			stringBuilder.Append(this.Record.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600106F RID: 4207 RVA: 0x00046B69 File Offset: 0x00044D69
		// (set) Token: 0x06001070 RID: 4208 RVA: 0x00046B76 File Offset: 0x00044D76
		internal object ValueInternal
		{
			get
			{
				return this.RecordFilter.CurrentUIOperand;
			}
			set
			{
				this.RecordFilter.CurrentUIOperand = value;
				base.RaisePropertyChangedEvent("Value");
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001071 RID: 4209 RVA: 0x00046B8F File Offset: 0x00044D8F
		public new global::Infragistics.Windows.DataPresenter.FilterRecord Record
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterRecord)base.Record;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001072 RID: 4210 RVA: 0x00046B9C File Offset: 0x00044D9C
		public bool HasActiveFilters
		{
			get
			{
				this.VerifyHasActiveFilters();
				return this._cachedHasActiveFilters;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001073 RID: 4211 RVA: 0x00046BAC File Offset: 0x00044DAC
		internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo FieldFilterInfo
		{
			get
			{
				if (this._fieldFilterInfo == null)
				{
					global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection filters = this.Record.Filters;
					if (filters != null)
					{
						this._fieldFilterInfo = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo(filters, base.Field);
						this._fieldFilterInfo.PropertyChanged += this.OnFieldFilterInfo_PropertyChanged;
					}
				}
				return this._fieldFilterInfo;
			}
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00046C00 File Offset: 0x00044E00
		private void OnFieldFilterInfo_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName = e.PropertyName;
			string a;
			if ((a = propertyName) != null)
			{
				if (a == "HasActiveFilters")
				{
					this.VerifyHasActiveFilters();
					return;
				}
				if (a == "RecordFilter")
				{
					this.NotifyAutoSizeInfo();
					base.RaisePropertyChangedEvent("RecordFilter");
					return;
				}
				if (!(a == "RecordFilterVersion"))
				{
					return;
				}
				this.NotifyAutoSizeInfo();
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x00046C60 File Offset: 0x00044E60
		public global::Infragistics.Windows.DataPresenter.RecordFilter RecordFilter
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo fieldFilterInfo = this.FieldFilterInfo;
				if (fieldFilterInfo == null)
				{
					return null;
				}
				return fieldFilterInfo.RecordFilter;
			}
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00046C7F File Offset: 0x00044E7F
		public void ClearActiveFilters()
		{
			this.ClearActiveFilters(false);
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00046C88 File Offset: 0x00044E88
		internal void ClearActiveFilters(bool raiseEvents)
		{
			if (base.IsInEditMode)
			{
				base.EndEditMode(false, false);
				if (base.IsInEditMode)
				{
					return;
				}
			}
			if (this.HasActiveFilters)
			{
				if (base.IsInEditMode)
				{
					base.EndEditMode(false, true);
				}
				this.RecordFilter.Clear(raiseEvents, raiseEvents);
			}
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00046CD8 File Offset: 0x00044ED8
		internal void VerifyHasActiveFilters()
		{
			bool flag = this.FieldFilterInfo != null && this.FieldFilterInfo.HasActiveFilters;
			if (this._cachedHasActiveFilters != flag)
			{
				this._cachedHasActiveFilters = flag;
				base.RaisePropertyChangedEvent("HasActiveFilters");
				this.Record.VerifyActiveFilters();
			}
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00046D24 File Offset: 0x00044F24
		private void NotifyAutoSizeInfo()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = base.Field.Owner;
			if (owner != null)
			{
				owner.AutoSizeInfo.OnFilterCellChanged(this);
			}
		}

		// Token: 0x0400067A RID: 1658
		private bool _cachedHasActiveFilters;

		// Token: 0x0400067B RID: 1659
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _fieldFilterInfo;
	}
}
