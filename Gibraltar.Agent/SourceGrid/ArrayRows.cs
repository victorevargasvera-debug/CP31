using System;

namespace SourceGrid
{
	// Token: 0x02000416 RID: 1046
	internal class ArrayRows : global::SourceGrid.RowsSimpleBase
	{
		// Token: 0x06002D98 RID: 11672 RVA: 0x00099384 File Offset: 0x00097584
		public ArrayRows(global::SourceGrid.ArrayGrid grid) : base(grid)
		{
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x00099394 File Offset: 0x00097594
		public new global::SourceGrid.ArrayGrid Grid
		{
			get
			{
				return (global::SourceGrid.ArrayGrid)base.Grid;
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x000993A4 File Offset: 0x000975A4
		public override int Count
		{
			get
			{
				if (this.Grid.DataSource == null)
				{
					return this.Grid.FixedRows;
				}
				return this.Grid.DataSource.GetLength(0) + this.Grid.FixedRows;
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x000993F0 File Offset: 0x000975F0
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x000993F8 File Offset: 0x000975F8
		public global::SourceGrid.AutoSizeMode AutoSizeMode
		{
			get
			{
				return this.mAutoSizeMode;
			}
			set
			{
				this.mAutoSizeMode = value;
			}
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x00099404 File Offset: 0x00097604
		public override global::SourceGrid.AutoSizeMode GetAutoSizeMode(int row)
		{
			return this.mAutoSizeMode;
		}

		// Token: 0x04000F6A RID: 3946
		private global::SourceGrid.AutoSizeMode mAutoSizeMode = global::SourceGrid.AutoSizeMode.Default;
	}
}
