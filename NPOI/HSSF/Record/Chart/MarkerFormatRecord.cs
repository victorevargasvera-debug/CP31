using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000497 RID: 1175
	public class MarkerFormatRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x00018AA0 File Offset: 0x00016CA0
		protected override int DataSize
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x00081888 File Offset: 0x0007FA88
		public MarkerFormatRecord()
		{
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x000818B8 File Offset: 0x0007FAB8
		public MarkerFormatRecord(global::NPOI.HSSF.Record.RecordInputStream ris)
		{
			this.field_1_rgbFore = ris.ReadInt();
			this.field_2_rgbBack = ris.ReadInt();
			this.field_3_imk = ris.ReadShort();
			this.field_4_flag = ris.ReadShort();
			this.field_5_icvFore = ris.ReadShort();
			this.field_6_icvBack = ris.ReadShort();
			this.field_7_miSize = ris.ReadInt();
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x00081948 File Offset: 0x0007FB48
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.field_1_rgbFore);
			out1.WriteInt(this.field_2_rgbBack);
			out1.WriteShort((int)this.field_3_imk);
			out1.WriteShort((int)this.field_4_flag);
			out1.WriteShort((int)this.field_5_icvFore);
			out1.WriteShort((int)this.field_6_icvBack);
			out1.WriteInt(this.field_7_miSize);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x000819AC File Offset: 0x0007FBAC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[MARKERFORMAT]").AppendLine().Append("   .rgbFore          =").Append(global::NPOI.Util.HexDump.ToHex(this.field_1_rgbFore)).Append("(").Append(this.field_1_rgbFore).AppendLine(")").Append("   .rgbBack          =").Append(global::NPOI.Util.HexDump.ToHex(this.field_2_rgbBack)).Append("(").Append(this.field_2_rgbBack).AppendLine(")").Append("   .imk              =").Append(global::NPOI.Util.HexDump.ToHex(this.field_3_imk)).Append("(").Append(this.field_3_imk).AppendLine(")").Append("   .flag             =").Append(global::NPOI.Util.HexDump.ToHex(this.field_4_flag)).Append("(").Append(this.field_4_flag).AppendLine(")").Append("       .fAuto        =").Append(this.Auto).AppendLine().Append("       .fNotShowInt  =").Append(this.NotShowInt).AppendLine().Append("       .fNotShowBrd  =").Append(this.NotShowBorder).AppendLine().Append("   .icvFore          =").Append(global::NPOI.Util.HexDump.ToHex(this.field_5_icvFore)).Append("(").Append(this.field_5_icvFore).AppendLine(")").Append("   .icvBack          =").Append(global::NPOI.Util.HexDump.ToHex(this.field_6_icvBack)).Append("(").Append(this.field_6_icvBack).AppendLine(")").Append("   .miSize           =").Append(global::NPOI.Util.HexDump.ToHex(this.field_7_miSize)).Append("(").Append(this.field_7_miSize).AppendLine(")").AppendLine("[/MARKERFORMAT]");
			return stringBuilder.ToString();
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x00081BBC File Offset: 0x0007FDBC
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.MarkerFormatRecord
			{
				Auto = this.Auto,
				DataMarkerType = this.DataMarkerType,
				IcvBack = this.IcvBack,
				IcvFore = this.IcvFore,
				NotShowBorder = this.NotShowBorder,
				NotShowInt = this.NotShowInt,
				RGBBack = this.RGBBack,
				RGBFore = this.RGBFore,
				Size = this.Size
			};
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x00081C3A File Offset: 0x0007FE3A
		public override short Sid
		{
			get
			{
				return 4105;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x00081C41 File Offset: 0x0007FE41
		// (set) Token: 0x06002B9A RID: 11162 RVA: 0x00081C49 File Offset: 0x0007FE49
		public int RGBFore
		{
			get
			{
				return this.field_1_rgbFore;
			}
			set
			{
				this.field_1_rgbFore = value;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x00081C52 File Offset: 0x0007FE52
		// (set) Token: 0x06002B9C RID: 11164 RVA: 0x00081C5A File Offset: 0x0007FE5A
		public int RGBBack
		{
			get
			{
				return this.field_2_rgbBack;
			}
			set
			{
				this.field_2_rgbBack = value;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002B9D RID: 11165 RVA: 0x00081C63 File Offset: 0x0007FE63
		// (set) Token: 0x06002B9E RID: 11166 RVA: 0x00081C6B File Offset: 0x0007FE6B
		public short DataMarkerType
		{
			get
			{
				return this.field_3_imk;
			}
			set
			{
				this.field_3_imk = value;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x00081C74 File Offset: 0x0007FE74
		// (set) Token: 0x06002BA0 RID: 11168 RVA: 0x00081C87 File Offset: 0x0007FE87
		public bool Auto
		{
			get
			{
				return this.fAuto.IsSet((int)this.field_4_flag);
			}
			set
			{
				this.field_4_flag = this.fAuto.SetShortBoolean(this.field_4_flag, value);
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x00081CA1 File Offset: 0x0007FEA1
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x00081CB4 File Offset: 0x0007FEB4
		public bool NotShowInt
		{
			get
			{
				return this.fNotShowInt.IsSet((int)this.field_4_flag);
			}
			set
			{
				this.field_4_flag = this.fNotShowInt.SetShortBoolean(this.field_4_flag, value);
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x00081CCE File Offset: 0x0007FECE
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x00081CE1 File Offset: 0x0007FEE1
		public bool NotShowBorder
		{
			get
			{
				return this.fNotShowBrd.IsSet((int)this.field_4_flag);
			}
			set
			{
				this.field_4_flag = this.fNotShowBrd.SetShortBoolean(this.field_4_flag, value);
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002BA5 RID: 11173 RVA: 0x00081CFB File Offset: 0x0007FEFB
		// (set) Token: 0x06002BA6 RID: 11174 RVA: 0x00081D03 File Offset: 0x0007FF03
		public short IcvFore
		{
			get
			{
				return this.field_5_icvFore;
			}
			set
			{
				this.field_5_icvFore = value;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x00081D0C File Offset: 0x0007FF0C
		// (set) Token: 0x06002BA8 RID: 11176 RVA: 0x00081D14 File Offset: 0x0007FF14
		public short IcvBack
		{
			get
			{
				return this.field_6_icvBack;
			}
			set
			{
				this.field_6_icvBack = value;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x00081D1D File Offset: 0x0007FF1D
		// (set) Token: 0x06002BAA RID: 11178 RVA: 0x00081D25 File Offset: 0x0007FF25
		public int Size
		{
			get
			{
				return this.field_7_miSize;
			}
			set
			{
				this.field_7_miSize = value;
			}
		}

		// Token: 0x040012DC RID: 4828
		public const short sid = 4105;

		// Token: 0x040012DD RID: 4829
		private int field_1_rgbFore;

		// Token: 0x040012DE RID: 4830
		private int field_2_rgbBack;

		// Token: 0x040012DF RID: 4831
		private short field_3_imk;

		// Token: 0x040012E0 RID: 4832
		private short field_4_flag;

		// Token: 0x040012E1 RID: 4833
		private short field_5_icvFore;

		// Token: 0x040012E2 RID: 4834
		private short field_6_icvBack;

		// Token: 0x040012E3 RID: 4835
		private int field_7_miSize;

		// Token: 0x040012E4 RID: 4836
		private global::NPOI.Util.BitField fAuto = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040012E5 RID: 4837
		private global::NPOI.Util.BitField fNotShowInt = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x040012E6 RID: 4838
		private global::NPOI.Util.BitField fNotShowBrd = global::NPOI.Util.BitFieldFactory.GetInstance(32);
	}
}
