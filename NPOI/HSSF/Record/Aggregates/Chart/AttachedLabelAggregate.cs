using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004DB RID: 1243
	public class AttachedLabelAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002F5B RID: 12123 RVA: 0x0008CFD3 File Offset: 0x0008B1D3
		// (set) Token: 0x06002F5C RID: 12124 RVA: 0x0008CFDB File Offset: 0x0008B1DB
		public bool IsFirst
		{
			get
			{
				return this._isFirst;
			}
			set
			{
				this._isFirst = value;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002F5D RID: 12125 RVA: 0x0008CFE4 File Offset: 0x0008B1E4
		public global::NPOI.HSSF.Record.Chart.ObjectLinkRecord ObjectLink
		{
			get
			{
				return this.objectLink;
			}
		}

		// Token: 0x06002F5E RID: 12126 RVA: 0x0008CFEC File Offset: 0x0008B1EC
		public AttachedLabelAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("ATTACHEDLABEL", container)
		{
			global::NPOI.HSSF.Record.Aggregates.Chart.ChartSheetAggregate container2 = base.GetContainer<global::NPOI.HSSF.Record.Aggregates.Chart.ChartSheetAggregate>("CHARTSHEET");
			this._isFirst = (container2.AttachLabelCount == 0);
			container2.AttachLabelCount++;
			this.text = (global::NPOI.HSSF.Record.TextRecord)rs.GetNext();
			rs.GetNext();
			this.pos = (global::NPOI.HSSF.Record.Chart.PosRecord)rs.GetNext();
			if (rs.PeekNextChartSid() == 4134)
			{
				this.fontX = (global::NPOI.HSSF.Record.Chart.FontIndexRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4176)
			{
				this.alRuns = (global::NPOI.HSSF.Record.Chart.AlRunsRecord)rs.GetNext();
			}
			this.brai = (global::NPOI.HSSF.Record.Chart.LinkedDataRecord)rs.GetNext();
			if (rs.PeekNextChartSid() == 4109)
			{
				this.seriesText = (global::NPOI.HSSF.Record.Chart.SeriesTextRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 4146)
			{
				this.frame = new global::NPOI.HSSF.Record.Aggregates.Chart.FrameAggregate(rs, this);
			}
			if (rs.PeekNextChartSid() == 4135)
			{
				this.objectLink = (global::NPOI.HSSF.Record.Chart.ObjectLinkRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 2155)
			{
				this.dataLab = (global::NPOI.HSSF.Record.Chart.DataLabExtContentsRecord)rs.GetNext();
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

		// Token: 0x06002F5F RID: 12127 RVA: 0x0008D174 File Offset: 0x0008B374
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.text);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			rv.VisitRecord(this.pos);
			if (this.fontX != null)
			{
				rv.VisitRecord(this.fontX);
			}
			if (this.alRuns != null)
			{
				rv.VisitRecord(this.alRuns);
			}
			rv.VisitRecord(this.brai);
			if (this.seriesText != null)
			{
				rv.VisitRecord(this.seriesText);
			}
			if (this.frame != null)
			{
				this.frame.VisitContainedRecords(rv);
			}
			if (this.objectLink != null)
			{
				rv.VisitRecord(this.objectLink);
			}
			if (this.dataLab != null)
			{
				rv.VisitRecord(this.dataLab);
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

		// Token: 0x04001498 RID: 5272
		private global::NPOI.HSSF.Record.TextRecord text;

		// Token: 0x04001499 RID: 5273
		private global::NPOI.HSSF.Record.Chart.PosRecord pos;

		// Token: 0x0400149A RID: 5274
		private global::NPOI.HSSF.Record.Chart.FontIndexRecord fontX;

		// Token: 0x0400149B RID: 5275
		private global::NPOI.HSSF.Record.Chart.AlRunsRecord alRuns;

		// Token: 0x0400149C RID: 5276
		private global::NPOI.HSSF.Record.Chart.LinkedDataRecord brai;

		// Token: 0x0400149D RID: 5277
		private global::NPOI.HSSF.Record.Chart.SeriesTextRecord seriesText;

		// Token: 0x0400149E RID: 5278
		private global::NPOI.HSSF.Record.Aggregates.Chart.FrameAggregate frame;

		// Token: 0x0400149F RID: 5279
		private global::NPOI.HSSF.Record.Chart.ObjectLinkRecord objectLink;

		// Token: 0x040014A0 RID: 5280
		private global::NPOI.HSSF.Record.Chart.DataLabExtContentsRecord dataLab;

		// Token: 0x040014A1 RID: 5281
		private global::NPOI.HSSF.Record.Chart.CrtLayout12Record crtLayout;

		// Token: 0x040014A2 RID: 5282
		private global::NPOI.HSSF.Record.Aggregates.Chart.TextPropsAggregate textProps;

		// Token: 0x040014A3 RID: 5283
		private global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate crtMlFrt;

		// Token: 0x040014A4 RID: 5284
		private bool _isFirst;
	}
}
