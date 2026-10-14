using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004E6 RID: 1254
	public class DFTTextAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06002F80 RID: 12160 RVA: 0x0008ED1D File Offset: 0x0008CF1D
		public global::NPOI.HSSF.Record.Chart.DefaultTextRecord DefaultText
		{
			get
			{
				return this.defaultText;
			}
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x0008ED28 File Offset: 0x0008CF28
		public DFTTextAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("DFTTEXT", container)
		{
			if (rs.PeekNextChartSid() == 2154)
			{
				this.dataLabExt = (global::NPOI.HSSF.Record.Chart.DataLabExtRecord)rs.GetNext();
				this.startObject = (global::NPOI.HSSF.Record.Chart.ChartStartObjectRecord)rs.GetNext();
			}
			this.defaultText = (global::NPOI.HSSF.Record.Chart.DefaultTextRecord)rs.GetNext();
			this.attachedLabel = new global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate(rs, this);
			if (this.startObject != null)
			{
				this.endObject = (global::NPOI.HSSF.Record.Chart.ChartEndObjectRecord)rs.GetNext();
			}
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x0008EDA8 File Offset: 0x0008CFA8
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			if (this.dataLabExt != null)
			{
				rv.VisitRecord(this.dataLabExt);
				rv.VisitRecord(this.startObject);
				base.IsInStartObject = true;
			}
			rv.VisitRecord(this.defaultText);
			this.attachedLabel.VisitContainedRecords(rv);
			if (this.endObject != null)
			{
				rv.VisitRecord(this.endObject);
				base.IsInStartObject = false;
			}
		}

		// Token: 0x04001508 RID: 5384
		private global::NPOI.HSSF.Record.Chart.DataLabExtRecord dataLabExt;

		// Token: 0x04001509 RID: 5385
		private global::NPOI.HSSF.Record.Chart.ChartStartObjectRecord startObject;

		// Token: 0x0400150A RID: 5386
		private global::NPOI.HSSF.Record.Chart.DefaultTextRecord defaultText;

		// Token: 0x0400150B RID: 5387
		private global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate attachedLabel;

		// Token: 0x0400150C RID: 5388
		private global::NPOI.HSSF.Record.Chart.ChartEndObjectRecord endObject;
	}
}
