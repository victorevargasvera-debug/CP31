using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004BE RID: 1214
	public class ValueRangeRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002D7F RID: 11647 RVA: 0x00086958 File Offset: 0x00084B58
		public ValueRangeRecord()
		{
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x000869E4 File Offset: 0x00084BE4
		public ValueRangeRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_minimumAxisValue = in1.ReadDouble();
			this.field_2_maximumAxisValue = in1.ReadDouble();
			this.field_3_majorIncrement = in1.ReadDouble();
			this.field_4_minorIncrement = in1.ReadDouble();
			this.field_5_categoryAxisCross = in1.ReadDouble();
			this.field_6_options = in1.ReadShort();
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x00086AB8 File Offset: 0x00084CB8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[VALUERANGE]\n");
			stringBuilder.Append("    .minimumAxisValue     = ").Append(" (").Append(this.MinimumAxisValue).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .maximumAxisValue     = ").Append(" (").Append(this.MaximumAxisValue).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .majorIncrement       = ").Append(" (").Append(this.MajorIncrement).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .minorIncrement       = ").Append(" (").Append(this.MinorIncrement).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .categoryAxisCross    = ").Append(" (").Append(this.CategoryAxisCross).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .options              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Options)).Append(" (").Append(this.Options).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .automaticMinimum         = ").Append(this.IsAutomaticMinimum).Append('\n');
			stringBuilder.Append("         .automaticMaximum         = ").Append(this.IsAutomaticMaximum).Append('\n');
			stringBuilder.Append("         .automaticMajor           = ").Append(this.IsAutomaticMajor).Append('\n');
			stringBuilder.Append("         .automaticMinor           = ").Append(this.IsAutomaticMinor).Append('\n');
			stringBuilder.Append("         .automaticCategoryCrossing     = ").Append(this.IsAutomaticCategoryCrossing).Append('\n');
			stringBuilder.Append("         .logarithmicScale         = ").Append(this.IsLogarithmicScale).Append('\n');
			stringBuilder.Append("         .valuesInReverse          = ").Append(this.IsValuesInReverse).Append('\n');
			stringBuilder.Append("         .crossCategoryAxisAtMaximum     = ").Append(this.IsCrossCategoryAxisAtMaximum).Append('\n');
			stringBuilder.Append("         .reserved                 = ").Append(this.IsReserved).Append('\n');
			stringBuilder.Append("[/VALUERANGE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00086D5C File Offset: 0x00084F5C
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteDouble(this.field_1_minimumAxisValue);
			out1.WriteDouble(this.field_2_maximumAxisValue);
			out1.WriteDouble(this.field_3_majorIncrement);
			out1.WriteDouble(this.field_4_minorIncrement);
			out1.WriteDouble(this.field_5_categoryAxisCross);
			out1.WriteShort((int)this.field_6_options);
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002D83 RID: 11651 RVA: 0x000709C2 File Offset: 0x0006EBC2
		protected override int DataSize
		{
			get
			{
				return 42;
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x00086DB1 File Offset: 0x00084FB1
		public override short Sid
		{
			get
			{
				return 4127;
			}
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00086DB8 File Offset: 0x00084FB8
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.ValueRangeRecord
			{
				field_1_minimumAxisValue = this.field_1_minimumAxisValue,
				field_2_maximumAxisValue = this.field_2_maximumAxisValue,
				field_3_majorIncrement = this.field_3_majorIncrement,
				field_4_minorIncrement = this.field_4_minorIncrement,
				field_5_categoryAxisCross = this.field_5_categoryAxisCross,
				field_6_options = this.field_6_options
			};
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x00086E12 File Offset: 0x00085012
		// (set) Token: 0x06002D87 RID: 11655 RVA: 0x00086E1A File Offset: 0x0008501A
		public double MinimumAxisValue
		{
			get
			{
				return this.field_1_minimumAxisValue;
			}
			set
			{
				this.field_1_minimumAxisValue = value;
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002D88 RID: 11656 RVA: 0x00086E23 File Offset: 0x00085023
		// (set) Token: 0x06002D89 RID: 11657 RVA: 0x00086E2B File Offset: 0x0008502B
		public double MaximumAxisValue
		{
			get
			{
				return this.field_2_maximumAxisValue;
			}
			set
			{
				this.field_2_maximumAxisValue = value;
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x00086E34 File Offset: 0x00085034
		// (set) Token: 0x06002D8B RID: 11659 RVA: 0x00086E3C File Offset: 0x0008503C
		public double MajorIncrement
		{
			get
			{
				return this.field_3_majorIncrement;
			}
			set
			{
				this.field_3_majorIncrement = value;
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x00086E45 File Offset: 0x00085045
		// (set) Token: 0x06002D8D RID: 11661 RVA: 0x00086E4D File Offset: 0x0008504D
		public double MinorIncrement
		{
			get
			{
				return this.field_4_minorIncrement;
			}
			set
			{
				this.field_4_minorIncrement = value;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x00086E56 File Offset: 0x00085056
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x00086E5E File Offset: 0x0008505E
		public double CategoryAxisCross
		{
			get
			{
				return this.field_5_categoryAxisCross;
			}
			set
			{
				this.field_5_categoryAxisCross = value;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x00086E67 File Offset: 0x00085067
		// (set) Token: 0x06002D91 RID: 11665 RVA: 0x00086E6F File Offset: 0x0008506F
		public short Options
		{
			get
			{
				return this.field_6_options;
			}
			set
			{
				this.field_6_options = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x00086E78 File Offset: 0x00085078
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x00086E8B File Offset: 0x0008508B
		public bool IsAutomaticMinimum
		{
			get
			{
				return this.automaticMinimum.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.automaticMinimum.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x00086EA5 File Offset: 0x000850A5
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x00086EB8 File Offset: 0x000850B8
		public bool IsAutomaticMaximum
		{
			get
			{
				return this.automaticMaximum.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.automaticMaximum.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x00086ED2 File Offset: 0x000850D2
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x00086EE5 File Offset: 0x000850E5
		public bool IsAutomaticMajor
		{
			get
			{
				return this.automaticMajor.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.automaticMajor.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x00086EFF File Offset: 0x000850FF
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x00086F12 File Offset: 0x00085112
		public bool IsAutomaticMinor
		{
			get
			{
				return this.automaticMinor.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.automaticMinor.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x00086F2C File Offset: 0x0008512C
		// (set) Token: 0x06002D9B RID: 11675 RVA: 0x00086F3F File Offset: 0x0008513F
		public bool IsAutomaticCategoryCrossing
		{
			get
			{
				return this.automaticCategoryCrossing.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.automaticCategoryCrossing.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x00086F59 File Offset: 0x00085159
		// (set) Token: 0x06002D9D RID: 11677 RVA: 0x00086F6C File Offset: 0x0008516C
		public bool IsLogarithmicScale
		{
			get
			{
				return this.logarithmicScale.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.logarithmicScale.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x00086F86 File Offset: 0x00085186
		// (set) Token: 0x06002D9F RID: 11679 RVA: 0x00086F99 File Offset: 0x00085199
		public bool IsValuesInReverse
		{
			get
			{
				return this.valuesInReverse.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.valuesInReverse.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x00086FB3 File Offset: 0x000851B3
		// (set) Token: 0x06002DA1 RID: 11681 RVA: 0x00086FC6 File Offset: 0x000851C6
		public bool IsCrossCategoryAxisAtMaximum
		{
			get
			{
				return this.crossCategoryAxisAtMaximum.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.crossCategoryAxisAtMaximum.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x00086FE0 File Offset: 0x000851E0
		// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x00086FF3 File Offset: 0x000851F3
		public bool IsReserved
		{
			get
			{
				return this.reserved.IsSet((int)this.field_6_options);
			}
			set
			{
				this.field_6_options = this.reserved.SetShortBoolean(this.field_6_options, value);
			}
		}

		// Token: 0x040013F1 RID: 5105
		public const short sid = 4127;

		// Token: 0x040013F2 RID: 5106
		private double field_1_minimumAxisValue;

		// Token: 0x040013F3 RID: 5107
		private double field_2_maximumAxisValue;

		// Token: 0x040013F4 RID: 5108
		private double field_3_majorIncrement;

		// Token: 0x040013F5 RID: 5109
		private double field_4_minorIncrement;

		// Token: 0x040013F6 RID: 5110
		private double field_5_categoryAxisCross;

		// Token: 0x040013F7 RID: 5111
		private short field_6_options;

		// Token: 0x040013F8 RID: 5112
		private global::NPOI.Util.BitField automaticMinimum = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040013F9 RID: 5113
		private global::NPOI.Util.BitField automaticMaximum = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x040013FA RID: 5114
		private global::NPOI.Util.BitField automaticMajor = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x040013FB RID: 5115
		private global::NPOI.Util.BitField automaticMinor = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x040013FC RID: 5116
		private global::NPOI.Util.BitField automaticCategoryCrossing = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x040013FD RID: 5117
		private global::NPOI.Util.BitField logarithmicScale = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x040013FE RID: 5118
		private global::NPOI.Util.BitField valuesInReverse = global::NPOI.Util.BitFieldFactory.GetInstance(64);

		// Token: 0x040013FF RID: 5119
		private global::NPOI.Util.BitField crossCategoryAxisAtMaximum = global::NPOI.Util.BitFieldFactory.GetInstance(128);

		// Token: 0x04001400 RID: 5120
		private global::NPOI.Util.BitField reserved = global::NPOI.Util.BitFieldFactory.GetInstance(256);
	}
}
