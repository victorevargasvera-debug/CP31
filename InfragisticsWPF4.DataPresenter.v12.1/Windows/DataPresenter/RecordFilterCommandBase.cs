using System;
using System.Collections.Generic;
using System.Windows.Input;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200011B RID: 283
	public abstract class RecordFilterCommandBase : global::Infragistics.PropertyChangeNotifier, global::System.Windows.Input.ICommand
	{
		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x0004120F File Offset: 0x0003F40F
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x00041217 File Offset: 0x0003F417
		public bool ShowCustomFilterDialog
		{
			get
			{
				return this._showCustomFilterDialog;
			}
			set
			{
				this.SetField<bool>(ref this._showCustomFilterDialog, value, "ShowCustomFilterDialog");
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x0004122C File Offset: 0x0003F42C
		private bool AreSimilar(global::Infragistics.Windows.Controls.ICondition condition1, global::Infragistics.Windows.Controls.ICondition condition2, bool compareOperands)
		{
			if (condition1 == condition2)
			{
				return true;
			}
			if (condition1 == null || condition2 == null)
			{
				return false;
			}
			if (condition1.GetType() != condition2.GetType())
			{
				return false;
			}
			if (condition1 is global::Infragistics.Windows.Controls.ConditionGroup)
			{
				global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = condition1 as global::Infragistics.Windows.Controls.ConditionGroup;
				global::Infragistics.Windows.Controls.ConditionGroup conditionGroup2 = condition2 as global::Infragistics.Windows.Controls.ConditionGroup;
				if (conditionGroup.Count != conditionGroup2.Count)
				{
					return false;
				}
				int i = 0;
				int count = conditionGroup.Count;
				while (i < count)
				{
					if (!this.AreSimilar(conditionGroup[i], conditionGroup2[i], compareOperands))
					{
						return false;
					}
					i++;
				}
				return true;
			}
			else
			{
				if (condition1 is global::Infragistics.Windows.Controls.ComparisonCondition)
				{
					global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = condition1 as global::Infragistics.Windows.Controls.ComparisonCondition;
					global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition2 = condition2 as global::Infragistics.Windows.Controls.ComparisonCondition;
					return comparisonCondition.Operator == comparisonCondition2.Operator && (!compareOperands || object.Equals(comparisonCondition.Value, comparisonCondition2.Value));
				}
				if (condition1 is global::Infragistics.Windows.Controls.ComplementCondition)
				{
					global::Infragistics.Windows.Controls.ComplementCondition complementCondition = condition1 as global::Infragistics.Windows.Controls.ComplementCondition;
					global::Infragistics.Windows.Controls.ComplementCondition complementCondition2 = condition2 as global::Infragistics.Windows.Controls.ComplementCondition;
					return this.AreSimilar(complementCondition.SourceCondition, complementCondition2.SourceCondition, compareOperands);
				}
				return condition1.Equals(condition2);
			}
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0004132C File Offset: 0x0003F52C
		private bool CanExecuteImpl(object parameter, out global::Infragistics.Windows.DataPresenter.Field field, out global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo fieldFilterInfo = parameter as global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo;
			if (fieldFilterInfo != null)
			{
				field = fieldFilterInfo.Field;
				rm = fieldFilterInfo.RecordManager;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.RecordFilterFieldInfo recordFilterFieldInfo = parameter as global::Infragistics.Windows.DataPresenter.RecordFilterFieldInfo;
				field = ((recordFilterFieldInfo != null) ? recordFilterFieldInfo.Field : null);
				rm = ((recordFilterFieldInfo != null) ? recordFilterFieldInfo.RecordManager : null);
			}
			return this.CanExecute(field, rm);
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00041384 File Offset: 0x0003F584
		private bool HasSameConditions(global::Infragistics.Windows.DataPresenter.RecordFilter rfOriginal, global::Infragistics.Windows.Controls.ICondition condition, bool compareOperands)
		{
			global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = condition as global::Infragistics.Windows.Controls.ConditionGroup;
			if (conditionGroup == null)
			{
				conditionGroup = new global::Infragistics.Windows.Controls.ConditionGroup();
				conditionGroup.Add(condition);
			}
			return this.AreSimilar(rfOriginal.Conditions, conditionGroup, compareOperands);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x000413B8 File Offset: 0x0003F5B8
		private void UpdateRecordFilter(global::Infragistics.Windows.DataPresenter.RecordFilter rf, global::Infragistics.Windows.Controls.ICondition condition)
		{
			if (this.ShowCustomFilterDialog || rf.ParentCollection == null)
			{
				rf.Conditions.Clear();
				global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = condition as global::Infragistics.Windows.Controls.ConditionGroup;
				if (conditionGroup != null)
				{
					rf.Conditions.LogicalOperator = conditionGroup.LogicalOperator;
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.Controls.ICondition> enumerator = conditionGroup.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::Infragistics.Windows.Controls.ICondition item = enumerator.Current;
							rf.Conditions.Add(item);
						}
						return;
					}
				}
				if (condition != null)
				{
					rf.Conditions.Add(condition);
					return;
				}
			}
			else
			{
				if (condition == null)
				{
					rf.Clear(true, true);
					return;
				}
				global::Infragistics.Windows.Controls.ComparisonCondition comparisonCondition = condition as global::Infragistics.Windows.Controls.ComparisonCondition;
				global::Infragistics.Windows.Controls.ConditionGroup conditionGroup2 = condition as global::Infragistics.Windows.Controls.ConditionGroup;
				if (comparisonCondition == null && conditionGroup2 != null && conditionGroup2.Count == 1)
				{
					comparisonCondition = (conditionGroup2[0] as global::Infragistics.Windows.Controls.ComparisonCondition);
				}
				if (comparisonCondition != null)
				{
					rf.CurrentUIOperator = comparisonCondition.Operator;
					rf.CurrentUIOperand = comparisonCondition.Value;
				}
				else
				{
					rf.CurrentUIOperator = global::Infragistics.Windows.Controls.ComparisonOperator.Equals;
					rf.CurrentUIOperand = condition;
				}
				rf.ApplyPendingFilter(true, true);
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000414C0 File Offset: 0x0003F6C0
		protected virtual bool CanExecute(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			return field != null && rm != null && field.Owner != null;
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x000414D8 File Offset: 0x0003F6D8
		protected virtual void Execute(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
		{
			global::Infragistics.Windows.Controls.ICondition condition = this.GetCondition(field, recordManager);
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			global::Infragistics.Windows.DataPresenter.RecordFilterCollection recordFiltersResolved = recordManager.GetRecordFiltersResolved(owner);
			if (this.ShowCustomFilterDialog)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter = recordFiltersResolved[field];
				global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter2;
				if (condition == null || this.HasSameConditions(recordFilter, condition, false))
				{
					recordFilter2 = recordFilter;
				}
				else
				{
					recordFilter2 = new global::Infragistics.Windows.DataPresenter.RecordFilter(field);
					this.UpdateRecordFilter(recordFilter2, condition);
				}
				owner.ShowCustomFilterSelectionControl(recordFilter2, recordManager);
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordFilter rf = recordFiltersResolved[field];
			this.UpdateRecordFilter(rf, condition);
		}

		// Token: 0x06000F4A RID: 3914
		protected abstract global::Infragistics.Windows.Controls.ICondition GetCondition(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager);

		// Token: 0x06000F4B RID: 3915 RVA: 0x0004154D File Offset: 0x0003F74D
		protected bool SetField<T>(ref T member, T newValue, string propertyName)
		{
			if (global::System.Collections.Generic.EqualityComparer<T>.Default.Equals(member, newValue))
			{
				return false;
			}
			member = newValue;
			this.OnPropertyChanged(propertyName);
			return true;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00041574 File Offset: 0x0003F774
		internal bool HasSameConditions(global::Infragistics.Windows.DataPresenter.RecordFilter filter, bool compareOperands, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			global::Infragistics.Windows.Controls.ICondition condition = this.GetCondition(field, rm);
			return this.HasSameConditions(filter, condition, compareOperands);
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00041594 File Offset: 0x0003F794
		bool global::System.Windows.Input.ICommand.CanExecute(object parameter)
		{
			global::Infragistics.Windows.DataPresenter.Field field;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager;
			return this.CanExecuteImpl(parameter, out field, out recordManager);
		}

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06000F4E RID: 3918 RVA: 0x000415AC File Offset: 0x0003F7AC
		// (remove) Token: 0x06000F4F RID: 3919 RVA: 0x000415B4 File Offset: 0x0003F7B4
		event global::System.EventHandler global::System.Windows.Input.ICommand.CanExecuteChanged
		{
			add
			{
				global::System.Windows.Input.CommandManager.RequerySuggested += value;
			}
			remove
			{
				global::System.Windows.Input.CommandManager.RequerySuggested -= value;
			}
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x000415BC File Offset: 0x0003F7BC
		void global::System.Windows.Input.ICommand.Execute(object parameter)
		{
			global::Infragistics.Windows.DataPresenter.Field field;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager;
			if (!this.CanExecuteImpl(parameter, out field, out recordManager))
			{
				return;
			}
			this.Execute(field, recordManager);
		}

		// Token: 0x040005DD RID: 1501
		private bool _showCustomFilterDialog;
	}
}
