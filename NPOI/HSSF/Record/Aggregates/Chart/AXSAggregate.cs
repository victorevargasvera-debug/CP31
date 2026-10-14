using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004DF RID: 1247
	public class AXSAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F67 RID: 12135 RVA: 0x0008D654 File Offset: 0x0008B854
		public AXSAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("AXS", container)
		{
			if (rs.PeekNextChartSid() == 4174)
			{
				this.ifmt = (global::NPOI.HSSF.Record.Chart.IFmtRecordRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4126)
			{
				this.tick = (global::NPOI.HSSF.Record.TickRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4134)
			{
				this.fontx = (global::NPOI.HSSF.Record.Chart.FontIndexRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4129)
			{
				while (rs.PeekNextChartSid() == 4129)
				{
					this.axisLines.Add((global::NPOI.HSSF.Record.Chart.AxisLineFormatRecord)rs.GetNext());
					this.lineFormats.Add((global::NPOI.HSSF.Record.Chart.LineFormatRecord)rs.GetNext());
				}
			}
			if (rs.PeekNextChartSid() == 4106)
			{
				this.areaFormat = (global::NPOI.HSSF.Record.Chart.AreaFormatRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4198)
			{
				this.gelFrame = new global::NPOI.HSSF.Record.Aggregates.Chart.GelFrameAggregate(rs, this);
			}
			if (rs.PeekNextChartSid() == 2212)
			{
				while (rs.PeekNextChartSid() == 2212)
				{
					this.shapes.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate(rs, this));
				}
			}
			if (rs.PeekNextChartSid() == 2213)
			{
				this.textProps = (global::NPOI.HSSF.Record.Chart.TextPropsStreamRecord)rs.GetNext();
				while (rs.PeekNextChartSid() == 2175)
				{
					this.continues.Add((global::NPOI.HSSF.Record.ContinueFrt12Record)rs.GetNext());
				}
			}
		}

		// Token: 0x06002F68 RID: 12136 RVA: 0x0008D7E4 File Offset: 0x0008B9E4
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			if (this.ifmt != null)
			{
				rv.VisitRecord(this.ifmt);
			}
			if (this.tick != null)
			{
				rv.VisitRecord(this.tick);
			}
			if (this.fontx != null)
			{
				rv.VisitRecord(this.fontx);
			}
			for (int i = 0; i < this.axisLines.Count; i++)
			{
				rv.VisitRecord(this.axisLines[i]);
				rv.VisitRecord(this.lineFormats[i]);
			}
			if (this.areaFormat != null)
			{
				rv.VisitRecord(this.areaFormat);
			}
			if (this.gelFrame != null)
			{
				this.gelFrame.VisitContainedRecords(rv);
			}
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate shapePropsAggregate in this.shapes)
			{
				shapePropsAggregate.VisitContainedRecords(rv);
			}
			if (this.textProps != null)
			{
				rv.VisitRecord(this.textProps);
				foreach (global::NPOI.HSSF.Record.ContinueFrt12Record r in this.continues)
				{
					rv.VisitRecord(r);
				}
			}
		}

		// Token: 0x040014B4 RID: 5300
		private global::NPOI.HSSF.Record.Chart.IFmtRecordRecord ifmt;

		// Token: 0x040014B5 RID: 5301
		private global::NPOI.HSSF.Record.TickRecord tick;

		// Token: 0x040014B6 RID: 5302
		private global::NPOI.HSSF.Record.Chart.FontIndexRecord fontx;

		// Token: 0x040014B7 RID: 5303
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Chart.AxisLineFormatRecord> axisLines = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Chart.AxisLineFormatRecord>();

		// Token: 0x040014B8 RID: 5304
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Chart.LineFormatRecord> lineFormats = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Chart.LineFormatRecord>();

		// Token: 0x040014B9 RID: 5305
		private global::NPOI.HSSF.Record.Chart.AreaFormatRecord areaFormat;

		// Token: 0x040014BA RID: 5306
		private global::NPOI.HSSF.Record.Aggregates.Chart.GelFrameAggregate gelFrame;

		// Token: 0x040014BB RID: 5307
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate> shapes = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate>();

		// Token: 0x040014BC RID: 5308
		private global::NPOI.HSSF.Record.Chart.TextPropsStreamRecord textProps;

		// Token: 0x040014BD RID: 5309
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ContinueFrt12Record> continues = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ContinueFrt12Record>();
	}
}
