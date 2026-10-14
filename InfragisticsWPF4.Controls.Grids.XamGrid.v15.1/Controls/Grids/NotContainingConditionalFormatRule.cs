using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200005A RID: 90
	public class NotContainingConditionalFormatRule : global::Infragistics.Controls.Grids.StringConditionalFormatRule
	{
		// Token: 0x06000315 RID: 789 RVA: 0x0000E6E0 File Offset: 0x0000C8E0
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.NotContainingConditionalFormatRuleProxy();
		}
	}
}
