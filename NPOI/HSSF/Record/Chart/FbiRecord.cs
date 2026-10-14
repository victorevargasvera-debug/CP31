using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200047B RID: 1147
	public class FbiRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002A87 RID: 10887 RVA: 0x0005FE49 File Offset: 0x0005E049
		public FbiRecord()
		{
		}

		// Token: 0x06002A88 RID: 10888 RVA: 0x0007F4CC File Offset: 0x0007D6CC
		public FbiRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_xBasis = in1.ReadShort();
			this.field_2_yBasis = in1.ReadShort();
			this.field_3_heightBasis = in1.ReadShort();
			this.field_4_scale = in1.ReadShort();
			this.field_5_indexToFontTable = in1.ReadShort();
		}

		// Token: 0x06002A89 RID: 10889 RVA: 0x0007F51C File Offset: 0x0007D71C
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

		// Token: 0x06002A8A RID: 10890 RVA: 0x0007F6E0 File Offset: 0x0007D8E0
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_xBasis);
			out1.WriteShort((int)this.field_2_yBasis);
			out1.WriteShort((int)this.field_3_heightBasis);
			out1.WriteShort((int)this.field_4_scale);
			out1.WriteShort((int)this.field_5_indexToFontTable);
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x00018662 File Offset: 0x00016862
		protected override int DataSize
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x0007F71E File Offset: 0x0007D91E
		public override short Sid
		{
			get
			{
				return 4192;
			}
		}

		// Token: 0x06002A8D RID: 10893 RVA: 0x0007F728 File Offset: 0x0007D928
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.FbiRecord
			{
				field_1_xBasis = this.field_1_xBasis,
				field_2_yBasis = this.field_2_yBasis,
				field_3_heightBasis = this.field_3_heightBasis,
				field_4_scale = this.field_4_scale,
				field_5_indexToFontTable = this.field_5_indexToFontTable
			};
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002A8E RID: 10894 RVA: 0x0007F776 File Offset: 0x0007D976
		// (set) Token: 0x06002A8F RID: 10895 RVA: 0x0007F77E File Offset: 0x0007D97E
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

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002A90 RID: 10896 RVA: 0x0007F787 File Offset: 0x0007D987
		// (set) Token: 0x06002A91 RID: 10897 RVA: 0x0007F78F File Offset: 0x0007D98F
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

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002A92 RID: 10898 RVA: 0x0007F798 File Offset: 0x0007D998
		// (set) Token: 0x06002A93 RID: 10899 RVA: 0x0007F7A0 File Offset: 0x0007D9A0
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

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002A94 RID: 10900 RVA: 0x0007F7A9 File Offset: 0x0007D9A9
		// (set) Token: 0x06002A95 RID: 10901 RVA: 0x0007F7B1 File Offset: 0x0007D9B1
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

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002A96 RID: 10902 RVA: 0x0007F7BA File Offset: 0x0007D9BA
		// (set) Token: 0x06002A97 RID: 10903 RVA: 0x0007F7C2 File Offset: 0x0007D9C2
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

		// Token: 0x04001265 RID: 4709
		public const short sid = 4192;

		// Token: 0x04001266 RID: 4710
		private short field_1_xBasis;

		// Token: 0x04001267 RID: 4711
		private short field_2_yBasis;

		// Token: 0x04001268 RID: 4712
		private short field_3_heightBasis;

		// Token: 0x04001269 RID: 4713
		private short field_4_scale;

		// Token: 0x0400126A RID: 4714
		private short field_5_indexToFontTable;
	}
}
