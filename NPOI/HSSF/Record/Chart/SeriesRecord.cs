using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004BB RID: 1211
	public class SeriesRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002D58 RID: 11608 RVA: 0x0005FE49 File Offset: 0x0005E049
		public SeriesRecord()
		{
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x0008624C File Offset: 0x0008444C
		public SeriesRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_categoryDataType = in1.ReadShort();
			this.field_2_valuesDataType = in1.ReadShort();
			this.field_3_numCategories = in1.ReadShort();
			this.field_4_numValues = in1.ReadShort();
			this.field_5_bubbleSeriesType = in1.ReadShort();
			this.field_6_numBubbleValues = in1.ReadShort();
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x000862A8 File Offset: 0x000844A8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SERIES]\n");
			stringBuilder.Append("    .categoryDataType     = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.CategoryDataType)).Append(" (").Append(this.CategoryDataType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .valuesDataType       = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.ValuesDataType)).Append(" (").Append(this.ValuesDataType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .numCategories        = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.NumCategories)).Append(" (").Append(this.NumCategories).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .numValues            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.NumValues)).Append(" (").Append(this.NumValues).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .bubbleSeriesType     = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.BubbleSeriesType)).Append(" (").Append(this.BubbleSeriesType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .numBubbleValues      = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.NumBubbleValues)).Append(" (").Append(this.NumBubbleValues).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/SERIES]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x000864C0 File Offset: 0x000846C0
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_categoryDataType);
			out1.WriteShort((int)this.field_2_valuesDataType);
			out1.WriteShort((int)this.field_3_numCategories);
			out1.WriteShort((int)this.field_4_numValues);
			out1.WriteShort((int)this.field_5_bubbleSeriesType);
			out1.WriteShort((int)this.field_6_numBubbleValues);
		}

		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x000184AD File Offset: 0x000166AD
		protected override int DataSize
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x00086515 File Offset: 0x00084715
		public override short Sid
		{
			get
			{
				return 4099;
			}
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x0008651C File Offset: 0x0008471C
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.SeriesRecord
			{
				field_1_categoryDataType = this.field_1_categoryDataType,
				field_2_valuesDataType = this.field_2_valuesDataType,
				field_3_numCategories = this.field_3_numCategories,
				field_4_numValues = this.field_4_numValues,
				field_5_bubbleSeriesType = this.field_5_bubbleSeriesType,
				field_6_numBubbleValues = this.field_6_numBubbleValues
			};
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x00086576 File Offset: 0x00084776
		// (set) Token: 0x06002D60 RID: 11616 RVA: 0x0008657E File Offset: 0x0008477E
		public short CategoryDataType
		{
			get
			{
				return this.field_1_categoryDataType;
			}
			set
			{
				this.field_1_categoryDataType = value;
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x00086587 File Offset: 0x00084787
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x0008658F File Offset: 0x0008478F
		public short ValuesDataType
		{
			get
			{
				return this.field_2_valuesDataType;
			}
			set
			{
				this.field_2_valuesDataType = value;
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x00086598 File Offset: 0x00084798
		// (set) Token: 0x06002D64 RID: 11620 RVA: 0x000865A0 File Offset: 0x000847A0
		public short NumCategories
		{
			get
			{
				return this.field_3_numCategories;
			}
			set
			{
				this.field_3_numCategories = value;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x000865A9 File Offset: 0x000847A9
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x000865B1 File Offset: 0x000847B1
		public short NumValues
		{
			get
			{
				return this.field_4_numValues;
			}
			set
			{
				this.field_4_numValues = value;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x000865BA File Offset: 0x000847BA
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x000865C2 File Offset: 0x000847C2
		public short BubbleSeriesType
		{
			get
			{
				return this.field_5_bubbleSeriesType;
			}
			set
			{
				this.field_5_bubbleSeriesType = value;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x000865CB File Offset: 0x000847CB
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x000865D3 File Offset: 0x000847D3
		public short NumBubbleValues
		{
			get
			{
				return this.field_6_numBubbleValues;
			}
			set
			{
				this.field_6_numBubbleValues = value;
			}
		}

		// Token: 0x040013D7 RID: 5079
		public const short sid = 4099;

		// Token: 0x040013D8 RID: 5080
		private short field_1_categoryDataType;

		// Token: 0x040013D9 RID: 5081
		public const short CATEGORY_DATA_TYPE_DATES = 0;

		// Token: 0x040013DA RID: 5082
		public const short CATEGORY_DATA_TYPE_NUMERIC = 1;

		// Token: 0x040013DB RID: 5083
		public const short CATEGORY_DATA_TYPE_SEQUENCE = 2;

		// Token: 0x040013DC RID: 5084
		public const short CATEGORY_DATA_TYPE_TEXT = 3;

		// Token: 0x040013DD RID: 5085
		private short field_2_valuesDataType;

		// Token: 0x040013DE RID: 5086
		public const short VALUES_DATA_TYPE_DATES = 0;

		// Token: 0x040013DF RID: 5087
		public const short VALUES_DATA_TYPE_NUMERIC = 1;

		// Token: 0x040013E0 RID: 5088
		public const short VALUES_DATA_TYPE_SEQUENCE = 2;

		// Token: 0x040013E1 RID: 5089
		public const short VALUES_DATA_TYPE_TEXT = 3;

		// Token: 0x040013E2 RID: 5090
		private short field_3_numCategories;

		// Token: 0x040013E3 RID: 5091
		private short field_4_numValues;

		// Token: 0x040013E4 RID: 5092
		private short field_5_bubbleSeriesType;

		// Token: 0x040013E5 RID: 5093
		public const short BUBBLE_SERIES_TYPE_DATES = 0;

		// Token: 0x040013E6 RID: 5094
		public const short BUBBLE_SERIES_TYPE_NUMERIC = 1;

		// Token: 0x040013E7 RID: 5095
		public const short BUBBLE_SERIES_TYPE_SEQUENCE = 2;

		// Token: 0x040013E8 RID: 5096
		public const short BUBBLE_SERIES_TYPE_TEXT = 3;

		// Token: 0x040013E9 RID: 5097
		private short field_6_numBubbleValues;
	}
}
