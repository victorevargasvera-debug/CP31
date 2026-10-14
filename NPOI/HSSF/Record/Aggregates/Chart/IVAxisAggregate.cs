using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004EC RID: 1260
	public class IVAxisAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F8F RID: 12175 RVA: 0x0008F3EC File Offset: 0x0008D5EC
		public IVAxisAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container, global::NPOI.HSSF.Record.Chart.AxisRecord axis) : base("IVAXIS", container)
		{
			this.axis = axis;
			if (rs.PeekNextChartSid() == 4128)
			{
				this.catSerRange = (global::NPOI.HSSF.Record.Chart.CatSerRangeRecord)rs.GetNext();
			}
			this.axcExt = (global::NPOI.HSSF.Record.Chart.AxcExtRecord)rs.GetNext();
			if (rs.PeekNextChartSid() == 2134)
			{
				this.catLab = (global::NPOI.HSSF.Record.Chart.CatLabRecord)rs.GetNext();
			}
			this.axs = new global::NPOI.HSSF.Record.Aggregates.Chart.AXSAggregate(rs, this);
			while (rs.PeekNextChartSid() == 2206)
			{
				this.crtmlfrtList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate(rs, this));
			}
			rs.GetNext();
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x0008F49C File Offset: 0x0008D69C
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.axis);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			if (this.catSerRange != null)
			{
				rv.VisitRecord(this.catSerRange);
			}
			rv.VisitRecord(this.axcExt);
			if (this.catLab != null)
			{
				base.WriteStartBlock(rv);
				rv.VisitRecord(this.catLab);
			}
			this.axs.VisitContainedRecords(rv);
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate crtMlFrtAggregate in this.crtmlfrtList)
			{
				crtMlFrtAggregate.VisitContainedRecords(rv);
			}
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x04001524 RID: 5412
		private global::NPOI.HSSF.Record.Chart.AxisRecord axis;

		// Token: 0x04001525 RID: 5413
		private global::NPOI.HSSF.Record.Chart.CatSerRangeRecord catSerRange;

		// Token: 0x04001526 RID: 5414
		private global::NPOI.HSSF.Record.Chart.AxcExtRecord axcExt;

		// Token: 0x04001527 RID: 5415
		private global::NPOI.HSSF.Record.Chart.CatLabRecord catLab;

		// Token: 0x04001528 RID: 5416
		private global::NPOI.HSSF.Record.Aggregates.Chart.AXSAggregate axs;

		// Token: 0x04001529 RID: 5417
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate> crtmlfrtList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate>();
	}
}
