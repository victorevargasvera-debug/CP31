using System;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200011D RID: 285
	public class ConditionFilterCommand : global::Infragistics.Windows.DataPresenter.RecordFilterCommandBase
	{
		// Token: 0x06000F57 RID: 3927 RVA: 0x00041647 File Offset: 0x0003F847
		public ConditionFilterCommand()
		{
			base.ShowCustomFilterDialog = true;
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00041658 File Offset: 0x0003F858
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

		// Token: 0x06000F59 RID: 3929 RVA: 0x000416AA File Offset: 0x0003F8AA
		protected override global::Infragistics.Windows.Controls.ICondition GetCondition(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			if (this._condition == null)
			{
				return null;
			}
			return this._condition.Clone() as global::Infragistics.Windows.Controls.ICondition;
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000F5A RID: 3930 RVA: 0x000416C6 File Offset: 0x0003F8C6
		// (set) Token: 0x06000F5B RID: 3931 RVA: 0x000416CE File Offset: 0x0003F8CE
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

		// Token: 0x040005E1 RID: 1505
		private global::Infragistics.Windows.Controls.ICondition _condition;
	}
}
