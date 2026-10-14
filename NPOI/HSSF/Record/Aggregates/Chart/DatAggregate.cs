using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004E5 RID: 1253
	public class DatAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F7E RID: 12158 RVA: 0x0008ECAC File Offset: 0x0008CEAC
		public DatAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("DAT", container)
		{
			this.dat = (global::NPOI.HSSF.Record.Chart.DatRecord)rs.GetNext();
			rs.GetNext();
			this.ld = new global::NPOI.HSSF.Record.Aggregates.Chart.LDAggregate(rs, this);
			rs.GetNext();
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x0008ECE6 File Offset: 0x0008CEE6
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.dat);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			this.ld.VisitContainedRecords(rv);
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x04001506 RID: 5382
		private global::NPOI.HSSF.Record.Chart.DatRecord dat;

		// Token: 0x04001507 RID: 5383
		private global::NPOI.HSSF.Record.Aggregates.Chart.LDAggregate ld;
	}
}
