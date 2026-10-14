using System;

namespace NPOI.SS.Util
{
	// Token: 0x02000016 RID: 22
	public abstract class CellRangeAddressBase
	{
		// Token: 0x060000DA RID: 218 RVA: 0x00004F2F File Offset: 0x0000312F
		protected CellRangeAddressBase(int firstRow, int lastRow, int firstCol, int lastCol)
		{
			this._firstRow = firstRow;
			this._lastRow = lastRow;
			this._firstCol = firstCol;
			this._lastCol = lastCol;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004F54 File Offset: 0x00003154
		public void Validate(global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			global::NPOI.SS.Util.CellRangeAddressBase.ValidateRow(this._firstRow, ssVersion);
			global::NPOI.SS.Util.CellRangeAddressBase.ValidateRow(this._lastRow, ssVersion);
			global::NPOI.SS.Util.CellRangeAddressBase.ValidateColumn(this._firstCol, ssVersion);
			global::NPOI.SS.Util.CellRangeAddressBase.ValidateColumn(this._lastCol, ssVersion);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004F88 File Offset: 0x00003188
		private static void ValidateRow(int row, global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			int lastRowIndex = ssVersion.LastRowIndex;
			if (row > lastRowIndex)
			{
				throw new global::System.ArgumentException("Maximum row number is " + lastRowIndex.ToString());
			}
			if (row < 0)
			{
				throw new global::System.ArgumentException("Minumum row number is 0");
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00004FC8 File Offset: 0x000031C8
		private static void ValidateColumn(int column, global::NPOI.SS.SpreadsheetVersion ssVersion)
		{
			int lastColumnIndex = ssVersion.LastColumnIndex;
			if (column > lastColumnIndex)
			{
				throw new global::System.ArgumentException("Maximum column number is " + lastColumnIndex.ToString());
			}
			if (column < 0)
			{
				throw new global::System.ArgumentException("Minimum column number is 0");
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00005006 File Offset: 0x00003206
		public bool IsInRange(int rowInd, int colInd)
		{
			return this._firstRow <= rowInd && rowInd <= this._lastRow && this._firstCol <= colInd && colInd <= this._lastCol;
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00005031 File Offset: 0x00003231
		public bool IsFullColumnRange
		{
			get
			{
				return (this._firstRow == 0 && this._lastRow == global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastRowIndex) || (this._firstRow == -1 && this._lastRow == -1);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005063 File Offset: 0x00003263
		public bool IsFullRowRange
		{
			get
			{
				return (this._firstCol == 0 && this._lastCol == global::NPOI.SS.SpreadsheetVersion.EXCEL97.LastColumnIndex) || (this._firstCol == -1 && this._lastCol == -1);
			}
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00005095 File Offset: 0x00003295
		public bool ContainsRow(int rowInd)
		{
			return this._firstRow <= rowInd && rowInd <= this._lastRow;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000050AE File Offset: 0x000032AE
		public bool ContainsColumn(int colInd)
		{
			return this._firstCol <= colInd && colInd <= this._lastCol;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000050C7 File Offset: 0x000032C7
		public bool Intersects(global::NPOI.SS.Util.CellRangeAddressBase other)
		{
			return this._firstRow <= other._lastRow && this._firstCol <= other._lastCol && other._firstRow <= this._lastRow && other._firstCol <= this._lastCol;
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005106 File Offset: 0x00003306
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000510E File Offset: 0x0000330E
		public int FirstColumn
		{
			get
			{
				return this._firstCol;
			}
			set
			{
				this._firstCol = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005117 File Offset: 0x00003317
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000511F File Offset: 0x0000331F
		public int FirstRow
		{
			get
			{
				return this._firstRow;
			}
			set
			{
				this._firstRow = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005128 File Offset: 0x00003328
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00005130 File Offset: 0x00003330
		public int LastColumn
		{
			get
			{
				return this._lastCol;
			}
			set
			{
				this._lastCol = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00005139 File Offset: 0x00003339
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00005141 File Offset: 0x00003341
		public int LastRow
		{
			get
			{
				return this._lastRow;
			}
			set
			{
				this._lastRow = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000514A File Offset: 0x0000334A
		public int NumberOfCells
		{
			get
			{
				return (this._lastRow - this._firstRow + 1) * (this._lastCol - this._firstCol + 1);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000516C File Offset: 0x0000336C
		public override string ToString()
		{
			global::NPOI.SS.Util.CellReference cellReference = new global::NPOI.SS.Util.CellReference(this._firstRow, this._firstCol);
			global::NPOI.SS.Util.CellReference cellReference2 = new global::NPOI.SS.Util.CellReference(this._lastRow, this._lastCol);
			return string.Concat(new string[]
			{
				base.GetType().Name,
				" [",
				cellReference.FormatAsString(),
				":",
				cellReference2.FormatAsString(),
				"]"
			});
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000051E0 File Offset: 0x000033E0
		public int MinRow
		{
			get
			{
				return global::System.Math.Min(this._firstRow, this._lastRow);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000EF RID: 239 RVA: 0x000051F3 File Offset: 0x000033F3
		public int MaxRow
		{
			get
			{
				return global::System.Math.Max(this._firstRow, this._lastRow);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005206 File Offset: 0x00003406
		public int MinColumn
		{
			get
			{
				return global::System.Math.Min(this._firstCol, this._lastCol);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00005219 File Offset: 0x00003419
		public int MaxColumn
		{
			get
			{
				return global::System.Math.Max(this._firstCol, this._lastCol);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000522C File Offset: 0x0000342C
		public override bool Equals(object other)
		{
			if (other is global::NPOI.SS.Util.CellRangeAddressBase)
			{
				global::NPOI.SS.Util.CellRangeAddressBase cellRangeAddressBase = (global::NPOI.SS.Util.CellRangeAddressBase)other;
				return this.MinRow == cellRangeAddressBase.MinRow && this.MaxRow == cellRangeAddressBase.MaxRow && this.MinColumn == cellRangeAddressBase.MinColumn && this.MaxColumn == cellRangeAddressBase.MaxColumn;
			}
			return false;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005284 File Offset: 0x00003484
		public override int GetHashCode()
		{
			return this.MinColumn + (this.MaxColumn << 8) + (this.MinRow << 16) + (this.MaxRow << 24);
		}

		// Token: 0x04000033 RID: 51
		private int _firstRow;

		// Token: 0x04000034 RID: 52
		private int _firstCol;

		// Token: 0x04000035 RID: 53
		private int _lastRow;

		// Token: 0x04000036 RID: 54
		private int _lastCol;
	}
}
