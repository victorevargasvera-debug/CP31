using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000493 RID: 1171
	public class CrtLayout12ARecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002B4F RID: 11087 RVA: 0x000809F7 File Offset: 0x0007EBF7
		public CrtLayout12ARecord()
		{
			this.frtHeader.rt = 2215;
			this.frtHeader.grbitFrt = 0;
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x00080A28 File Offset: 0x0007EC28
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.CrtLayout12ARecord
			{
				IsLayoutTargetInner = this.IsLayoutTargetInner,
				CheckSum = this.CheckSum,
				DX = this.DX,
				DY = this.DY,
				HeightMode = this.HeightMode,
				WidthMode = this.WidthMode,
				X = this.X,
				XMode = this.XMode,
				Y = this.Y,
				YMode = this.YMode,
				XTL = this.XTL,
				YTL = this.YTL,
				XBR = this.XBR,
				YBR = this.YBR
			};
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x00080AE4 File Offset: 0x0007ECE4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CRTLAYOUT12A]").AppendLine().Append("   .rt               =").Append(global::NPOI.Util.HexDump.ToHex((int)this.frtHeader.rt)).Append("(").Append(this.frtHeader.rt).AppendLine(")").Append("   .grbit            =").Append(global::NPOI.Util.HexDump.ToHex((int)this.frtHeader.grbitFrt)).Append("(").Append(this.frtHeader.grbitFrt).AppendLine(")").Append("   .reserved         =").Append(global::NPOI.Util.HexDump.ToHex(0)).Append("(").Append(0).AppendLine(")").Append("   .dwCheckSum       =").Append(global::NPOI.Util.HexDump.ToHex(this.field_1_dwCheckSum)).Append("(").Append(this.field_1_dwCheckSum).AppendLine(")").Append("   .option           =").Append(global::NPOI.Util.HexDump.ToHex(this.field_2_option)).Append("(").Append(this.field_2_option).AppendLine(")").Append("       .fLayoutTargetInner =").Append(this.IsLayoutTargetInner).AppendLine().Append("   .xTL              =").Append(global::NPOI.Util.HexDump.ToHex(this.field_3_xTL)).Append("(").Append(this.field_3_xTL).AppendLine(")").Append("   .yTL              =").Append(global::NPOI.Util.HexDump.ToHex(this.field_4_yTL)).Append("(").Append(this.field_4_yTL).AppendLine(")").Append("   .xBR              =").Append(global::NPOI.Util.HexDump.ToHex(this.field_5_xBR)).Append("(").Append(this.field_5_xBR).AppendLine(")").Append("   .yBR              =").Append(global::NPOI.Util.HexDump.ToHex(this.field_6_yBR)).Append("(").Append(this.field_6_yBR).AppendLine(")").Append("   .wXMode           =").Append(global::NPOI.Util.HexDump.ToHex(this.field_7_wXMode)).Append("(").Append(this.field_7_wXMode).AppendLine(")").Append("   .wYMode           =").Append(global::NPOI.Util.HexDump.ToHex(this.field_8_wYMode)).Append("(").Append(this.field_8_wYMode).AppendLine(")").Append("   .wWidthMode       =").Append(global::NPOI.Util.HexDump.ToHex(this.field_9_wWidthMode)).Append("(").Append(this.field_9_wWidthMode).AppendLine(")").Append("   .wHeightMode      =").Append(global::NPOI.Util.HexDump.ToHex(this.field_10_wHeightMode)).Append("(").Append(this.field_10_wHeightMode).AppendLine(")").Append("   .x                =").Append(global::NPOI.Util.HexDump.ToHex(global::System.BitConverter.DoubleToInt64Bits(this.field_11_x))).Append("(").Append(this.field_11_x).AppendLine(")").Append("   .y                =").Append(global::NPOI.Util.HexDump.ToHex(global::System.BitConverter.DoubleToInt64Bits(this.field_12_y))).Append("(").Append(this.field_12_y).AppendLine(")").Append("   .dx               =").Append(global::NPOI.Util.HexDump.ToHex(global::System.BitConverter.DoubleToInt64Bits(this.field_13_dx))).Append("(").Append(this.field_13_dx).AppendLine(")").Append("   .dy               =").Append(global::NPOI.Util.HexDump.ToHex(global::System.BitConverter.DoubleToInt64Bits(this.field_14_dy))).Append("(").Append(this.field_14_dy).AppendLine(")").AppendLine("[/CRTLAYOUT12A]");
			return stringBuilder.ToString();
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00080F18 File Offset: 0x0007F118
		public CrtLayout12ARecord(global::NPOI.HSSF.Record.RecordInputStream ris)
		{
			this.frtHeader.rt = (ushort)ris.ReadUShort();
			this.frtHeader.grbitFrt = (ushort)ris.ReadUShort();
			ris.ReadLong();
			this.field_1_dwCheckSum = ris.ReadInt();
			this.field_2_option = ris.ReadShort();
			this.field_3_xTL = ris.ReadShort();
			this.field_4_yTL = ris.ReadShort();
			this.field_5_xBR = ris.ReadShort();
			this.field_6_yBR = ris.ReadShort();
			this.field_7_wXMode = ris.ReadShort();
			this.field_8_wYMode = ris.ReadShort();
			this.field_9_wWidthMode = ris.ReadShort();
			this.field_10_wHeightMode = ris.ReadShort();
			this.field_11_x = ris.ReadDouble();
			this.field_12_y = ris.ReadDouble();
			this.field_13_dx = ris.ReadDouble();
			this.field_14_dy = ris.ReadDouble();
			this.reserved2 = ris.ReadShort();
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x00081016 File Offset: 0x0007F216
		protected override int DataSize
		{
			get
			{
				return 68;
			}
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x0008101C File Offset: 0x0007F21C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.frtHeader.rt);
			out1.WriteShort((int)this.frtHeader.grbitFrt);
			out1.WriteLong(this.frtHeader.reserved);
			out1.WriteInt(this.field_1_dwCheckSum);
			out1.WriteShort((int)this.field_2_option);
			out1.WriteShort((int)this.field_3_xTL);
			out1.WriteShort((int)this.field_4_yTL);
			out1.WriteShort((int)this.field_5_xBR);
			out1.WriteShort((int)this.field_6_yBR);
			out1.WriteShort((int)this.field_7_wXMode);
			out1.WriteShort((int)this.field_8_wYMode);
			out1.WriteShort((int)this.field_9_wWidthMode);
			out1.WriteShort((int)this.field_10_wHeightMode);
			out1.WriteDouble(this.field_11_x);
			out1.WriteDouble(this.field_12_y);
			out1.WriteDouble(this.field_13_dx);
			out1.WriteDouble(this.field_14_dy);
			out1.WriteShort((int)this.reserved2);
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x00081110 File Offset: 0x0007F310
		public override short Sid
		{
			get
			{
				return 2215;
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002B56 RID: 11094 RVA: 0x00081117 File Offset: 0x0007F317
		// (set) Token: 0x06002B57 RID: 11095 RVA: 0x0008112A File Offset: 0x0007F32A
		public bool IsLayoutTargetInner
		{
			get
			{
				return this.fLayoutTargetInner.IsSet((int)this.field_2_option);
			}
			set
			{
				this.field_2_option = this.fLayoutTargetInner.SetShortBoolean(this.field_2_option, value);
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002B58 RID: 11096 RVA: 0x00081144 File Offset: 0x0007F344
		// (set) Token: 0x06002B59 RID: 11097 RVA: 0x0008114C File Offset: 0x0007F34C
		public int CheckSum
		{
			get
			{
				return this.field_1_dwCheckSum;
			}
			set
			{
				this.field_1_dwCheckSum = value;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002B5A RID: 11098 RVA: 0x00081155 File Offset: 0x0007F355
		// (set) Token: 0x06002B5B RID: 11099 RVA: 0x0008115D File Offset: 0x0007F35D
		public short XTL
		{
			get
			{
				return this.field_3_xTL;
			}
			set
			{
				this.field_3_xTL = value;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002B5C RID: 11100 RVA: 0x00081166 File Offset: 0x0007F366
		// (set) Token: 0x06002B5D RID: 11101 RVA: 0x0008116E File Offset: 0x0007F36E
		public short YTL
		{
			get
			{
				return this.field_4_yTL;
			}
			set
			{
				this.field_4_yTL = value;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002B5E RID: 11102 RVA: 0x00081177 File Offset: 0x0007F377
		// (set) Token: 0x06002B5F RID: 11103 RVA: 0x0008117F File Offset: 0x0007F37F
		public short XBR
		{
			get
			{
				return this.field_5_xBR;
			}
			set
			{
				this.field_5_xBR = value;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x00081188 File Offset: 0x0007F388
		// (set) Token: 0x06002B61 RID: 11105 RVA: 0x00081190 File Offset: 0x0007F390
		public short YBR
		{
			get
			{
				return this.field_6_yBR;
			}
			set
			{
				this.field_6_yBR = value;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002B62 RID: 11106 RVA: 0x00081199 File Offset: 0x0007F399
		// (set) Token: 0x06002B63 RID: 11107 RVA: 0x000811A1 File Offset: 0x0007F3A1
		public global::NPOI.HSSF.Record.Chart.CrtLayout12Mode XMode
		{
			get
			{
				return (global::NPOI.HSSF.Record.Chart.CrtLayout12Mode)this.field_7_wXMode;
			}
			set
			{
				this.field_7_wXMode = (short)value;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x000811AA File Offset: 0x0007F3AA
		// (set) Token: 0x06002B65 RID: 11109 RVA: 0x000811B2 File Offset: 0x0007F3B2
		public global::NPOI.HSSF.Record.Chart.CrtLayout12Mode YMode
		{
			get
			{
				return (global::NPOI.HSSF.Record.Chart.CrtLayout12Mode)this.field_8_wYMode;
			}
			set
			{
				this.field_8_wYMode = (short)value;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002B66 RID: 11110 RVA: 0x000811BB File Offset: 0x0007F3BB
		// (set) Token: 0x06002B67 RID: 11111 RVA: 0x000811C3 File Offset: 0x0007F3C3
		public global::NPOI.HSSF.Record.Chart.CrtLayout12Mode WidthMode
		{
			get
			{
				return (global::NPOI.HSSF.Record.Chart.CrtLayout12Mode)this.field_9_wWidthMode;
			}
			set
			{
				this.field_9_wWidthMode = (short)value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002B68 RID: 11112 RVA: 0x000811CC File Offset: 0x0007F3CC
		// (set) Token: 0x06002B69 RID: 11113 RVA: 0x000811D4 File Offset: 0x0007F3D4
		public global::NPOI.HSSF.Record.Chart.CrtLayout12Mode HeightMode
		{
			get
			{
				return (global::NPOI.HSSF.Record.Chart.CrtLayout12Mode)this.field_10_wHeightMode;
			}
			set
			{
				this.field_10_wHeightMode = (short)value;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002B6A RID: 11114 RVA: 0x000811DD File Offset: 0x0007F3DD
		// (set) Token: 0x06002B6B RID: 11115 RVA: 0x000811E5 File Offset: 0x0007F3E5
		public double X
		{
			get
			{
				return this.field_11_x;
			}
			set
			{
				this.field_11_x = value;
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002B6C RID: 11116 RVA: 0x000811EE File Offset: 0x0007F3EE
		// (set) Token: 0x06002B6D RID: 11117 RVA: 0x000811F6 File Offset: 0x0007F3F6
		public double Y
		{
			get
			{
				return this.field_12_y;
			}
			set
			{
				this.field_12_y = value;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x000811FF File Offset: 0x0007F3FF
		// (set) Token: 0x06002B6F RID: 11119 RVA: 0x00081207 File Offset: 0x0007F407
		public double DX
		{
			get
			{
				return this.field_13_dx;
			}
			set
			{
				this.field_13_dx = value;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x00081210 File Offset: 0x0007F410
		// (set) Token: 0x06002B71 RID: 11121 RVA: 0x00081218 File Offset: 0x0007F418
		public double DY
		{
			get
			{
				return this.field_14_dy;
			}
			set
			{
				this.field_14_dy = value;
			}
		}

		// Token: 0x040012B2 RID: 4786
		public const short sid = 2215;

		// Token: 0x040012B3 RID: 4787
		private global::NPOI.HSSF.FrtHeader frtHeader;

		// Token: 0x040012B4 RID: 4788
		private int field_1_dwCheckSum;

		// Token: 0x040012B5 RID: 4789
		private short field_2_option;

		// Token: 0x040012B6 RID: 4790
		private short field_3_xTL;

		// Token: 0x040012B7 RID: 4791
		private short field_4_yTL;

		// Token: 0x040012B8 RID: 4792
		private short field_5_xBR;

		// Token: 0x040012B9 RID: 4793
		private short field_6_yBR;

		// Token: 0x040012BA RID: 4794
		private short field_7_wXMode;

		// Token: 0x040012BB RID: 4795
		private short field_8_wYMode;

		// Token: 0x040012BC RID: 4796
		private short field_9_wWidthMode;

		// Token: 0x040012BD RID: 4797
		private short field_10_wHeightMode;

		// Token: 0x040012BE RID: 4798
		private double field_11_x;

		// Token: 0x040012BF RID: 4799
		private double field_12_y;

		// Token: 0x040012C0 RID: 4800
		private double field_13_dx;

		// Token: 0x040012C1 RID: 4801
		private double field_14_dy;

		// Token: 0x040012C2 RID: 4802
		private short reserved2;

		// Token: 0x040012C3 RID: 4803
		private global::NPOI.Util.BitField fLayoutTargetInner = global::NPOI.Util.BitFieldFactory.GetInstance(1);
	}
}
