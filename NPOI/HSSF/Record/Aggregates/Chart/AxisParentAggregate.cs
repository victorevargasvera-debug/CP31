using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004DD RID: 1245
	public class AxisParentAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06002F62 RID: 12130 RVA: 0x0008D454 File Offset: 0x0008B654
		public global::NPOI.HSSF.Record.Chart.AxisParentRecord AxisParent
		{
			get
			{
				return this.axisPraent;
			}
		}

		// Token: 0x06002F63 RID: 12131 RVA: 0x0008D45C File Offset: 0x0008B65C
		public AxisParentAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("AXISPARENT", container)
		{
			this.axisPraent = (global::NPOI.HSSF.Record.Chart.AxisParentRecord)rs.GetNext();
			rs.GetNext();
			this.pos = (global::NPOI.HSSF.Record.Chart.PosRecord)rs.GetNext();
			if (4116 == rs.PeekNextChartSid())
			{
				goto IL_78;
			}
			try
			{
				this.axes = new global::NPOI.HSSF.Record.Aggregates.Chart.AxesAggregate(rs, this);
				goto IL_78;
			}
			catch
			{
				this.axes = null;
				goto IL_78;
			}
			IL_66:
			this.crtList.Add(new global::NPOI.HSSF.Record.Aggregates.Chart.CRTAggregate(rs, this));
			IL_78:
			if (4116 != rs.PeekNextChartSid())
			{
				rs.GetNext();
				return;
			}
			goto IL_66;
		}

		// Token: 0x06002F64 RID: 12132 RVA: 0x0008D508 File Offset: 0x0008B708
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.axisPraent);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.BeginRecord.instance);
			rv.VisitRecord(this.pos);
			if (this.axes != null)
			{
				this.axes.VisitContainedRecords(rv);
			}
			foreach (global::NPOI.HSSF.Record.Aggregates.Chart.CRTAggregate crtaggregate in this.crtList)
			{
				crtaggregate.VisitContainedRecords(rv);
			}
			base.WriteEndBlock(rv);
			rv.VisitRecord(global::NPOI.HSSF.Record.Chart.EndRecord.instance);
		}

		// Token: 0x040014AC RID: 5292
		private global::NPOI.HSSF.Record.Chart.AxisParentRecord axisPraent;

		// Token: 0x040014AD RID: 5293
		private global::NPOI.HSSF.Record.Chart.PosRecord pos;

		// Token: 0x040014AE RID: 5294
		private global::NPOI.HSSF.Record.Aggregates.Chart.AxesAggregate axes;

		// Token: 0x040014AF RID: 5295
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.CRTAggregate> crtList = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Aggregates.Chart.CRTAggregate>();
	}
}
