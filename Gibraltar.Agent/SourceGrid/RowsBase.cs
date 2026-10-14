using System;
using System.Collections.Generic;
using System.Drawing;
using SourceGrid.Cells;

namespace SourceGrid
{
	// Token: 0x0200033E RID: 830
	internal abstract class RowsBase
	{
		// Token: 0x06002805 RID: 10245 RVA: 0x0008B628 File Offset: 0x00089828
		public RowsBase(global::SourceGrid.GridVirtual grid)
		{
			this.mGrid = grid;
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06002806 RID: 10246 RVA: 0x0008B638 File Offset: 0x00089838
		public global::SourceGrid.GridVirtual Grid
		{
			get
			{
				return this.mGrid;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06002807 RID: 10247
		public abstract int Count { get; }

		// Token: 0x06002808 RID: 10248
		public abstract int GetHeight(int row);

		// Token: 0x06002809 RID: 10249
		public abstract void SetHeight(int row, int height);

		// Token: 0x0600280A RID: 10250
		public abstract global::SourceGrid.AutoSizeMode GetAutoSizeMode(int row);

		// Token: 0x0600280B RID: 10251 RVA: 0x0008B640 File Offset: 0x00089840
		public global::System.Collections.Generic.List<int> RowsInsideRegion(int y, int height)
		{
			return this.RowsInsideRegion(y, height, true);
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x0008B64C File Offset: 0x0008984C
		public global::System.Collections.Generic.List<int> RowsInsideRegion(int y, int height, bool returnsPartial)
		{
			int num = y + height;
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			int num2 = 0;
			while (num2 < this.Grid.FixedRows && num2 < this.Count)
			{
				int top = this.GetTop(num2);
				int num3 = top + this.GetHeight(num2);
				if (num >= top && y <= num3 && (returnsPartial || (num3 <= num && top >= y)))
				{
					list.Add(num2);
				}
				if (num3 > num)
				{
					break;
				}
				num2++;
			}
			int? firstVisibleScrollableRow = this.FirstVisibleScrollableRow;
			if (firstVisibleScrollableRow != null)
			{
				for (int i = firstVisibleScrollableRow.Value; i < this.Count; i++)
				{
					int top2 = this.GetTop(i);
					int num4 = top2 + this.GetHeight(i);
					if (num >= top2 && y <= num4 && (returnsPartial || (num4 <= num && top2 >= y)))
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

		// Token: 0x0600280D RID: 10253 RVA: 0x0008B754 File Offset: 0x00089954
		public int? RowAtPoint(int y)
		{
			global::System.Collections.Generic.List<int> list = this.RowsInsideRegion(y, 1);
			if (list.Count == 0)
			{
				return null;
			}
			return new int?(list[0]);
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600280E RID: 10254 RVA: 0x0008B790 File Offset: 0x00089990
		public int? FirstVisibleScrollableRow
		{
			get
			{
				int num = this.Grid.CustomScrollPosition.Y + this.Grid.FixedRows;
				if (num >= this.Count)
				{
					return null;
				}
				return new int?(num);
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x0008B7E0 File Offset: 0x000899E0
		public int? LastVisibleScrollableRow
		{
			get
			{
				int? firstVisibleScrollableRow = this.FirstVisibleScrollableRow;
				if (firstVisibleScrollableRow == null)
				{
					return null;
				}
				global::System.Drawing.Rectangle scrollableArea = this.Grid.GetScrollableArea();
				int num = this.GetTop(firstVisibleScrollableRow.Value);
				int i;
				for (i = firstVisibleScrollableRow.Value; i < this.Count; i++)
				{
					num += this.GetHeight(i);
					if (num >= scrollableArea.Bottom)
					{
						return new int?(i);
					}
				}
				return new int?(i - 1);
			}
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x0008B870 File Offset: 0x00089A70
		public void AutoSizeRow(int row)
		{
			this.AutoSizeRow(row, true, 0, this.Grid.Columns.Count - 1);
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x0008B89C File Offset: 0x00089A9C
		public void AutoSizeRow(int row, bool useColumnWidth, int StartCol, int EndCol)
		{
			if ((this.GetAutoSizeMode(row) & global::SourceGrid.AutoSizeMode.EnableAutoSize) == global::SourceGrid.AutoSizeMode.EnableAutoSize && this.IsRowVisible(row))
			{
				this.SetHeight(row, this.MeasureRowHeight(row, useColumnWidth, StartCol, EndCol));
			}
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x0008B8DC File Offset: 0x00089ADC
		public int MeasureRowHeight(int row, bool useColumnWidth, int StartCol, int EndCol)
		{
			int num = this.Grid.MinimumHeight;
			if ((this.GetAutoSizeMode(row) & global::SourceGrid.AutoSizeMode.MinimumSize) == global::SourceGrid.AutoSizeMode.MinimumSize)
			{
				return num;
			}
			for (int i = StartCol; i <= EndCol; i++)
			{
				global::SourceGrid.Cells.ICellVirtual cell = this.Grid.GetCell(row, i);
				if (cell != null)
				{
					global::SourceGrid.Position pPosition = new global::SourceGrid.Position(row, i);
					global::System.Drawing.Size empty = global::System.Drawing.Size.Empty;
					if (useColumnWidth)
					{
						empty.Width = this.Grid.RangeToSize(this.Grid.PositionToCellRange(pPosition)).Width;
					}
					global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(this.Grid, pPosition, cell);
					global::System.Drawing.Size size = cellContext.Measure(empty);
					if (size.Height > num)
					{
						num = size.Height;
					}
				}
			}
			return num;
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x0008B9A0 File Offset: 0x00089BA0
		public void AutoSize(bool useColumnWidth)
		{
			this.AutoSize(useColumnWidth, 0, this.Grid.Columns.Count - 1);
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x0008B9CC File Offset: 0x00089BCC
		public void AutoSize(bool useColumnWidth, int StartCol, int EndCol)
		{
			this.SuspendLayout();
			for (int i = 0; i < this.Count; i++)
			{
				this.AutoSizeRow(i, useColumnWidth, StartCol, EndCol);
			}
			this.ResumeLayout();
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0008BA08 File Offset: 0x00089C08
		public virtual void StretchToFit()
		{
			this.SuspendLayout();
			global::System.Drawing.Rectangle displayRectangle = this.Grid.DisplayRectangle;
			if (this.Count > 0 && displayRectangle.Height > 0)
			{
				global::System.Collections.Generic.List<int> list = this.RowsInsideRegion(displayRectangle.Y, displayRectangle.Height);
				if (list.Count >= this.Count)
				{
					int? num = new int?(this.GetBottom(this.Count - 1));
					if (num != null && displayRectangle.Height > num.Value)
					{
						int num2 = 0;
						for (int i = 0; i < this.Count; i++)
						{
							if ((this.GetAutoSizeMode(i) & global::SourceGrid.AutoSizeMode.EnableStretch) == global::SourceGrid.AutoSizeMode.EnableStretch && this.IsRowVisible(i))
							{
								num2++;
							}
						}
						if (num2 > 0)
						{
							int num3 = (displayRectangle.Height - num.Value) / num2;
							for (int j = 0; j < this.Count; j++)
							{
								if ((this.GetAutoSizeMode(j) & global::SourceGrid.AutoSizeMode.EnableStretch) == global::SourceGrid.AutoSizeMode.EnableStretch && this.IsRowVisible(j))
								{
									this.SetHeight(j, this.GetHeight(j) + num3);
								}
							}
						}
					}
				}
			}
			this.ResumeLayout();
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x0008BB44 File Offset: 0x00089D44
		public global::SourceGrid.Range GetRange(int row)
		{
			return new global::SourceGrid.Range(row, 0, row, this.Grid.Columns.Count - 1);
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x0008BB70 File Offset: 0x00089D70
		public void SuspendLayout()
		{
			this.mSuspendedCount++;
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x0008BB80 File Offset: 0x00089D80
		public void ResumeLayout()
		{
			if (this.mSuspendedCount > 0)
			{
				this.mSuspendedCount--;
			}
			this.PerformLayout();
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x0008BBA4 File Offset: 0x00089DA4
		public void PerformLayout()
		{
			if (this.mSuspendedCount == 0)
			{
				this.OnLayout();
			}
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x0008BBB8 File Offset: 0x00089DB8
		protected virtual void OnLayout()
		{
			this.Grid.OnCellsAreaChanged();
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x0008BBC8 File Offset: 0x00089DC8
		public void RowsChanged()
		{
			this.PerformLayout();
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x0008BBD0 File Offset: 0x00089DD0
		public int GetAbsoluteTop(int row)
		{
			if (row < 0)
			{
				throw new global::System.ArgumentException("Must be a valid index");
			}
			int num = 0;
			for (int i = 0; i < row; i++)
			{
				num += this.GetHeight(i);
			}
			return num;
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x0008BC10 File Offset: 0x00089E10
		public int GetAbsoluteBottom(int row)
		{
			int absoluteTop = this.GetAbsoluteTop(row);
			return absoluteTop + this.GetHeight(row);
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x0008BC34 File Offset: 0x00089E34
		public int GetTop(int row)
		{
			int num = global::System.Math.Min(this.Grid.FixedRows, this.Count);
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				if (i == row)
				{
					return num2;
				}
				num2 += this.GetHeight(i);
			}
			int? firstVisibleScrollableRow = this.FirstVisibleScrollableRow;
			if (firstVisibleScrollableRow == null)
			{
				firstVisibleScrollableRow = new int?(this.Count);
			}
			if (firstVisibleScrollableRow == row)
			{
				return num2;
			}
			if (firstVisibleScrollableRow < row)
			{
				for (int j = firstVisibleScrollableRow.Value; j < this.Count; j++)
				{
					if (j == row)
					{
						return num2;
					}
					num2 += this.GetHeight(j);
				}
			}
			else if (firstVisibleScrollableRow > row)
			{
				for (int k = firstVisibleScrollableRow.Value - 1; k >= 0; k--)
				{
					num2 -= this.GetHeight(k);
					if (k == row)
					{
						return num2;
					}
				}
			}
			throw new global::System.IndexOutOfRangeException();
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x0008BD84 File Offset: 0x00089F84
		public int GetBottom(int row)
		{
			int top = this.GetTop(row);
			return top + this.GetHeight(row);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x0008BDA8 File Offset: 0x00089FA8
		public void ShowRow(int row)
		{
			if (!this.IsRowVisible(row))
			{
				this.SetHeight(row, this.Grid.DefaultHeight);
			}
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0008BDD8 File Offset: 0x00089FD8
		public void HideRow(int row)
		{
			this.SetHeight(row, 0);
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x0008BDE4 File Offset: 0x00089FE4
		public bool IsRowVisible(int row)
		{
			return this.GetHeight(row) > 0;
		}

		// Token: 0x04000DEA RID: 3562
		private global::SourceGrid.GridVirtual mGrid;

		// Token: 0x04000DEB RID: 3563
		private int mSuspendedCount;
	}
}
