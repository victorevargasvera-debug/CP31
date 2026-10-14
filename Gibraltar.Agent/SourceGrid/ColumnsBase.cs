using System;
using System.Collections.Generic;
using System.Drawing;
using SourceGrid.Cells;

namespace SourceGrid
{
	// Token: 0x0200033B RID: 827
	internal abstract class ColumnsBase
	{
		// Token: 0x060027BC RID: 10172 RVA: 0x0008A8C4 File Offset: 0x00088AC4
		public ColumnsBase(global::SourceGrid.GridVirtual grid)
		{
			this.mGrid = grid;
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x0008A8D4 File Offset: 0x00088AD4
		public global::SourceGrid.GridVirtual Grid
		{
			get
			{
				return this.mGrid;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x060027BE RID: 10174
		public abstract int Count { get; }

		// Token: 0x060027BF RID: 10175
		public abstract int GetWidth(int column);

		// Token: 0x060027C0 RID: 10176
		public abstract void SetWidth(int column, int width);

		// Token: 0x060027C1 RID: 10177
		public abstract global::SourceGrid.AutoSizeMode GetAutoSizeMode(int column);

		// Token: 0x060027C2 RID: 10178 RVA: 0x0008A8DC File Offset: 0x00088ADC
		public void AutoSizeColumn(int column)
		{
			this.AutoSizeColumn(column, true, 0, this.Grid.Rows.Count - 1);
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x0008A908 File Offset: 0x00088B08
		public void AutoSizeColumn(int column, bool useRowHeight, int StartRow, int EndRow)
		{
			if ((this.GetAutoSizeMode(column) & global::SourceGrid.AutoSizeMode.EnableAutoSize) == global::SourceGrid.AutoSizeMode.EnableAutoSize && this.IsColumnVisible(column))
			{
				this.SetWidth(column, this.MeasureColumnWidth(column, useRowHeight, StartRow, EndRow));
			}
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x0008A948 File Offset: 0x00088B48
		public int MeasureColumnWidth(int column, bool useRowHeight, int StartRow, int EndRow)
		{
			int num = this.Grid.MinimumWidth;
			if ((this.GetAutoSizeMode(column) & global::SourceGrid.AutoSizeMode.MinimumSize) == global::SourceGrid.AutoSizeMode.MinimumSize)
			{
				return num;
			}
			for (int i = StartRow; i <= EndRow; i++)
			{
				global::SourceGrid.Cells.ICellVirtual cell = this.Grid.GetCell(i, column);
				if (cell != null)
				{
					global::SourceGrid.Position pPosition = new global::SourceGrid.Position(i, column);
					global::System.Drawing.Size empty = global::System.Drawing.Size.Empty;
					if (useRowHeight)
					{
						empty.Height = this.Grid.RangeToSize(this.Grid.PositionToCellRange(pPosition)).Height;
					}
					global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(this.Grid, pPosition, cell);
					global::System.Drawing.Size size = cellContext.Measure(empty);
					if (size.Width > num)
					{
						num = size.Width;
					}
				}
			}
			return num;
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x0008AA0C File Offset: 0x00088C0C
		public void AutoSize(bool useRowHeight)
		{
			this.AutoSize(useRowHeight, 0, this.Grid.Rows.Count - 1);
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x0008AA38 File Offset: 0x00088C38
		public void AutoSize(bool useRowHeight, int StartRow, int EndRow)
		{
			this.SuspendLayout();
			for (int i = 0; i < this.Count; i++)
			{
				this.AutoSizeColumn(i, useRowHeight, StartRow, EndRow);
			}
			this.ResumeLayout();
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x0008AA74 File Offset: 0x00088C74
		public virtual void StretchToFit()
		{
			this.SuspendLayout();
			global::System.Drawing.Rectangle displayRectangle = this.Grid.DisplayRectangle;
			if (this.Count > 0 && displayRectangle.Width > 0)
			{
				global::System.Collections.Generic.List<int> list = this.ColumnsInsideRegion(displayRectangle.X, displayRectangle.Width);
				if (list.Count >= this.Count)
				{
					int? num = new int?(this.GetRight(this.Count - 1));
					if (num != null && displayRectangle.Width > num.Value)
					{
						int num2 = 0;
						for (int i = 0; i < this.Count; i++)
						{
							if ((this.GetAutoSizeMode(i) & global::SourceGrid.AutoSizeMode.EnableStretch) == global::SourceGrid.AutoSizeMode.EnableStretch && this.IsColumnVisible(i))
							{
								num2++;
							}
						}
						if (num2 > 0)
						{
							int num3 = (displayRectangle.Width - num.Value) / num2;
							for (int j = 0; j < this.Count; j++)
							{
								if ((this.GetAutoSizeMode(j) & global::SourceGrid.AutoSizeMode.EnableStretch) == global::SourceGrid.AutoSizeMode.EnableStretch && this.IsColumnVisible(j))
								{
									this.SetWidth(j, this.GetWidth(j) + num3);
								}
							}
						}
					}
				}
			}
			this.ResumeLayout();
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x0008ABB0 File Offset: 0x00088DB0
		public global::System.Collections.Generic.List<int> ColumnsInsideRegion(int x, int width)
		{
			return this.ColumnsInsideRegion(x, width, true);
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x0008ABBC File Offset: 0x00088DBC
		public global::System.Collections.Generic.List<int> ColumnsInsideRegion(int x, int width, bool returnsPartial)
		{
			int num = x + width;
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			int num2 = 0;
			while (num2 < this.Grid.FixedColumns && num2 < this.Count)
			{
				int left = this.GetLeft(num2);
				int num3 = left + this.GetWidth(num2);
				if (num >= left && x <= num3 && (returnsPartial || (num3 <= num && left >= x)))
				{
					list.Add(num2);
				}
				if (num3 > num)
				{
					break;
				}
				num2++;
			}
			int? firstVisibleScrollableColumn = this.FirstVisibleScrollableColumn;
			if (firstVisibleScrollableColumn != null)
			{
				for (int i = firstVisibleScrollableColumn.Value; i < this.Count; i++)
				{
					int left2 = this.GetLeft(i);
					int num4 = left2 + this.GetWidth(i);
					if (num >= left2 && x <= num4 && (returnsPartial || (num4 <= num && left2 >= x)))
					{
						list.Add(i);
					}
					if (num4 > num)
					{
						break;
					}
				}
			}
			return list;
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x0008ACC4 File Offset: 0x00088EC4
		public int? ColumnAtPoint(int x)
		{
			global::System.Collections.Generic.List<int> list = this.ColumnsInsideRegion(x, 1);
			if (list.Count == 0)
			{
				return null;
			}
			return new int?(list[0]);
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x060027CB RID: 10187 RVA: 0x0008AD00 File Offset: 0x00088F00
		public int? FirstVisibleScrollableColumn
		{
			get
			{
				int num = this.Grid.CustomScrollPosition.X + this.Grid.FixedColumns;
				if (num >= this.Count)
				{
					return null;
				}
				return new int?(num);
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x0008AD50 File Offset: 0x00088F50
		public int? LastVisibleScrollableColumn
		{
			get
			{
				int? firstVisibleScrollableColumn = this.FirstVisibleScrollableColumn;
				if (firstVisibleScrollableColumn == null)
				{
					return null;
				}
				global::System.Drawing.Rectangle scrollableArea = this.Grid.GetScrollableArea();
				int num = this.GetLeft(firstVisibleScrollableColumn.Value);
				int i;
				for (i = firstVisibleScrollableColumn.Value; i < this.Count; i++)
				{
					num += this.GetWidth(i);
					if (num >= scrollableArea.Right)
					{
						return new int?(i);
					}
				}
				return new int?(i - 1);
			}
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x0008ADE0 File Offset: 0x00088FE0
		public global::SourceGrid.Range GetRange(int column)
		{
			return new global::SourceGrid.Range(0, column, this.Grid.Rows.Count - 1, column);
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x0008AE0C File Offset: 0x0008900C
		public void SuspendLayout()
		{
			this.mSuspendedCount++;
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x0008AE1C File Offset: 0x0008901C
		public void ResumeLayout()
		{
			if (this.mSuspendedCount > 0)
			{
				this.mSuspendedCount--;
			}
			this.PerformLayout();
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x0008AE40 File Offset: 0x00089040
		public void PerformLayout()
		{
			if (this.mSuspendedCount == 0)
			{
				this.OnLayout();
			}
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x0008AE54 File Offset: 0x00089054
		protected virtual void OnLayout()
		{
			this.Grid.OnCellsAreaChanged();
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x0008AE64 File Offset: 0x00089064
		public void ColumnsChanged()
		{
			this.PerformLayout();
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x0008AE6C File Offset: 0x0008906C
		public int GetAbsoluteLeft(int column)
		{
			if (column < 0)
			{
				throw new global::System.ArgumentException("Must be a valid index");
			}
			int num = 0;
			for (int i = 0; i < column; i++)
			{
				num += this.GetWidth(i);
			}
			return num;
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x0008AEAC File Offset: 0x000890AC
		public int GetAbsoluteRight(int column)
		{
			int absoluteLeft = this.GetAbsoluteLeft(column);
			return absoluteLeft + this.GetWidth(column);
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x0008AED0 File Offset: 0x000890D0
		public int GetLeft(int column)
		{
			int num = global::System.Math.Min(this.Grid.FixedColumns, this.Count);
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				if (i == column)
				{
					return num2;
				}
				num2 += this.GetWidth(i);
			}
			int? firstVisibleScrollableColumn = this.FirstVisibleScrollableColumn;
			if (firstVisibleScrollableColumn == null)
			{
				firstVisibleScrollableColumn = new int?(this.Count);
			}
			if (firstVisibleScrollableColumn == column)
			{
				return num2;
			}
			if (firstVisibleScrollableColumn < column)
			{
				for (int j = firstVisibleScrollableColumn.Value; j < this.Count; j++)
				{
					if (j == column)
					{
						return num2;
					}
					num2 += this.GetWidth(j);
				}
			}
			else if (firstVisibleScrollableColumn > column)
			{
				for (int k = firstVisibleScrollableColumn.Value - 1; k >= 0; k--)
				{
					num2 -= this.GetWidth(k);
					if (k == column)
					{
						return num2;
					}
				}
			}
			throw new global::System.IndexOutOfRangeException();
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x0008B020 File Offset: 0x00089220
		public int GetRight(int column)
		{
			int left = this.GetLeft(column);
			return left + this.GetWidth(column);
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x0008B044 File Offset: 0x00089244
		public void ShowColumn(int column)
		{
			if (!this.IsColumnVisible(column))
			{
				this.SetWidth(column, this.Grid.DefaultWidth);
			}
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x0008B074 File Offset: 0x00089274
		public void HideColumn(int column)
		{
			this.SetWidth(column, 0);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x0008B080 File Offset: 0x00089280
		public bool IsColumnVisible(int column)
		{
			return this.GetWidth(column) > 0;
		}

		// Token: 0x04000DDF RID: 3551
		private global::SourceGrid.GridVirtual mGrid;

		// Token: 0x04000DE0 RID: 3552
		private int mSuspendedCount;
	}
}
