using System;

namespace SourceGrid
{
	// Token: 0x020003B8 RID: 952
	internal abstract class RowsSimpleBase : global::SourceGrid.RowsBase
	{
		// Token: 0x06002B9D RID: 11165 RVA: 0x000925D8 File Offset: 0x000907D8
		public RowsSimpleBase(global::SourceGrid.GridVirtual grid) : base(grid)
		{
			this.mRowHeight = grid.DefaultHeight;
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x000925F0 File Offset: 0x000907F0
		// (set) Token: 0x06002B9F RID: 11167 RVA: 0x000925F8 File Offset: 0x000907F8
		public int RowHeight
		{
			get
			{
				return this.mRowHeight;
			}
			set
			{
				if (this.mRowHeight != value)
				{
					this.mRowHeight = value;
					base.PerformLayout();
				}
			}
		}

		// Token: 0x06002BA0 RID: 11168 RVA: 0x00092614 File Offset: 0x00090814
		public override int GetHeight(int row)
		{
			return this.RowHeight;
		}

		// Token: 0x06002BA1 RID: 11169 RVA: 0x0009261C File Offset: 0x0009081C
		public override void SetHeight(int row, int height)
		{
			this.RowHeight = height;
		}

		// Token: 0x04000E9D RID: 3741
		private int mRowHeight;
	}
}
