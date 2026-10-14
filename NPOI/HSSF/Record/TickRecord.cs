using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003B9 RID: 953
	public class TickRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x0600214B RID: 8523 RVA: 0x00065B5A File Offset: 0x00063D5A
		public TickRecord()
		{
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00065B94 File Offset: 0x00063D94
		public TickRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_majorTickType = (byte)in1.ReadByte();
			this.field_2_minorTickType = (byte)in1.ReadByte();
			this.field_3_labelPosition = (byte)in1.ReadByte();
			this.field_4_background = (byte)in1.ReadByte();
			this.field_5_labelColorRgb = (int)((byte)in1.ReadInt());
			this.field_6_zero1 = in1.ReadInt();
			this.field_7_zero2 = in1.ReadInt();
			this.field_8_zero3 = in1.ReadInt();
			this.field_9_zero4 = in1.ReadInt();
			this.field_10_options = in1.ReadShort();
			this.field_11_tickColor = in1.ReadShort();
			this.field_12_zero5 = in1.ReadShort();
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x00065C70 File Offset: 0x00063E70
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[TICK]\n");
			stringBuilder.Append("    .majorTickType        = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MajorTickType)).Append(" (").Append(this.MajorTickType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .minorTickType        = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.MinorTickType)).Append(" (").Append(this.MinorTickType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .labelPosition        = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.LabelPosition)).Append(" (").Append(this.LabelPosition).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .background           = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Background)).Append(" (").Append(this.Background).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .labelColorRgb        = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.LabelColorRgb)).Append(" (").Append(this.LabelColorRgb).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .zero1                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Zero1)).Append(" (").Append(this.Zero1).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .zero2                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Zero2)).Append(" (").Append(this.Zero2).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .options              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Options)).Append(" (").Append(this.Options).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .autoTextColor            = ").Append(this.IsAutoTextColor).Append('\n');
			stringBuilder.Append("         .autoTextBackground       = ").Append(this.IsAutoTextBackground).Append('\n');
			stringBuilder.Append("         .rotation                 = ").Append(this.Rotation).Append('\n');
			stringBuilder.Append("         .autorotate               = ").Append(this.IsAutorotate).Append('\n');
			stringBuilder.Append("    .tickColor            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.TickColor)).Append(" (").Append(this.TickColor).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .zero3                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Zero3)).Append(" (").Append(this.Zero3).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/TICK]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x00066044 File Offset: 0x00064244
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteByte((int)this.field_1_majorTickType);
			out1.WriteByte((int)this.field_2_minorTickType);
			out1.WriteByte((int)this.field_3_labelPosition);
			out1.WriteByte((int)this.field_4_background);
			out1.WriteInt(this.field_5_labelColorRgb);
			out1.WriteInt(this.field_6_zero1);
			out1.WriteInt(this.field_7_zero2);
			out1.WriteInt(this.field_8_zero3);
			out1.WriteInt(this.field_9_zero4);
			out1.WriteShort((int)this.field_10_options);
			out1.WriteShort((int)this.field_11_tickColor);
			out1.WriteShort((int)this.field_12_zero5);
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x00020904 File Offset: 0x0001EB04
		protected override int DataSize
		{
			get
			{
				return 30;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002150 RID: 8528 RVA: 0x000660E1 File Offset: 0x000642E1
		public override short Sid
		{
			get
			{
				return 4126;
			}
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x000660E8 File Offset: 0x000642E8
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.TickRecord
			{
				field_1_majorTickType = this.field_1_majorTickType,
				field_2_minorTickType = this.field_2_minorTickType,
				field_3_labelPosition = this.field_3_labelPosition,
				field_4_background = this.field_4_background,
				field_5_labelColorRgb = this.field_5_labelColorRgb,
				field_6_zero1 = this.field_6_zero1,
				field_7_zero2 = this.field_7_zero2,
				field_8_zero3 = this.field_8_zero3,
				field_9_zero4 = this.field_9_zero4,
				field_10_options = this.field_10_options,
				field_11_tickColor = this.field_11_tickColor,
				field_12_zero5 = this.field_12_zero5
			};
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x0006618A File Offset: 0x0006438A
		// (set) Token: 0x06002153 RID: 8531 RVA: 0x00066192 File Offset: 0x00064392
		public byte MajorTickType
		{
			get
			{
				return this.field_1_majorTickType;
			}
			set
			{
				this.field_1_majorTickType = value;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x0006619B File Offset: 0x0006439B
		// (set) Token: 0x06002155 RID: 8533 RVA: 0x000661A3 File Offset: 0x000643A3
		public byte MinorTickType
		{
			get
			{
				return this.field_2_minorTickType;
			}
			set
			{
				this.field_2_minorTickType = value;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x000661AC File Offset: 0x000643AC
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x000661B4 File Offset: 0x000643B4
		public byte LabelPosition
		{
			get
			{
				return this.field_3_labelPosition;
			}
			set
			{
				this.field_3_labelPosition = value;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002158 RID: 8536 RVA: 0x000661BD File Offset: 0x000643BD
		// (set) Token: 0x06002159 RID: 8537 RVA: 0x000661C5 File Offset: 0x000643C5
		public byte Background
		{
			get
			{
				return this.field_4_background;
			}
			set
			{
				this.field_4_background = value;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x0600215A RID: 8538 RVA: 0x000661CE File Offset: 0x000643CE
		// (set) Token: 0x0600215B RID: 8539 RVA: 0x000661D6 File Offset: 0x000643D6
		public int LabelColorRgb
		{
			get
			{
				return this.field_5_labelColorRgb;
			}
			set
			{
				this.field_5_labelColorRgb = value;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x000661DF File Offset: 0x000643DF
		// (set) Token: 0x0600215D RID: 8541 RVA: 0x000661E7 File Offset: 0x000643E7
		public int Zero1
		{
			get
			{
				return this.field_6_zero1;
			}
			set
			{
				this.field_6_zero1 = value;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x000661F0 File Offset: 0x000643F0
		// (set) Token: 0x0600215F RID: 8543 RVA: 0x000661F8 File Offset: 0x000643F8
		public int Zero2
		{
			get
			{
				return this.field_7_zero2;
			}
			set
			{
				this.field_7_zero2 = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x00066201 File Offset: 0x00064401
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x00066209 File Offset: 0x00064409
		public short Options
		{
			get
			{
				return this.field_10_options;
			}
			set
			{
				this.field_10_options = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x00066212 File Offset: 0x00064412
		// (set) Token: 0x06002163 RID: 8547 RVA: 0x0006621A File Offset: 0x0006441A
		public short TickColor
		{
			get
			{
				return this.field_11_tickColor;
			}
			set
			{
				this.field_11_tickColor = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x00066223 File Offset: 0x00064423
		// (set) Token: 0x06002165 RID: 8549 RVA: 0x0006622B File Offset: 0x0006442B
		public short Zero3
		{
			get
			{
				return this.field_12_zero5;
			}
			set
			{
				this.field_12_zero5 = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x00066234 File Offset: 0x00064434
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x00066247 File Offset: 0x00064447
		public bool IsAutoTextColor
		{
			get
			{
				return this.autoTextColor.IsSet((int)this.field_10_options);
			}
			set
			{
				this.field_10_options = this.autoTextColor.SetShortBoolean(this.field_10_options, value);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x00066261 File Offset: 0x00064461
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x00066274 File Offset: 0x00064474
		public bool IsAutoTextBackground
		{
			get
			{
				return this.autoTextBackground.IsSet((int)this.field_10_options);
			}
			set
			{
				this.field_10_options = this.autoTextBackground.SetShortBoolean(this.field_10_options, value);
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x0006628E File Offset: 0x0006448E
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x000662A1 File Offset: 0x000644A1
		public short Rotation
		{
			get
			{
				return this.rotation.GetShortValue(this.field_10_options);
			}
			set
			{
				this.field_10_options = this.rotation.SetShortValue(this.field_10_options, value);
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x0600216C RID: 8556 RVA: 0x000662BB File Offset: 0x000644BB
		// (set) Token: 0x0600216D RID: 8557 RVA: 0x000662CE File Offset: 0x000644CE
		public bool IsAutorotate
		{
			get
			{
				return this.autorotate.IsSet((int)this.field_10_options);
			}
			set
			{
				this.field_10_options = this.autorotate.SetShortBoolean(this.field_10_options, value);
			}
		}

		// Token: 0x04000D13 RID: 3347
		public const short sid = 4126;

		// Token: 0x04000D14 RID: 3348
		private byte field_1_majorTickType;

		// Token: 0x04000D15 RID: 3349
		private byte field_2_minorTickType;

		// Token: 0x04000D16 RID: 3350
		private byte field_3_labelPosition;

		// Token: 0x04000D17 RID: 3351
		private byte field_4_background;

		// Token: 0x04000D18 RID: 3352
		private int field_5_labelColorRgb;

		// Token: 0x04000D19 RID: 3353
		private int field_6_zero1;

		// Token: 0x04000D1A RID: 3354
		private int field_7_zero2;

		// Token: 0x04000D1B RID: 3355
		private int field_8_zero3;

		// Token: 0x04000D1C RID: 3356
		private int field_9_zero4;

		// Token: 0x04000D1D RID: 3357
		private short field_10_options;

		// Token: 0x04000D1E RID: 3358
		private global::NPOI.Util.BitField autoTextColor = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000D1F RID: 3359
		private global::NPOI.Util.BitField autoTextBackground = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04000D20 RID: 3360
		private global::NPOI.Util.BitField rotation = global::NPOI.Util.BitFieldFactory.GetInstance(28);

		// Token: 0x04000D21 RID: 3361
		private global::NPOI.Util.BitField autorotate = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x04000D22 RID: 3362
		private short field_11_tickColor;

		// Token: 0x04000D23 RID: 3363
		private short field_12_zero5;
	}
}
