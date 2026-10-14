using System;

namespace SourceGrid
{
	// Token: 0x02000417 RID: 1047
	internal class ArrayColumns : global::SourceGrid.ColumnsSimpleBase
	{
		// Token: 0x06002D9E RID: 11678 RVA: 0x0009940C File Offset: 0x0009760C
		public ArrayColumns(global::SourceGrid.ArrayGrid grid) : base(grid)
		{
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002D9F RID: 11679 RVA: 0x0009941C File Offset: 0x0009761C
		public new global::SourceGrid.ArrayGrid Grid
		{
			get
			{
				return (global::SourceGrid.ArrayGrid)base.Grid;
			}
		}

		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x0009942C File Offset: 0x0009762C
		public override int Count
		{
			get
			{
				if (this.Grid.DataSource == null)
				{
					return this.Grid.FixedColumns;
				}
				return this.Grid.DataSource.GetLength(1) + this.Grid.FixedColumns;
			}
		}

		// Token: 0x17000D50 RID: 3408
		// (get) Token: 0x06002DA1 RID: 11681 RVA: 0x00099478 File Offset: 0x00097678
		// (set) Token: 0x06002DA2 RID: 11682 RVA: 0x00099480 File Offset: 0x00097680
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

		// Token: 0x06002DA3 RID: 11683 RVA: 0x0009948C File Offset: 0x0009768C
		public override global::SourceGrid.AutoSizeMode GetAutoSizeMode(int row)
		{
			return this.mAutoSizeMode;
		}

		// Token: 0x04000F6B RID: 3947
		private global::SourceGrid.AutoSizeMode mAutoSizeMode = global::SourceGrid.AutoSizeMode.Default;
	}
}
