using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004DE RID: 1246
	public class AXMAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F65 RID: 12133 RVA: 0x0008D5A4 File Offset: 0x0008B7A4
		public AXMAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("AXM", container)
		{
			this.yMult = (global::NPOI.HSSF.Record.Chart.YMultRecord)rs.GetNext();
			this.startObject = (global::NPOI.HSSF.Record.Chart.ChartStartObjectRecord)rs.GetNext();
			this.attachedLabel = new global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate(rs, this);
			this.endObject = (global::NPOI.HSSF.Record.Chart.ChartEndObjectRecord)rs.GetNext();
		}

		// Token: 0x06002F66 RID: 12134 RVA: 0x0008D600 File Offset: 0x0008B800
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			base.WriteStartBlock(rv);
			rv.VisitRecord(this.yMult);
			rv.VisitRecord(this.startObject);
			base.IsInStartObject = true;
			this.attachedLabel.VisitContainedRecords(rv);
			base.IsInStartObject = false;
			rv.VisitRecord(this.endObject);
		}

		// Token: 0x040014B0 RID: 5296
		private global::NPOI.HSSF.Record.Chart.YMultRecord yMult;

		// Token: 0x040014B1 RID: 5297
		private global::NPOI.HSSF.Record.Chart.ChartStartObjectRecord startObject;

		// Token: 0x040014B2 RID: 5298
		private global::NPOI.HSSF.Record.Aggregates.Chart.AttachedLabelAggregate attachedLabel;

		// Token: 0x040014B3 RID: 5299
		private global::NPOI.HSSF.Record.Chart.ChartEndObjectRecord endObject;
	}
}
