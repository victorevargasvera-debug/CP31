using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200046E RID: 1134
	public class CategorySeriesAxisRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002A1B RID: 10779 RVA: 0x0005FE49 File Offset: 0x0005E049
		public CategorySeriesAxisRecord()
		{
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x0007E7C4 File Offset: 0x0007C9C4
		public CategorySeriesAxisRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_crossingPoint = in1.ReadShort();
			this.field_2_labelFrequency = in1.ReadShort();
			this.field_3_tickMarkFrequency = in1.ReadShort();
			this.field_4_options = in1.ReadShort();
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x0007E7FC File Offset: 0x0007C9FC
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CATSERRANGE]\n");
			stringBuilder.Append("    .crossingPoint        = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.CrossingPoint)).Append(" (").Append(this.CrossingPoint).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .labelFrequency       = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.LabelFrequency)).Append(" (").Append(this.LabelFrequency).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .tickMarkFrequency    = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.TickMarkFrequency)).Append(" (").Append(this.TickMarkFrequency).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .options              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Options)).Append(" (").Append(this.Options).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .valueAxisCrossing        = ").Append(this.IsValueAxisCrossing).Append('\n');
			stringBuilder.Append("         .crossesFarRight          = ").Append(this.IsCrossesFarRight).Append('\n');
			stringBuilder.Append("         .reversed                 = ").Append(this.IsReversed).Append('\n');
			stringBuilder.Append("[/CATSERRANGE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x0007E9C9 File Offset: 0x0007CBC9
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_crossingPoint);
			out1.WriteShort((int)this.field_2_labelFrequency);
			out1.WriteShort((int)this.field_3_tickMarkFrequency);
			out1.WriteShort((int)this.field_4_options);
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x00017DF4 File Offset: 0x00015FF4
		protected override int DataSize
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002A20 RID: 10784 RVA: 0x0007E9FB File Offset: 0x0007CBFB
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.CategorySeriesAxisRecord.sid;
			}
		}

		// Token: 0x06002A21 RID: 10785 RVA: 0x0007EA02 File Offset: 0x0007CC02
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.CategorySeriesAxisRecord
			{
				field_1_crossingPoint = this.field_1_crossingPoint,
				field_2_labelFrequency = this.field_2_labelFrequency,
				field_3_tickMarkFrequency = this.field_3_tickMarkFrequency,
				field_4_options = this.field_4_options
			};
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002A22 RID: 10786 RVA: 0x0007EA39 File Offset: 0x0007CC39
		// (set) Token: 0x06002A23 RID: 10787 RVA: 0x0007EA41 File Offset: 0x0007CC41
		public short CrossingPoint
		{
			get
			{
				return this.field_1_crossingPoint;
			}
			set
			{
				this.field_1_crossingPoint = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x0007EA4A File Offset: 0x0007CC4A
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x0007EA52 File Offset: 0x0007CC52
		public short LabelFrequency
		{
			get
			{
				return this.field_2_labelFrequency;
			}
			set
			{
				this.field_2_labelFrequency = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x0007EA5B File Offset: 0x0007CC5B
		// (set) Token: 0x06002A27 RID: 10791 RVA: 0x0007EA63 File Offset: 0x0007CC63
		public short TickMarkFrequency
		{
			get
			{
				return this.field_3_tickMarkFrequency;
			}
			set
			{
				this.field_3_tickMarkFrequency = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x0007EA6C File Offset: 0x0007CC6C
		// (set) Token: 0x06002A29 RID: 10793 RVA: 0x0007EA74 File Offset: 0x0007CC74
		public short Options
		{
			get
			{
				return this.field_4_options;
			}
			set
			{
				this.field_4_options = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x0007EA7D File Offset: 0x0007CC7D
		// (set) Token: 0x06002A2B RID: 10795 RVA: 0x0007EA8F File Offset: 0x0007CC8F
		public bool IsValueAxisCrossing
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.CategorySeriesAxisRecord.valueAxisCrossing.IsSet((int)this.field_4_options);
			}
			set
			{
				this.field_4_options = global::NPOI.HSSF.Record.Chart.CategorySeriesAxisRecord.valueAxisCrossing.SetShortBoolean(this.field_4_options, value);
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x0007EAA8 File Offset: 0x0007CCA8
		// (set) Token: 0x06002A2D RID: 10797 RVA: 0x0007EABA File Offset: 0x0007CCBA
		public bool IsCrossesFarRight
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.CategorySeriesAxisRecord.crossesFarRight.IsSet((int)this.field_4_options);
			}
			set
			{
				this.field_4_options = global::NPOI.HSSF.Record.Chart.CategorySeriesAxisRecord.crossesFarRight.SetShortBoolean(this.field_4_options, value);
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002A2E RID: 10798 RVA: 0x0007EAD3 File Offset: 0x0007CCD3
		// (set) Token: 0x06002A2F RID: 10799 RVA: 0x0007EAE5 File Offset: 0x0007CCE5
		public bool IsReversed
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.CategorySeriesAxisRecord.reversed.IsSet((int)this.field_4_options);
			}
			set
			{
				this.field_4_options = global::NPOI.HSSF.Record.Chart.CategorySeriesAxisRecord.reversed.SetShortBoolean(this.field_4_options, value);
			}
		}

		// Token: 0x04001238 RID: 4664
		public static short sid = 4128;

		// Token: 0x04001239 RID: 4665
		private static global::NPOI.Util.BitField valueAxisCrossing = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x0400123A RID: 4666
		private static global::NPOI.Util.BitField crossesFarRight = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x0400123B RID: 4667
		private static global::NPOI.Util.BitField reversed = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x0400123C RID: 4668
		private short field_1_crossingPoint;

		// Token: 0x0400123D RID: 4669
		private short field_2_labelFrequency;

		// Token: 0x0400123E RID: 4670
		private short field_3_tickMarkFrequency;

		// Token: 0x0400123F RID: 4671
		private short field_4_options;
	}
}
