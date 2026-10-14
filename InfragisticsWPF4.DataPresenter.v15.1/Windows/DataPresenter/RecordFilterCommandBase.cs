using System;
using System.Collections.Generic;
using System.Windows.Input;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000137 RID: 311
	public abstract class RecordFilterCommandBase : global::Infragistics.PropertyChangeNotifier, global::System.Windows.Input.ICommand
	{
		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00051E2B File Offset: 0x0005002B
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00051E33 File Offset: 0x00050033
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

		// Token: 0x060012AA RID: 4778 RVA: 0x00051E48 File Offset: 0x00050048
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

		// Token: 0x060012AB RID: 4779 RVA: 0x00051F48 File Offset: 0x00050148
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

		// Token: 0x060012AC RID: 4780 RVA: 0x00051FA0 File Offset: 0x000501A0
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

		// Token: 0x060012AD RID: 4781 RVA: 0x00051FD4 File Offset: 0x000501D4
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

		// Token: 0x060012AE RID: 4782 RVA: 0x000520DC File Offset: 0x000502DC
		protected virtual bool CanExecute(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			return field != null && rm != null && field.Owner != null;
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000520F4 File Offset: 0x000502F4
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

		// Token: 0x060012B0 RID: 4784
		protected abstract global::Infragistics.Windows.Controls.ICondition GetCondition(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager);

		// Token: 0x060012B1 RID: 4785 RVA: 0x00052169 File Offset: 0x00050369
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

		// Token: 0x060012B2 RID: 4786 RVA: 0x00052190 File Offset: 0x00050390
		internal bool HasSameConditions(global::Infragistics.Windows.DataPresenter.RecordFilter filter, bool compareOperands, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager rm)
		{
			global::Infragistics.Windows.Controls.ICondition condition = this.GetCondition(field, rm);
			return this.HasSameConditions(filter, condition, compareOperands);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x000521B0 File Offset: 0x000503B0
		bool global::System.Windows.Input.ICommand.CanExecute(object parameter)
		{
			global::Infragistics.Windows.DataPresenter.Field field;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager;
			return this.CanExecuteImpl(parameter, out field, out recordManager);
		}

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x060012B4 RID: 4788 RVA: 0x000521C8 File Offset: 0x000503C8
		// (remove) Token: 0x060012B5 RID: 4789 RVA: 0x000521D0 File Offset: 0x000503D0
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

		// Token: 0x060012B6 RID: 4790 RVA: 0x000521D8 File Offset: 0x000503D8
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

		// Token: 0x0400077F RID: 1919
		private bool _showCustomFilterDialog;
	}
}
