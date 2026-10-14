using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200003D RID: 61
	public class BeginningWithConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.StringConditionalFormatRuleProxy
	{
		// Token: 0x0600029E RID: 670 RVA: 0x0000C768 File Offset: 0x0000A968
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			string text = sourceDataValue as string;
			global::Infragistics.Controls.Grids.StringConditionalFormatRule stringConditionalFormatRule = base.Parent as global::Infragistics.Controls.Grids.StringConditionalFormatRule;
			if (stringConditionalFormatRule == null || string.IsNullOrEmpty(text) || string.IsNullOrEmpty(stringConditionalFormatRule.Value))
			{
				return null;
			}
			global::System.StringComparison comparisonType = global::System.StringComparison.InvariantCulture;
			if (!text.StartsWith(stringConditionalFormatRule.Value, comparisonType))
			{
				return null;
			}
			return stringConditionalFormatRule.StyleToApply;
		}
	}
}
