using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000402 RID: 1026
	public class PaneRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002542 RID: 9538 RVA: 0x0005FE49 File Offset: 0x0005E049
		public PaneRecord()
		{
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x000703C0 File Offset: 0x0006E5C0
		public PaneRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_x = in1.ReadShort();
			this.field_2_y = in1.ReadShort();
			this.field_3_topRow = in1.ReadShort();
			this.field_4_leftColumn = in1.ReadShort();
			this.field_5_activePane = in1.ReadShort();
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x00070410 File Offset: 0x0006E610
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PANE]\n");
			stringBuilder.Append("    .x                    = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.X)).Append(" (").Append(this.X).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .y                    = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Y)).Append(" (").Append(this.Y).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .topRow               = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.TopRow)).Append(" (").Append(this.TopRow).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .leftColumn           = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.LeftColumn)).Append(" (").Append(this.LeftColumn).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .activePane           = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.ActivePane)).Append(" (").Append(this.ActivePane).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/PANE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x000705D4 File Offset: 0x0006E7D4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_x);
			out1.WriteShort((int)this.field_2_y);
			out1.WriteShort((int)this.field_3_topRow);
			out1.WriteShort((int)this.field_4_leftColumn);
			out1.WriteShort((int)this.field_5_activePane);
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x00018662 File Offset: 0x00016862
		protected override int DataSize
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x00070612 File Offset: 0x0006E812
		public override short Sid
		{
			get
			{
				return 65;
			}
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x00070618 File Offset: 0x0006E818
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.PaneRecord
			{
				field_1_x = this.field_1_x,
				field_2_y = this.field_2_y,
				field_3_topRow = this.field_3_topRow,
				field_4_leftColumn = this.field_4_leftColumn,
				field_5_activePane = this.field_5_activePane
			};
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x00070666 File Offset: 0x0006E866
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x0007066E File Offset: 0x0006E86E
		public short X
		{
			get
			{
				return this.field_1_x;
			}
			set
			{
				this.field_1_x = value;
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x00070677 File Offset: 0x0006E877
		// (set) Token: 0x0600254C RID: 9548 RVA: 0x0007067F File Offset: 0x0006E87F
		public short Y
		{
			get
			{
				return this.field_2_y;
			}
			set
			{
				this.field_2_y = value;
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x00070688 File Offset: 0x0006E888
		// (set) Token: 0x0600254E RID: 9550 RVA: 0x00070690 File Offset: 0x0006E890
		public short TopRow
		{
			get
			{
				return this.field_3_topRow;
			}
			set
			{
				this.field_3_topRow = value;
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x00070699 File Offset: 0x0006E899
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x000706A1 File Offset: 0x0006E8A1
		public short LeftColumn
		{
			get
			{
				return this.field_4_leftColumn;
			}
			set
			{
				this.field_4_leftColumn = value;
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x000706AA File Offset: 0x0006E8AA
		// (set) Token: 0x06002552 RID: 9554 RVA: 0x000706B2 File Offset: 0x0006E8B2
		public short ActivePane
		{
			get
			{
				return this.field_5_activePane;
			}
			set
			{
				this.field_5_activePane = value;
			}
		}

		// Token: 0x04000FAB RID: 4011
		public const short sid = 65;

		// Token: 0x04000FAC RID: 4012
		private short field_1_x;

		// Token: 0x04000FAD RID: 4013
		private short field_2_y;

		// Token: 0x04000FAE RID: 4014
		private short field_3_topRow;

		// Token: 0x04000FAF RID: 4015
		private short field_4_leftColumn;

		// Token: 0x04000FB0 RID: 4016
		private short field_5_activePane;

		// Token: 0x04000FB1 RID: 4017
		public const short ACTIVE_PANE_LOWER_RIGHT = 0;

		// Token: 0x04000FB2 RID: 4018
		public const short ACTIVE_PANE_UPPER_RIGHT = 1;

		// Token: 0x04000FB3 RID: 4019
		public const short ACTIVE_PANE_LOWER_LEFT = 2;

		// Token: 0x04000FB4 RID: 4020
		public const short ACTIVE_PANE_UPPER_LEFT = 3;
	}
}
