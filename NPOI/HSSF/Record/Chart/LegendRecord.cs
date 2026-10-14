using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004AF RID: 1199
	public class LegendRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002CB3 RID: 11443 RVA: 0x00084A68 File Offset: 0x00082C68
		public LegendRecord()
		{
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x00084AC8 File Offset: 0x00082CC8
		public LegendRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_xAxisUpperLeft = in1.ReadInt();
			this.field_2_yAxisUpperLeft = in1.ReadInt();
			this.field_3_xSize = in1.ReadInt();
			this.field_4_ySize = in1.ReadInt();
			this.field_5_type = (byte)in1.ReadByte();
			this.field_6_spacing = (byte)in1.ReadByte();
			this.field_7_options = in1.ReadShort();
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x00084B7C File Offset: 0x00082D7C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[LEGEND]\n");
			stringBuilder.Append("    .xAxisUpperLeft       = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.XAxisUpperLeft)).Append(" (").Append(this.XAxisUpperLeft).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .yAxisUpperLeft       = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.YAxisUpperLeft)).Append(" (").Append(this.YAxisUpperLeft).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .xSize                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.XSize)).Append(" (").Append(this.XSize).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .ySize                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.YSize)).Append(" (").Append(this.YSize).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .type                 = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Type)).Append(" (").Append(this.Type).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .spacing              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Spacing)).Append(" (").Append(this.Spacing).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .options              = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Options)).Append(" (").Append(this.Options).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("         .autoPosition             = ").Append(this.IsAutoPosition).Append('\n');
			stringBuilder.Append("         .autoSeries               = ").Append(this.IsAutoSeries).Append('\n');
			stringBuilder.Append("         .autoXPositioning         = ").Append(this.IsAutoXPositioning).Append('\n');
			stringBuilder.Append("         .autoYPositioning         = ").Append(this.IsAutoYPositioning).Append('\n');
			stringBuilder.Append("         .vertical                 = ").Append(this.IsVertical).Append('\n');
			stringBuilder.Append("         .dataTable                = ").Append(this.IsDataTable).Append('\n');
			stringBuilder.Append("[/LEGEND]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x00084E98 File Offset: 0x00083098
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.field_1_xAxisUpperLeft);
			out1.WriteInt(this.field_2_yAxisUpperLeft);
			out1.WriteInt(this.field_3_xSize);
			out1.WriteInt(this.field_4_ySize);
			out1.WriteByte((int)this.field_5_type);
			out1.WriteByte((int)this.field_6_spacing);
			out1.WriteShort((int)this.field_7_options);
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x00018AA0 File Offset: 0x00016CA0
		protected override int DataSize
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x00084EF9 File Offset: 0x000830F9
		public override short Sid
		{
			get
			{
				return 4117;
			}
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x00084F00 File Offset: 0x00083100
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.LegendRecord
			{
				field_1_xAxisUpperLeft = this.field_1_xAxisUpperLeft,
				field_2_yAxisUpperLeft = this.field_2_yAxisUpperLeft,
				field_3_xSize = this.field_3_xSize,
				field_4_ySize = this.field_4_ySize,
				field_5_type = this.field_5_type,
				field_6_spacing = this.field_6_spacing,
				field_7_options = this.field_7_options
			};
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06002CBA RID: 11450 RVA: 0x00084F66 File Offset: 0x00083166
		// (set) Token: 0x06002CBB RID: 11451 RVA: 0x00084F6E File Offset: 0x0008316E
		public int XAxisUpperLeft
		{
			get
			{
				return this.field_1_xAxisUpperLeft;
			}
			set
			{
				this.field_1_xAxisUpperLeft = value;
			}
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002CBC RID: 11452 RVA: 0x00084F77 File Offset: 0x00083177
		// (set) Token: 0x06002CBD RID: 11453 RVA: 0x00084F7F File Offset: 0x0008317F
		public int YAxisUpperLeft
		{
			get
			{
				return this.field_2_yAxisUpperLeft;
			}
			set
			{
				this.field_2_yAxisUpperLeft = value;
			}
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002CBE RID: 11454 RVA: 0x00084F88 File Offset: 0x00083188
		// (set) Token: 0x06002CBF RID: 11455 RVA: 0x00084F90 File Offset: 0x00083190
		public int XSize
		{
			get
			{
				return this.field_3_xSize;
			}
			set
			{
				this.field_3_xSize = value;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002CC0 RID: 11456 RVA: 0x00084F99 File Offset: 0x00083199
		// (set) Token: 0x06002CC1 RID: 11457 RVA: 0x00084FA1 File Offset: 0x000831A1
		public int YSize
		{
			get
			{
				return this.field_4_ySize;
			}
			set
			{
				this.field_4_ySize = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x00084FAA File Offset: 0x000831AA
		// (set) Token: 0x06002CC3 RID: 11459 RVA: 0x00084FB2 File Offset: 0x000831B2
		public byte Type
		{
			get
			{
				return this.field_5_type;
			}
			set
			{
				this.field_5_type = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x00084FBB File Offset: 0x000831BB
		// (set) Token: 0x06002CC5 RID: 11461 RVA: 0x00084FC3 File Offset: 0x000831C3
		public byte Spacing
		{
			get
			{
				return this.field_6_spacing;
			}
			set
			{
				this.field_6_spacing = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x00084FCC File Offset: 0x000831CC
		// (set) Token: 0x06002CC7 RID: 11463 RVA: 0x00084FD4 File Offset: 0x000831D4
		public short Options
		{
			get
			{
				return this.field_7_options;
			}
			set
			{
				this.field_7_options = value;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x00084FDD File Offset: 0x000831DD
		// (set) Token: 0x06002CC9 RID: 11465 RVA: 0x00084FF0 File Offset: 0x000831F0
		public bool IsAutoPosition
		{
			get
			{
				return this.autoPosition.IsSet((int)this.field_7_options);
			}
			set
			{
				this.field_7_options = this.autoPosition.SetShortBoolean(this.field_7_options, value);
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x06002CCA RID: 11466 RVA: 0x0008500A File Offset: 0x0008320A
		// (set) Token: 0x06002CCB RID: 11467 RVA: 0x0008501D File Offset: 0x0008321D
		public bool IsAutoSeries
		{
			get
			{
				return this.autoSeries.IsSet((int)this.field_7_options);
			}
			set
			{
				this.field_7_options = this.autoSeries.SetShortBoolean(this.field_7_options, value);
			}
		}

		// Token: 0x17000B9E RID: 2974
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x00085037 File Offset: 0x00083237
		// (set) Token: 0x06002CCD RID: 11469 RVA: 0x0008504A File Offset: 0x0008324A
		public bool IsAutoXPositioning
		{
			get
			{
				return this.autoXPositioning.IsSet((int)this.field_7_options);
			}
			set
			{
				this.field_7_options = this.autoXPositioning.SetShortBoolean(this.field_7_options, value);
			}
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x00085064 File Offset: 0x00083264
		// (set) Token: 0x06002CCF RID: 11471 RVA: 0x00085077 File Offset: 0x00083277
		public bool IsAutoYPositioning
		{
			get
			{
				return this.autoYPositioning.IsSet((int)this.field_7_options);
			}
			set
			{
				this.field_7_options = this.autoYPositioning.SetShortBoolean(this.field_7_options, value);
			}
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x00085091 File Offset: 0x00083291
		// (set) Token: 0x06002CD1 RID: 11473 RVA: 0x000850A4 File Offset: 0x000832A4
		public bool IsVertical
		{
			get
			{
				return this.vertical.IsSet((int)this.field_7_options);
			}
			set
			{
				this.field_7_options = this.vertical.SetShortBoolean(this.field_7_options, value);
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x000850BE File Offset: 0x000832BE
		// (set) Token: 0x06002CD3 RID: 11475 RVA: 0x000850D1 File Offset: 0x000832D1
		public bool IsDataTable
		{
			get
			{
				return this.dataTable.IsSet((int)this.field_7_options);
			}
			set
			{
				this.field_7_options = this.dataTable.SetShortBoolean(this.field_7_options, value);
			}
		}

		// Token: 0x04001380 RID: 4992
		public const short sid = 4117;

		// Token: 0x04001381 RID: 4993
		private int field_1_xAxisUpperLeft;

		// Token: 0x04001382 RID: 4994
		private int field_2_yAxisUpperLeft;

		// Token: 0x04001383 RID: 4995
		private int field_3_xSize;

		// Token: 0x04001384 RID: 4996
		private int field_4_ySize;

		// Token: 0x04001385 RID: 4997
		private byte field_5_type;

		// Token: 0x04001386 RID: 4998
		public const byte TYPE_BOTTOM = 0;

		// Token: 0x04001387 RID: 4999
		public const byte TYPE_CORNER = 1;

		// Token: 0x04001388 RID: 5000
		public const byte TYPE_TOP = 2;

		// Token: 0x04001389 RID: 5001
		public const byte TYPE_RIGHT = 3;

		// Token: 0x0400138A RID: 5002
		public const byte TYPE_LEFT = 4;

		// Token: 0x0400138B RID: 5003
		public const byte TYPE_UNDOCKED = 7;

		// Token: 0x0400138C RID: 5004
		private byte field_6_spacing;

		// Token: 0x0400138D RID: 5005
		public const byte SPACING_CLOSE = 0;

		// Token: 0x0400138E RID: 5006
		public const byte SPACING_MEDIUM = 1;

		// Token: 0x0400138F RID: 5007
		public const byte SPACING_OPEN = 2;

		// Token: 0x04001390 RID: 5008
		private short field_7_options;

		// Token: 0x04001391 RID: 5009
		private global::NPOI.Util.BitField autoPosition = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001392 RID: 5010
		private global::NPOI.Util.BitField autoSeries = global::NPOI.Util.BitFieldFactory.GetInstance(2);

		// Token: 0x04001393 RID: 5011
		private global::NPOI.Util.BitField autoXPositioning = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04001394 RID: 5012
		private global::NPOI.Util.BitField autoYPositioning = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04001395 RID: 5013
		private global::NPOI.Util.BitField vertical = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04001396 RID: 5014
		private global::NPOI.Util.BitField dataTable = global::NPOI.Util.BitFieldFactory.GetInstance(32);
	}
}
