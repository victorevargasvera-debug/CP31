using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000040 RID: 64
	public class ContainingConditionalFormatRule : global::Infragistics.Controls.Grids.StringConditionalFormatRule
	{
		// Token: 0x060002B1 RID: 689 RVA: 0x0000CADB File Offset: 0x0000ACDB
		protected internal override global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy CreateProxy()
		{
			return new global::Infragistics.Controls.Grids.ContainingConditionalFormatRuleProxy();
		}
	}
}
