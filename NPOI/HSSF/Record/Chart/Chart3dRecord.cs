using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x02000492 RID: 1170
	public class Chart3dRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002B32 RID: 11058 RVA: 0x00080414 File Offset: 0x0007E614
		public Chart3dRecord()
		{
		}

		// Token: 0x06002B33 RID: 11059 RVA: 0x00080474 File Offset: 0x0007E674
		public Chart3dRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_anRot = in1.ReadShort();
			this.field_2_anElev = in1.ReadShort();
			this.field_3_pcDist = in1.ReadShort();
			this.field_4_pcHeight = in1.ReadShort();
			this.field_5_pcDepth = in1.ReadShort();
			this.field_6_pcGap = in1.ReadShort();
			this.field_7_option = in1.ReadShort();
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x00018987 File Offset: 0x00016B87
		protected override int DataSize
		{
			get
			{
				return 14;
			}
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x00080528 File Offset: 0x0007E728
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_anRot);
			out1.WriteShort((int)this.field_2_anElev);
			out1.WriteShort((int)this.field_3_pcDist);
			out1.WriteShort((int)this.field_4_pcHeight);
			out1.WriteShort((int)this.field_5_pcDepth);
			out1.WriteShort((int)this.field_6_pcGap);
			out1.WriteShort((int)this.field_7_option);
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002B36 RID: 11062 RVA: 0x00080589 File Offset: 0x0007E789
		public override short Sid
		{
			get
			{
				return 4154;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002B37 RID: 11063 RVA: 0x00080590 File Offset: 0x0007E790
		// (set) Token: 0x06002B38 RID: 11064 RVA: 0x00080598 File Offset: 0x0007E798
		public int Rotation
		{
			get
			{
				return (int)this.field_1_anRot;
			}
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				if (value > 360)
				{
					value = 360;
				}
				this.field_1_anRot = (short)value;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x000805B8 File Offset: 0x0007E7B8
		// (set) Token: 0x06002B3A RID: 11066 RVA: 0x000805C0 File Offset: 0x0007E7C0
		public int Elev
		{
			get
			{
				return (int)this.field_2_anElev;
			}
			set
			{
				if (value < -90)
				{
					value = -90;
				}
				if (value > 90)
				{
					value = 90;
				}
				this.field_2_anElev = (short)value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000805DC File Offset: 0x0007E7DC
		// (set) Token: 0x06002B3C RID: 11068 RVA: 0x000805E4 File Offset: 0x0007E7E4
		public int Dist
		{
			get
			{
				return (int)this.field_3_pcDist;
			}
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				if (value > 200)
				{
					value = 200;
				}
				this.field_3_pcDist = (short)value;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x00080604 File Offset: 0x0007E804
		// (set) Token: 0x06002B3E RID: 11070 RVA: 0x0008060C File Offset: 0x0007E80C
		public int Height
		{
			get
			{
				return (int)this.field_4_pcHeight;
			}
			set
			{
				this.field_4_pcHeight = (short)value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x00080616 File Offset: 0x0007E816
		// (set) Token: 0x06002B40 RID: 11072 RVA: 0x0008061E File Offset: 0x0007E81E
		public int Depth
		{
			get
			{
				return (int)this.field_5_pcDepth;
			}
			set
			{
				this.field_5_pcDepth = (short)value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002B41 RID: 11073 RVA: 0x00080628 File Offset: 0x0007E828
		// (set) Token: 0x06002B42 RID: 11074 RVA: 0x00080630 File Offset: 0x0007E830
		public int Gap
		{
			get
			{
				return (int)this.field_6_pcGap;
			}
			set
			{
				this.field_6_pcGap = (short)value;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x0008063A File Offset: 0x0007E83A
		// (set) Token: 0x06002B44 RID: 11076 RVA: 0x0008064D File Offset: 0x0007E84D
		public bool IsPerspective
		{
			get
			{
				return this.fPerspective.IsSet((int)this.field_7_option);
			}
			set
			{
				this.field_7_option = this.fPerspective.SetShortBoolean(this.field_7_option, value);
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002B45 RID: 11077 RVA: 0x00080667 File Offset: 0x0007E867
		// (set) Token: 0x06002B46 RID: 11078 RVA: 0x0008067A File Offset: 0x0007E87A
		public bool IsCluster
		{
			get
			{
				return this.fCluster.IsSet((int)this.field_7_option);
			}
			set
			{
				this.field_7_option = this.fCluster.SetShortBoolean(this.field_7_option, value);
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002B47 RID: 11079 RVA: 0x00080694 File Offset: 0x0007E894
		// (set) Token: 0x06002B48 RID: 11080 RVA: 0x000806A7 File Offset: 0x0007E8A7
		public bool Is3DScaling
		{
			get
			{
				return this.f3DScaling.IsSet((int)this.field_7_option);
			}
			set
			{
				this.field_7_option = this.f3DScaling.SetShortBoolean(this.field_7_option, value);
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x000806C1 File Offset: 0x0007E8C1
		// (set) Token: 0x06002B4A RID: 11082 RVA: 0x000806D4 File Offset: 0x0007E8D4
		public bool IsNotPieChart
		{
			get
			{
				return this.fNotPieChart.IsSet((int)this.field_7_option);
			}
			set
			{
				this.field_7_option = this.fNotPieChart.SetShortBoolean(this.field_7_option, value);
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x000806EE File Offset: 0x0007E8EE
		// (set) Token: 0x06002B4C RID: 11084 RVA: 0x00080701 File Offset: 0x0007E901
		public bool IsWalls2D
		{
			get
			{
				return this.fWalls2D.IsSet((int)this.field_7_option);
			}
			set
			{
				this.field_7_option = this.fWalls2D.SetShortBoolean(this.field_7_option, value);
			}
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x0008071C File Offset: 0x0007E91C
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.Chart3dRecord
			{
				Depth = this.Depth,
				Dist = this.Dist,
				Elev = this.Elev,
				Height = this.Height,
				Gap = this.Gap,
				Is3DScaling = this.Is3DScaling,
				IsCluster = this.IsCluster,
				IsNotPieChart = this.IsNotPieChart,
				IsPerspective = this.IsPerspective,
				IsWalls2D = this.IsWalls2D,
				Rotation = this.Rotation
			};
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x000807B4 File Offset: 0x0007E9B4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CHART3D]").AppendLine().Append("   .anRot              =").Append(global::NPOI.Util.HexDump.ToHex(this.field_1_anRot)).Append("(").Append(this.field_1_anRot).AppendLine(")").Append("   .anElev             =").Append(global::NPOI.Util.HexDump.ToHex(this.field_2_anElev)).Append("(").Append(this.field_2_anElev).AppendLine(")").Append("   .pcDist             =").Append(global::NPOI.Util.HexDump.ToHex(this.field_3_pcDist)).Append("(").Append(this.field_3_pcDist).AppendLine(")").Append("   .pcHeight           =").Append(global::NPOI.Util.HexDump.ToHex(this.field_4_pcHeight)).Append("(").Append(this.field_4_pcHeight).AppendLine(")").Append("   .pcDepth            =").Append(global::NPOI.Util.HexDump.ToHex(this.field_5_pcDepth)).Append("(").Append(this.field_5_pcDepth).AppendLine(")").Append("   .pcGap              =").Append(global::NPOI.Util.HexDump.ToHex(this.field_6_pcGap)).Append("(").Append(this.field_6_pcGap).AppendLine(")").Append("   .option             =").Append(global::NPOI.Util.HexDump.ToHex(this.field_7_option)).Append("(").Append(this.field_7_option).AppendLine(")").Append("       .fPerspective       =").Append(this.IsPerspective).AppendLine().Append("       .fCluster           =").Append(this.IsCluster).AppendLine().Append("       .f3DScaling         =").Append(this.Is3DScaling).AppendLine().Append("       .fNotPieChart       =").Append(this.IsNotPieChart).AppendLine().Append("       .fWalls2D           =").Append(this.IsWalls2D).AppendLine().AppendLine("[/CHART3D]");
			return stringBuilder.ToString();
		}

		// Token: 0x040012A4 RID: 4772
		public const short sid = 4154;

		// Token: 0x040012A5 RID: 4773
		private short field_1_anRot;

		// Token: 0x040012A6 RID: 4774
		private short field_2_anElev;

		// Token: 0x040012A7 RID: 4775
		private short field_3_pcDist;

		// Token: 0x040012A8 RID: 4776
		private short field_4_pcHeight;

		// Token: 0x040012A9 RID: 4777
		private short field_5_pcDepth;

		// Token: 0x040012AA RID: 4778
		private short field_6_pcGap;

		// Token: 0x040012AB RID: 4779
		private short field_7_option;

		// Token: 0x040012AC RID: 4780
		private global::NPOI.Util.BitField fPerspective = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040012AD RID: 4781
		private global::NPOI.Util.BitField fCluster = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x040012AE RID: 4782
		private global::NPOI.Util.BitField f3DScaling = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x040012AF RID: 4783
		private global::NPOI.Util.BitField reserved1 = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x040012B0 RID: 4784
		private global::NPOI.Util.BitField fNotPieChart = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x040012B1 RID: 4785
		private global::NPOI.Util.BitField fWalls2D = global::NPOI.Util.BitFieldFactory.GetInstance(32);
	}
}
