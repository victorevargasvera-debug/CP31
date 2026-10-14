using System;
using System.Text;
using NPOI.HSSF.Util;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003F8 RID: 1016
	public class MulRKRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060024AF RID: 9391 RVA: 0x0005FE49 File Offset: 0x0005E049
		public MulRKRecord()
		{
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0006E230 File Offset: 0x0006C430
		public MulRKRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_row = in1.ReadUShort();
			this.field_2_first_col = in1.ReadShort();
			this.field_3_rks = global::NPOI.HSSF.Record.MulRKRecord.RkRec.ParseRKs(in1);
			this.field_4_last_col = in1.ReadShort();
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x0006E268 File Offset: 0x0006C468
		public int Row
		{
			get
			{
				return this.field_1_row;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x0006E270 File Offset: 0x0006C470
		public short FirstColumn
		{
			get
			{
				return this.field_2_first_col;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x0006E278 File Offset: 0x0006C478
		public short LastColumn
		{
			get
			{
				return this.field_4_last_col;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x0006E280 File Offset: 0x0006C480
		public int NumColumns
		{
			get
			{
				return (int)(this.field_4_last_col - this.field_2_first_col + 1);
			}
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0006E291 File Offset: 0x0006C491
		public short GetXFAt(int coffset)
		{
			return this.field_3_rks[coffset].xf;
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x0006E2A0 File Offset: 0x0006C4A0
		public double GetRKNumberAt(int coffset)
		{
			return global::NPOI.HSSF.Util.RKUtil.DecodeNumber(this.field_3_rks[coffset].rk);
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x0006E2B4 File Offset: 0x0006C4B4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[MULRK]\n");
			stringBuilder.Append("\t.row\t = ").Append(global::NPOI.Util.HexDump.ShortToHex(this.Row)).Append("\n");
			stringBuilder.Append(" .firstcol= ").Append(global::NPOI.Util.StringUtil.ToHexString(this.FirstColumn)).Append("\n");
			stringBuilder.Append(" .lastcol = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.LastColumn)).Append("\n");
			for (int i = 0; i < this.NumColumns; i++)
			{
				stringBuilder.Append(" xf[").Append(i).Append("] = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.GetXFAt(i))).Append("\n");
				stringBuilder.Append(" rk[").Append(i).Append("] = ").Append(this.GetRKNumberAt(i)).Append("\n");
			}
			stringBuilder.Append("[/MULRK]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x0006E3D1 File Offset: 0x0006C5D1
		public override short Sid
		{
			get
			{
				return 189;
			}
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x0006E3D8 File Offset: 0x0006C5D8
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			throw new global::NPOI.Util.RecordFormatException("Sorry, you can't serialize MulRK in this release");
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x0006E3D8 File Offset: 0x0006C5D8
		protected override int DataSize
		{
			get
			{
				throw new global::NPOI.Util.RecordFormatException("Sorry, you can't serialize MulRK in this release");
			}
		}

		// Token: 0x04000F62 RID: 3938
		public const short sid = 189;

		// Token: 0x04000F63 RID: 3939
		private int field_1_row;

		// Token: 0x04000F64 RID: 3940
		private short field_2_first_col;

		// Token: 0x04000F65 RID: 3941
		private global::NPOI.HSSF.Record.MulRKRecord.RkRec[] field_3_rks;

		// Token: 0x04000F66 RID: 3942
		private short field_4_last_col;

		// Token: 0x02000610 RID: 1552
		private class RkRec
		{
			// Token: 0x06003685 RID: 13957 RVA: 0x000A6968 File Offset: 0x000A4B68
			private RkRec(global::NPOI.HSSF.Record.RecordInputStream in1)
			{
				this.xf = in1.ReadShort();
				this.rk = in1.ReadInt();
			}

			// Token: 0x06003686 RID: 13958 RVA: 0x000A6988 File Offset: 0x000A4B88
			public static global::NPOI.HSSF.Record.MulRKRecord.RkRec[] ParseRKs(global::NPOI.HSSF.Record.RecordInputStream in1)
			{
				int num = (in1.Remaining - 2) / 6;
				global::NPOI.HSSF.Record.MulRKRecord.RkRec[] array = new global::NPOI.HSSF.Record.MulRKRecord.RkRec[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = new global::NPOI.HSSF.Record.MulRKRecord.RkRec(in1);
				}
				return array;
			}

			// Token: 0x04001A72 RID: 6770
			public const int ENCODED_SIZE = 6;

			// Token: 0x04001A73 RID: 6771
			public short xf;

			// Token: 0x04001A74 RID: 6772
			public int rk;
		}
	}
}
