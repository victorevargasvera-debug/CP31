using System;
using System.Globalization;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200003F RID: 63
	public class BetweenXandYConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.DiscreetRuleBaseProxy
	{
		// Token: 0x060002AE RID: 686 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			global::System.IComparable comparable = sourceDataValue as global::System.IComparable;
			global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule betweenXandYConditionalFormatRule = base.Parent as global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule;
			global::System.IComparable comparable2 = betweenXandYConditionalFormatRule.LowerBoundResolved;
			global::System.IComparable comparable3 = betweenXandYConditionalFormatRule.UpperBoundResolved;
			global::System.Type type = comparable.GetType();
			if (!type.Equals(comparable2.GetType()))
			{
				try
				{
					comparable2 = (global::System.Convert.ChangeType(comparable2, type, global::System.Globalization.CultureInfo.InvariantCulture) as global::System.IComparable);
					comparable3 = (global::System.Convert.ChangeType(comparable3, type, global::System.Globalization.CultureInfo.InvariantCulture) as global::System.IComparable);
				}
				catch (global::System.OverflowException)
				{
					return null;
				}
				catch (global::System.InvalidCastException)
				{
					return null;
				}
				catch (global::System.FormatException)
				{
					return null;
				}
			}
			if (comparable2 != null && comparable3 != null && comparable != null)
			{
				return this.EvaluateConditionHelper(comparable2, comparable3, comparable, betweenXandYConditionalFormatRule.StyleToApply, betweenXandYConditionalFormatRule.IsInclusive);
			}
			return null;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000CA9C File Offset: 0x0000AC9C
		protected virtual global::System.Windows.Style EvaluateConditionHelper(global::System.IComparable lowerBound, global::System.IComparable upperBound, global::System.IComparable obj1, global::System.Windows.Style styleToApply, bool inclusive)
		{
			if (inclusive)
			{
				if (lowerBound.CompareTo(obj1) >= 1 || upperBound.CompareTo(obj1) < 0)
				{
					return null;
				}
				return styleToApply;
			}
			else
			{
				if (lowerBound.CompareTo(obj1) >= 0 || upperBound.CompareTo(obj1) <= 0)
				{
					return null;
				}
				return styleToApply;
			}
		}
	}
}
