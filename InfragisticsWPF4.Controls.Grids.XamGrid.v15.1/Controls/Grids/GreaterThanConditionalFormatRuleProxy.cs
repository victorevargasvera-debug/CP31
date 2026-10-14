using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200004B RID: 75
	public class GreaterThanConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.EqualToConditionalFormatRuleProxy
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x0000DE30 File Offset: 0x0000C030
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			global::System.IComparable comparable = sourceDataValue as global::System.IComparable;
			global::System.IComparable comparable2 = base.ResolvedValue as global::System.IComparable;
			if (comparable == null || comparable2 == null)
			{
				return null;
			}
			if (comparable2.CompareTo(comparable) < 0)
			{
				return ((global::Infragistics.Controls.Grids.DiscreetRuleBase)base.Parent).StyleToApply;
			}
			return null;
		}
	}
}
