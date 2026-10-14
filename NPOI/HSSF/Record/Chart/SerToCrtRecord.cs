using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x0200048B RID: 1163
	public class SerToCrtRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002AF0 RID: 10992 RVA: 0x0005FE49 File Offset: 0x0005E049
		public SerToCrtRecord()
		{
		}

		// Token: 0x06002AF1 RID: 10993 RVA: 0x0007FCCF File Offset: 0x0007DECF
		public SerToCrtRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_chartGroupIndex = in1.ReadShort();
		}

		// Token: 0x06002AF2 RID: 10994 RVA: 0x0007FCE4 File Offset: 0x0007DEE4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SERTOCRT]\n");
			stringBuilder.Append("    .chartGroupIndex      = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.ChartGroupIndex)).Append(" (").Append(this.ChartGroupIndex).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/SERTOCRT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002AF3 RID: 10995 RVA: 0x0007FD64 File Offset: 0x0007DF64
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_chartGroupIndex);
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002AF4 RID: 10996 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002AF5 RID: 10997 RVA: 0x0007FD72 File Offset: 0x0007DF72
		public override short Sid
		{
			get
			{
				return 4165;
			}
		}

		// Token: 0x06002AF6 RID: 10998 RVA: 0x0007FD79 File Offset: 0x0007DF79
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.SerToCrtRecord
			{
				field_1_chartGroupIndex = this.field_1_chartGroupIndex
			};
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002AF7 RID: 10999 RVA: 0x0007FD8C File Offset: 0x0007DF8C
		// (set) Token: 0x06002AF8 RID: 11000 RVA: 0x0007FD94 File Offset: 0x0007DF94
		public short ChartGroupIndex
		{
			get
			{
				return this.field_1_chartGroupIndex;
			}
			set
			{
				this.field_1_chartGroupIndex = value;
			}
		}

		// Token: 0x0400128B RID: 4747
		public const short sid = 4165;

		// Token: 0x0400128C RID: 4748
		private short field_1_chartGroupIndex;
	}
}
