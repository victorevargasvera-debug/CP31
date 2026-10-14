using System;

namespace SourceGrid
{
	// Token: 0x020003A4 RID: 932
	internal abstract class ColumnsSimpleBase : global::SourceGrid.ColumnsBase
	{
		// Token: 0x06002B4F RID: 11087 RVA: 0x00091E48 File Offset: 0x00090048
		public ColumnsSimpleBase(global::SourceGrid.GridVirtual grid) : base(grid)
		{
			this.mColumnWidth = grid.DefaultWidth;
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x00091E60 File Offset: 0x00090060
		// (set) Token: 0x06002B51 RID: 11089 RVA: 0x00091E68 File Offset: 0x00090068
		public int ColumnWidth
		{
			get
			{
				return this.mColumnWidth;
			}
			set
			{
				if (this.mColumnWidth != value)
				{
					this.mColumnWidth = value;
					base.PerformLayout();
				}
			}
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00091E84 File Offset: 0x00090084
		public override int GetWidth(int column)
		{
			return this.ColumnWidth;
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x00091E8C File Offset: 0x0009008C
		public override void SetWidth(int column, int width)
		{
			this.ColumnWidth = width;
		}

		// Token: 0x04000E91 RID: 3729
		private int mColumnWidth;
	}
}
