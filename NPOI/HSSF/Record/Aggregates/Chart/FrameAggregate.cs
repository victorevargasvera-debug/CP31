using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004EA RID: 1258
	public class FrameAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F8A RID: 12170 RVA: 0x0008F18C File Offset: 0x0008D38C
		public FrameAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("FRAME", container)
		{
			this.frame = (global::NPOI.HSSF.Record.Chart.FrameRecord)rs.GetNext();
			rs.GetNext();
			this.lineFormat = (global::NPOI.HSSF.Record.Chart.LineFormatRecord)rs.GetNext();
			this.areaFormat = (global::NPOI.HSSF.Record.Chart.AreaFormatRecord)rs.GetNext();
			if (rs.PeekNextChartSid() == 4198)
			{
				this.gelFrame = new global::NPOI.HSSF.Record.Aggregates.Chart.GelFrameAggregate(rs, this);
			}
			if (rs.PeekNextChartSid() == 2212)
			{
				this.shapeProps = new global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate(rs, this);
			}
			rs.GetNext();
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x0008F21C File Offset: 0x0008D41C
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.frame);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			rv.VisitRecord(this.lineFormat);
			rv.VisitRecord(this.areaFormat);
			if (this.gelFrame != null)
			{
				this.gelFrame.VisitContainedRecords(rv);
			}
			if (this.shapeProps != null)
			{
				this.shapeProps.VisitContainedRecords(rv);
			}
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x0008F292 File Offset: 0x0008D492
		protected override bool ShoudWriteStartBlock()
		{
			bool isInStartObject = base.IsInStartObject;
			return false;
		}

		// Token: 0x0400151B RID: 5403
		private global::NPOI.HSSF.Record.Chart.FrameRecord frame;

		// Token: 0x0400151C RID: 5404
		private global::NPOI.HSSF.Record.Chart.LineFormatRecord lineFormat;

		// Token: 0x0400151D RID: 5405
		private global::NPOI.HSSF.Record.Chart.AreaFormatRecord areaFormat;

		// Token: 0x0400151E RID: 5406
		private global::NPOI.HSSF.Record.Aggregates.Chart.GelFrameAggregate gelFrame;

		// Token: 0x0400151F RID: 5407
		private global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate shapeProps;
	}
}
