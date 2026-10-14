using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004F2 RID: 1266
	public class SSAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002F9D RID: 12189 RVA: 0x0008FC9C File Offset: 0x0008DE9C
		public global::NPOI.HSSF.Record.Chart.DataFormatRecord DataFormat
		{
			get
			{
				return this.dataFormat;
			}
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x0008FCA4 File Offset: 0x0008DEA4
		public SSAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("SS", container)
		{
			this.dataFormat = (global::NPOI.HSSF.Record.Chart.DataFormatRecord)rs.GetNext();
			rs.GetNext();
			if (rs.PeekNextChartSid() == 4191)
			{
				this.chart3DBarShape = (global::NPOI.HSSF.Record.Chart.Chart3DBarShapeRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4103)
			{
				this.lineFormat = (global::NPOI.HSSF.Record.Chart.LineFormatRecord)rs.GetNext();
				this.areaFormat = (global::NPOI.HSSF.Record.Chart.AreaFormatRecord)rs.GetNext();
				this.pieFormat = (global::NPOI.HSSF.Record.Chart.PieFormatRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4189)
			{
				this.serFmt = (global::NPOI.HSSF.Record.Chart.SerFmtRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4198)
			{
				this.gelFrame = new global::NPOI.HSSF.Record.Aggregates.Chart.GelFrameAggregate(rs, this);
			}
			if (rs.PeekNextChartSid() == 4105)
			{
				this.markerFormat = (global::NPOI.HSSF.Record.Chart.MarkerFormatRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4108)
			{
				this.attachedLabel = (global::NPOI.HSSF.Record.Chart.AttachedLabelRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 2212)
			{
				this.shapeProps1 = new global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate(rs, this);
			}
			if (rs.PeekNextChartSid() == 2212)
			{
				this.shapeProps2 = new global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate(rs, this);
			}
			if (rs.PeekNextChartSid() == 2206)
			{
				this.crtMlFrt = new global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate(rs, this);
			}
			rs.GetNext();
		}

		// Token: 0x06002F9F RID: 12191 RVA: 0x0008FDFC File Offset: 0x0008DFFC
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.dataFormat);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			if (this.chart3DBarShape != null)
			{
				rv.VisitRecord(this.chart3DBarShape);
			}
			if (this.lineFormat != null)
			{
				rv.VisitRecord(this.lineFormat);
				rv.VisitRecord(this.areaFormat);
				rv.VisitRecord(this.pieFormat);
			}
			if (this.serFmt != null)
			{
				rv.VisitRecord(this.serFmt);
			}
			if (this.gelFrame != null)
			{
				this.gelFrame.VisitContainedRecords(rv);
			}
			if (this.markerFormat != null)
			{
				rv.VisitRecord(this.markerFormat);
			}
			if (this.attachedLabel != null)
			{
				rv.VisitRecord(this.attachedLabel);
			}
			if (this.shapeProps1 != null)
			{
				this.shapeProps1.VisitContainedRecords(rv);
			}
			if (this.shapeProps2 != null)
			{
				this.shapeProps2.VisitContainedRecords(rv);
			}
			if (this.crtMlFrt != null)
			{
				this.crtMlFrt.VisitContainedRecords(rv);
			}
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x04001542 RID: 5442
		private global::NPOI.HSSF.Record.Chart.DataFormatRecord dataFormat;

		// Token: 0x04001543 RID: 5443
		private global::NPOI.HSSF.Record.Chart.Chart3DBarShapeRecord chart3DBarShape;

		// Token: 0x04001544 RID: 5444
		private global::NPOI.HSSF.Record.Chart.LineFormatRecord lineFormat;

		// Token: 0x04001545 RID: 5445
		private global::NPOI.HSSF.Record.Chart.AreaFormatRecord areaFormat;

		// Token: 0x04001546 RID: 5446
		private global::NPOI.HSSF.Record.Chart.PieFormatRecord pieFormat;

		// Token: 0x04001547 RID: 5447
		private global::NPOI.HSSF.Record.Chart.SerFmtRecord serFmt;

		// Token: 0x04001548 RID: 5448
		private global::NPOI.HSSF.Record.Aggregates.Chart.GelFrameAggregate gelFrame;

		// Token: 0x04001549 RID: 5449
		private global::NPOI.HSSF.Record.Chart.MarkerFormatRecord markerFormat;

		// Token: 0x0400154A RID: 5450
		private global::NPOI.HSSF.Record.Chart.AttachedLabelRecord attachedLabel;

		// Token: 0x0400154B RID: 5451
		private global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate shapeProps1;

		// Token: 0x0400154C RID: 5452
		private global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate shapeProps2;

		// Token: 0x0400154D RID: 5453
		private global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate crtMlFrt;
	}
}
