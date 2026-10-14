using System;
using System.ComponentModel;
using System.Text;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200014C RID: 332
	public class FilterCell : global::Infragistics.Windows.DataPresenter.Cell
	{
		// Token: 0x060013D4 RID: 5076 RVA: 0x00057DAA File Offset: 0x00055FAA
		internal FilterCell(global::Infragistics.Windows.DataPresenter.FilterRecord record, global::Infragistics.Windows.DataPresenter.Field field) : base(record, field)
		{
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00057DB4 File Offset: 0x00055FB4
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

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x00057DF4 File Offset: 0x00055FF4
		internal override bool IsSelectable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00057DF8 File Offset: 0x00055FF8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("FilterCell: ");
			stringBuilder.Append(base.Field.ToString());
			stringBuilder.Append(", ");
			stringBuilder.Append(this.Record.ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x00057E4D File Offset: 0x0005604D
		// (set) Token: 0x060013D9 RID: 5081 RVA: 0x00057E5A File Offset: 0x0005605A
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

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060013DA RID: 5082 RVA: 0x00057E73 File Offset: 0x00056073
		public new global::Infragistics.Windows.DataPresenter.FilterRecord Record
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.FilterRecord)base.Record;
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x00057E80 File Offset: 0x00056080
		public bool HasActiveFilters
		{
			get
			{
				this.VerifyHasActiveFilters();
				return this._cachedHasActiveFilters;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x00057E90 File Offset: 0x00056090
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

		// Token: 0x060013DD RID: 5085 RVA: 0x00057EE4 File Offset: 0x000560E4
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

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x00057F44 File Offset: 0x00056144
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

		// Token: 0x060013DF RID: 5087 RVA: 0x00057F63 File Offset: 0x00056163
		public void ClearActiveFilters()
		{
			this.ClearActiveFilters(false);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x00057F6C File Offset: 0x0005616C
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

		// Token: 0x060013E1 RID: 5089 RVA: 0x00057FBC File Offset: 0x000561BC
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

		// Token: 0x060013E2 RID: 5090 RVA: 0x00058008 File Offset: 0x00056208
		private void NotifyAutoSizeInfo()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = base.Field.Owner;
			if (owner != null)
			{
				owner.AutoSizeInfo.OnFilterCellChanged(this);
			}
		}

		// Token: 0x04000820 RID: 2080
		private bool _cachedHasActiveFilters;

		// Token: 0x04000821 RID: 2081
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _fieldFilterInfo;
	}
}
