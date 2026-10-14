using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using DevAge.Drawing;
using SourceGrid.Cells;

namespace SourceGrid
{
	// Token: 0x02000339 RID: 825
	[global::System.ComponentModel.ToolboxItem(true)]
	internal class Grid : global::SourceGrid.GridVirtual
	{
		// Token: 0x06002791 RID: 10129 RVA: 0x00089B4C File Offset: 0x00087D4C
		public Grid()
		{
			base.SuspendLayout();
			base.Name = "Grid";
			base.ResumeLayout(false);
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x00089B90 File Offset: 0x00087D90
		protected override global::SourceGrid.RowsBase CreateRowsObject()
		{
			return new global::SourceGrid.Grid.GridRows(this);
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x00089B98 File Offset: 0x00087D98
		protected override global::SourceGrid.ColumnsBase CreateColumnsObject()
		{
			return new global::SourceGrid.Grid.GridColumns(this);
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x00089BA0 File Offset: 0x00087DA0
		// (set) Token: 0x06002795 RID: 10133 RVA: 0x00089BB0 File Offset: 0x00087DB0
		[global::System.ComponentModel.DefaultValue(0)]
		public int ColumnsCount
		{
			get
			{
				return this.Columns.Count;
			}
			set
			{
				this.Columns.SetCount(value);
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x00089BC0 File Offset: 0x00087DC0
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x00089BD0 File Offset: 0x00087DD0
		[global::System.ComponentModel.DefaultValue(0)]
		public int RowsCount
		{
			get
			{
				return this.Rows.Count;
			}
			set
			{
				this.Rows.SetCount(value);
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x00089BE0 File Offset: 0x00087DE0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public new global::SourceGrid.Grid.GridRows Rows
		{
			get
			{
				return (global::SourceGrid.Grid.GridRows)base.Rows;
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06002799 RID: 10137 RVA: 0x00089BF0 File Offset: 0x00087DF0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public new global::SourceGrid.Grid.GridColumns Columns
		{
			get
			{
				return (global::SourceGrid.Grid.GridColumns)base.Columns;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x00089C00 File Offset: 0x00087E00
		// (set) Token: 0x0600279B RID: 10139 RVA: 0x00089C08 File Offset: 0x00087E08
		public global::SourceGrid.CellOptimizeMode OptimizeMode
		{
			get
			{
				return this.mOptimizeMode;
			}
			set
			{
				this.mOptimizeMode = value;
			}
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x00089C14 File Offset: 0x00087E14
		public virtual void SetCell(int p_iRow, int p_iCol, global::SourceGrid.Cells.ICellVirtual p_Cell)
		{
			if (p_Cell is global::SourceGrid.Cells.ICell)
			{
				this.InsertCell(p_iRow, p_iCol, (global::SourceGrid.Cells.ICell)p_Cell);
				return;
			}
			if (p_Cell == null)
			{
				this.InsertCell(p_iRow, p_iCol, null);
				return;
			}
			throw new global::SourceGrid.SourceGridException("Expected ICell class");
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x00089C4C File Offset: 0x00087E4C
		public void SetCell(global::SourceGrid.Position p_Position, global::SourceGrid.Cells.ICellVirtual p_Cell)
		{
			this.SetCell(p_Position.Row, p_Position.Column, p_Cell);
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x00089C74 File Offset: 0x00087E74
		public override global::SourceGrid.Cells.ICellVirtual GetCell(int row, int column)
		{
			return this[row, column];
		}

		// Token: 0x0600279F RID: 10143 RVA: 0x00089C80 File Offset: 0x00087E80
		private void DirectSetCell(global::SourceGrid.Position position, global::SourceGrid.Cells.ICell cell)
		{
			if (this.OptimizeMode == global::SourceGrid.CellOptimizeMode.ForRows)
			{
				global::SourceGrid.Grid.GridRow gridRow = this.Rows[position.Row];
				gridRow[this.Columns[position.Column]] = cell;
				return;
			}
			if (this.OptimizeMode == global::SourceGrid.CellOptimizeMode.ForColumns)
			{
				global::SourceGrid.Grid.GridColumn gridColumn = this.Columns[position.Column];
				gridColumn[this.Rows[position.Row]] = cell;
				return;
			}
			throw new global::SourceGrid.SourceGridException("Invalid OptimizeMode");
		}

		// Token: 0x060027A0 RID: 10144 RVA: 0x00089D10 File Offset: 0x00087F10
		private global::SourceGrid.Cells.ICell DirectGetCell(global::SourceGrid.Position position)
		{
			if (this.OptimizeMode == global::SourceGrid.CellOptimizeMode.ForRows)
			{
				global::SourceGrid.Grid.GridRow gridRow = this.Rows[position.Row];
				return gridRow[this.Columns[position.Column]];
			}
			if (this.OptimizeMode == global::SourceGrid.CellOptimizeMode.ForColumns)
			{
				global::SourceGrid.Grid.GridColumn gridColumn = this.Columns[position.Column];
				return gridColumn[this.Rows[position.Row]];
			}
			throw new global::SourceGrid.SourceGridException("Invalid OptimizeMode");
		}

		// Token: 0x17000C22 RID: 3106
		public global::SourceGrid.Cells.ICell this[int row, int col]
		{
			get
			{
				global::SourceGrid.Cells.ICell cell = this.DirectGetCell(new global::SourceGrid.Position(row, col));
				if (cell != null)
				{
					return cell;
				}
				global::SourceGrid.Position p_Position = new global::SourceGrid.Position(row, col);
				int num = p_Position.Row;
				int num2 = p_Position.Column;
				bool flag = false;
				bool flag2 = false;
				for (int i = 0; i < global::SourceGrid.Grid.MaxSpan; i++)
				{
					if (!flag2)
					{
						for (int j = num; j <= p_Position.Row; j++)
						{
							global::SourceGrid.Cells.ICell cell2 = this.DirectGetCell(new global::SourceGrid.Position(j, num2));
							if (cell2 != null && cell2.Range.Contains(p_Position))
							{
								return cell2;
							}
						}
					}
					if (!flag)
					{
						for (int k = num2; k <= p_Position.Column; k++)
						{
							global::SourceGrid.Cells.ICell cell2 = this.DirectGetCell(new global::SourceGrid.Position(num, k));
							if (cell2 != null && cell2.Range.Contains(p_Position))
							{
								return cell2;
							}
						}
					}
					if (num == 0 && num2 == 0)
					{
						return null;
					}
					if (num == 0)
					{
						flag = true;
					}
					else
					{
						num--;
					}
					if (num2 == 0)
					{
						flag2 = true;
					}
					else
					{
						num2--;
					}
				}
				return null;
			}
			set
			{
				this.InsertCell(row, col, value);
			}
		}

		// Token: 0x060027A3 RID: 10147 RVA: 0x00089EDC File Offset: 0x000880DC
		private void RemoveCell(int row, int col)
		{
			global::SourceGrid.Cells.ICell cell = this.DirectGetCell(new global::SourceGrid.Position(row, col));
			if (cell != null)
			{
				cell.UnBindToGrid();
				this.DirectSetCell(new global::SourceGrid.Position(row, col), null);
			}
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00089F18 File Offset: 0x00088118
		private void InsertCell(int row, int col, global::SourceGrid.Cells.ICell p_cell)
		{
			this.RemoveCell(row, col);
			if (p_cell != null && p_cell.Grid != null)
			{
				throw new global::System.ArgumentException("This cell already have a linked grid", "p_cell");
			}
			this.DirectSetCell(new global::SourceGrid.Position(row, col), p_cell);
			if (p_cell != null)
			{
				p_cell.BindToGrid(this, new global::SourceGrid.Position(row, col));
			}
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00089F74 File Offset: 0x00088174
		public void Redim(int p_Rows, int p_Cols)
		{
			this.RowsCount = p_Rows;
			this.ColumnsCount = p_Cols;
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x00089F84 File Offset: 0x00088184
		// (set) Token: 0x060027A7 RID: 10151 RVA: 0x00089F9C File Offset: 0x0008819C
		public static int MaxSpan
		{
			get
			{
				if (global::SourceGrid.Grid.t_MaxSpan <= 0)
				{
					return 10;
				}
				return global::SourceGrid.Grid.t_MaxSpan;
			}
			set
			{
				global::SourceGrid.Grid.t_MaxSpan = ((value > 0) ? value : 1);
			}
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00089FB4 File Offset: 0x000881B4
		public override global::SourceGrid.Range PositionToCellRange(global::SourceGrid.Position pPosition)
		{
			if (pPosition.IsEmpty())
			{
				return global::SourceGrid.Range.Empty;
			}
			global::SourceGrid.Cells.ICell cell = this[pPosition.Row, pPosition.Column];
			if (cell == null)
			{
				return new global::SourceGrid.Range(pPosition);
			}
			return cell.Range;
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x0008A000 File Offset: 0x00088200
		public virtual void InvalidateCell(global::SourceGrid.Cells.ICell p_Cell)
		{
			if (p_Cell != null)
			{
				base.InvalidateRange(p_Cell.Range);
			}
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x0008A014 File Offset: 0x00088214
		public override void InvalidateCell(global::SourceGrid.Position p_Position)
		{
			global::SourceGrid.Cells.ICell cell = this[p_Position.Row, p_Position.Column];
			if (cell == null || (cell.Range.ColumnsCount == 1 && cell.Range.RowsCount == 1))
			{
				base.InvalidateCell(p_Position);
				return;
			}
			base.InvalidateRange(cell.Range);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x0008A07C File Offset: 0x0008827C
		protected override void OnRangePaint(global::SourceGrid.RangePaintEventArgs e)
		{
			this.mDrawnRange.Clear();
			base.OnRangePaint(e);
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x0008A090 File Offset: 0x00088290
		protected override void PaintCell(global::DevAge.Drawing.GraphicsCache graphics, global::SourceGrid.CellContext cellContext, global::System.Drawing.RectangleF drawRectangle)
		{
			global::SourceGrid.Range range = this.PositionToCellRange(cellContext.Position);
			if (range.ColumnsCount == 1 && range.RowsCount == 1)
			{
				base.PaintCell(graphics, cellContext, drawRectangle);
				return;
			}
			if (!this.mDrawnRange.Contains(range))
			{
				global::System.Drawing.Rectangle r = base.RangeToRectangle(range);
				base.PaintCell(graphics, cellContext, r);
				this.mDrawnRange.Add(range);
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x0008A108 File Offset: 0x00088308
		// (set) Token: 0x060027AE RID: 10158 RVA: 0x0008A110 File Offset: 0x00088310
		[global::System.ComponentModel.DefaultValue(false)]
		public bool CustomSort
		{
			get
			{
				return this.m_CustomSort;
			}
			set
			{
				this.m_CustomSort = value;
			}
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x0008A11C File Offset: 0x0008831C
		protected override void OnSortingRangeRows(global::SourceGrid.SortRangeRowsEventArgs e)
		{
			base.OnSortingRangeRows(e);
			if (this.CustomSort)
			{
				return;
			}
			if (e.KeyColumn > e.Range.End.Column && e.KeyColumn < e.Range.Start.Column)
			{
				throw new global::System.ArgumentException("Invalid range", "e.KeyColumn");
			}
			global::System.Collections.IComparer comparer = e.CellComparer;
			if (comparer == null)
			{
				comparer = new global::SourceGrid.ValueCellComparer();
			}
			if (e.Range.ColumnsCount == this.ColumnsCount)
			{
				global::SourceGrid.RowInfo[] array = new global::SourceGrid.RowInfo[e.Range.End.Row - e.Range.Start.Row + 1];
				global::SourceGrid.Cells.ICell[] array2 = new global::SourceGrid.Cells.ICell[e.Range.End.Row - e.Range.Start.Row + 1];
				int i = 0;
				for (int j = e.Range.Start.Row; j <= e.Range.End.Row; j++)
				{
					array2[i] = this[j, e.KeyColumn];
					array[i] = this.Rows[j];
					i++;
				}
				global::System.Array.Sort(array2, array, 0, array2.Length, comparer);
				if (e.Ascending)
				{
					for (i = 0; i < array.Length; i++)
					{
						this.Rows.Swap(array[i].Index, e.Range.Start.Row + i);
					}
					return;
				}
				for (i = array.Length - 1; i >= 0; i--)
				{
					this.Rows.Swap(array[i].Index, e.Range.End.Row - i);
				}
				return;
			}
			else
			{
				global::SourceGrid.Cells.ICell[][] array3 = new global::SourceGrid.Cells.ICell[e.Range.End.Row - e.Range.Start.Row + 1][];
				global::SourceGrid.Cells.ICell[] array4 = new global::SourceGrid.Cells.ICell[e.Range.End.Row - e.Range.Start.Row + 1];
				int num = 0;
				for (int k = e.Range.Start.Row; k <= e.Range.End.Row; k++)
				{
					array4[num] = this[k, e.KeyColumn];
					int num2 = 0;
					array3[num] = new global::SourceGrid.Cells.ICell[e.Range.End.Column - e.Range.Start.Column + 1];
					for (int l = e.Range.Start.Column; l <= e.Range.End.Column; l++)
					{
						array3[num][num2] = this[k, l];
						num2++;
					}
					num++;
				}
				global::System.Array.Sort(array4, array3, 0, array4.Length, comparer);
				num = 0;
				if (e.Ascending)
				{
					for (int m = e.Range.Start.Row; m <= e.Range.End.Row; m++)
					{
						int num3 = 0;
						for (int n = e.Range.Start.Column; n <= e.Range.End.Column; n++)
						{
							this.RemoveCell(m, n);
							global::SourceGrid.Cells.ICell cell = array3[num][num3];
							if (cell != null && cell.Grid != null && cell.Range.Start.Row >= 0 && cell.Range.Start.Column >= 0)
							{
								this.RemoveCell(cell.Range.Start.Row, cell.Range.Start.Column);
							}
							this[m, n] = cell;
							num3++;
						}
						num++;
					}
					return;
				}
				for (int num4 = e.Range.End.Row; num4 >= e.Range.Start.Row; num4--)
				{
					int num5 = 0;
					for (int num6 = e.Range.Start.Column; num6 <= e.Range.End.Column; num6++)
					{
						this.RemoveCell(num4, num6);
						global::SourceGrid.Cells.ICell cell2 = array3[num][num5];
						if (cell2 != null && cell2.Grid != null && cell2.Range.Start.Row >= 0 && cell2.Range.Start.Column >= 0)
						{
							this.RemoveCell(cell2.Range.Start.Row, cell2.Range.Start.Column);
						}
						this[num4, num6] = cell2;
						num5++;
					}
					num++;
				}
				return;
			}
		}

		// Token: 0x04000DD6 RID: 3542
		private const int c_MaxSpan = 10;

		// Token: 0x04000DD7 RID: 3543
		private global::SourceGrid.CellOptimizeMode mOptimizeMode = global::SourceGrid.CellOptimizeMode.ForRows;

		// Token: 0x04000DD8 RID: 3544
		[global::System.ThreadStatic]
		private static int t_MaxSpan;

		// Token: 0x04000DD9 RID: 3545
		private global::SourceGrid.RangeCollection mDrawnRange = new global::SourceGrid.RangeCollection();

		// Token: 0x04000DDA RID: 3546
		private bool m_CustomSort;

		// Token: 0x020004C9 RID: 1225
		public class GridColumn : global::SourceGrid.ColumnInfo
		{
			// Token: 0x0600341F RID: 13343 RVA: 0x000BBB98 File Offset: 0x000B9D98
			public GridColumn(global::SourceGrid.Grid grid) : base(grid)
			{
			}

			// Token: 0x17000F03 RID: 3843
			public global::SourceGrid.Cells.ICell this[global::SourceGrid.Grid.GridRow row]
			{
				get
				{
					global::SourceGrid.Cells.ICell result;
					if (this.mCells.TryGetValue(row, out result))
					{
						return result;
					}
					return null;
				}
				set
				{
					this.mCells[row] = value;
				}
			}

			// Token: 0x040013C0 RID: 5056
			private global::System.Collections.Generic.Dictionary<global::SourceGrid.Grid.GridRow, global::SourceGrid.Cells.ICell> mCells = new global::System.Collections.Generic.Dictionary<global::SourceGrid.Grid.GridRow, global::SourceGrid.Cells.ICell>();
		}

		// Token: 0x020004CA RID: 1226
		public class GridColumns : global::SourceGrid.ColumnInfoCollection
		{
			// Token: 0x06003422 RID: 13346 RVA: 0x000BBBE4 File Offset: 0x000B9DE4
			public GridColumns(global::SourceGrid.Grid grid) : base(grid)
			{
			}

			// Token: 0x06003423 RID: 13347 RVA: 0x000BBBF0 File Offset: 0x000B9DF0
			public void Insert(int p_Index)
			{
				this.InsertRange(p_Index, 1);
			}

			// Token: 0x06003424 RID: 13348 RVA: 0x000BBBFC File Offset: 0x000B9DFC
			public void InsertRange(int p_StartIndex, int p_Count)
			{
				global::SourceGrid.ColumnInfo[] array = new global::SourceGrid.ColumnInfo[p_Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this.CreateColumn();
				}
				base.InsertRange(p_StartIndex, array);
			}

			// Token: 0x06003425 RID: 13349 RVA: 0x000BBC3C File Offset: 0x000B9E3C
			protected global::SourceGrid.Grid.GridColumn CreateColumn()
			{
				return new global::SourceGrid.Grid.GridColumn((global::SourceGrid.Grid)base.Grid);
			}

			// Token: 0x17000F04 RID: 3844
			public global::SourceGrid.Grid.GridColumn this[int index]
			{
				get
				{
					return (global::SourceGrid.Grid.GridColumn)base[index];
				}
			}

			// Token: 0x06003427 RID: 13351 RVA: 0x000BBC60 File Offset: 0x000B9E60
			public void SetCount(int value)
			{
				if (this.Count < value)
				{
					this.InsertRange(this.Count, value - this.Count);
					return;
				}
				if (this.Count > value)
				{
					base.RemoveRange(value, this.Count - value);
				}
			}
		}

		// Token: 0x020004CB RID: 1227
		public class GridRow : global::SourceGrid.RowInfo
		{
			// Token: 0x06003428 RID: 13352 RVA: 0x000BBCB0 File Offset: 0x000B9EB0
			public GridRow(global::SourceGrid.Grid grid) : base(grid)
			{
			}

			// Token: 0x17000F05 RID: 3845
			public global::SourceGrid.Cells.ICell this[global::SourceGrid.Grid.GridColumn column]
			{
				get
				{
					global::SourceGrid.Cells.ICell result;
					if (this.mCells.TryGetValue(column, out result))
					{
						return result;
					}
					return null;
				}
				set
				{
					this.mCells[column] = value;
				}
			}

			// Token: 0x040013C1 RID: 5057
			private global::System.Collections.Generic.Dictionary<global::SourceGrid.Grid.GridColumn, global::SourceGrid.Cells.ICell> mCells = new global::System.Collections.Generic.Dictionary<global::SourceGrid.Grid.GridColumn, global::SourceGrid.Cells.ICell>();
		}

		// Token: 0x020004CC RID: 1228
		public class GridRows : global::SourceGrid.RowInfoCollection
		{
			// Token: 0x0600342B RID: 13355 RVA: 0x000BBCFC File Offset: 0x000B9EFC
			public GridRows(global::SourceGrid.Grid grid) : base(grid)
			{
			}

			// Token: 0x0600342C RID: 13356 RVA: 0x000BBD08 File Offset: 0x000B9F08
			public void Insert(int p_Index)
			{
				this.InsertRange(p_Index, 1);
			}

			// Token: 0x0600342D RID: 13357 RVA: 0x000BBD14 File Offset: 0x000B9F14
			public void InsertRange(int p_StartIndex, int p_Count)
			{
				global::SourceGrid.RowInfo[] array = new global::SourceGrid.RowInfo[p_Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = this.CreateRow();
				}
				base.InsertRange(p_StartIndex, array);
			}

			// Token: 0x0600342E RID: 13358 RVA: 0x000BBD54 File Offset: 0x000B9F54
			protected global::SourceGrid.Grid.GridRow CreateRow()
			{
				return new global::SourceGrid.Grid.GridRow((global::SourceGrid.Grid)base.Grid);
			}

			// Token: 0x17000F06 RID: 3846
			public global::SourceGrid.Grid.GridRow this[int index]
			{
				get
				{
					return (global::SourceGrid.Grid.GridRow)base[index];
				}
			}

			// Token: 0x06003430 RID: 13360 RVA: 0x000BBD78 File Offset: 0x000B9F78
			public void SetCount(int value)
			{
				if (this.Count < value)
				{
					this.InsertRange(this.Count, value - this.Count);
					return;
				}
				if (this.Count > value)
				{
					base.RemoveRange(value, this.Count - value);
				}
			}
		}
	}
}
