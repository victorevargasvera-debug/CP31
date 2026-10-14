using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000056 RID: 86
	public class MinimumValueConditionalFormatRule : global::Infragistics.Controls.Grids.EqualToConditionalFormatRule
	{
		// Token: 0x0600030D RID: 781 RVA: 0x0000E624 File Offset: 0x0000C824
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.MinimumValueConditionalFormatRuleProxy
			{
				Value = base.Value
			};
		}
	}
}
