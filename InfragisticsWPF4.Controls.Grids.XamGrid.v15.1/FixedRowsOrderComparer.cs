using System;
using System.Collections.Generic;
using Infragistics.Controls.Grids;

namespace Infragistics
{
	// Token: 0x020001D4 RID: 468
	internal sealed class FixedRowsOrderComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Grids.RowBase>
	{
		// Token: 0x06000C54 RID: 3156 RVA: 0x0002B93C File Offset: 0x00029B3C
		int global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Grids.RowBase>.Compare(global::Infragistics.Controls.Grids.RowBase x, global::Infragistics.Controls.Grids.RowBase y)
		{
			return x.FixedPositionSortOrder.CompareTo(y.FixedPositionSortOrder);
		}
	}
}
