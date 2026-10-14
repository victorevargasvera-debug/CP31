using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200005B RID: 91
	public class NotContainingConditionalFormatRuleProxy : global::Infragistics.Controls.Grids.StringConditionalFormatRuleProxy
	{
		// Token: 0x06000317 RID: 791 RVA: 0x0000E6F0 File Offset: 0x0000C8F0
		protected override global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			string text = sourceDataValue as string;
			global::Infragistics.Controls.Grids.StringConditionalFormatRule stringConditionalFormatRule = base.Parent as global::Infragistics.Controls.Grids.StringConditionalFormatRule;
			if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(stringConditionalFormatRule.Value))
			{
				return null;
			}
			if (text.Contains(stringConditionalFormatRule.Value))
			{
				return null;
			}
			return stringConditionalFormatRule.StyleToApply;
		}
	}
}
