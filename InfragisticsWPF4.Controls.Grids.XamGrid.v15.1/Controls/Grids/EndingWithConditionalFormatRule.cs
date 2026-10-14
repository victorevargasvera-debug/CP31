using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000046 RID: 70
	public class EndingWithConditionalFormatRule : global::Infragistics.Controls.Grids.StringConditionalFormatRule
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x0000DB46 File Offset: 0x0000BD46
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.EndingWithConditionalFormatRuleProxy();
		}
	}
}
