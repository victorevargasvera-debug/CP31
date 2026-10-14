using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000054 RID: 84
	public class MaximumValueConditionalFormatRule : global::Infragistics.Controls.Grids.EqualToConditionalFormatRule
	{
		// Token: 0x06000309 RID: 777 RVA: 0x0000E5B4 File Offset: 0x0000C7B4
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.MaximumValueConditionalFormatRuleProxy
			{
				Value = base.Value
			};
		}
	}
}
