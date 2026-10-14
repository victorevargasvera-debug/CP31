using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004EE RID: 1262
	public class SeriesAxisAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F93 RID: 12179 RVA: 0x0008F6C4 File Offset: 0x0008D8C4
		public SeriesAxisAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("SERIESAXIS", container)
		{
			this.axis = (global::NPOI.HSSF.Record.Chart.AxisRecord)rs.GetNext();
			rs.GetNext();
			if (rs.PeekNextChartSid() == 4128)
			{
				this.catSerRange = (global::NPOI.HSSF.Record.Chart.CatSerRangeRecord)rs.GetNext();
			}
			this.axs = new global::NPOI.HSSF.Record.Aggregates.Chart.AXSAggregate(rs, this);
			if (rs.PeekNextChartSid() == 2206)
			{
				this.crtmlfrt = new global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate(rs, this);
			}
			rs.GetNext();
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x0008F744 File Offset: 0x0008D944
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.axis);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			if (this.catSerRange != null)
			{
				rv.VisitRecord(this.catSerRange);
			}
			this.axs.VisitContainedRecords(rv);
			if (this.crtmlfrt != null)
			{
				this.crtmlfrt.VisitContainedRecords(rv);
			}
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x04001531 RID: 5425
		private global::NPOI.HSSF.Record.Chart.AxisRecord axis;

		// Token: 0x04001532 RID: 5426
		private global::NPOI.HSSF.Record.Chart.CatSerRangeRecord catSerRange;

		// Token: 0x04001533 RID: 5427
		private global::NPOI.HSSF.Record.Aggregates.Chart.AXSAggregate axs;

		// Token: 0x04001534 RID: 5428
		private global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate crtmlfrt;
	}
}
