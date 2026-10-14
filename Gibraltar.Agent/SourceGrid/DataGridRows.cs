using System;

namespace SourceGrid
{
	// Token: 0x020003FF RID: 1023
	internal class DataGridRows : global::SourceGrid.RowsSimpleBase
	{
		// Token: 0x06002D20 RID: 11552 RVA: 0x00097EE0 File Offset: 0x000960E0
		public DataGridRows(global::SourceGrid.DataGrid grid) : base(grid)
		{
			this.mHeaderHeight = grid.DefaultHeight;
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x00097EFC File Offset: 0x000960FC
		public new global::SourceGrid.DataGrid Grid
		{
			get
			{
				return (global::SourceGrid.DataGrid)base.Grid;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x00097F0C File Offset: 0x0009610C
		public override int Count
		{
			get
			{
				if (this.Grid.DataSource == null)
				{
					return this.Grid.FixedRows;
				}
				if (this.Grid.DataSource.AllowNew)
				{
					return this.Grid.DataSource.Count + this.Grid.FixedRows + 1;
				}
				return this.Grid.DataSource.Count + this.Grid.FixedRows;
			}
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x00097F8C File Offset: 0x0009618C
		public int IndexToDataSourceIndex(int gridRowIndex)
		{
			return gridRowIndex - this.Grid.FixedRows;
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00097FAC File Offset: 0x000961AC
		public int DataSourceIndexToGridRowIndex(int dataSourceIndex)
		{
			return dataSourceIndex + this.Grid.FixedRows;
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00097FBC File Offset: 0x000961BC
		public object IndexToDataSourceRow(int gridRowIndex)
		{
			int num = this.IndexToDataSourceIndex(gridRowIndex);
			if (this.Grid.DataSource != null && num >= 0 && num < this.Grid.DataSource.Count)
			{
				return this.Grid.DataSource[num];
			}
			return null;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00098018 File Offset: 0x00096218
		public int DataSourceRowToIndex(object row)
		{
			if (this.Grid.DataSource != null)
			{
				return this.Grid.DataSource.IndexOf(row);
			}
			return -1;
		}

		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06002D27 RID: 11559 RVA: 0x0009804C File Offset: 0x0009624C
		// (set) Token: 0x06002D28 RID: 11560 RVA: 0x00098054 File Offset: 0x00096254
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

		// Token: 0x06002D29 RID: 11561 RVA: 0x00098060 File Offset: 0x00096260
		public override global::SourceGrid.AutoSizeMode GetAutoSizeMode(int row)
		{
			return this.mAutoSizeMode;
		}

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x00098068 File Offset: 0x00096268
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x00098070 File Offset: 0x00096270
		public int HeaderHeight
		{
			get
			{
				return this.mHeaderHeight;
			}
			set
			{
				if (this.mHeaderHeight != value)
				{
					this.mHeaderHeight = value;
					base.PerformLayout();
				}
			}
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x0009808C File Offset: 0x0009628C
		public override int GetHeight(int row)
		{
			if (row == 0)
			{
				return this.HeaderHeight;
			}
			return base.GetHeight(row);
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000980A4 File Offset: 0x000962A4
		public override void SetHeight(int row, int height)
		{
			if (row == 0)
			{
				this.HeaderHeight = height;
				return;
			}
			base.SetHeight(row, height);
		}

		// Token: 0x04000F55 RID: 3925
		private global::SourceGrid.AutoSizeMode mAutoSizeMode = global::SourceGrid.AutoSizeMode.Default;

		// Token: 0x04000F56 RID: 3926
		private int mHeaderHeight;
	}
}
