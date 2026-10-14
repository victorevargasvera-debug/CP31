using System;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000F0 RID: 240
	public class XamGridFilterYearCollection : global::Infragistics.Controls.Grids.Primitives.FilterItemCollection<global::Infragistics.Controls.Grids.XamGridFilterDate>
	{
		// Token: 0x060007F0 RID: 2032 RVA: 0x00020784 File Offset: 0x0001E984
		public global::Infragistics.Controls.Grids.XamGridFilterDate GetItemByYear(global::System.DateTime date)
		{
			int year = date.Year;
			foreach (global::Infragistics.Controls.Grids.XamGridFilterDate xamGridFilterDate in base.List)
			{
				if (xamGridFilterDate.Date.Year == year)
				{
					return xamGridFilterDate;
				}
			}
			return null;
		}
	}
}
