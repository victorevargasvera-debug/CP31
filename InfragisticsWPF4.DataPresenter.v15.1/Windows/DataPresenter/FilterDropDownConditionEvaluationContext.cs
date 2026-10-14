using System;
using System.Collections.Generic;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200015E RID: 350
	internal class FilterDropDownConditionEvaluationContext : global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase
	{
		// Token: 0x060014A8 RID: 5288 RVA: 0x0005C02D File Offset: 0x0005A22D
		internal FilterDropDownConditionEvaluationContext(global::Infragistics.Windows.DataPresenter.Field field, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> allValuesRecords) : base(field, allValuesRecords)
		{
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0005C037 File Offset: 0x0005A237
		public override global::Infragistics.Windows.Controls.ValueEntry CurrentValue
		{
			get
			{
				if (this._currentValue == null)
				{
					this._currentValue = new global::Infragistics.Windows.DataPresenter.FilterDropDownConditionEvaluationContext.DropDownItemValueEntry(base.Field, this._dropDownItem, base.CurrentCellValueForFilterComparison);
				}
				return this._currentValue;
			}
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0005C064 File Offset: 0x0005A264
		internal void Initialize(global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem)
		{
			this._dropDownItem = dropDownItem;
			this._currentValue = null;
			base.CurrentCellValueForFilterComparison = dropDownItem.Value;
		}

		// Token: 0x04000877 RID: 2167
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItem _dropDownItem;

		// Token: 0x04000878 RID: 2168
		private global::Infragistics.Windows.Controls.ValueEntry _currentValue;

		// Token: 0x0200015F RID: 351
		private class DropDownItemValueEntry : global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntryBase
		{
			// Token: 0x060014AB RID: 5291 RVA: 0x0005C080 File Offset: 0x0005A280
			internal DropDownItemValueEntry(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem, object value) : base(field, value)
			{
				this._dropDownItem = dropDownItem;
			}

			// Token: 0x1700052A RID: 1322
			// (get) Token: 0x060014AC RID: 5292 RVA: 0x0005C091 File Offset: 0x0005A291
			public override object Context
			{
				get
				{
					return this._dropDownItem;
				}
			}

			// Token: 0x04000879 RID: 2169
			private global::Infragistics.Windows.DataPresenter.FilterDropDownItem _dropDownItem;
		}
	}
}
