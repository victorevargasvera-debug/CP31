using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004F3 RID: 1267
	public class TextPropsAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002FA0 RID: 12192 RVA: 0x0008FF00 File Offset: 0x0008E100
		public TextPropsAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("TEXTPROPS", container)
		{
			if (rs.PeekNextChartSid() == 2213)
			{
				this.textPropsStream = (global::NPOI.HSSF.Record.Chart.TextPropsStreamRecord)rs.GetNext();
			}
			else
			{
				this.richTextStream = (global::NPOI.HSSF.Record.Chart.RichTextStreamRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 2175)
			{
				while (rs.PeekNextChartSid() == 2175)
				{
					this.continues.Add((global::NPOI.HSSF.Record.ContinueFrt12Record)rs.GetNext());
				}
			}
		}

		// Token: 0x06002FA1 RID: 12193 RVA: 0x0008FF88 File Offset: 0x0008E188
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			base.WriteStartBlock(rv);
			if (this.textPropsStream != null)
			{
				rv.VisitRecord(this.textPropsStream);
			}
			if (this.richTextStream != null)
			{
				rv.VisitRecord(this.richTextStream);
			}
			foreach (global::NPOI.HSSF.Record.ContinueFrt12Record r in this.continues)
			{
				rv.VisitRecord(r);
			}
		}

		// Token: 0x0400154E RID: 5454
		private global::NPOI.HSSF.Record.Chart.TextPropsStreamRecord textPropsStream;

		// Token: 0x0400154F RID: 5455
		private global::NPOI.HSSF.Record.Chart.RichTextStreamRecord richTextStream;

		// Token: 0x04001550 RID: 5456
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ContinueFrt12Record> continues = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ContinueFrt12Record>();
	}
}
