using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000495 RID: 1173
	public class CrtLayout12Record : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002B72 RID: 11122 RVA: 0x00081224 File Offset: 0x0007F424
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CRTLAYOUT12]").AppendLine().Append("   .rt               =").Append(global::NPOI.Util.HexDump.ToHex(this.field_1_frtHeader_rt)).Append("(").Append(this.field_1_frtHeader_rt).AppendLine(")").Append("   .grbit            =").Append(global::NPOI.Util.HexDump.ToHex(this.field_2_frtHeader_grbitFrt)).Append("(").Append(this.field_2_frtHeader_grbitFrt).AppendLine(")").Append("   .reserved         =").Append(global::NPOI.Util.HexDump.ToHex(0)).Append("(").Append(0).AppendLine(")").Append("   .dwCheckSum       =").Append(global::NPOI.Util.HexDump.ToHex(this.field_5_dwCheckSum)).Append("(").Append(this.field_5_dwCheckSum).AppendLine(")").Append("   .option           =").Append(global::NPOI.Util.HexDump.ToHex(this.field_6_option)).Append("(").Append(this.field_6_option).AppendLine(")").Append("       .autolayouttype =").Append(this.autolayouttype.GetValue((int)this.field_6_option)).AppendLine().Append("   .wXMode           =").Append(global::NPOI.Util.HexDump.ToHex(this.field_7_wXMode)).Append("(").Append(this.field_7_wXMode).AppendLine(")").Append("   .wYMode           =").Append(global::NPOI.Util.HexDump.ToHex(this.field_8_wYMode)).Append("(").Append(this.field_8_wYMode).AppendLine(")").Append("   .wWidthMode       =").Append(global::NPOI.Util.HexDump.ToHex(this.field_9_wWidthMode)).Append("(").Append(this.field_9_wWidthMode).AppendLine(")").Append("   .wHeightMode      =").Append(global::NPOI.Util.HexDump.ToHex(this.field_10_wHeightMode)).Append("(").Append(this.field_10_wHeightMode).AppendLine(")").Append("   .x                =").Append(global::NPOI.Util.HexDump.ToHex(global::System.BitConverter.DoubleToInt64Bits(this.field_11_x))).Append("(").Append(this.field_11_x).AppendLine(")").Append("   .y                =").Append(global::NPOI.Util.HexDump.ToHex(global::System.BitConverter.DoubleToInt64Bits(this.field_12_y))).Append("(").Append(this.field_12_y).AppendLine(")").Append("   .dx               =").Append(global::NPOI.Util.HexDump.ToHex(global::System.BitConverter.DoubleToInt64Bits(this.field_13_dx))).Append("(").Append(this.field_13_dx).AppendLine(")").Append("   .dy               =").Append(global::NPOI.Util.HexDump.ToHex(global::System.BitConverter.DoubleToInt64Bits(this.field_14_dy))).Append("(").Append(this.field_14_dy).AppendLine(")").AppendLine("[/CRTLAYOUT12]");
			return stringBuilder.ToString();
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x0008156A File Offset: 0x0007F76A
		public CrtLayout12Record()
		{
			this.field_1_frtHeader_rt = 2205;
			this.field_2_frtHeader_grbitFrt = 0;
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00081594 File Offset: 0x0007F794
		public CrtLayout12Record(global::NPOI.HSSF.Record.RecordInputStream ris)
		{
			this.field_1_frtHeader_rt = ris.ReadShort();
			this.field_2_frtHeader_grbitFrt = ris.ReadShort();
			ris.ReadLong();
			this.field_5_dwCheckSum = ris.ReadInt();
			this.field_6_option = ris.ReadShort();
			this.field_7_wXMode = ris.ReadShort();
			this.field_8_wYMode = ris.ReadShort();
			this.field_9_wWidthMode = ris.ReadShort();
			this.field_10_wHeightMode = ris.ReadShort();
			this.field_11_x = ris.ReadDouble();
			this.field_12_y = ris.ReadDouble();
			this.field_13_dx = ris.ReadDouble();
			this.field_14_dy = ris.ReadDouble();
			ris.ReadShort();
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x00066981 File Offset: 0x00064B81
		protected override int DataSize
		{
			get
			{
				return 60;
			}
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x00081654 File Offset: 0x0007F854
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_frtHeader_rt);
			out1.WriteShort((int)this.field_2_frtHeader_grbitFrt);
			out1.WriteInt(0);
			out1.WriteInt(0);
			out1.WriteInt(this.field_5_dwCheckSum);
			out1.WriteShort((int)this.field_6_option);
			out1.WriteShort((int)this.field_7_wXMode);
			out1.WriteShort((int)this.field_8_wYMode);
			out1.WriteShort((int)this.field_9_wWidthMode);
			out1.WriteShort((int)this.field_10_wHeightMode);
			out1.WriteDouble(this.field_11_x);
			out1.WriteDouble(this.field_12_y);
			out1.WriteDouble(this.field_13_dx);
			out1.WriteDouble(this.field_14_dy);
			out1.WriteShort(0);
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002B77 RID: 11127 RVA: 0x00081706 File Offset: 0x0007F906
		public override short Sid
		{
			get
			{
				return 2205;
			}
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x00081710 File Offset: 0x0007F910
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.CrtLayout12Record
			{
				AutoLayoutType = this.AutoLayoutType,
				CheckSum = this.CheckSum,
				DX = this.DX,
				DY = this.DY,
				HeightMode = this.HeightMode,
				WidthMode = this.WidthMode,
				X = this.X,
				XMode = this.XMode,
				Y = this.Y,
				YMode = this.YMode
			};
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002B79 RID: 11129 RVA: 0x0008179A File Offset: 0x0007F99A
		// (set) Token: 0x06002B7A RID: 11130 RVA: 0x000817AD File Offset: 0x0007F9AD
		public int AutoLayoutType
		{
			get
			{
				return this.autolayouttype.GetValue((int)this.field_6_option);
			}
			set
			{
				this.field_6_option = this.autolayouttype.SetShortValue(this.field_6_option, (short)value);
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002B7B RID: 11131 RVA: 0x000817C8 File Offset: 0x0007F9C8
		// (set) Token: 0x06002B7C RID: 11132 RVA: 0x000817D0 File Offset: 0x0007F9D0
		public int CheckSum
		{
			get
			{
				return this.field_5_dwCheckSum;
			}
			set
			{
				this.field_5_dwCheckSum = value;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x000817D9 File Offset: 0x0007F9D9
		// (set) Token: 0x06002B7E RID: 11134 RVA: 0x000817E1 File Offset: 0x0007F9E1
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

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000817EA File Offset: 0x0007F9EA
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x000817F2 File Offset: 0x0007F9F2
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

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x000817FB File Offset: 0x0007F9FB
		// (set) Token: 0x06002B82 RID: 11138 RVA: 0x00081803 File Offset: 0x0007FA03
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

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x0008180C File Offset: 0x0007FA0C
		// (set) Token: 0x06002B84 RID: 11140 RVA: 0x00081814 File Offset: 0x0007FA14
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

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x0008181D File Offset: 0x0007FA1D
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x00081825 File Offset: 0x0007FA25
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

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002B87 RID: 11143 RVA: 0x0008182E File Offset: 0x0007FA2E
		// (set) Token: 0x06002B88 RID: 11144 RVA: 0x00081836 File Offset: 0x0007FA36
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

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002B89 RID: 11145 RVA: 0x0008183F File Offset: 0x0007FA3F
		// (set) Token: 0x06002B8A RID: 11146 RVA: 0x00081847 File Offset: 0x0007FA47
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

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002B8B RID: 11147 RVA: 0x00081850 File Offset: 0x0007FA50
		// (set) Token: 0x06002B8C RID: 11148 RVA: 0x00081858 File Offset: 0x0007FA58
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

		// Token: 0x040012C8 RID: 4808
		public const short sid = 2205;

		// Token: 0x040012C9 RID: 4809
		private short field_1_frtHeader_rt;

		// Token: 0x040012CA RID: 4810
		private short field_2_frtHeader_grbitFrt;

		// Token: 0x040012CB RID: 4811
		private int field_5_dwCheckSum;

		// Token: 0x040012CC RID: 4812
		private short field_6_option;

		// Token: 0x040012CD RID: 4813
		private short field_7_wXMode;

		// Token: 0x040012CE RID: 4814
		private short field_8_wYMode;

		// Token: 0x040012CF RID: 4815
		private short field_9_wWidthMode;

		// Token: 0x040012D0 RID: 4816
		private short field_10_wHeightMode;

		// Token: 0x040012D1 RID: 4817
		private double field_11_x;

		// Token: 0x040012D2 RID: 4818
		private double field_12_y;

		// Token: 0x040012D3 RID: 4819
		private double field_13_dx;

		// Token: 0x040012D4 RID: 4820
		private double field_14_dy;

		// Token: 0x040012D5 RID: 4821
		public static int AutoLayoutType_Bottom = 0;

		// Token: 0x040012D6 RID: 4822
		public static int AutoLayoutType_TopRightCorner = 1;

		// Token: 0x040012D7 RID: 4823
		public static int AutoLayoutType_Top = 2;

		// Token: 0x040012D8 RID: 4824
		public static int AutoLayoutType_Right = 3;

		// Token: 0x040012D9 RID: 4825
		public static int AutoLayoutType_Left = 4;

		// Token: 0x040012DA RID: 4826
		private global::NPOI.Util.BitField autolayouttype = global::NPOI.Util.BitFieldFactory.GetInstance(30);
	}
}
