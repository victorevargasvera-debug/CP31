using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200004A RID: 74
	public class GreaterThanConditionalFormatRule : global::Infragistics.Controls.Grids.EqualToConditionalFormatRule
	{
		// Token: 0x060002F0 RID: 752 RVA: 0x0000DE08 File Offset: 0x0000C008
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.GreaterThanConditionalFormatRuleProxy
			{
				Value = base.Value
			};
		}
	}
}
