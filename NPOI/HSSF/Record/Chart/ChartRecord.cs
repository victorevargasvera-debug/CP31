using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004A5 RID: 1189
	public class ChartRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002C40 RID: 11328 RVA: 0x0005FE49 File Offset: 0x0005E049
		public ChartRecord()
		{
		}

		// Token: 0x06002C41 RID: 11329 RVA: 0x00083838 File Offset: 0x00081A38
		public ChartRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_x = in1.ReadInt();
			this.field_2_y = in1.ReadInt();
			this.field_3_width = in1.ReadInt();
			this.field_4_height = in1.ReadInt();
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x00083870 File Offset: 0x00081A70
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CHART]\n");
			stringBuilder.Append("    .x                    = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.X)).Append(" (").Append(this.X).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .y                    = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Y)).Append(" (").Append(this.Y).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .width                = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Width)).Append(" (").Append(this.Width).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("    .height               = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.Height)).Append(" (").Append(this.Height).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/CHART]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x000839E3 File Offset: 0x00081BE3
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.field_1_x);
			out1.WriteInt(this.field_2_y);
			out1.WriteInt(this.field_3_width);
			out1.WriteInt(this.field_4_height);
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		protected override int DataSize
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x00083A15 File Offset: 0x00081C15
		public override short Sid
		{
			get
			{
				return 4098;
			}
		}

		// Token: 0x06002C46 RID: 11334 RVA: 0x00083A1C File Offset: 0x00081C1C
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.ChartRecord
			{
				field_1_x = this.field_1_x,
				field_2_y = this.field_2_y,
				field_3_width = this.field_3_width,
				field_4_height = this.field_4_height
			};
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x00083A53 File Offset: 0x00081C53
		// (set) Token: 0x06002C48 RID: 11336 RVA: 0x00083A5B File Offset: 0x00081C5B
		public int X
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

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x00083A64 File Offset: 0x00081C64
		// (set) Token: 0x06002C4A RID: 11338 RVA: 0x00083A6C File Offset: 0x00081C6C
		public int Y
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

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002C4B RID: 11339 RVA: 0x00083A75 File Offset: 0x00081C75
		// (set) Token: 0x06002C4C RID: 11340 RVA: 0x00083A7D File Offset: 0x00081C7D
		public int Width
		{
			get
			{
				return this.field_3_width;
			}
			set
			{
				this.field_3_width = value;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x00083A86 File Offset: 0x00081C86
		// (set) Token: 0x06002C4E RID: 11342 RVA: 0x00083A8E File Offset: 0x00081C8E
		public int Height
		{
			get
			{
				return this.field_4_height;
			}
			set
			{
				this.field_4_height = value;
			}
		}

		// Token: 0x0400134D RID: 4941
		public const short sid = 4098;

		// Token: 0x0400134E RID: 4942
		private int field_1_x;

		// Token: 0x0400134F RID: 4943
		private int field_2_y;

		// Token: 0x04001350 RID: 4944
		private int field_3_width;

		// Token: 0x04001351 RID: 4945
		private int field_4_height;
	}
}
