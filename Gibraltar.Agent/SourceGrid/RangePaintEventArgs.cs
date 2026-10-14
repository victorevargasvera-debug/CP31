using System;
using DevAge.Drawing;

namespace SourceGrid
{
	// Token: 0x02000370 RID: 880
	internal class RangePaintEventArgs : global::System.EventArgs
	{
		// Token: 0x06002A56 RID: 10838 RVA: 0x0008FB0C File Offset: 0x0008DD0C
		public RangePaintEventArgs(global::SourceGrid.GridVirtual grid, global::DevAge.Drawing.GraphicsCache graphicsCache, global::SourceGrid.Range drawingRange)
		{
			this.mGrid = grid;
			this.mGraphicsCache = graphicsCache;
			this.mDrawingRange = drawingRange;
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x0008FB2C File Offset: 0x0008DD2C
		public global::SourceGrid.GridVirtual Grid
		{
			get
			{
				return this.mGrid;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x0008FB34 File Offset: 0x0008DD34
		// (set) Token: 0x06002A59 RID: 10841 RVA: 0x0008FB3C File Offset: 0x0008DD3C
		public global::DevAge.Drawing.GraphicsCache GraphicsCache
		{
			get
			{
				return this.mGraphicsCache;
			}
			set
			{
				this.mGraphicsCache = value;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x0008FB48 File Offset: 0x0008DD48
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x0008FB50 File Offset: 0x0008DD50
		public global::SourceGrid.Range DrawingRange
		{
			get
			{
				return this.mDrawingRange;
			}
			set
			{
				this.mDrawingRange = value;
			}
		}

		// Token: 0x04000E4A RID: 3658
		private global::SourceGrid.GridVirtual mGrid;

		// Token: 0x04000E4B RID: 3659
		private global::DevAge.Drawing.GraphicsCache mGraphicsCache;

		// Token: 0x04000E4C RID: 3660
		private global::SourceGrid.Range mDrawingRange;
	}
}
