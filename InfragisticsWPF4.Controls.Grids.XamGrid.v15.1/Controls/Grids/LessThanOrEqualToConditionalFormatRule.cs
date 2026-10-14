using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000052 RID: 82
	public class LessThanOrEqualToConditionalFormatRule : global::Infragistics.Controls.Grids.EqualToConditionalFormatRule
	{
		// Token: 0x06000305 RID: 773 RVA: 0x0000E540 File Offset: 0x0000C740
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.LessThanOrEqualToConditionalFormatRuleProxy
			{
				Value = base.Value
			};
		}
	}
}
