using System;
using System.Collections;

namespace SourceGrid
{
	// Token: 0x02000380 RID: 896
	internal class SortRangeRowsEventArgs : global::System.EventArgs
	{
		// Token: 0x06002A91 RID: 10897 RVA: 0x0008FC58 File Offset: 0x0008DE58
		public SortRangeRowsEventArgs(global::SourceGrid.Range p_Range, int keyColumn, bool p_bAscending, global::System.Collections.IComparer p_CellComparer)
		{
			this.m_Range = p_Range;
			this.mKeyColumn = keyColumn;
			this.m_bAscending = p_bAscending;
			this.m_CellComparer = p_CellComparer;
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002A92 RID: 10898 RVA: 0x0008FC80 File Offset: 0x0008DE80
		public global::SourceGrid.Range Range
		{
			get
			{
				return this.m_Range;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x0008FC88 File Offset: 0x0008DE88
		public int KeyColumn
		{
			get
			{
				return this.mKeyColumn;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x0008FC90 File Offset: 0x0008DE90
		public bool Ascending
		{
			get
			{
				return this.m_bAscending;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x0008FC98 File Offset: 0x0008DE98
		public global::System.Collections.IComparer CellComparer
		{
			get
			{
				return this.m_CellComparer;
			}
		}

		// Token: 0x04000E58 RID: 3672
		private global::SourceGrid.Range m_Range;

		// Token: 0x04000E59 RID: 3673
		private int mKeyColumn;

		// Token: 0x04000E5A RID: 3674
		private bool m_bAscending;

		// Token: 0x04000E5B RID: 3675
		private global::System.Collections.IComparer m_CellComparer;
	}
}
