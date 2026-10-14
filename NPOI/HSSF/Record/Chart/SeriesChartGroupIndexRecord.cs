using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Chart
{
	// Token: 0x020004B7 RID: 1207
	public class SeriesChartGroupIndexRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002D26 RID: 11558 RVA: 0x0005FE49 File Offset: 0x0005E049
		public SeriesChartGroupIndexRecord()
		{
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x00085C15 File Offset: 0x00083E15
		public SeriesChartGroupIndexRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.field_1_chartGroupIndex = in1.ReadShort();
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x00085C2C File Offset: 0x00083E2C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[SERTOCRT]\n");
			stringBuilder.Append("    .chartGroupIndex      = ").Append("0x").Append(global::NPOI.Util.HexDump.ToHex(this.ChartGroupIndex)).Append(" (").Append(this.ChartGroupIndex).Append(" )");
			stringBuilder.Append(global::System.Environment.NewLine);
			stringBuilder.Append("[/SERTOCRT]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00085CAC File Offset: 0x00083EAC
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort((int)this.field_1_chartGroupIndex);
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x00016A02 File Offset: 0x00014C02
		protected override int DataSize
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06002D2B RID: 11563 RVA: 0x00085CBA File Offset: 0x00083EBA
		public override short Sid
		{
			get
			{
				return global::NPOI.HSSF.Record.Chart.SeriesChartGroupIndexRecord.sid;
			}
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x00085CC1 File Offset: 0x00083EC1
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.Chart.SeriesChartGroupIndexRecord
			{
				field_1_chartGroupIndex = this.field_1_chartGroupIndex
			};
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x00085CD4 File Offset: 0x00083ED4
		// (set) Token: 0x06002D2E RID: 11566 RVA: 0x00085CDC File Offset: 0x00083EDC
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

		// Token: 0x040013C9 RID: 5065
		public static short sid = 4165;

		// Token: 0x040013CA RID: 5066
		private short field_1_chartGroupIndex;
	}
}
