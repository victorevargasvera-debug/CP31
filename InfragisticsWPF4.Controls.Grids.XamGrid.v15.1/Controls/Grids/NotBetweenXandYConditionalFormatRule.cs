using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000058 RID: 88
	public class NotBetweenXandYConditionalFormatRule : global::Infragistics.Controls.Grids.BetweenXandYConditionalFormatRule
	{
		// Token: 0x06000311 RID: 785 RVA: 0x0000E692 File Offset: 0x0000C892
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.NotBetweenXandYConditionalFormatRuleProxy();
		}
	}
}
