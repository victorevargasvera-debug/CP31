using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200005D RID: 93
	public class NotEqualToConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.EqualToConditionalFormatRuleProxy
	{
		// Token: 0x0600031B RID: 795 RVA: 0x0000E770 File Offset: 0x0000C970
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			if (sourceDataValue != null && !sourceDataValue.Equals(base.ResolvedValue))
			{
				return ((global::Infragistics.Controls.Grids.DiscreetRuleBase)base.Parent).StyleToApply;
			}
			return null;
		}
	}
}
