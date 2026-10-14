using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000047 RID: 71
	public class EndingWithConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.StringConditionalFormatRuleProxy
	{
		// Token: 0x060002E2 RID: 738 RVA: 0x0000DB58 File Offset: 0x0000BD58
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			string text = sourceDataValue as string;
			global::Infragistics.Controls.Grids.StringConditionalFormatRule stringConditionalFormatRule = base.Parent as global::Infragistics.Controls.Grids.StringConditionalFormatRule;
			if (stringConditionalFormatRule == null || string.IsNullOrEmpty(text) || string.IsNullOrEmpty(stringConditionalFormatRule.Value))
			{
				return null;
			}
			if (!text.EndsWith(stringConditionalFormatRule.Value))
			{
				return null;
			}
			return stringConditionalFormatRule.StyleToApply;
		}
	}
}
