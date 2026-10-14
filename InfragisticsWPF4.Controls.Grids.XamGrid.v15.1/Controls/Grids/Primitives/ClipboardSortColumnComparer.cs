using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000011 RID: 17
	public class ClipboardSortColumnComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Grids.Column>
	{
		// Token: 0x06000103 RID: 259 RVA: 0x00008258 File Offset: 0x00006458
		public int Compare(global::Infragistics.Controls.Grids.Column x, global::Infragistics.Controls.Grids.Column y)
		{
			return x.CachedClipboardIndex.CompareTo(y.CachedClipboardIndex);
		}
	}
}
