using System;
using NPOI.SS.UserModel;

namespace NPOI.SS.Util
{
	// Token: 0x0200000F RID: 15
	public class CellAddress : global::System.IComparable<global::NPOI.SS.Util.CellAddress>
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00002FB8 File Offset: 0x000011B8
		public CellAddress(int row, int column)
		{
			this._row = row;
			this._col = column;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002FD0 File Offset: 0x000011D0
		public CellAddress(string address)
		{
			int length = address.Length;
			int num = 0;
			while (num < length && !char.IsDigit(address[num]))
			{
				num++;
			}
			string @ref = address.Substring(0, num).ToUpper();
			string s = address.Substring(num);
			this._row = int.Parse(s) - 1;
			this._col = global::NPOI.SS.Util.CellReference.ConvertColStringToIndex(@ref);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003034 File Offset: 0x00001234
		public CellAddress(global::NPOI.SS.Util.CellReference reference) : this(reference.Row, (int)reference.Col)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003048 File Offset: 0x00001248
		public CellAddress(global::NPOI.SS.UserModel.ICell cell) : this(cell.RowIndex, cell.ColumnIndex)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000305C File Offset: 0x0000125C
		public int Row
		{
			get
			{
				return this._row;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00003064 File Offset: 0x00001264
		public int Column
		{
			get
			{
				return this._col;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000306C File Offset: 0x0000126C
		public int CompareTo(global::NPOI.SS.Util.CellAddress other)
		{
			int num = this._row - other._row;
			if (num != 0)
			{
				return num;
			}
			num = this._col - other._col;
			if (num != 0)
			{
				return num;
			}
			return 0;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000030A0 File Offset: 0x000012A0
		public override bool Equals(object o)
		{
			if (this == o)
			{
				return true;
			}
			if (!(o is global::NPOI.SS.Util.CellAddress))
			{
				return false;
			}
			global::NPOI.SS.Util.CellAddress cellAddress = (global::NPOI.SS.Util.CellAddress)o;
			return this._row == cellAddress._row && this._col == cellAddress._col;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000030E2 File Offset: 0x000012E2
		public override int GetHashCode()
		{
			return this._row + this._col << 16;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000030F4 File Offset: 0x000012F4
		public override string ToString()
		{
			return this.FormatAsString();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000030FC File Offset: 0x000012FC
		public string FormatAsString()
		{
			return global::NPOI.SS.Util.CellReference.ConvertNumToColString(this._col) + (this._row + 1).ToString();
		}

		// Token: 0x0400001F RID: 31
		public static global::NPOI.SS.Util.CellAddress A1 = new global::NPOI.SS.Util.CellAddress(0, 0);

		// Token: 0x04000020 RID: 32
		private int _row;

		// Token: 0x04000021 RID: 33
		private int _col;
	}
}
