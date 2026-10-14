using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200049B RID: 1179
	public class AreaFormatRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002BC3 RID: 11203 RVA: 0x0008204F File Offset: 0x0008024F
		public AreaFormatRecord()
		{
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00082070 File Offset: 0x00080270
		public AreaFormatRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_foregroundColor = in1.ReadInt();
			this.field_2_backgroundColor = in1.ReadInt();
			this.field_3_pattern = in1.ReadShort();
			this.field_4_formatFlags = in1.ReadShort();
			this.field_5_forecolorIndex = in1.ReadShort();
			this.field_6_backcolorIndex = in1.ReadShort();
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000820E4 File Offset: 0x000802E4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[AREAFORMAT]\n");
			stringBuilder.Append("    .foregroundColor      = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.ForegroundColor)).Append(" (").Append(this.ForegroundColor).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .backgroundColor      = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.BackgroundColor)).Append(" (").Append(this.BackgroundColor).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .pattern              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Pattern)).Append(" (").Append(this.Pattern).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .formatFlags          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.FormatFlags)).Append(" (").Append(this.FormatFlags).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .automatic                = ").Append(this.IsAutomatic).Append('\n');
			stringBuilder.Append("         .invert                   = ").Append(this.IsInvert).Append('\n');
			stringBuilder.Append("    .forecolorIndex       = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.ForecolorIndex)).Append(" (").Append(this.ForecolorIndex).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .backcolorIndex       = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.BackcolorIndex)).Append(" (").Append(this.BackcolorIndex).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/AREAFORMAT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x00082338 File Offset: 0x00080538
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.field_1_foregroundColor);
			out1.WriteInt(this.field_2_backgroundColor);
			out1.WriteShort((int)this.field_3_pattern);
			out1.WriteShort((int)this.field_4_formatFlags);
			out1.WriteShort((int)this.field_5_forecolorIndex);
			out1.WriteShort((int)this.field_6_backcolorIndex);
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		protected override int DataSize
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x0008238D File Offset: 0x0008058D
		public override short Sid
		{
			get
			{
				return 4106;
			}
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x00082394 File Offset: 0x00080594
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.AreaFormatRecord
			{
				field_1_foregroundColor = this.field_1_foregroundColor,
				field_2_backgroundColor = this.field_2_backgroundColor,
				field_3_pattern = this.field_3_pattern,
				field_4_formatFlags = this.field_4_formatFlags,
				field_5_forecolorIndex = this.field_5_forecolorIndex,
				field_6_backcolorIndex = this.field_6_backcolorIndex
			};
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x000823EE File Offset: 0x000805EE
		// (set) Token: 0x06002BCB RID: 11211 RVA: 0x000823F6 File Offset: 0x000805F6
		public int ForegroundColor
		{
			get
			{
				return this.field_1_foregroundColor;
			}
			set
			{
				this.field_1_foregroundColor = value;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x000823FF File Offset: 0x000805FF
		// (set) Token: 0x06002BCD RID: 11213 RVA: 0x00082407 File Offset: 0x00080607
		public int BackgroundColor
		{
			get
			{
				return this.field_2_backgroundColor;
			}
			set
			{
				this.field_2_backgroundColor = value;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x00082410 File Offset: 0x00080610
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x00082418 File Offset: 0x00080618
		public short Pattern
		{
			get
			{
				return this.field_3_pattern;
			}
			set
			{
				this.field_3_pattern = value;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x00082421 File Offset: 0x00080621
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x00082429 File Offset: 0x00080629
		public short FormatFlags
		{
			get
			{
				return this.field_4_formatFlags;
			}
			set
			{
				this.field_4_formatFlags = value;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x00082432 File Offset: 0x00080632
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x0008243A File Offset: 0x0008063A
		public short ForecolorIndex
		{
			get
			{
				return this.field_5_forecolorIndex;
			}
			set
			{
				this.field_5_forecolorIndex = value;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x00082443 File Offset: 0x00080643
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x0008244B File Offset: 0x0008064B
		public short BackcolorIndex
		{
			get
			{
				return this.field_6_backcolorIndex;
			}
			set
			{
				this.field_6_backcolorIndex = value;
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x00082454 File Offset: 0x00080654
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x00082467 File Offset: 0x00080667
		public bool IsAutomatic
		{
			get
			{
				return this.automatic.IsSet((int)this.field_4_formatFlags);
			}
			set
			{
				this.field_4_formatFlags = this.automatic.SetShortBoolean(this.field_4_formatFlags, value);
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x00082481 File Offset: 0x00080681
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x00082494 File Offset: 0x00080694
		public bool IsInvert
		{
			get
			{
				return this.invert.IsSet((int)this.field_4_formatFlags);
			}
			set
			{
				this.field_4_formatFlags = this.invert.SetShortBoolean(this.field_4_formatFlags, value);
			}
		}

		// Token: 0x040012FA RID: 4858
		public const short FILL_PATTERN_NONE = 0;

		// Token: 0x040012FB RID: 4859
		public const short FILL_PATTERN_SOLID = 1;

		// Token: 0x040012FC RID: 4860
		public const short FILL_PATTERN_MEDIUM_GRAY = 2;

		// Token: 0x040012FD RID: 4861
		public const short FILL_PATTERN_DARK_GRAY = 3;

		// Token: 0x040012FE RID: 4862
		public const short FILL_PATTERN_LIGHT_GRAY = 4;

		// Token: 0x040012FF RID: 4863
		public const short FILL_PATTERN_HORIZONTAL_STRIPES = 5;

		// Token: 0x04001300 RID: 4864
		public const short FILL_PATTERN_VERTICAL_STRIPES = 6;

		// Token: 0x04001301 RID: 4865
		public const short FILL_PATTERN_DOWNWARD_DIAGONAL_STRIPES = 7;

		// Token: 0x04001302 RID: 4866
		public const short FILL_PATTERN_UPWARD_DIAGONAL_STRIPES = 8;

		// Token: 0x04001303 RID: 4867
		public const short FILL_PATTERN_GRID = 9;

		// Token: 0x04001304 RID: 4868
		public const short FILL_PATTERN_TRELLIS = 10;

		// Token: 0x04001305 RID: 4869
		public const short FILL_PATTERN_LIGHT_HORIZONTAL_STRIPES = 11;

		// Token: 0x04001306 RID: 4870
		public const short FILL_PATTERN_LIGHT_VERTICAL_STRIPES = 12;

		// Token: 0x04001307 RID: 4871
		public const short FILL_PATTERN_LIGHTDOWN = 13;

		// Token: 0x04001308 RID: 4872
		public const short FILL_PATTERN_LIGHTUP = 14;

		// Token: 0x04001309 RID: 4873
		public const short FILL_PATTERN_LIGHT_GRID = 15;

		// Token: 0x0400130A RID: 4874
		public const short FILL_PATTERN_LIGHT_TRELLIS = 16;

		// Token: 0x0400130B RID: 4875
		public const short FILL_PATTERN_GRAYSCALE_1_8 = 17;

		// Token: 0x0400130C RID: 4876
		public const short FILL_PATTERN_GRAYSCALE_1_16 = 18;

		// Token: 0x0400130D RID: 4877
		public const short sid = 4106;

		// Token: 0x0400130E RID: 4878
		private int field_1_foregroundColor;

		// Token: 0x0400130F RID: 4879
		private int field_2_backgroundColor;

		// Token: 0x04001310 RID: 4880
		private short field_3_pattern;

		// Token: 0x04001311 RID: 4881
		private short field_4_formatFlags;

		// Token: 0x04001312 RID: 4882
		private global::NPOI.Util.BitField automatic = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001313 RID: 4883
		private global::NPOI.Util.BitField invert = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04001314 RID: 4884
		private short field_5_forecolorIndex;

		// Token: 0x04001315 RID: 4885
		private short field_6_backcolorIndex;
	}
}
