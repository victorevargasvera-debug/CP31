using System;
using System.Linq;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000039 RID: 57
	public class AverageValueConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.DiscreetRuleBaseProxy
	{
		// Token: 0x06000293 RID: 659 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			global::System.IComparable comparable = sourceDataValue as global::System.IComparable;
			if (comparable == null)
			{
				return null;
			}
			global::Infragistics.Controls.Grids.AverageValueConditionalFormatRule averageValueConditionalFormatRule = (global::Infragistics.Controls.Grids.AverageValueConditionalFormatRule)base.Parent;
			if (averageValueConditionalFormatRule.FormattingTarget == global::Infragistics.Controls.Grids.AverageFormattingTarget.Above)
			{
				if (comparable.CompareTo(this._value) > 0)
				{
					return averageValueConditionalFormatRule.StyleToApply;
				}
			}
			else if (averageValueConditionalFormatRule.FormattingTarget == global::Infragistics.Controls.Grids.AverageFormattingTarget.EqualOrAbove)
			{
				if (comparable.CompareTo(this._value) >= 0)
				{
					return averageValueConditionalFormatRule.StyleToApply;
				}
			}
			else if (averageValueConditionalFormatRule.FormattingTarget == global::Infragistics.Controls.Grids.AverageFormattingTarget.Below)
			{
				if (comparable.CompareTo(this._value) < 0)
				{
					return averageValueConditionalFormatRule.StyleToApply;
				}
			}
			else if (averageValueConditionalFormatRule.FormattingTarget == global::Infragistics.Controls.Grids.AverageFormattingTarget.EqualOrBelow && comparable.CompareTo(this._value) <= 0)
			{
				return averageValueConditionalFormatRule.StyleToApply;
			}
			return null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000C670 File Offset: 0x0000A870
		protected override void GatherData(global::System.Linq.IQueryable query)
		{
			global::Infragistics.SummaryContext summaryContext = global::Infragistics.SummaryContext.CreateGenericSummary(base.Parent.Column.ColumnLayout.ObjectDataTypeInfo, base.Parent.Column.Key, global::Infragistics.LinqSummaryOperator.Average);
			this._value = (base.Parent.Column.ResolveValue(summaryContext.Execute(query)) as global::System.IComparable);
		}

		// Token: 0x040000A5 RID: 165
		private global::System.IComparable _value;
	}
}
