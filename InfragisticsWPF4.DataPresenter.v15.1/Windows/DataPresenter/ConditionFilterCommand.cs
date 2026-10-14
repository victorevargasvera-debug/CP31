using System;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000139 RID: 313
	public class ConditionFilterCommand : global::Infragistics.Windows.DataPresenter.RecordFilterCommandBase
	{
		// Token: 0x060012BD RID: 4797 RVA: 0x00052263 File Offset: 0x00050463
		public ConditionFilterCommand()
		{
			base.ShowCustomFilterDialog = true;
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00052274 File Offset: 0x00050474
		protected override bool CanExecute(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			if (!base.CanExecute(field, rm))
			{
				return false;
			}
			if (this._condition == null && !base.ShowCustomFilterDialog)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFiltersResolved = rm.GetRecordFiltersResolved(field.Owner);
				if (recordFiltersResolved == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.RecordFilter item = recordFiltersResolved.GetItem(field, false);
				if (item == null || !item.HasConditions)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x000522C6 File Offset: 0x000504C6
		protected override global::Infragistics.Windows.Controls.ICondition GetCondition(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			if (this._condition == null)
			{
				return null;
			}
			return this._condition.Clone() as global::Infragistics.Windows.Controls.ICondition;
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x000522E2 File Offset: 0x000504E2
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x000522EA File Offset: 0x000504EA
		public global::Infragistics.Windows.Controls.ICondition Condition
		{
			get
			{
				return this._condition;
			}
			set
			{
				base.SetField<global::Infragistics.Windows.Controls.ICondition>(ref this._condition, value, "Condition");
			}
		}

		// Token: 0x04000783 RID: 1923
		private global::Infragistics.Windows.Controls.ICondition _condition;
	}
}
