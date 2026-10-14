using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004E8 RID: 1256
	public class DVAxisAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06002F85 RID: 12165 RVA: 0x0008EF16 File Offset: 0x0008D116
		public global::NPOI.HSSF.Record.Chart.AxisRecord Axis
		{
			get
			{
				return this.axis;
			}
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x0008EF20 File Offset: 0x0008D120
		public DVAxisAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container, global::NPOI.HSSF.Record.Chart.AxisRecord axis) : base("DVAXIS", container)
		{
			if (axis == null)
			{
				this.axis = (global::NPOI.HSSF.Record.Chart.AxisRecord)rs.GetNext();
				rs.GetNext();
			}
			else
			{
				this.axis = axis;
			}
			if (rs.PeekNextChartSid() == 4127)
			{
				this.valueRange = (global::NPOI.HSSF.Record.Chart.ValueRangeRecord)rs.GetNext();
			}
			if (rs.PeekNextChartSid() == 2135)
			{
				this.axm = new global::NPOI.HSSF.Record.Aggregates.Chart.AXMAggregate(rs, this);
			}
			this.axs = new global::NPOI.HSSF.Record.Aggregates.Chart.AXSAggregate(rs, this);
			if (rs.PeekNextChartSid() == 2206)
			{
				this.crtmlfrt = new global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate(rs, this);
			}
			rs.GetNext();
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x0008EFC4 File Offset: 0x0008D1C4
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.axis);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			if (this.valueRange != null)
			{
				rv.VisitRecord(this.valueRange);
			}
			if (this.axm != null)
			{
				this.axm.VisitContainedRecords(rv);
			}
			this.axs.VisitContainedRecords(rv);
			if (this.crtmlfrt != null)
			{
				this.crtmlfrt.VisitContainedRecords(rv);
			}
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x04001512 RID: 5394
		private global::NPOI.HSSF.Record.Chart.AxisRecord axis;

		// Token: 0x04001513 RID: 5395
		private global::NPOI.HSSF.Record.Chart.ValueRangeRecord valueRange;

		// Token: 0x04001514 RID: 5396
		private global::NPOI.HSSF.Record.Aggregates.Chart.AXMAggregate axm;

		// Token: 0x04001515 RID: 5397
		private global::NPOI.HSSF.Record.Aggregates.Chart.AXSAggregate axs;

		// Token: 0x04001516 RID: 5398
		private global::NPOI.HSSF.Record.Aggregates.Chart.CrtMlFrtAggregate crtmlfrt;
	}
}
