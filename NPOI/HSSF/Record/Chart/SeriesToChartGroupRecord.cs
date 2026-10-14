using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004BD RID: 1213
	[global::System.Obsolete("duplication record, see SerToCrtRecord")]
	public class SeriesToChartGroupRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002D76 RID: 11638 RVA: 0x0005FE49 File Offset: 0x0005E049
		public SeriesToChartGroupRecord()
		{
		}

		// Token: 0x06002D77 RID: 11639 RVA: 0x0008688F File Offset: 0x00084A8F
		public SeriesToChartGroupRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_chartGroupIndex = in1.ReadShort();
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x000868A4 File Offset: 0x00084AA4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SeriesToChartGroup]\n");
			stringBuilder.Append("    .chartGroupIndex      = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.ChartGroupIndex)).Append(" (").Append(this.ChartGroupIndex).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/SeriesToChartGroup]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x00086924 File Offset: 0x00084B24
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_chartGroupIndex);
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06002D7A RID: 11642 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002D7B RID: 11643 RVA: 0x0007FD72 File Offset: 0x0007DF72
		public override short Sid
		{
			get
			{
				return 4165;
			}
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x00086932 File Offset: 0x00084B32
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.SeriesToChartGroupRecord
			{
				field_1_chartGroupIndex = this.field_1_chartGroupIndex
			};
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002D7D RID: 11645 RVA: 0x00086945 File Offset: 0x00084B45
		// (set) Token: 0x06002D7E RID: 11646 RVA: 0x0008694D File Offset: 0x00084B4D
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

		// Token: 0x040013EF RID: 5103
		public const short sid = 4165;

		// Token: 0x040013F0 RID: 5104
		private short field_1_chartGroupIndex;
	}
}
