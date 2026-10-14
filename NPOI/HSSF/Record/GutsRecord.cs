using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003E4 RID: 996
	public class GutsRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x060023D3 RID: 9171 RVA: 0x0005FE49 File Offset: 0x0005E049
		public GutsRecord()
		{
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0006C094 File Offset: 0x0006A294
		public GutsRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_left_row_gutter = in1.ReadShort();
			this.field_2_top_col_gutter = in1.ReadShort();
			this.field_3_row_level_max = in1.ReadShort();
			this.field_4_col_level_max = in1.ReadShort();
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x0006C0CC File Offset: 0x0006A2CC
		// (set) Token: 0x060023D6 RID: 9174 RVA: 0x0006C0D4 File Offset: 0x0006A2D4
		public short LeftRowGutter
		{
			get
			{
				return this.field_1_left_row_gutter;
			}
			set
			{
				this.field_1_left_row_gutter = value;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060023D7 RID: 9175 RVA: 0x0006C0DD File Offset: 0x0006A2DD
		// (set) Token: 0x060023D8 RID: 9176 RVA: 0x0006C0E5 File Offset: 0x0006A2E5
		public short TopColGutter
		{
			get
			{
				return this.field_2_top_col_gutter;
			}
			set
			{
				this.field_2_top_col_gutter = value;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x0006C0EE File Offset: 0x0006A2EE
		// (set) Token: 0x060023DA RID: 9178 RVA: 0x0006C0F6 File Offset: 0x0006A2F6
		public short RowLevelMax
		{
			get
			{
				return this.field_3_row_level_max;
			}
			set
			{
				this.field_3_row_level_max = value;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060023DB RID: 9179 RVA: 0x0006C0FF File Offset: 0x0006A2FF
		// (set) Token: 0x060023DC RID: 9180 RVA: 0x0006C107 File Offset: 0x0006A307
		public short ColLevelMax
		{
			get
			{
				return this.field_4_col_level_max;
			}
			set
			{
				this.field_4_col_level_max = value;
			}
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x0006C110 File Offset: 0x0006A310
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[GUTS]\n");
			stringBuilder.Append("    .leftgutter     = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.LeftRowGutter)).Append("\n");
			stringBuilder.Append("    .topgutter      = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.TopColGutter)).Append("\n");
			stringBuilder.Append("    .rowlevelmax    = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.RowLevelMax)).Append("\n");
			stringBuilder.Append("    .collevelmax    = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.ColLevelMax)).Append("\n");
			stringBuilder.Append("[/GUTS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0006C1D7 File Offset: 0x0006A3D7
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.LeftRowGutter);
			out1.WriteShort((int)this.TopColGutter);
			out1.WriteShort((int)this.RowLevelMax);
			out1.WriteShort((int)this.ColLevelMax);
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060023DF RID: 9183 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int DataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x0006C209 File Offset: 0x0006A409
		public override short Sid
		{
			get
			{
				return 128;
			}
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x0006C210 File Offset: 0x0006A410
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.GutsRecord
			{
				field_1_left_row_gutter = this.field_1_left_row_gutter,
				field_2_top_col_gutter = this.field_2_top_col_gutter,
				field_3_row_level_max = this.field_3_row_level_max,
				field_4_col_level_max = this.field_4_col_level_max
			};
		}

		// Token: 0x04000F0F RID: 3855
		public const short sid = 128;

		// Token: 0x04000F10 RID: 3856
		private short field_1_left_row_gutter;

		// Token: 0x04000F11 RID: 3857
		private short field_2_top_col_gutter;

		// Token: 0x04000F12 RID: 3858
		private short field_3_row_level_max;

		// Token: 0x04000F13 RID: 3859
		private short field_4_col_level_max;
	}
}
