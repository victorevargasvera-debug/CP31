using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000059 RID: 89
	public class NotBetweenXandYConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRuleProxy
	{
		// Token: 0x06000313 RID: 787 RVA: 0x0000E6A1 File Offset: 0x0000C8A1
		protected override global::System.Windows.Style EvaluateConditionHelper(global::System.IComparable lowerBound, global::System.IComparable upperBound, global::System.IComparable obj1, global::System.Windows.Style styleToApply, bool inclusive)
		{
			if (inclusive)
			{
				if (lowerBound.CompareTo(obj1) < 1 && upperBound.CompareTo(obj1) >= 0)
				{
					return null;
				}
				return styleToApply;
			}
			else
			{
				if (lowerBound.CompareTo(obj1) < 0 && upperBound.CompareTo(obj1) >= 1)
				{
					return null;
				}
				return styleToApply;
			}
		}
	}
}
