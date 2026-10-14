using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003B7 RID: 951
	public class ChartFormatRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x060020FF RID: 8447 RVA: 0x00064CBF File Offset: 0x00062EBF
		public ChartFormatRecord()
		{
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x00064CD4 File Offset: 0x00062ED4
		public ChartFormatRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field1_x_position = in1.ReadInt();
			this.field2_y_position = in1.ReadInt();
			this.field3_width = in1.ReadInt();
			this.field4_height = in1.ReadInt();
			this.field5_grbit = in1.ReadShort();
			this.field6_icrt = in1.ReadShort();
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x00064D3C File Offset: 0x00062F3C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[CHARTFORMAT]\n");
			stringBuilder.Append("    .xPosition       = ").Append(this.XPosition).Append("\n");
			stringBuilder.Append("    .yPosition       = ").Append(this.YPosition).Append("\n");
			stringBuilder.Append("    .width           = ").Append(this.Width).Append("\n");
			stringBuilder.Append("    .height          = ").Append(this.Height).Append("\n");
			stringBuilder.Append("    .grBit           = ").Append(global::NPOI.Util.StringUtil.ToHexString(this.field5_grbit)).Append("\n");
			stringBuilder.Append("[/CHARTFORMAT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00064E18 File Offset: 0x00063018
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.XPosition);
			out1.WriteInt(this.YPosition);
			out1.WriteInt(this.Width);
			out1.WriteInt(this.Height);
			out1.WriteShort((int)this.field5_grbit);
			out1.WriteShort((int)this.field6_icrt);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00064E70 File Offset: 0x00063070
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.ChartFormatRecord
			{
				Height = this.Height,
				Icrt = this.Icrt,
				VaryDisplayPattern = this.VaryDisplayPattern,
				Width = this.Width,
				XPosition = this.XPosition,
				YPosition = this.YPosition
			};
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x00018AA0 File Offset: 0x00016CA0
		protected override int DataSize
		{
			get
			{
				return 20;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06002105 RID: 8453 RVA: 0x00064ECA File Offset: 0x000630CA
		public override short Sid
		{
			get
			{
				return 4116;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x00064ED1 File Offset: 0x000630D1
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x00064ED9 File Offset: 0x000630D9
		public int XPosition
		{
			get
			{
				return this.field1_x_position;
			}
			set
			{
				this.field1_x_position = value;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x00064EE2 File Offset: 0x000630E2
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x00064EEA File Offset: 0x000630EA
		public int YPosition
		{
			get
			{
				return this.field2_y_position;
			}
			set
			{
				this.field2_y_position = value;
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x00064EF3 File Offset: 0x000630F3
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x00064EFB File Offset: 0x000630FB
		public int Width
		{
			get
			{
				return this.field3_width;
			}
			set
			{
				this.field3_width = value;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x00064F04 File Offset: 0x00063104
		// (set) Token: 0x0600210D RID: 8461 RVA: 0x00064F0C File Offset: 0x0006310C
		public int Height
		{
			get
			{
				return this.field4_height;
			}
			set
			{
				this.field4_height = value;
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x00064F15 File Offset: 0x00063115
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x00064F1D File Offset: 0x0006311D
		public short Icrt
		{
			get
			{
				return this.field6_icrt;
			}
			set
			{
				this.field6_icrt = value;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x00064F26 File Offset: 0x00063126
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x00064F39 File Offset: 0x00063139
		public bool VaryDisplayPattern
		{
			get
			{
				return this.varyDisplayPattern.IsSet((int)this.field5_grbit);
			}
			set
			{
				this.field5_grbit = this.varyDisplayPattern.SetShortBoolean(this.field5_grbit, value);
			}
		}

		// Token: 0x04000CD3 RID: 3283
		public const short sid = 4116;

		// Token: 0x04000CD4 RID: 3284
		private int field1_x_position;

		// Token: 0x04000CD5 RID: 3285
		private int field2_y_position;

		// Token: 0x04000CD6 RID: 3286
		private int field3_width;

		// Token: 0x04000CD7 RID: 3287
		private int field4_height;

		// Token: 0x04000CD8 RID: 3288
		private short field5_grbit;

		// Token: 0x04000CD9 RID: 3289
		private global::NPOI.Util.BitField varyDisplayPattern = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04000CDA RID: 3290
		private short field6_icrt;
	}
}
