using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000050 RID: 80
	public class LessThanConditionalFormatRule : global::Infragistics.Controls.Grids.EqualToConditionalFormatRule
	{
		// Token: 0x06000301 RID: 769 RVA: 0x0000E4CC File Offset: 0x0000C6CC
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.LessThanConditionalFormatRuleProxy
			{
				Value = base.Value
			};
		}
	}
}
