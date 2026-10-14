using System;
using System.ComponentModel;
using SourceGrid.Cells;
using SourceGrid.Cells.DataGrid;
using SourceGrid.Cells.Editors;

namespace SourceGrid
{
	// Token: 0x0200040D RID: 1037
	internal class DataGridColumns : global::SourceGrid.ColumnInfoCollection
	{
		// Token: 0x06002D65 RID: 11621 RVA: 0x00098CA8 File Offset: 0x00096EA8
		public DataGridColumns(global::SourceGrid.DataGrid grid) : base(grid)
		{
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06002D66 RID: 11622 RVA: 0x00098CB4 File Offset: 0x00096EB4
		public new global::SourceGrid.DataGrid Grid
		{
			get
			{
				return (global::SourceGrid.DataGrid)base.Grid;
			}
		}

		// Token: 0x17000D3D RID: 3389
		public global::SourceGrid.DataGridColumn this[int index]
		{
			get
			{
				return (global::SourceGrid.DataGridColumn)base[index];
			}
		}

		// Token: 0x06002D68 RID: 11624 RVA: 0x00098CD4 File Offset: 0x00096ED4
		public void Insert(int index, global::SourceGrid.DataGridColumn dataGridColumn)
		{
			base.InsertRange(index, new global::SourceGrid.ColumnInfo[]
			{
				dataGridColumn
			});
		}

		// Token: 0x06002D69 RID: 11625 RVA: 0x00098CFC File Offset: 0x00096EFC
		public global::System.ComponentModel.PropertyDescriptor IndexToPropertyColumn(int gridColumnIndex)
		{
			return this.Grid.Columns[gridColumnIndex].PropertyColumn;
		}

		// Token: 0x06002D6A RID: 11626 RVA: 0x00098D24 File Offset: 0x00096F24
		public int DataSourceColumnToIndex(global::System.ComponentModel.PropertyDescriptor propertyColumn)
		{
			for (int i = 0; i < this.Grid.Columns.Count; i++)
			{
				if (this.Grid.Columns[i].PropertyColumn == propertyColumn)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00098D74 File Offset: 0x00096F74
		public global::SourceGrid.DataGridColumn Add(string property, string caption, global::System.Type propertyType)
		{
			global::SourceGrid.Cells.ICellVirtual cell = global::SourceGrid.Cells.DataGrid.Cell.Create(propertyType, true);
			return this.Add(property, caption, cell);
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00098D98 File Offset: 0x00096F98
		public global::SourceGrid.DataGridColumn Add(string property, string caption, global::SourceGrid.Cells.Editors.EditorBase editor)
		{
			return this.Add(property, caption, new global::SourceGrid.Cells.DataGrid.Cell
			{
				Editor = editor
			});
		}

		// Token: 0x06002D6D RID: 11629 RVA: 0x00098DC0 File Offset: 0x00096FC0
		public global::SourceGrid.DataGridColumn Add(string property, string caption, global::SourceGrid.Cells.ICellVirtual cell)
		{
			global::SourceGrid.DataGridColumn dataGridColumn = new global::SourceGrid.DataGridColumn(this.Grid, new global::SourceGrid.Cells.DataGrid.ColumnHeader(caption), cell, property);
			this.Insert(this.Count, dataGridColumn);
			return dataGridColumn;
		}
	}
}
