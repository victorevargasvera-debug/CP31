using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002B9 RID: 697
	public struct FieldPosition
	{
		// Token: 0x06001FDA RID: 8154 RVA: 0x000889E0 File Offset: 0x00086BE0
		public FieldPosition(int column, int row, int columnSpan, int rowSpan)
		{
			this._column = column;
			this._row = row;
			this._columnSpan = ((columnSpan > 0) ? columnSpan : 1);
			this._rowSpan = ((rowSpan > 0) ? rowSpan : 1);
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00088A0E File Offset: 0x00086C0E
		public int Row
		{
			get
			{
				return this._row;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x00088A16 File Offset: 0x00086C16
		public int Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x00088A1E File Offset: 0x00086C1E
		public int RowSpan
		{
			get
			{
				return this._rowSpan;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001FDE RID: 8158 RVA: 0x00088A26 File Offset: 0x00086C26
		public int ColumnSpan
		{
			get
			{
				return this._columnSpan;
			}
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00088A30 File Offset: 0x00086C30
		internal bool Contains(int row, int col)
		{
			return this._columnSpan > 0 && this._rowSpan > 0 && (this._row <= row && row < this._row + this._rowSpan) && this._column <= col && col < this._column + this._columnSpan;
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00088A88 File Offset: 0x00086C88
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

		// Token: 0x04000FA6 RID: 4006
		private int _column;

		// Token: 0x04000FA7 RID: 4007
		private int _row;

		// Token: 0x04000FA8 RID: 4008
		private int _columnSpan;

		// Token: 0x04000FA9 RID: 4009
		private int _rowSpan;
	}
}
