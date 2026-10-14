using System;
using System.Drawing;
using SourceGrid;
using SourceGrid.Cells;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001E9 RID: 489
	internal class GridViewerRows : global::SourceGrid.DataGridRows
	{
		// Token: 0x060017FE RID: 6142 RVA: 0x000514A0 File Offset: 0x0004F6A0
		public GridViewerRows(global::SourceGrid.DataGrid grid) : base(grid)
		{
			this.MaxRowHeight = 500;
			this.MinRowHeight = 20;
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x000514BC File Offset: 0x0004F6BC
		// (set) Token: 0x06001800 RID: 6144 RVA: 0x000514C4 File Offset: 0x0004F6C4
		public global::SourceGrid.DataGridColumn MessageColumn { get; set; }

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x000514D0 File Offset: 0x0004F6D0
		// (set) Token: 0x06001802 RID: 6146 RVA: 0x000514D8 File Offset: 0x0004F6D8
		public int MaxRowHeight { get; set; }

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x000514E4 File Offset: 0x0004F6E4
		// (set) Token: 0x06001804 RID: 6148 RVA: 0x000514EC File Offset: 0x0004F6EC
		public int MinRowHeight { get; set; }

		// Token: 0x06001805 RID: 6149 RVA: 0x000514F8 File Offset: 0x0004F6F8
		public override int GetHeight(int row)
		{
			if (row == 0)
			{
				return base.HeaderHeight;
			}
			int num;
			try
			{
				if (this.m_MessageColumn == null)
				{
					global::Gibraltar.Monitor.Windows.Internal.GridViewer gridViewer = (global::Gibraltar.Monitor.Windows.Internal.GridViewer)base.Grid;
					this.m_MessageColumn = gridViewer.GetColumnForEnum(global::Gibraltar.Monitor.Windows.LogMessageColumn.Caption);
				}
				if (this.m_MessageColumn == null)
				{
					return base.HeaderHeight;
				}
				int index = this.m_MessageColumn.Index;
				global::SourceGrid.Cells.ICellVirtual cell = base.Grid.GetCell(row, index);
				global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(base.Grid, new global::SourceGrid.Position(row, index));
				num = cell.View.Measure(cellContext, new global::System.Drawing.Size(base.Grid.Columns[index].Width, this.MaxRowHeight)).Height;
			}
			catch
			{
				num = 0;
			}
			if (num < this.MinRowHeight)
			{
				num = this.MinRowHeight;
			}
			return num;
		}

		// Token: 0x04000862 RID: 2146
		private global::SourceGrid.DataGridColumn m_MessageColumn;
	}
}
