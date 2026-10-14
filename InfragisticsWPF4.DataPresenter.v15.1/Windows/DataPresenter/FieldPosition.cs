using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F6 RID: 758
	public struct FieldPosition
	{
		// Token: 0x06002313 RID: 8979 RVA: 0x00098BEC File Offset: 0x00096DEC
		public FieldPosition(int column, int row, int columnSpan, int rowSpan)
		{
			this._column = column;
			this._row = row;
			this._columnSpan = ((columnSpan > 0) ? columnSpan : 1);
			this._rowSpan = ((rowSpan > 0) ? rowSpan : 1);
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06002314 RID: 8980 RVA: 0x00098C1A File Offset: 0x00096E1A
		public int Row
		{
			get
			{
				return this._row;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x00098C22 File Offset: 0x00096E22
		public int Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x00098C2A File Offset: 0x00096E2A
		public int RowSpan
		{
			get
			{
				return this._rowSpan;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x00098C32 File Offset: 0x00096E32
		public int ColumnSpan
		{
			get
			{
				return this._columnSpan;
			}
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00098C3C File Offset: 0x00096E3C
		internal bool Contains(int row, int col)
		{
			return this._columnSpan > 0 && this._rowSpan > 0 && (this._row <= row && row < this._row + this._rowSpan) && this._column <= col && col < this._column + this._columnSpan;
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00098C94 File Offset: 0x00096E94
		internal static global::Infragistics.Windows.DataPresenter.FieldPosition CreateHelper(int col, int row, int colSpan, int rowSpan)
		{
			return new global::Infragistics.Windows.DataPresenter.FieldPosition
			{
				_column = col,
				_row = row,
				_columnSpan = colSpan,
				_rowSpan = rowSpan
			};
		}

		// Token: 0x0400118E RID: 4494
		private int _column;

		// Token: 0x0400118F RID: 4495
		private int _row;

		// Token: 0x04001190 RID: 4496
		private int _columnSpan;

		// Token: 0x04001191 RID: 4497
		private int _rowSpan;
	}
}
