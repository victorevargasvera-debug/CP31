using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000041 RID: 65
	public class ContainingConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.StringConditionalFormatRuleProxy
	{
		// Token: 0x060002B3 RID: 691 RVA: 0x0000CAEC File Offset: 0x0000ACEC
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			string text = sourceDataValue as string;
			global::Infragistics.Controls.Grids.StringConditionalFormatRule stringConditionalFormatRule = base.Parent as global::Infragistics.Controls.Grids.StringConditionalFormatRule;
			if (stringConditionalFormatRule == null || string.IsNullOrEmpty(text) || string.IsNullOrEmpty(stringConditionalFormatRule.Value))
			{
				return null;
			}
			if (!text.Contains(stringConditionalFormatRule.Value))
			{
				return null;
			}
			return stringConditionalFormatRule.StyleToApply;
		}
	}
}
