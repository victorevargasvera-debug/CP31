using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000E2 RID: 226
	public class FilterValueProxyStringFilter : global::Infragistics.CustomComparisonCondition
	{
		// Token: 0x0600073F RID: 1855 RVA: 0x0001EFCC File Offset: 0x0001D1CC
		protected override global::System.Linq.Expressions.Expression GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			string text = (string)base.FilterValue;
			text = global::System.Text.RegularExpressions.Regex.Escape(text);
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(text, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			return (global::Infragistics.Controls.Grids.Primitives.FilterValueProxy a) => a.ContentString != null && regex.IsMatch(a.ContentString);
		}
	}
}
