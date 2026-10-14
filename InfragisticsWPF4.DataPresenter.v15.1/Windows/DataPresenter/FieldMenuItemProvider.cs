using System;
using System.Collections.Generic;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200012E RID: 302
	internal class FieldMenuItemProvider
	{
		// Token: 0x060011E0 RID: 4576 RVA: 0x0004E4E8 File Offset: 0x0004C6E8
		internal FieldMenuItemProvider(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem rootMenuItem, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo fieldFilterInfo)
		{
			this._rootMenuItem = rootMenuItem;
			this._fieldFilterInfo = fieldFilterInfo;
			this._editAsTypeResolved = this._fieldFilterInfo.Field.EditAsTypeResolved;
			this._compatibleOperators = global::Infragistics.Windows.Controls.ComparisonCondition.GetCompatibleComparisonOperators(this._editAsTypeResolved, out this._defaultUiOperator);
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0004E536 File Offset: 0x0004C736
		internal object FilterCommandParameter
		{
			get
			{
				return this._fieldFilterInfo;
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0004E540 File Offset: 0x0004C740
		internal global::Infragistics.Windows.DataPresenter.FieldMenuDataItem AddClearFilterMenuItem(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem parent)
		{
			if (this._fieldFilterInfo == null || this._fieldFilterInfo.Field == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Field field = this._fieldFilterInfo.Field;
			global::Infragistics.Windows.DataPresenter.ConditionFilterCommand command = new global::Infragistics.Windows.DataPresenter.ConditionFilterCommand
			{
				ShowCustomFilterDialog = false
			};
			string @string = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("FilterMenuCaption_ClearFieldFilter", new object[]
			{
				field.Label
			});
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddMenuItem(parent, @string, command, this.FilterCommandParameter);
			global::System.Uri uriSource = global::Infragistics.CoreUtilities.BuildEmbeddedResourceUri(base.GetType().Assembly, "/Images/FilterClearMenu.png");
			global::System.Windows.Media.Imaging.BitmapImage imageSource = new global::System.Windows.Media.Imaging.BitmapImage(uriSource);
			fieldMenuDataItem.ImageSource = imageSource;
			return fieldMenuDataItem;
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x0004E5DC File Offset: 0x0004C7DC
		internal static global::Infragistics.Windows.DataPresenter.FieldMenuDataItem AddSeparator(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem parent)
		{
			int count = parent.Items.Count;
			if (count < 1 || parent.Items[count - 1].IsSeparator)
			{
				return null;
			}
			return global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddMenuItem(parent.Items, new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem
			{
				IsSeparator = true
			});
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x0004E62C File Offset: 0x0004C82C
		internal global::Infragistics.Windows.DataPresenter.FieldMenuDataItem CreateDataTypeFilterMenuItem(global::System.Type fieldType)
		{
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(fieldType);
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem;
			if (underlyingType == typeof(global::System.DateTime))
			{
				fieldMenuDataItem = this.CreateDateFilterMenuItem();
			}
			else if (global::Infragistics.Windows.Utilities.IsNumericType(underlyingType) || underlyingType == typeof(bool))
			{
				fieldMenuDataItem = this.CreateNumericFilterMenuItem();
			}
			else
			{
				fieldMenuDataItem = this.CreateTextFilterMenuItem();
			}
			if (fieldMenuDataItem != null)
			{
				int count = fieldMenuDataItem.Items.Count;
				if (count > 0 && fieldMenuDataItem.Items[count - 1].IsSeparator)
				{
					fieldMenuDataItem.Items.RemoveAt(count - 1);
				}
			}
			return fieldMenuDataItem;
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x0004E6C0 File Offset: 0x0004C8C0
		private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem AddCustomFilterMenuItem(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem parent)
		{
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddMenuItem(parent, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("FilterMenuCaption_CustomFilter"), new global::Infragistics.Windows.DataPresenter.ConditionFilterCommand(), this.FilterCommandParameter);
			fieldMenuDataItem.IsCheckable = true;
			return fieldMenuDataItem;
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0004E6F4 File Offset: 0x0004C8F4
		private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem AddFilterMenuItem(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem parent, string headerResourceName, global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
		{
			if (!this.IsCompatibleOperator(comparisonOperator))
			{
				return null;
			}
			return this.AddFilterMenuItem(parent, headerResourceName, new global::Infragistics.Windows.Controls.ICondition[]
			{
				new global::Infragistics.Windows.Controls.ComparisonCondition
				{
					Operator = comparisonOperator
				}
			});
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0004E730 File Offset: 0x0004C930
		private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem AddFilterMenuItem(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem parent, string headerResourceName, params global::Infragistics.Windows.Controls.ICondition[] conditions)
		{
			global::Infragistics.Windows.DataPresenter.ConditionFilterCommand conditionFilterCommand = new global::Infragistics.Windows.DataPresenter.ConditionFilterCommand();
			if (conditions != null)
			{
				if (conditions.Length > 1)
				{
					global::Infragistics.Windows.Controls.ConditionGroup conditionGroup = new global::Infragistics.Windows.Controls.ConditionGroup();
					foreach (global::Infragistics.Windows.Controls.ICondition item in conditions)
					{
						conditionGroup.Add(item);
					}
					conditionFilterCommand.Condition = conditionGroup;
				}
				else
				{
					conditionFilterCommand.Condition = conditions[0];
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddMenuItem(parent, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(headerResourceName), conditionFilterCommand, this.FilterCommandParameter);
			fieldMenuDataItem.IsCheckable = true;
			return fieldMenuDataItem;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0004E7A4 File Offset: 0x0004C9A4
		private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem AddFilterOperandMenuItem(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem parent, string specialOperandName)
		{
			global::Infragistics.Windows.Controls.SpecialFilterOperandBase registeredOperand = global::Infragistics.Windows.Controls.SpecialFilterOperands.GetRegisteredOperand(specialOperandName);
			if (registeredOperand == null)
			{
				return null;
			}
			if (!registeredOperand.SupportsOperator(global::Infragistics.Windows.Controls.ComparisonOperator.Equals))
			{
				return null;
			}
			if (!registeredOperand.SupportsDataType(this._editAsTypeResolved))
			{
				return null;
			}
			string name = string.Format("FilterMenuCaption_{0}_Operand", specialOperandName);
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddMenuItem(parent, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString(name), new global::Infragistics.Windows.DataPresenter.SpecialFilterOperandCommand
			{
				OperandName = specialOperandName
			}, this.FilterCommandParameter);
			fieldMenuDataItem.IsCheckable = true;
			return fieldMenuDataItem;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0004E810 File Offset: 0x0004CA10
		private static global::Infragistics.Windows.DataPresenter.FieldMenuDataItem AddMenuItem(global::Infragistics.Windows.DataPresenter.FieldMenuDataItem parent, object header, global::System.Windows.Input.ICommand command, object commandParameter)
		{
			return global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddMenuItem(parent.Items, new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem
			{
				Header = header,
				Command = command,
				CommandParameter = commandParameter
			});
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0004E844 File Offset: 0x0004CA44
		private static global::Infragistics.Windows.DataPresenter.FieldMenuDataItem AddMenuItem(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> parentItems, global::Infragistics.Windows.DataPresenter.FieldMenuDataItem child)
		{
			parentItems.Add(child);
			return child;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0004E850 File Offset: 0x0004CA50
		private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem CreateDateFilterMenuItem()
		{
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem
			{
				Header = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("FilterMenuCaption_DateFilters")
			};
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_Equals", global::Infragistics.Windows.Controls.ComparisonOperator.Equals);
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_Before", global::Infragistics.Windows.Controls.ComparisonOperator.LessThan);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_After", global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThan);
			if (this.IsCompatibleOperator(global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThanOrEqualTo) && this.IsCompatibleOperator(global::Infragistics.Windows.Controls.ComparisonOperator.LessThanOrEqualTo))
			{
				this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_Between", new global::Infragistics.Windows.Controls.ICondition[]
				{
					new global::Infragistics.Windows.Controls.ComparisonCondition
					{
						Operator = global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThanOrEqualTo
					},
					new global::Infragistics.Windows.Controls.ComparisonCondition
					{
						Operator = global::Infragistics.Windows.Controls.ComparisonOperator.LessThanOrEqualTo
					}
				});
			}
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "Tomorrow");
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "Today");
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "Yesterday");
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "NextWeek");
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "ThisWeek");
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "LastWeek");
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "NextMonth");
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "ThisMonth");
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "LastMonth");
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "NextQuarter");
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "ThisQuarter");
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "LastQuarter");
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "NextYear");
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "ThisYear");
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "LastYear");
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "YearToDate");
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem2 = new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem
			{
				Header = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("FilterMenuCaption_AllDates")
			};
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "Quarter1");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "Quarter2");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "Quarter3");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "Quarter4");
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem2);
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "January");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "February");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "March");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "April");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "May");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "June");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "July");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "August");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "September");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "October");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "November");
			this.AddFilterOperandMenuItem(fieldMenuDataItem2, "December");
			if (fieldMenuDataItem2.Items.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddMenuItem(fieldMenuDataItem.Items, fieldMenuDataItem2);
				global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			}
			this.AddCustomFilterMenuItem(fieldMenuDataItem);
			return fieldMenuDataItem;
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0004EB14 File Offset: 0x0004CD14
		private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem CreateNumericFilterMenuItem()
		{
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem
			{
				Header = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("FilterMenuCaption_NumberFilters")
			};
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_Equals", global::Infragistics.Windows.Controls.ComparisonOperator.Equals);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_NotEquals", global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals);
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_GreaterThan", global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThan);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_GreaterThanOrEqual", global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThanOrEqualTo);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_LessThan", global::Infragistics.Windows.Controls.ComparisonOperator.LessThan);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_LessThanOrEqual", global::Infragistics.Windows.Controls.ComparisonOperator.LessThanOrEqualTo);
			if (this.IsCompatibleOperator(global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThanOrEqualTo) && this.IsCompatibleOperator(global::Infragistics.Windows.Controls.ComparisonOperator.LessThanOrEqualTo))
			{
				this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_Between", new global::Infragistics.Windows.Controls.ICondition[]
				{
					new global::Infragistics.Windows.Controls.ComparisonCondition
					{
						Operator = global::Infragistics.Windows.Controls.ComparisonOperator.GreaterThanOrEqualTo
					},
					new global::Infragistics.Windows.Controls.ComparisonCondition
					{
						Operator = global::Infragistics.Windows.Controls.ComparisonOperator.LessThanOrEqualTo
					}
				});
			}
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			if (this.IsCompatibleOperator(global::Infragistics.Windows.Controls.ComparisonOperator.Top))
			{
				this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_Top10", new global::Infragistics.Windows.Controls.ICondition[]
				{
					new global::Infragistics.Windows.Controls.ComparisonCondition(global::Infragistics.Windows.Controls.ComparisonOperator.Top, 10)
				});
			}
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "AboveAverage");
			this.AddFilterOperandMenuItem(fieldMenuDataItem, "BelowAverage");
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddCustomFilterMenuItem(fieldMenuDataItem);
			return fieldMenuDataItem;
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0004EC48 File Offset: 0x0004CE48
		private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem CreateTextFilterMenuItem()
		{
			global::Infragistics.Windows.DataPresenter.FieldMenuDataItem fieldMenuDataItem = new global::Infragistics.Windows.DataPresenter.FieldMenuDataItem
			{
				Header = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("FilterMenuCaption_TextFilters")
			};
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_Equals", global::Infragistics.Windows.Controls.ComparisonOperator.Equals);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_NotEquals", global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals);
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_BeginsWith", global::Infragistics.Windows.Controls.ComparisonOperator.StartsWith);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_EndsWith", global::Infragistics.Windows.Controls.ComparisonOperator.EndsWith);
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_Contains", global::Infragistics.Windows.Controls.ComparisonOperator.Contains);
			this.AddFilterMenuItem(fieldMenuDataItem, "FilterMenuCaption_NotContains", global::Infragistics.Windows.Controls.ComparisonOperator.DoesNotContain);
			global::Infragistics.Windows.DataPresenter.FieldMenuItemProvider.AddSeparator(fieldMenuDataItem);
			this.AddCustomFilterMenuItem(fieldMenuDataItem);
			return fieldMenuDataItem;
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0004ECE4 File Offset: 0x0004CEE4
		private bool IsCompatibleOperator(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
		{
			global::Infragistics.Windows.Controls.ComparisonOperatorFlags comparisonOperatorFlag = global::Infragistics.Windows.Controls.ComparisonCondition.GetComparisonOperatorFlag(comparisonOperator);
			return comparisonOperatorFlag == (comparisonOperatorFlag & this._compatibleOperators);
		}

		// Token: 0x04000741 RID: 1857
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.FieldFilterInfo _fieldFilterInfo;

		// Token: 0x04000742 RID: 1858
		private global::Infragistics.Windows.DataPresenter.FieldMenuDataItem _rootMenuItem;

		// Token: 0x04000743 RID: 1859
		private global::System.Type _editAsTypeResolved;

		// Token: 0x04000744 RID: 1860
		private global::Infragistics.Windows.Controls.ComparisonOperatorFlags _compatibleOperators;

		// Token: 0x04000745 RID: 1861
		private global::Infragistics.Windows.Controls.ComparisonOperator _defaultUiOperator;
	}
}
