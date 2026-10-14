using System;

namespace SourceGrid
{
	// Token: 0x02000376 RID: 886
	internal class RangeRegionEventArgs : global::System.EventArgs
	{
		// Token: 0x06002A6D RID: 10861 RVA: 0x0008FB94 File Offset: 0x0008DD94
		public RangeRegionEventArgs(global::SourceGrid.RangeRegion p_GridRangeRegion)
		{
			this.m_GridRangeRegion = p_GridRangeRegion;
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002A6E RID: 10862 RVA: 0x0008FBA4 File Offset: 0x0008DDA4
		public global::SourceGrid.RangeRegion RangeRegion
		{
			get
			{
				return this.m_GridRangeRegion;
			}
		}

		// Token: 0x04000E4F RID: 3663
		private global::SourceGrid.RangeRegion m_GridRangeRegion;
	}
}
