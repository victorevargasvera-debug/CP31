using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200005C RID: 92
	public class NotEqualToConditionalFormatRule : global::Infragistics.Controls.Grids.EqualToConditionalFormatRule
	{
		// Token: 0x06000319 RID: 793 RVA: 0x0000E748 File Offset: 0x0000C948
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.NotEqualToConditionalFormatRuleProxy
			{
				Value = base.Value
			};
		}
	}
}
