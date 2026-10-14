using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004E4 RID: 1252
	public class CrtMlFrtAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F7C RID: 12156 RVA: 0x0008EBDC File Offset: 0x0008CDDC
		public CrtMlFrtAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("CRTMLFRT", container)
		{
			this.crtmlFrt = (global::NPOI.HSSF.Record.Chart.CrtMlFrtRecord)rs.GetNext();
			if (rs.PeekNextChartSid() == 2207)
			{
				while (rs.PeekNextChartSid() == 2207)
				{
					this.continues.Add((global::NPOI.HSSF.Record.Chart.CrtMlFrtContinueRecord)rs.GetNext());
				}
			}
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x0008EC44 File Offset: 0x0008CE44
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			base.WriteStartBlock(rv);
			rv.VisitRecord(this.crtmlFrt);
			foreach (global::NPOI.HSSF.Record.Chart.CrtMlFrtContinueRecord r in this.continues)
			{
				rv.VisitRecord(r);
			}
		}

		// Token: 0x04001504 RID: 5380
		private global::NPOI.HSSF.Record.Chart.CrtMlFrtRecord crtmlFrt;

		// Token: 0x04001505 RID: 5381
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Chart.CrtMlFrtContinueRecord> continues = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Chart.CrtMlFrtContinueRecord>();
	}
}
