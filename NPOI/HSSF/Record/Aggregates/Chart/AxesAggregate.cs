using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004DC RID: 1244
	public class AxesAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F60 RID: 12128 RVA: 0x0008D278 File Offset: 0x0008B478
		public AxesAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("AXES", container)
		{
			if (rs.PeekNextChartSid() == 4125)
			{
				global::NPOI.HSSF.Record.Chart.AxisRecord axis = (global::NPOI.HSSF.Record.Chart.AxisRecord)rs.GetNext();
				rs.GetNext();
				int num = rs.PeekNextChartSid();
				if (num == 4128)
				{
					this.ivaxis = new global::NPOI.HSSF.Record.Aggregates.Chart.IVAxisAggregate(rs, this, axis);
				}
				else
				{
					if (num != 4127)
					{
						throw new global::System.InvalidOperationException(string.Format("Invalid record sid=0x{0:X}. Shoud be CatSerRangeRecord or ValueRangeRecord", num));
					}
					this.dvaxis = new global::NPOI.HSSF.Record.Aggregates.Chart.DVAxisAggregate(rs, this, axis);
				}
				this.dvaxisSecond = new global::NPOI.HSSF.Record.Aggregates.Chart.DVAxisAggregate(rs, this, null);
				if (rs.PeekNextChartSid() == 4125)
				{
					this.seriesAxis = new global::NPOI.HSSF.Record.Aggregates.Chart.SeriesAxisAggregate(rs, this);
				}
				while (rs.PeekNextChartSid() == 4133)
				{
					this.attachedLabelList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate(rs, this));
				}
				if (rs.PeekNextChartSid() == 4149)
				{
					this.plotArea = (global::NPOI.HSSF.Record.Chart.PlotAreaRecord)rs.GetNext();
					if (rs.PeekNextChartSid() == 4146)
					{
						this.frame = new global::NPOI.HSSF.Record.Aggregates.Chart.FrameAggregate(rs, this);
					}
				}
			}
		}

		// Token: 0x06002F61 RID: 12129 RVA: 0x0008D390 File Offset: 0x0008B590
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			if (this.ivaxis != null)
			{
				this.ivaxis.VisitContainedRecords(rv);
			}
			if (this.dvaxis != null)
			{
				this.dvaxis.VisitContainedRecords(rv);
			}
			this.dvaxisSecond.VisitContainedRecords(rv);
			if (this.seriesAxis != null)
			{
				this.seriesAxis.VisitContainedRecords(rv);
			}
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate attachedLabelAggregate in this.attachedLabelList)
			{
				attachedLabelAggregate.VisitContainedRecords(rv);
			}
			if (this.plotArea != null)
			{
				rv.VisitRecord(this.plotArea);
				if (this.frame != null)
				{
					this.frame.VisitContainedRecords(rv);
				}
			}
		}

		// Token: 0x040014A5 RID: 5285
		private global::NPOI.HSSF.Record.Aggregates.Chart.IVAxisAggregate ivaxis;

		// Token: 0x040014A6 RID: 5286
		private global::NPOI.HSSF.Record.Aggregates.Chart.DVAxisAggregate dvaxis;

		// Token: 0x040014A7 RID: 5287
		private global::NPOI.HSSF.Record.Aggregates.Chart.DVAxisAggregate dvaxisSecond;

		// Token: 0x040014A8 RID: 5288
		private global::NPOI.HSSF.Record.Aggregates.Chart.SeriesAxisAggregate seriesAxis;

		// Token: 0x040014A9 RID: 5289
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate> attachedLabelList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate>();

		// Token: 0x040014AA RID: 5290
		private global::NPOI.HSSF.Record.Chart.PlotAreaRecord plotArea;

		// Token: 0x040014AB RID: 5291
		private global::NPOI.HSSF.Record.Aggregates.Chart.FrameAggregate frame;
	}
}
