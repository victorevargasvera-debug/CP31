using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004AD RID: 1197
	public class FontBasisRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002C93 RID: 11411 RVA: 0x0005FE49 File Offset: 0x0005E049
		public FontBasisRecord()
		{
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x0008454C File Offset: 0x0008274C
		public FontBasisRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_xBasis = in1.ReadShort();
			this.field_2_yBasis = in1.ReadShort();
			this.field_3_heightBasis = in1.ReadShort();
			this.field_4_scale = in1.ReadShort();
			this.field_5_indexToFontTable = in1.ReadShort();
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x0008459C File Offset: 0x0008279C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FBI]\n");
			stringBuilder.Append("    .xBasis               = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.XBasis)).Append(" (").Append(this.XBasis).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .yBasis               = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.YBasis)).Append(" (").Append(this.YBasis).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .heightBasis          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.HeightBasis)).Append(" (").Append(this.HeightBasis).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .scale                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Scale)).Append(" (").Append(this.Scale).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .indexToFontTable     = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.IndexToFontTable)).Append(" (").Append(this.IndexToFontTable).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/FBI]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x00084760 File Offset: 0x00082960
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_xBasis);
			out1.WriteShort((int)this.field_2_yBasis);
			out1.WriteShort((int)this.field_3_heightBasis);
			out1.WriteShort((int)this.field_4_scale);
			out1.WriteShort((int)this.field_5_indexToFontTable);
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x00018662 File Offset: 0x00016862
		protected override int DataSize
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x0007F71E File Offset: 0x0007D91E
		public override short Sid
		{
			get
			{
				return 4192;
			}
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x000847A0 File Offset: 0x000829A0
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.FontBasisRecord
			{
				field_1_xBasis = this.field_1_xBasis,
				field_2_yBasis = this.field_2_yBasis,
				field_3_heightBasis = this.field_3_heightBasis,
				field_4_scale = this.field_4_scale,
				field_5_indexToFontTable = this.field_5_indexToFontTable
			};
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06002C9A RID: 11418 RVA: 0x000847EE File Offset: 0x000829EE
		// (set) Token: 0x06002C9B RID: 11419 RVA: 0x000847F6 File Offset: 0x000829F6
		public short XBasis
		{
			get
			{
				return this.field_1_xBasis;
			}
			set
			{
				this.field_1_xBasis = value;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06002C9C RID: 11420 RVA: 0x000847FF File Offset: 0x000829FF
		// (set) Token: 0x06002C9D RID: 11421 RVA: 0x00084807 File Offset: 0x00082A07
		public short YBasis
		{
			get
			{
				return this.field_2_yBasis;
			}
			set
			{
				this.field_2_yBasis = value;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06002C9E RID: 11422 RVA: 0x00084810 File Offset: 0x00082A10
		// (set) Token: 0x06002C9F RID: 11423 RVA: 0x00084818 File Offset: 0x00082A18
		public short HeightBasis
		{
			get
			{
				return this.field_3_heightBasis;
			}
			set
			{
				this.field_3_heightBasis = value;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06002CA0 RID: 11424 RVA: 0x00084821 File Offset: 0x00082A21
		// (set) Token: 0x06002CA1 RID: 11425 RVA: 0x00084829 File Offset: 0x00082A29
		public short Scale
		{
			get
			{
				return this.field_4_scale;
			}
			set
			{
				this.field_4_scale = value;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06002CA2 RID: 11426 RVA: 0x00084832 File Offset: 0x00082A32
		// (set) Token: 0x06002CA3 RID: 11427 RVA: 0x0008483A File Offset: 0x00082A3A
		public short IndexToFontTable
		{
			get
			{
				return this.field_5_indexToFontTable;
			}
			set
			{
				this.field_5_indexToFontTable = value;
			}
		}

		// Token: 0x04001373 RID: 4979
		public const short sid = 4192;

		// Token: 0x04001374 RID: 4980
		private short field_1_xBasis;

		// Token: 0x04001375 RID: 4981
		private short field_2_yBasis;

		// Token: 0x04001376 RID: 4982
		private short field_3_heightBasis;

		// Token: 0x04001377 RID: 4983
		private short field_4_scale;

		// Token: 0x04001378 RID: 4984
		private short field_5_indexToFontTable;
	}
}
