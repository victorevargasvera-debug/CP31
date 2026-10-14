using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200003B RID: 59
	public class BeginningWithConditionalFormatRule : global::Infragistics.Controls.Grids.StringConditionalFormatRule
	{
		// Token: 0x0600029B RID: 667 RVA: 0x0000C751 File Offset: 0x0000A951
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.BeginningWithConditionalFormatRuleProxy();
		}
	}
}
