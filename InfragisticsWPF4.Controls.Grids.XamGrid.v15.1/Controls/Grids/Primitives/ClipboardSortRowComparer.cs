using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000012 RID: 18
	public class ClipboardSortRowComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Grids.RowBase>
	{
		// Token: 0x06000105 RID: 261 RVA: 0x00008284 File Offset: 0x00006484
		public int Compare(global::Infragistics.Controls.Grids.RowBase x, global::Infragistics.Controls.Grids.RowBase y)
		{
			return x.CachedClipboardIndex.CompareTo(y.CachedClipboardIndex);
		}
	}
}
