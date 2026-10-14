using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NPOI.SS;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming
{
	// Token: 0x020000CD RID: 205
	public class SXSSFRow : global::NPOI.SS.UserModel.IRow, global::System.Collections.Generic.IEnumerable<global::NPOI.SS.UserModel.ICell>, global::System.Collections.IEnumerable, global::System.IComparable<global::NPOI.XSSF.Streaming.SXSSFRow>
	{
		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x0002E230 File Offset: 0x0002C430
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x0002E238 File Offset: 0x0002C438
		public bool? Hidden { get; set; }

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0002E241 File Offset: 0x0002C441
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x0002E249 File Offset: 0x0002C449
		public bool? Collapsed { get; set; }

		// Token: 0x06000CAC RID: 3244 RVA: 0x0002E252 File Offset: 0x0002C452
		public SXSSFRow(global::NPOI.XSSF.Streaming.SXSSFSheet sheet)
		{
			this._sheet = sheet;
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x0002E28C File Offset: 0x0002C48C
		public global::NPOI.XSSF.Streaming.SXSSFRow.CellIterator AllCellsIterator()
		{
			return new global::NPOI.XSSF.Streaming.SXSSFRow.CellIterator((int)this.LastCellNum, new global::System.Collections.Generic.SortedDictionary<int, global::NPOI.XSSF.Streaming.SXSSFCell>(this._cells));
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x0002E2A4 File Offset: 0x0002C4A4
		public bool HasCustomHeight()
		{
			return this.Height != -1;
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0002E2B2 File Offset: 0x0002C4B2
		public global::System.Collections.Generic.List<global::NPOI.SS.UserModel.ICell> Cells
		{
			get
			{
				return (from cell in this._cells.Values
				select cell).ToList<global::NPOI.SS.UserModel.ICell>();
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0002E2E8 File Offset: 0x0002C4E8
		public short FirstCellNum
		{
			get
			{
				short result;
				try
				{
					result = (short)this._FirstCellNum;
				}
				catch
				{
					result = -1;
				}
				return result;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0002E318 File Offset: 0x0002C518
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x0002E341 File Offset: 0x0002C541
		public short Height
		{
			get
			{
				return (short)((this._height == -1f) ? (this.Sheet.DefaultRowHeightInPoints * 20f) : this._height);
			}
			set
			{
				this._height = (float)value;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0002E34B File Offset: 0x0002C54B
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x0002E37A File Offset: 0x0002C57A
		public float HeightInPoints
		{
			get
			{
				return (float)((this._height == -1f) ? ((double)this.Sheet.DefaultRowHeightInPoints) : ((double)this._height / 20.0));
			}
			set
			{
				this._height = ((value == -1f) ? -1f : (value * 20f));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x0002E398 File Offset: 0x0002C598
		public bool IsFormatted
		{
			get
			{
				return this._style > -1;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0002E3A3 File Offset: 0x0002C5A3
		public short LastCellNum
		{
			get
			{
				return (short)this._LastCellNum;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x0002E3AC File Offset: 0x0002C5AC
		// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x0002E3B4 File Offset: 0x0002C5B4
		public int OutlineLevel { get; set; }

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000CB9 RID: 3257 RVA: 0x0002E3BD File Offset: 0x0002C5BD
		public int PhysicalNumberOfCells
		{
			get
			{
				return this.Cells.Count;
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0002E3CA File Offset: 0x0002C5CA
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x0002E3D8 File Offset: 0x0002C5D8
		public int RowNum
		{
			get
			{
				return this._sheet.GetRowNum(this);
			}
			set
			{
				this._sheet.ChangeRowNum(this, value);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0002E3E7 File Offset: 0x0002C5E7
		internal int RowStyleIndex
		{
			get
			{
				return (int)this._style;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000CBD RID: 3261 RVA: 0x0002E3EF File Offset: 0x0002C5EF
		// (set) Token: 0x06000CBE RID: 3262 RVA: 0x0002E411 File Offset: 0x0002C611
		public global::NPOI.SS.UserModel.ICellStyle RowStyle
		{
			get
			{
				if (!this.IsFormatted)
				{
					return null;
				}
				return this.Sheet.Workbook.GetCellStyleAt((int)this._style);
			}
			set
			{
				if (value == null)
				{
					this._style = -1;
					return;
				}
				this._style = value.Index;
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000CBF RID: 3263 RVA: 0x0002E42A File Offset: 0x0002C62A
		public global::NPOI.SS.UserModel.ISheet Sheet
		{
			get
			{
				return this._sheet;
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0002E432 File Offset: 0x0002C632
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x0002E43A File Offset: 0x0002C63A
		public bool ZeroHeight
		{
			get
			{
				return this._zHeight;
			}
			set
			{
				this._zHeight = value;
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0002E444 File Offset: 0x0002C644
		public int CompareTo(global::NPOI.XSSF.Streaming.SXSSFRow other)
		{
			if (this.Sheet != other.Sheet)
			{
				throw new global::System.InvalidOperationException("The compared rows must belong to the same sheet");
			}
			int rowNum = this.RowNum;
			int rowNum2 = other.RowNum;
			return rowNum.CompareTo(rowNum2);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0002E480 File Offset: 0x0002C680
		public override bool Equals(object obj)
		{
			if (!(obj is global::NPOI.XSSF.Streaming.SXSSFRow))
			{
				return false;
			}
			global::NPOI.XSSF.Streaming.SXSSFRow sxssfrow = (global::NPOI.XSSF.Streaming.SXSSFRow)obj;
			return this.RowNum == sxssfrow.RowNum && this.Sheet == sxssfrow.Sheet;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x0002E4BC File Offset: 0x0002C6BC
		public override int GetHashCode()
		{
			return this._cells.GetHashCode();
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.SS.UserModel.ICell CopyCell(int sourceIndex, int targetIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x000065E4 File Offset: 0x000047E4
		public global::NPOI.SS.UserModel.IRow CopyRowTo(int targetIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0002E4C9 File Offset: 0x0002C6C9
		public global::NPOI.SS.UserModel.ICell CreateCell(int column)
		{
			return this.CreateCell(column, global::NPOI.SS.UserModel.CellType.Blank);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0002E4D4 File Offset: 0x0002C6D4
		public global::NPOI.SS.UserModel.ICell CreateCell(int column, global::NPOI.SS.UserModel.CellType type)
		{
			global::NPOI.XSSF.Streaming.SXSSFRow.CheckBounds(column);
			global::NPOI.XSSF.Streaming.SXSSFCell sxssfcell = new global::NPOI.XSSF.Streaming.SXSSFCell(this, type);
			this._cells[column] = sxssfcell;
			this.UpdateIndexWhenAdd(column);
			return sxssfcell;
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0002E504 File Offset: 0x0002C704
		private void UpdateIndexWhenAdd(int cellnum)
		{
			if (cellnum < this._FirstCellNum || this._FirstCellNum == -1)
			{
				this._FirstCellNum = cellnum;
			}
			if (cellnum >= this._LastCellNum)
			{
				this._LastCellNum = cellnum + 1;
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x0002E534 File Offset: 0x0002C734
		private static void CheckBounds(int cellIndex)
		{
			global::NPOI.SS.SpreadsheetVersion excel = global::NPOI.SS.SpreadsheetVersion.EXCEL2007;
			int lastColumnIndex = global::NPOI.SS.SpreadsheetVersion.EXCEL2007.LastColumnIndex;
			if (cellIndex < 0 || cellIndex > lastColumnIndex)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Invalid column index (",
					cellIndex.ToString(),
					").  Allowable column range for ",
					excel.DefaultExtension,
					" is (0..",
					lastColumnIndex.ToString(),
					") or ('A'..'",
					excel.LastColumnName,
					"')"
				}));
			}
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x0002E5BC File Offset: 0x0002C7BC
		public global::NPOI.SS.UserModel.ICell GetCell(int cellnum)
		{
			global::NPOI.SS.UserModel.MissingCellPolicy missingCellPolicy = this._sheet.Workbook.MissingCellPolicy;
			return this.GetCell(cellnum, missingCellPolicy);
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x0002E5E4 File Offset: 0x0002C7E4
		public global::NPOI.SS.UserModel.ICell GetCell(int cellnum, global::NPOI.SS.UserModel.MissingCellPolicy policy)
		{
			global::NPOI.XSSF.Streaming.SXSSFRow.CheckBounds(cellnum);
			global::NPOI.XSSF.Streaming.SXSSFCell sxssfcell = null;
			if (this._cells.ContainsKey(cellnum))
			{
				sxssfcell = this._cells[cellnum];
			}
			switch (policy)
			{
			case global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_NULL_AND_BLANK:
				return sxssfcell;
			case global::NPOI.SS.UserModel.MissingCellPolicy.RETURN_BLANK_AS_NULL:
				if (sxssfcell == null || sxssfcell.CellType != global::NPOI.SS.UserModel.CellType.Blank)
				{
					return sxssfcell;
				}
				return null;
			case global::NPOI.SS.UserModel.MissingCellPolicy.CREATE_NULL_AS_BLANK:
				if (sxssfcell != null)
				{
					return sxssfcell;
				}
				return this.CreateCell(cellnum, global::NPOI.SS.UserModel.CellType.Blank);
			default:
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Illegal policy ",
					policy.ToString(),
					" (",
					policy.ToString(),
					")"
				}));
			}
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x0002E699 File Offset: 0x0002C899
		public global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ICell> GetEnumerator()
		{
			return new global::NPOI.XSSF.Streaming.SXSSFRow.FilledCellIterator(new global::System.Collections.Generic.SortedDictionary<int, global::NPOI.XSSF.Streaming.SXSSFCell>(this._cells));
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x000065E4 File Offset: 0x000047E4
		public void MoveCell(global::NPOI.SS.UserModel.ICell cell, int newColumn)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0002E6AC File Offset: 0x0002C8AC
		public void RemoveCell(global::NPOI.SS.UserModel.ICell cell)
		{
			int cellIndex = this.GetCellIndex((global::NPOI.XSSF.Streaming.SXSSFCell)cell);
			this._cells.Remove(cellIndex);
			if (cellIndex == this._FirstCellNum)
			{
				this.InvalidateFirstCellNum();
			}
			if (cellIndex >= this._LastCellNum - 1)
			{
				this.InvalidateLastCellNum();
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0002E6F3 File Offset: 0x0002C8F3
		private void InvalidateFirstCellNum()
		{
			if (this._cells.Keys.Count == 0)
			{
				this._FirstCellNum = 0;
				return;
			}
			this._FirstCellNum = this._cells.Keys.Min();
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0002E725 File Offset: 0x0002C925
		private void InvalidateLastCellNum()
		{
			if (this._cells.Count == 0)
			{
				this._LastCellNum = 0;
				return;
			}
			this._LastCellNum = this._cells.Keys.Max() + 1;
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0002E754 File Offset: 0x0002C954
		public int GetCellIndex(global::NPOI.XSSF.Streaming.SXSSFCell cell)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<int, global::NPOI.XSSF.Streaming.SXSSFCell> keyValuePair in this._cells)
			{
				if (keyValuePair.Value == cell)
				{
					return keyValuePair.Key;
				}
			}
			return -1;
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x000065E4 File Offset: 0x000047E4
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040003EB RID: 1003
		private global::NPOI.XSSF.Streaming.SXSSFSheet _sheet;

		// Token: 0x040003EC RID: 1004
		private global::System.Collections.Generic.IDictionary<int, global::NPOI.XSSF.Streaming.SXSSFCell> _cells = new global::System.Collections.Generic.Dictionary<int, global::NPOI.XSSF.Streaming.SXSSFCell>();

		// Token: 0x040003ED RID: 1005
		private short _style = -1;

		// Token: 0x040003EE RID: 1006
		private bool _zHeight;

		// Token: 0x040003EF RID: 1007
		private float _height = -1f;

		// Token: 0x040003F0 RID: 1008
		private int _FirstCellNum = -1;

		// Token: 0x040003F1 RID: 1009
		private int _LastCellNum = -1;

		// Token: 0x02000146 RID: 326
		public class FilledCellIterator : global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ICell>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600104A RID: 4170 RVA: 0x0003917C File Offset: 0x0003737C
			public FilledCellIterator(global::System.Collections.Generic.SortedDictionary<int, global::NPOI.XSSF.Streaming.SXSSFCell> cells)
			{
				this.enumerator = cells.Values.GetEnumerator();
			}

			// Token: 0x170003C4 RID: 964
			// (get) Token: 0x0600104B RID: 4171 RVA: 0x0003919A File Offset: 0x0003739A
			public global::NPOI.SS.UserModel.ICell Current
			{
				get
				{
					return this.enumerator.Current;
				}
			}

			// Token: 0x170003C5 RID: 965
			// (get) Token: 0x0600104C RID: 4172 RVA: 0x0003919A File Offset: 0x0003739A
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.enumerator.Current;
				}
			}

			// Token: 0x0600104D RID: 4173 RVA: 0x000029BF File Offset: 0x00000BBF
			public void Dispose()
			{
			}

			// Token: 0x0600104E RID: 4174 RVA: 0x000391A7 File Offset: 0x000373A7
			public global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ICell> GetEnumerator()
			{
				return this.enumerator;
			}

			// Token: 0x0600104F RID: 4175 RVA: 0x000391AF File Offset: 0x000373AF
			public bool MoveNext()
			{
				return this.enumerator.MoveNext();
			}

			// Token: 0x06001050 RID: 4176 RVA: 0x000391BC File Offset: 0x000373BC
			public void Reset()
			{
				this.enumerator.Reset();
			}

			// Token: 0x04000527 RID: 1319
			private global::System.Collections.Generic.IEnumerator<global::NPOI.XSSF.Streaming.SXSSFCell> enumerator;
		}

		// Token: 0x02000147 RID: 327
		public class CellIterator : global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ICell>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06001051 RID: 4177 RVA: 0x000391C9 File Offset: 0x000373C9
			public CellIterator(int lastCellNum, global::System.Collections.Generic.IDictionary<int, global::NPOI.XSSF.Streaming.SXSSFCell> cells)
			{
				this.maxColumn = lastCellNum;
				this.pos = -1;
				this._cells = cells;
			}

			// Token: 0x170003C6 RID: 966
			// (get) Token: 0x06001052 RID: 4178 RVA: 0x000391E6 File Offset: 0x000373E6
			public global::NPOI.SS.UserModel.ICell Current
			{
				get
				{
					if (!this._cells.ContainsKey(this.pos))
					{
						return null;
					}
					return this._cells[this.pos];
				}
			}

			// Token: 0x170003C7 RID: 967
			// (get) Token: 0x06001053 RID: 4179 RVA: 0x0003920E File Offset: 0x0003740E
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06001054 RID: 4180 RVA: 0x000029BF File Offset: 0x00000BBF
			public void Dispose()
			{
			}

			// Token: 0x06001055 RID: 4181 RVA: 0x000065E4 File Offset: 0x000047E4
			public global::System.Collections.Generic.IEnumerator<global::NPOI.SS.UserModel.ICell> GetEnumerator()
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x06001056 RID: 4182 RVA: 0x00039216 File Offset: 0x00037416
			public bool HasNext()
			{
				return this.pos < this.maxColumn;
			}

			// Token: 0x06001057 RID: 4183 RVA: 0x00039226 File Offset: 0x00037426
			public bool MoveNext()
			{
				if (this.HasNext())
				{
					this.pos++;
					return true;
				}
				return false;
			}

			// Token: 0x06001058 RID: 4184 RVA: 0x00039244 File Offset: 0x00037444
			public global::NPOI.SS.UserModel.ICell Next()
			{
				if (!this.HasNext())
				{
					throw new global::System.NullReferenceException();
				}
				if (this._cells.ContainsKey(this.pos))
				{
					global::System.Collections.Generic.IDictionary<int, global::NPOI.XSSF.Streaming.SXSSFCell> cells = this._cells;
					int num = this.pos;
					this.pos = num + 1;
					return cells[num];
				}
				this.pos++;
				return null;
			}

			// Token: 0x06001059 RID: 4185 RVA: 0x000104EF File Offset: 0x0000E6EF
			public void Remove()
			{
				throw new global::System.InvalidOperationException();
			}

			// Token: 0x0600105A RID: 4186 RVA: 0x000065E4 File Offset: 0x000047E4
			public void Reset()
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x04000528 RID: 1320
			private global::System.Collections.Generic.IDictionary<int, global::NPOI.XSSF.Streaming.SXSSFCell> _cells;

			// Token: 0x04000529 RID: 1321
			private int maxColumn;

			// Token: 0x0400052A RID: 1322
			private int pos;
		}
	}
}
