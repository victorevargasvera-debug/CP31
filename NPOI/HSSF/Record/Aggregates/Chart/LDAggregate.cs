using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004ED RID: 1261
	public class LDAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F91 RID: 12177 RVA: 0x0008F560 File Offset: 0x0008D760
		public LDAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("LD", container)
		{
			this.legend = (global::NPOI.HSSF.Record.Chart.LegendRecord)rs.GetNext();
			rs.GetNext();
			this.pos = (global::NPOI.HSSF.Record.Chart.PosRecord)rs.GetNext();
			this.attachedLabel = new global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate(rs, this);
			if (rs.PeekNextChartSid() == 4146)
			{
				this.frame = new global::NPOI.HSSF.Record.Aggregates.Chart.FrameAggregate(rs, this);
			}
			if (rs.PeekNextChartSid() == 2205)
			{
				this.crtLayout = (global::NPOI.HSSF.Record.Chart.CrtLayout12Record)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 2213)
			{
				this.textProps = new global::NPOI.HSSF.Record.Aggregates.Chart.TextPropsAggregate(rs, this);
			}
			if (rs.PeekNextChartSid() == 2206)
			{
				this.crtMlFrt = new global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate(rs, this);
			}
			rs.GetNext();
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x0008F624 File Offset: 0x0008D824
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.legend);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			rv.VisitRecord(this.pos);
			this.attachedLabel.VisitContainedRecords(rv);
			if (this.frame != null)
			{
				this.frame.VisitContainedRecords(rv);
			}
			if (this.crtLayout != null)
			{
				rv.VisitRecord(this.crtLayout);
			}
			if (this.textProps != null)
			{
				this.textProps.VisitContainedRecords(rv);
			}
			if (this.crtMlFrt != null)
			{
				this.crtMlFrt.VisitContainedRecords(rv);
			}
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x0400152A RID: 5418
		private global::NPOI.HSSF.Record.Chart.LegendRecord legend;

		// Token: 0x0400152B RID: 5419
		private global::NPOI.HSSF.Record.Chart.PosRecord pos;

		// Token: 0x0400152C RID: 5420
		private global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate attachedLabel;

		// Token: 0x0400152D RID: 5421
		private global::NPOI.HSSF.Record.Aggregates.Chart.FrameAggregate frame;

		// Token: 0x0400152E RID: 5422
		private global::NPOI.HSSF.Record.Chart.CrtLayout12Record crtLayout;

		// Token: 0x0400152F RID: 5423
		private global::NPOI.HSSF.Record.Aggregates.Chart.TextPropsAggregate textProps;

		// Token: 0x04001530 RID: 5424
		private global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate crtMlFrt;
	}
}
