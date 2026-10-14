using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200004C RID: 76
	public class GreaterThanOrEqualToConditionalFormatRule : global::Infragistics.Controls.Grids.EqualToConditionalFormatRule
	{
		// Token: 0x060002F4 RID: 756 RVA: 0x0000DE7C File Offset: 0x0000C07C
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.GreaterThanOrEqualToConditionalFormatRuleProxy
			{
				Value = base.Value
			};
		}
	}
}
