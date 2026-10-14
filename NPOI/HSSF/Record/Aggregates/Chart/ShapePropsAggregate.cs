using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004F1 RID: 1265
	public class ShapePropsAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F9B RID: 12187 RVA: 0x0008FBCC File Offset: 0x0008DDCC
		public ShapePropsAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("SHAPEPROPS", container)
		{
			this.shapProps = (global::NPOI.HSSF.Record.Chart.ShapePropsStreamRecord)rs.GetNext();
			if (rs.PeekNextChartSid() == 2207)
			{
				while (rs.PeekNextChartSid() == 2207)
				{
					this.continues.Add((global::NPOI.HSSF.Record.ContinueFrt12Record)rs.GetNext());
				}
			}
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x0008FC34 File Offset: 0x0008DE34
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			base.WriteStartBlock(rv);
			rv.VisitRecord(this.shapProps);
			foreach (global::NPOI.HSSF.Record.ContinueFrt12Record r in this.continues)
			{
				rv.VisitRecord(r);
			}
		}

		// Token: 0x04001540 RID: 5440
		private global::NPOI.HSSF.Record.Chart.ShapePropsStreamRecord shapProps;

		// Token: 0x04001541 RID: 5441
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ContinueFrt12Record> continues = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ContinueFrt12Record>();
	}
}
