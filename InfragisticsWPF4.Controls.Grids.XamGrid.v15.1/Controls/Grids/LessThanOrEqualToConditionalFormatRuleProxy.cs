using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000053 RID: 83
	public class LessThanOrEqualToConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.EqualToConditionalFormatRuleProxy
	{
		// Token: 0x06000307 RID: 775 RVA: 0x0000E568 File Offset: 0x0000C768
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			global::System.IComparable comparable = sourceDataValue as global::System.IComparable;
			global::System.IComparable comparable2 = base.ResolvedValue as global::System.IComparable;
			if (comparable2 == null || comparable == null)
			{
				return null;
			}
			if (comparable2.CompareTo(comparable) >= 0)
			{
				return ((global::Infragistics.Controls.Grids.DiscreetRuleBase)base.Parent).StyleToApply;
			}
			return null;
		}
	}
}
