using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200049D RID: 1181
	public class AxisParentRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002BE9 RID: 11241 RVA: 0x0005FE49 File Offset: 0x0005E049
		public AxisParentRecord()
		{
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000826B0 File Offset: 0x000808B0
		public AxisParentRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_axisType = in1.ReadShort();
			this.field_2_x = in1.ReadInt();
			this.field_3_y = in1.ReadInt();
			this.field_4_width = in1.ReadInt();
			this.field_5_height = in1.ReadInt();
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00082700 File Offset: 0x00080900
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[AXISPARENT]\n");
			stringBuilder.Append("    .axisType             = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.AxisType)).Append(" (").Append(this.AxisType).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .x                    = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.X)).Append(" (").Append(this.X).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .y                    = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Y)).Append(" (").Append(this.Y).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .width                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Width)).Append(" (").Append(this.Width).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .height               = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Height)).Append(" (").Append(this.Height).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/AXISPARENT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002BEC RID: 11244 RVA: 0x000828C4 File Offset: 0x00080AC4
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_axisType);
			out1.WriteInt(this.field_2_x);
			out1.WriteInt(this.field_3_y);
			out1.WriteInt(this.field_4_width);
			out1.WriteInt(this.field_5_height);
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002BED RID: 11245 RVA: 0x000199E4 File Offset: 0x00017BE4
		protected override int DataSize
		{
			get
			{
				return 18;
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002BEE RID: 11246 RVA: 0x00082902 File Offset: 0x00080B02
		public override short Sid
		{
			get
			{
				return 4161;
			}
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x0008290C File Offset: 0x00080B0C
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.AxisParentRecord
			{
				field_1_axisType = this.field_1_axisType,
				field_2_x = this.field_2_x,
				field_3_y = this.field_3_y,
				field_4_width = this.field_4_width,
				field_5_height = this.field_5_height
			};
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x0008295A File Offset: 0x00080B5A
		// (set) Token: 0x06002BF1 RID: 11249 RVA: 0x00082962 File Offset: 0x00080B62
		public short AxisType
		{
			get
			{
				return this.field_1_axisType;
			}
			set
			{
				this.field_1_axisType = value;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x06002BF2 RID: 11250 RVA: 0x0008296B File Offset: 0x00080B6B
		// (set) Token: 0x06002BF3 RID: 11251 RVA: 0x00082973 File Offset: 0x00080B73
		public int X
		{
			get
			{
				return this.field_2_x;
			}
			set
			{
				this.field_2_x = value;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x06002BF4 RID: 11252 RVA: 0x0008297C File Offset: 0x00080B7C
		// (set) Token: 0x06002BF5 RID: 11253 RVA: 0x00082984 File Offset: 0x00080B84
		public int Y
		{
			get
			{
				return this.field_3_y;
			}
			set
			{
				this.field_3_y = value;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002BF6 RID: 11254 RVA: 0x0008298D File Offset: 0x00080B8D
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x00082995 File Offset: 0x00080B95
		public int Width
		{
			get
			{
				return this.field_4_width;
			}
			set
			{
				this.field_4_width = value;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002BF8 RID: 11256 RVA: 0x0008299E File Offset: 0x00080B9E
		// (set) Token: 0x06002BF9 RID: 11257 RVA: 0x000829A6 File Offset: 0x00080BA6
		public int Height
		{
			get
			{
				return this.field_5_height;
			}
			set
			{
				this.field_5_height = value;
			}
		}

		// Token: 0x0400131B RID: 4891
		public const short sid = 4161;

		// Token: 0x0400131C RID: 4892
		private short field_1_axisType;

		// Token: 0x0400131D RID: 4893
		public const short AXIS_TYPE_MAIN = 0;

		// Token: 0x0400131E RID: 4894
		public const short AXIS_TYPE_SECONDARY = 1;

		// Token: 0x0400131F RID: 4895
		private int field_2_x;

		// Token: 0x04001320 RID: 4896
		private int field_3_y;

		// Token: 0x04001321 RID: 4897
		private int field_4_width;

		// Token: 0x04001322 RID: 4898
		private int field_5_height;
	}
}
