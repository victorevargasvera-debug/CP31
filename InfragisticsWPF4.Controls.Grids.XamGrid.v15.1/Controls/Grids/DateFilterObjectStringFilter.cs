using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000E1 RID: 225
	public class DateFilterObjectStringFilter : global::Infragistics.CustomComparisonCondition
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0001E487 File Offset: 0x0001C687
		// (set) Token: 0x0600073B RID: 1851 RVA: 0x0001E48F File Offset: 0x0001C68F
		public global::Infragistics.Controls.Grids.DateFilterObjectType DateFilterObjectType { get; set; }

		// Token: 0x0600073C RID: 1852 RVA: 0x0001E498 File Offset: 0x0001C698
		protected override global::System.Linq.Expressions.Expression GetCurrentExpression()
		{
			return base.GetCurrentExpression();
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0001E4A8 File Offset: 0x0001C6A8
		protected override global::System.Linq.Expressions.Expression GetCurrentExpression(global::Infragistics.FilterContext context)
		{
			global::System.Linq.Expressions.Expression<global::System.Func<global::Infragistics.Controls.Grids.XamGridFilterDate, bool>> result = null;
			string text = (string)base.FilterValue;
			text = global::System.Text.RegularExpressions.Regex.Escape(text);
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(text, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			switch (this.DateFilterObjectType)
			{
			case global::Infragistics.Controls.Grids.DateFilterObjectType.All:
				result = ((global::Infragistics.Controls.Grids.XamGridFilterDate a) => (a.NullDate && regex.IsMatch(a.ContentString)) || (!a.NullDate && (regex.IsMatch(a.Date.Year.ToString()) || regex.IsMatch(a.ContentStringMonth) || regex.IsMatch(a.Date.Day.ToString()) || regex.IsMatch(a.Date.Hour.ToString()) || regex.IsMatch(a.Date.Minute.ToString()) || regex.IsMatch(a.Date.Second.ToString()))));
				break;
			case global::Infragistics.Controls.Grids.DateFilterObjectType.Year:
				result = ((global::Infragistics.Controls.Grids.XamGridFilterDate a) => (a.NullDate && regex.IsMatch(a.ContentString)) || (!a.NullDate && regex.IsMatch(a.Date.Year.ToString())));
				break;
			case global::Infragistics.Controls.Grids.DateFilterObjectType.Month:
				result = ((global::Infragistics.Controls.Grids.XamGridFilterDate a) => (a.NullDate && regex.IsMatch(a.ContentString)) || (!a.NullDate && regex.IsMatch(a.ContentStringMonth)));
				break;
			case global::Infragistics.Controls.Grids.DateFilterObjectType.Date:
				result = ((global::Infragistics.Controls.Grids.XamGridFilterDate a) => (a.NullDate && regex.IsMatch(a.ContentString)) || (!a.NullDate && regex.IsMatch(a.Date.Day.ToString())));
				break;
			case global::Infragistics.Controls.Grids.DateFilterObjectType.Hour:
				result = ((global::Infragistics.Controls.Grids.XamGridFilterDate a) => (a.NullDate && regex.IsMatch(a.ContentString)) || (!a.NullDate && regex.IsMatch(a.Date.Hour.ToString())));
				break;
			case global::Infragistics.Controls.Grids.DateFilterObjectType.Minute:
				result = ((global::Infragistics.Controls.Grids.XamGridFilterDate a) => (a.NullDate && regex.IsMatch(a.ContentString)) || (!a.NullDate && regex.IsMatch(a.Date.Minute.ToString())));
				break;
			case global::Infragistics.Controls.Grids.DateFilterObjectType.Second:
				result = ((global::Infragistics.Controls.Grids.XamGridFilterDate a) => (a.NullDate && regex.IsMatch(a.ContentString)) || (!a.NullDate && regex.IsMatch(a.Date.Second.ToString())));
				break;
			}
			return result;
		}
	}
}
