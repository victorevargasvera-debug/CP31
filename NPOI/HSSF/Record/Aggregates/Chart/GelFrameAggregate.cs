using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004EB RID: 1259
	public class GelFrameAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F8D RID: 12173 RVA: 0x0008F29C File Offset: 0x0008D49C
		public GelFrameAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("GELFRAME", container)
		{
			this.gelFrame1 = (global::NPOI.HSSF.Record.Chart.GelFrameRecord)rs.GetNext();
			int num = rs.PeekNextChartSid();
			if (num == 4198)
			{
				this.gelFrame2 = (global::NPOI.HSSF.Record.Chart.GelFrameRecord)rs.GetNext();
				num = rs.PeekNextChartSid();
			}
			if (num == 60)
			{
				while (rs.PeekNextChartSid() == 60)
				{
					this.continues.Add((global::NPOI.HSSF.Record.ContinueRecord)rs.GetNext());
				}
			}
			if (rs.PeekNextChartSid() == 4147)
			{
				rs.GetNext();
				this.picF = (global::NPOI.HSSF.Record.Chart.PicFRecord)rs.GetNext();
				rs.GetNext();
			}
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x0008F34C File Offset: 0x0008D54C
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.gelFrame1);
			if (this.gelFrame2 != null)
			{
				rv.VisitRecord(this.gelFrame2);
			}
			foreach (global::NPOI.HSSF.Record.ContinueRecord r in this.continues)
			{
				rv.VisitRecord(r);
			}
			if (this.picF != null)
			{
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
				rv.VisitRecord(this.picF);
				rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
			}
		}

		// Token: 0x04001520 RID: 5408
		private global::NPOI.HSSF.Record.Chart.GelFrameRecord gelFrame1;

		// Token: 0x04001521 RID: 5409
		private global::NPOI.HSSF.Record.Chart.GelFrameRecord gelFrame2;

		// Token: 0x04001522 RID: 5410
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ContinueRecord> continues = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ContinueRecord>();

		// Token: 0x04001523 RID: 5411
		private global::NPOI.HSSF.Record.Chart.PicFRecord picF;
	}
}
