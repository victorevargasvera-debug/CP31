using System;
using System.Collections.Generic;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000142 RID: 322
	internal class FilterDropDownConditionEvaluationContext : global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase
	{
		// Token: 0x0600113E RID: 4414 RVA: 0x0004ABAD File Offset: 0x00048DAD
		internal FilterDropDownConditionEvaluationContext(global::Infragistics.Windows.DataPresenter.Field field, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> allValuesRecords) : base(field, allValuesRecords)
		{
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x0600113F RID: 4415 RVA: 0x0004ABB7 File Offset: 0x00048DB7
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

		// Token: 0x06001140 RID: 4416 RVA: 0x0004ABE4 File Offset: 0x00048DE4
		internal void Initialize(global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem)
		{
			this._dropDownItem = dropDownItem;
			this._currentValue = null;
			base.CurrentCellValueForFilterComparison = dropDownItem.Value;
		}

		// Token: 0x040006CF RID: 1743
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItem _dropDownItem;

		// Token: 0x040006D0 RID: 1744
		private global::Infragistics.Windows.Controls.ValueEntry _currentValue;

		// Token: 0x02000143 RID: 323
		private class DropDownItemValueEntry : global::Infragistics.Windows.DataPresenter.FilterConditionEvaluationContextBase.FilterValueEntryBase
		{
			// Token: 0x06001141 RID: 4417 RVA: 0x0004AC00 File Offset: 0x00048E00
			internal DropDownItemValueEntry(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem, object value) : base(field, value)
			{
				this._dropDownItem = dropDownItem;
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06001142 RID: 4418 RVA: 0x0004AC11 File Offset: 0x00048E11
			public override object Context
			{
				get
				{
					return this._dropDownItem;
				}
			}

			// Token: 0x040006D1 RID: 1745
			private global::Infragistics.Windows.DataPresenter.FilterDropDownItem _dropDownItem;
		}
	}
}
