using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000051 RID: 81
	public class LessThanConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.EqualToConditionalFormatRuleProxy
	{
		// Token: 0x06000303 RID: 771 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			global::System.IComparable comparable = sourceDataValue as global::System.IComparable;
			global::System.IComparable comparable2 = base.ResolvedValue as global::System.IComparable;
			if (comparable == null || comparable2 == null)
			{
				return null;
			}
			if (comparable2.CompareTo(comparable) > 0)
			{
				return ((global::Infragistics.Controls.Grids.DiscreetRuleBase)base.Parent).StyleToApply;
			}
			return null;
		}
	}
}
