using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004E0 RID: 1248
	public class ChartFormatsAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F69 RID: 12137 RVA: 0x0008D92C File Offset: 0x0008BB2C
		public ChartFormatsAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("CHARTFOMATS", container)
		{
			this.chart = (global::NPOI.HSSF.Record.Chart.ChartRecord)rs.GetNext();
			rs.GetNext();
			while (rs.PeekNextChartSid() == 2138)
			{
				this.fontList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.FontListAggregate(rs, this));
			}
			this.scl = (global::NPOI.HSSF.Record.SCLRecord)rs.GetNext();
			this.plotGrowth = (global::NPOI.HSSF.Record.Chart.PlotGrowthRecord)rs.GetNext();
			if (rs.PeekNextChartSid() == 4146)
			{
				this.frame = new global::NPOI.HSSF.Record.Aggregates.Chart.FrameAggregate(rs, this);
			}
			while (rs.PeekNextChartSid() == 4099)
			{
				this.seriesFormatList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.SeriesFormatAggregate(rs, this));
			}
			while (rs.PeekNextChartSid() == 4102)
			{
				this.ssList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate(rs, this));
			}
			this.shtProps = (global::NPOI.HSSF.Record.Chart.ShtPropsRecord)rs.GetNext();
			while (rs.PeekNextChartSid() == 4132 || rs.PeekNextChartSid() == 2154)
			{
				this.dftTextList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.DFTTextAggregate(rs, this));
			}
			this.axesUsed = (global::NPOI.HSSF.Record.Chart.AxesUsedRecord)rs.GetNext();
			this.axisParent1 = new global::NPOI.HSSF.Record.Aggregates.Chart.AxisParentAggregate(rs, this);
			if (rs.PeekNextChartSid() == 4161)
			{
				this.axisParent2 = new global::NPOI.HSSF.Record.Aggregates.Chart.AxisParentAggregate(rs, this);
			}
			if (rs.PeekNextChartSid() == 2215)
			{
				this.crt12A = (global::NPOI.HSSF.Record.Chart.CrtLayout12ARecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4195)
			{
				this.dat = new global::NPOI.HSSF.Record.Aggregates.Chart.DatAggregate(rs, container);
			}
			if (rs.PeekNextChartSid() == 4133)
			{
				while (rs.PeekNextChartSid() == 4133)
				{
					this.attachedLabelList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate(rs, this));
				}
			}
			if (rs.PeekNextChartSid() == 2206)
			{
				this.crtMlFrt = new global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate(rs, container);
			}
			while (rs.PeekNextChartSid() == 2154 || rs.PeekNextChartSid() == 4133)
			{
				this.cfalList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.ChartFormatsAggregate.ChartFormatsAttachedLabelAggregate(rs, this));
			}
			if (rs.PeekNextChartSid() == 2213)
			{
				this.textProps = new global::NPOI.HSSF.Record.Aggregates.Chart.TextPropsAggregate(rs, container);
			}
			while (rs.PeekNextChartSid() == 2206)
			{
				this.mlfrtList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate(rs, container));
			}
			rs.GetNext();
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x0008DBB0 File Offset: 0x0008BDB0
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.chart);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.FontListAggregate fontListAggregate in this.fontList)
			{
				fontListAggregate.VisitContainedRecords(rv);
			}
			rv.VisitRecord(this.scl);
			rv.VisitRecord(this.plotGrowth);
			if (this.frame != null)
			{
				this.frame.VisitContainedRecords(rv);
			}
			short num = 0;
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.SeriesFormatAggregate seriesFormatAggregate in this.seriesFormatList)
			{
				seriesFormatAggregate.VisitContainedRecords(rv);
				short num2 = num;
				num = num2 + 1;
				seriesFormatAggregate.SeriesIndex = num2;
			}
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate ssaggregate in this.ssList)
			{
				ssaggregate.VisitContainedRecords(rv);
			}
			rv.VisitRecord(this.shtProps);
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.DFTTextAggregate dfttextAggregate in this.dftTextList)
			{
				dfttextAggregate.VisitContainedRecords(rv);
			}
			rv.VisitRecord(this.axesUsed);
			this.axisParent1.VisitContainedRecords(rv);
			if (this.axisParent2 != null)
			{
				this.axisParent2.VisitContainedRecords(rv);
			}
			if (this.crt12A != null)
			{
				rv.VisitRecord(this.crt12A);
			}
			if (this.dat != null)
			{
				this.dat.VisitContainedRecords(rv);
			}
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate attachedLabelAggregate in this.attachedLabelList)
			{
				attachedLabelAggregate.VisitContainedRecords(rv);
			}
			if (this.crtMlFrt != null)
			{
				this.crtMlFrt.VisitContainedRecords(rv);
			}
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.ChartFormatsAggregate.ChartFormatsAttachedLabelAggregate chartFormatsAttachedLabelAggregate in this.cfalList)
			{
				chartFormatsAttachedLabelAggregate.VisitContainedRecords(rv);
			}
			if (this.textProps != null)
			{
				this.textProps.VisitContainedRecords(rv);
			}
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate crtMlFrtAggregate in this.mlfrtList)
			{
				crtMlFrtAggregate.VisitContainedRecords(rv);
			}
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x040014BE RID: 5310
		private global::NPOI.HSSF.Record.Chart.ChartRecord chart;

		// Token: 0x040014BF RID: 5311
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.FontListAggregate> fontList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.FontListAggregate>();

		// Token: 0x040014C0 RID: 5312
		private global::NPOI.HSSF.Record.SCLRecord scl;

		// Token: 0x040014C1 RID: 5313
		private global::NPOI.HSSF.Record.Chart.PlotGrowthRecord plotGrowth;

		// Token: 0x040014C2 RID: 5314
		private global::NPOI.HSSF.Record.Aggregates.Chart.FrameAggregate frame;

		// Token: 0x040014C3 RID: 5315
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.SeriesFormatAggregate> seriesFormatList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.SeriesFormatAggregate>();

		// Token: 0x040014C4 RID: 5316
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate> ssList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.SSAggregate>();

		// Token: 0x040014C5 RID: 5317
		private global::NPOI.HSSF.Record.Chart.ShtPropsRecord shtProps;

		// Token: 0x040014C6 RID: 5318
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.DFTTextAggregate> dftTextList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.DFTTextAggregate>();

		// Token: 0x040014C7 RID: 5319
		private global::NPOI.HSSF.Record.Chart.AxesUsedRecord axesUsed;

		// Token: 0x040014C8 RID: 5320
		private global::NPOI.HSSF.Record.Aggregates.Chart.AxisParentAggregate axisParent1;

		// Token: 0x040014C9 RID: 5321
		private global::NPOI.HSSF.Record.Aggregates.Chart.AxisParentAggregate axisParent2;

		// Token: 0x040014CA RID: 5322
		private global::NPOI.HSSF.Record.Chart.CrtLayout12ARecord crt12A;

		// Token: 0x040014CB RID: 5323
		private global::NPOI.HSSF.Record.Aggregates.Chart.DatAggregate dat;

		// Token: 0x040014CC RID: 5324
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate> attachedLabelList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate>();

		// Token: 0x040014CD RID: 5325
		private global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate crtMlFrt;

		// Token: 0x040014CE RID: 5326
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.ChartFormatsAggregate.ChartFormatsAttachedLabelAggregate> cfalList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.ChartFormatsAggregate.ChartFormatsAttachedLabelAggregate>();

		// Token: 0x040014CF RID: 5327
		private global::NPOI.HSSF.Record.Aggregates.Chart.TextPropsAggregate textProps;

		// Token: 0x040014D0 RID: 5328
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate> mlfrtList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate>();

		// Token: 0x02000623 RID: 1571
		private class ChartFormatsAttachedLabelAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
		{
			// Token: 0x060036CA RID: 14026 RVA: 0x000A7248 File Offset: 0x000A5448
			public ChartFormatsAttachedLabelAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("ChartFormatsAttachedLabel", container)
			{
				if (rs.PeekNextChartSid() == 2154)
				{
					this.dataLabExt = (global::NPOI.HSSF.Record.Chart.DataLabExtRecord)rs.GetNext();
					this.startObject = (global::NPOI.HSSF.Record.Chart.ChartStartObjectRecord)rs.GetNext();
				}
				this.attachedLabel = new global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate(rs, this);
				if (this.startObject != null)
				{
					this.endObject = (global::NPOI.HSSF.Record.Chart.ChartEndObjectRecord)rs.GetNext();
				}
			}

			// Token: 0x060036CB RID: 14027 RVA: 0x000A72B8 File Offset: 0x000A54B8
			public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
			{
				if (this.dataLabExt != null)
				{
					rv.VisitRecord(this.dataLabExt);
					rv.VisitRecord(this.startObject);
					base.IsInStartObject = true;
				}
				this.attachedLabel.VisitContainedRecords(rv);
				if (this.endObject != null)
				{
					base.IsInStartObject = false;
					rv.VisitRecord(this.endObject);
				}
			}

			// Token: 0x04001AA7 RID: 6823
			private global::NPOI.HSSF.Record.Chart.DataLabExtRecord dataLabExt;

			// Token: 0x04001AA8 RID: 6824
			private global::NPOI.HSSF.Record.Chart.ChartStartObjectRecord startObject;

			// Token: 0x04001AA9 RID: 6825
			private global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate attachedLabel;

			// Token: 0x04001AAA RID: 6826
			private global::NPOI.HSSF.Record.Chart.ChartEndObjectRecord endObject;
		}
	}
}
