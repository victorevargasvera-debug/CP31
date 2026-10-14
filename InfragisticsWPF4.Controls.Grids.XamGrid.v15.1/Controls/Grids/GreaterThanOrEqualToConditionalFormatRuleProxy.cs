using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200004D RID: 77
	public class GreaterThanOrEqualToConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.EqualToConditionalFormatRuleProxy
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			global::System.IComparable comparable = sourceDataValue as global::System.IComparable;
			global::System.IComparable comparable2 = base.ResolvedValue as global::System.IComparable;
			if (comparable2 == null || comparable == null)
			{
				return null;
			}
			if (comparable2.CompareTo(comparable) <= 0)
			{
				return ((global::Infragistics.Controls.Grids.DiscreetRuleBase)base.Parent).StyleToApply;
			}
			return null;
		}
	}
}
