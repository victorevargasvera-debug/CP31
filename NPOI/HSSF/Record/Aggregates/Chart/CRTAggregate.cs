using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004E3 RID: 1251
	public class CRTAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F7A RID: 12154 RVA: 0x0008E854 File Offset: 0x0008CA54
		public CRTAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("CRT", container)
		{
			this.chartForamt = (global::NPOI.HSSF.Record.ChartFormatRecord)rs.GetNext();
			rs.GetNext();
			this.chartTypeRecord = rs.GetNext();
			if (rs.PeekNextChartSid() == 4199)
			{
				this.bopPopCustom = (global::NPOI.HSSF.Record.Chart.BopPopCustomRecord)rs.GetNext();
			}
			this.crtLink = (global::NPOI.HSSF.Record.Chart.CrtLinkRecord)rs.GetNext();
			if (rs.PeekNextChartSid() == 4118)
			{
				this.seriesList = (global::NPOI.HSSF.Record.Chart.SeriesListRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4154)
			{
				this.chart3d = (global::NPOI.HSSF.Record.Chart.Chart3dRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4117)
			{
				this.ld = new global::NPOI.HSSF.Record.Aggregates.Chart.LDAggregate(rs, this);
			}
			if (rs.PeekNextChartSid() == 4157)
			{
				this.dropBar1 = new global::NPOI.HSSF.Record.Aggregates.Chart.DropBarAggregate(rs, this);
				this.dropBar2 = new global::NPOI.HSSF.Record.Aggregates.Chart.DropBarAggregate(rs, this);
			}
			while (rs.PeekNextChartSid() == 4124)
			{
				this.dicLines.Add((global::NPOI.HSSF.Record.Chart.CrtLineRecord)rs.GetNext(), (global::NPOI.HSSF.Record.Chart.LineFormatRecord)rs.GetNext());
			}
			if (rs.PeekNextChartSid() == 2154 || rs.PeekNextChartSid() == 4132)
			{
				this.dft1 = new global::NPOI.HSSF.Record.Aggregates.Chart.DFTTextAggregate(rs, this);
				if (rs.PeekNextChartSid() == 2154 || rs.PeekNextChartSid() == 4132)
				{
					this.dft2 = new global::NPOI.HSSF.Record.Aggregates.Chart.DFTTextAggregate(rs, this);
				}
			}
			if (rs.PeekNextChartSid() == 2155)
			{
				this.dataLabExtContents = (global::NPOI.HSSF.Record.Chart.DataLabExtContentsRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4102)
			{
				this.ss = new global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate(rs, this);
			}
			while (rs.PeekNextChartSid() == 2212)
			{
				this.shapeList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate(rs, this));
			}
			rs.GetNext();
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x0008EA34 File Offset: 0x0008CC34
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.chartForamt);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			rv.VisitRecord(this.chartTypeRecord);
			if (this.bopPopCustom != null)
			{
				rv.VisitRecord(this.bopPopCustom);
			}
			rv.VisitRecord(this.crtLink);
			if (this.seriesList != null)
			{
				rv.VisitRecord(this.crtLink);
			}
			if (this.chart3d != null)
			{
				rv.VisitRecord(this.chart3d);
			}
			if (this.ld != null)
			{
				this.ld.VisitContainedRecords(rv);
			}
			if (this.dropBar1 != null)
			{
				this.dropBar1.VisitContainedRecords(rv);
				this.dropBar2.VisitContainedRecords(rv);
			}
			foreach (global::System.Collections.Generic.KeyValuePair<global::NPOI.HSSF.Record.Chart.CrtLineRecord, global::NPOI.HSSF.Record.Chart.LineFormatRecord> keyValuePair in this.dicLines)
			{
				rv.VisitRecord(keyValuePair.Key);
				rv.VisitRecord(keyValuePair.Value);
			}
			if (this.dft1 != null)
			{
				this.dft1.VisitContainedRecords(rv);
				if (this.dft2 != null)
				{
					this.dft2.VisitContainedRecords(rv);
				}
			}
			if (this.dataLabExtContents != null)
			{
				rv.VisitRecord(this.dataLabExtContents);
			}
			if (this.ss != null)
			{
				this.ss.VisitContainedRecords(rv);
			}
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate shapePropsAggregate in this.shapeList)
			{
				shapePropsAggregate.VisitContainedRecords(rv);
			}
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x040014F5 RID: 5365
		private global::NPOI.HSSF.Record.ChartFormatRecord chartForamt;

		// Token: 0x040014F6 RID: 5366
		private global::NPOI.HSSF.Record.Record chartTypeRecord;

		// Token: 0x040014F7 RID: 5367
		private global::NPOI.HSSF.Record.Chart.BopPopCustomRecord bopPopCustom;

		// Token: 0x040014F8 RID: 5368
		private global::NPOI.HSSF.Record.Chart.CrtLinkRecord crtLink;

		// Token: 0x040014F9 RID: 5369
		private global::NPOI.HSSF.Record.Chart.SeriesListRecord seriesList;

		// Token: 0x040014FA RID: 5370
		private global::NPOI.HSSF.Record.Chart.Chart3dRecord chart3d;

		// Token: 0x040014FB RID: 5371
		private global::NPOI.HSSF.Record.Aggregates.Chart.LDAggregate ld;

		// Token: 0x040014FC RID: 5372
		private global::NPOI.HSSF.Record.Aggregates.Chart.DropBarAggregate dropBar1;

		// Token: 0x040014FD RID: 5373
		private global::NPOI.HSSF.Record.Aggregates.Chart.DropBarAggregate dropBar2;

		// Token: 0x040014FE RID: 5374
		private global::System.Collections.Generic.Dictionary<global::NPOI.HSSF.Record.Chart.CrtLineRecord, global::NPOI.HSSF.Record.Chart.LineFormatRecord> dicLines = new global::System.Collections.Generic.Dictionary<global::NPOI.HSSF.Record.Chart.CrtLineRecord, global::NPOI.HSSF.Record.Chart.LineFormatRecord>();

		// Token: 0x040014FF RID: 5375
		private global::NPOI.HSSF.Record.Aggregates.Chart.DFTTextAggregate dft1;

		// Token: 0x04001500 RID: 5376
		private global::NPOI.HSSF.Record.Aggregates.Chart.DFTTextAggregate dft2;

		// Token: 0x04001501 RID: 5377
		private global::NPOI.HSSF.Record.Chart.DataLabExtContentsRecord dataLabExtContents;

		// Token: 0x04001502 RID: 5378
		private global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate ss;

		// Token: 0x04001503 RID: 5379
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate> shapeList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.ShapePropsAggregate>();
	}
}
