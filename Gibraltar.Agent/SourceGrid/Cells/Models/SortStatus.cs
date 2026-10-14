using System;
using System.Collections;
using DevAge.Drawing;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003ED RID: 1005
	internal struct SortStatus
	{
		// Token: 0x06002CBD RID: 11453 RVA: 0x00096650 File Offset: 0x00094850
		public SortStatus(global::DevAge.Drawing.HeaderSortStyle p_Style)
		{
			this.Style = p_Style;
			this.Comparer = null;
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x00096660 File Offset: 0x00094860
		public SortStatus(global::DevAge.Drawing.HeaderSortStyle p_Style, global::System.Collections.IComparer p_Comparer)
		{
			this = new global::SourceGrid.Cells.Models.SortStatus(p_Style);
			this.Comparer = p_Comparer;
		}

		// Token: 0x04000F2C RID: 3884
		public global::DevAge.Drawing.HeaderSortStyle Style;

		// Token: 0x04000F2D RID: 3885
		public global::System.Collections.IComparer Comparer;
	}
}
