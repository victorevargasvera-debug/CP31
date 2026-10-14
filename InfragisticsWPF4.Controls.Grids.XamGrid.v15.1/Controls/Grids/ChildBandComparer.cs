using System;
using System.Collections.Generic;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000273 RID: 627
	internal class ChildBandComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Grids.Primitives.ChildBand>
	{
		// Token: 0x060014DD RID: 5341 RVA: 0x0004CDFC File Offset: 0x0004AFFC
		public int Compare(global::Infragistics.Controls.Grids.Primitives.ChildBand x, global::Infragistics.Controls.Grids.Primitives.ChildBand y)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = x.ParentRow.ColumnLayout;
			int num = columnLayout.Columns.IndexOf(x.ColumnLayout);
			int value = columnLayout.Columns.IndexOf(y.ColumnLayout);
			return num.CompareTo(value);
		}
	}
}
