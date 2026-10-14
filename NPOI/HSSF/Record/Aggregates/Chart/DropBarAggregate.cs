using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004E7 RID: 1255
	public class DropBarAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F83 RID: 12163 RVA: 0x0008EE10 File Offset: 0x0008D010
		public DropBarAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("DROPBAR", container)
		{
			this.dropBar = (global::NPOI.HSSF.Record.Chart.DropBarRecord)rs.GetNext();
			rs.GetNext();
			this.lineFormat = (global::NPOI.HSSF.Record.Chart.LineFormatRecord)rs.GetNext();
			this.areaFormat = (global::NPOI.HSSF.Record.Chart.AreaFormatRecord)rs.GetNext();
			if (rs.PeekNextChartSid() == 4198)
			{
				this.gelFrame = new global::NPOI.HSSF.Record.Aggregates.Chart.GelFrameAggregate(rs, this);
			}
			if (rs.PeekNextChartSid() == 2212)
			{
				this.shapProps = new global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate(rs, this);
			}
			rs.GetNext();
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x0008EEA0 File Offset: 0x0008D0A0
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.dropBar);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			rv.VisitRecord(this.lineFormat);
			rv.VisitRecord(this.areaFormat);
			if (this.gelFrame != null)
			{
				this.gelFrame.VisitContainedRecords(rv);
			}
			if (this.shapProps != null)
			{
				this.shapProps.VisitContainedRecords(rv);
			}
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x0400150D RID: 5389
		private global::NPOI.HSSF.Record.Chart.DropBarRecord dropBar;

		// Token: 0x0400150E RID: 5390
		private global::NPOI.HSSF.Record.Chart.LineFormatRecord lineFormat;

		// Token: 0x0400150F RID: 5391
		private global::NPOI.HSSF.Record.Chart.AreaFormatRecord areaFormat;

		// Token: 0x04001510 RID: 5392
		private global::NPOI.HSSF.Record.Aggregates.Chart.GelFrameAggregate gelFrame;

		// Token: 0x04001511 RID: 5393
		private global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate shapProps;
	}
}
