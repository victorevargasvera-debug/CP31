using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003F7 RID: 1015
	public class MulBlankRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060024A1 RID: 9377 RVA: 0x0005FE49 File Offset: 0x0005E049
		public MulBlankRecord()
		{
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x0006E00C File Offset: 0x0006C20C
		public MulBlankRecord(int row, int firstCol, short[] xfs)
		{
			this._row = row;
			this._first_col = firstCol;
			this._xfs = xfs;
			this._last_col = firstCol + xfs.Length - 1;
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x0006E036 File Offset: 0x0006C236
		public MulBlankRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._row = in1.ReadUShort();
			this._first_col = (int)in1.ReadShort();
			this._xfs = this.ParseXFs(in1);
			this._last_col = (int)in1.ReadShort();
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x060024A4 RID: 9380 RVA: 0x0006E06F File Offset: 0x0006C26F
		public int Row
		{
			get
			{
				return this._row;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060024A5 RID: 9381 RVA: 0x0006E077 File Offset: 0x0006C277
		public int FirstColumn
		{
			get
			{
				return this._first_col;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060024A6 RID: 9382 RVA: 0x0006E07F File Offset: 0x0006C27F
		public int LastColumn
		{
			get
			{
				return this._last_col;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060024A7 RID: 9383 RVA: 0x0006E087 File Offset: 0x0006C287
		public int NumColumns
		{
			get
			{
				return this._last_col - this._first_col + 1;
			}
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0006E098 File Offset: 0x0006C298
		public short GetXFAt(int coffset)
		{
			return this._xfs[coffset];
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0006E0A4 File Offset: 0x0006C2A4
		private short[] ParseXFs(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			short[] array = new short[(in1.Remaining - 2) / 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = in1.ReadShort();
			}
			return array;
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x0006E0DC File Offset: 0x0006C2DC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[MULBLANK]\n");
			stringBuilder.Append("row  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.Row)).Append("\n");
			stringBuilder.Append("firstcol  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FirstColumn)).Append("\n");
			stringBuilder.Append(" lastcol  = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.LastColumn)).Append("\n");
			for (int i = 0; i < this.NumColumns; i++)
			{
				stringBuilder.Append("xf").Append(i).Append("        = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.GetXFAt(i))).Append("\n");
			}
			stringBuilder.Append("[/MULBLANK]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060024AB RID: 9387 RVA: 0x0006E1C7 File Offset: 0x0006C3C7
		public override short Sid
		{
			get
			{
				return 190;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060024AC RID: 9388 RVA: 0x0006E1CE File Offset: 0x0006C3CE
		protected override int DataSize
		{
			get
			{
				return 6 + this._xfs.Length * 2;
			}
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0006E1DC File Offset: 0x0006C3DC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._row);
			out1.WriteShort(this._first_col);
			int num = this._xfs.Length;
			for (int i = 0; i < num; i++)
			{
				out1.WriteShort((int)this._xfs[i]);
			}
			out1.WriteShort(this._last_col);
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x0000F20C File Offset: 0x0000D40C
		public override object Clone()
		{
			return this;
		}

		// Token: 0x04000F5D RID: 3933
		public const short sid = 190;

		// Token: 0x04000F5E RID: 3934
		private int _row;

		// Token: 0x04000F5F RID: 3935
		private int _first_col;

		// Token: 0x04000F60 RID: 3936
		private short[] _xfs;

		// Token: 0x04000F61 RID: 3937
		private int _last_col;
	}
}
