using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004B0 RID: 1200
	public class LineFormatRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002CD4 RID: 11476 RVA: 0x000850EB File Offset: 0x000832EB
		public LineFormatRecord()
		{
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x00085118 File Offset: 0x00083318
		public LineFormatRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_lineColor = in1.ReadInt();
			this.field_2_linePattern = in1.ReadShort();
			this.field_3_weight = in1.ReadShort();
			this.field_4_format = in1.ReadShort();
			this.field_5_colourPaletteIndex = in1.ReadShort();
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x0008518C File Offset: 0x0008338C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[LINEFORMAT]\n");
			stringBuilder.Append("    .lineColor            = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.LineColor)).Append(" (").Append(this.LineColor).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .linePattern          = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.LinePattern)).Append(" (").Append(this.LinePattern).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .weight               = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Weight)).Append(" (").Append(this.Weight).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .format               = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Format)).Append(" (").Append(this.Format).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .auto                     = ").Append(this.IsAuto).Append('\n');
			stringBuilder.Append("         .drawTicks                = ").Append(this.IsDrawTicks).Append('\n');
			stringBuilder.Append("         .unknown                  = ").Append(this.IsUnknown).Append('\n');
			stringBuilder.Append("    .colourPaletteIndex   = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.ColourPaletteIndex)).Append(" (").Append(this.ColourPaletteIndex).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/LINEFORMAT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x000853AA File Offset: 0x000835AA
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.field_1_lineColor);
			out1.WriteShort((int)this.field_2_linePattern);
			out1.WriteShort((int)this.field_3_weight);
			out1.WriteShort((int)this.field_4_format);
			out1.WriteShort((int)this.field_5_colourPaletteIndex);
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x000184AD File Offset: 0x000166AD
		protected override int DataSize
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x000853E8 File Offset: 0x000835E8
		public override short Sid
		{
			get
			{
				return 4103;
			}
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x000853F0 File Offset: 0x000835F0
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.LineFormatRecord
			{
				field_1_lineColor = this.field_1_lineColor,
				field_2_linePattern = this.field_2_linePattern,
				field_3_weight = this.field_3_weight,
				field_4_format = this.field_4_format,
				field_5_colourPaletteIndex = this.field_5_colourPaletteIndex
			};
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x0008543E File Offset: 0x0008363E
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x00085446 File Offset: 0x00083646
		public int LineColor
		{
			get
			{
				return this.field_1_lineColor;
			}
			set
			{
				this.field_1_lineColor = value;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x0008544F File Offset: 0x0008364F
		// (set) Token: 0x06002CDE RID: 11486 RVA: 0x00085457 File Offset: 0x00083657
		public short LinePattern
		{
			get
			{
				return this.field_2_linePattern;
			}
			set
			{
				this.field_2_linePattern = value;
				if (value == 5)
				{
					this.field_3_weight = -1;
					this.field_5_colourPaletteIndex = 77;
				}
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x00085473 File Offset: 0x00083673
		// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x0008547B File Offset: 0x0008367B
		public short Weight
		{
			get
			{
				return this.field_3_weight;
			}
			set
			{
				this.field_3_weight = value;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x00085484 File Offset: 0x00083684
		// (set) Token: 0x06002CE2 RID: 11490 RVA: 0x0008548C File Offset: 0x0008368C
		public short Format
		{
			get
			{
				return this.field_4_format;
			}
			set
			{
				this.field_4_format = value;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x00085495 File Offset: 0x00083695
		// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x0008549D File Offset: 0x0008369D
		public short ColourPaletteIndex
		{
			get
			{
				return this.field_5_colourPaletteIndex;
			}
			set
			{
				this.field_5_colourPaletteIndex = value;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x000854A6 File Offset: 0x000836A6
		// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x000854B9 File Offset: 0x000836B9
		public bool IsAuto
		{
			get
			{
				return this.auto.IsSet((int)this.field_4_format);
			}
			set
			{
				this.field_4_format = this.auto.SetShortBoolean(this.field_4_format, value);
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x000854D3 File Offset: 0x000836D3
		// (set) Token: 0x06002CE8 RID: 11496 RVA: 0x000854E6 File Offset: 0x000836E6
		public bool IsDrawTicks
		{
			get
			{
				return this.drawTicks.IsSet((int)this.field_4_format);
			}
			set
			{
				this.field_4_format = this.drawTicks.SetShortBoolean(this.field_4_format, value);
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x00085500 File Offset: 0x00083700
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x00085513 File Offset: 0x00083713
		public bool IsUnknown
		{
			get
			{
				return this.Unknown.IsSet((int)this.field_4_format);
			}
			set
			{
				this.field_4_format = this.Unknown.SetShortBoolean(this.field_4_format, value);
			}
		}

		// Token: 0x04001397 RID: 5015
		public const short sid = 4103;

		// Token: 0x04001398 RID: 5016
		private int field_1_lineColor;

		// Token: 0x04001399 RID: 5017
		private short field_2_linePattern;

		// Token: 0x0400139A RID: 5018
		public const short LINE_PATTERN_SOLID = 0;

		// Token: 0x0400139B RID: 5019
		public const short LINE_PATTERN_DASH = 1;

		// Token: 0x0400139C RID: 5020
		public const short LINE_PATTERN_DOT = 2;

		// Token: 0x0400139D RID: 5021
		public const short LINE_PATTERN_DASH_DOT = 3;

		// Token: 0x0400139E RID: 5022
		public const short LINE_PATTERN_DASH_DOT_DOT = 4;

		// Token: 0x0400139F RID: 5023
		public const short LINE_PATTERN_NONE = 5;

		// Token: 0x040013A0 RID: 5024
		public const short LINE_PATTERN_DARK_GRAY_PATTERN = 6;

		// Token: 0x040013A1 RID: 5025
		public const short LINE_PATTERN_MEDIUM_GRAY_PATTERN = 7;

		// Token: 0x040013A2 RID: 5026
		public const short LINE_PATTERN_LIGHT_GRAY_PATTERN = 8;

		// Token: 0x040013A3 RID: 5027
		private short field_3_weight;

		// Token: 0x040013A4 RID: 5028
		public const short WEIGHT_HAIRLINE = -1;

		// Token: 0x040013A5 RID: 5029
		public const short WEIGHT_NARROW = 0;

		// Token: 0x040013A6 RID: 5030
		public const short WEIGHT_MEDIUM = 1;

		// Token: 0x040013A7 RID: 5031
		public const short WEIGHT_WIDE = 2;

		// Token: 0x040013A8 RID: 5032
		private short field_4_format;

		// Token: 0x040013A9 RID: 5033
		private global::NPOI.Util.BitField auto = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x040013AA RID: 5034
		private global::NPOI.Util.BitField drawTicks = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x040013AB RID: 5035
		private global::NPOI.Util.BitField Unknown = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x040013AC RID: 5036
		private short field_5_colourPaletteIndex;
	}
}
