using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004EF RID: 1263
	public class SeriesDataAggregate : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x06002F95 RID: 12181 RVA: 0x0008F7B0 File Offset: 0x0008D9B0
		public SeriesDataAggregate(global::NPOI.HSSF.Model.RecordStream rs)
		{
			this.dimensions = (global::NPOI.HSSF.Record.DimensionsRecord)rs.GetNext();
			while (rs.PeekNextChartSid() == 4197)
			{
				global::NPOI.HSSF.Record.Chart.SeriesIndexRecord key = (global::NPOI.HSSF.Record.Chart.SeriesIndexRecord)rs.GetNext();
				int num = rs.PeekNextChartSid();
				global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>();
				while (num == 515 || num == 517 || num == 513 || num == 516)
				{
					list.Add(rs.GetNext());
				}
				this.dicData.Add(key, list);
			}
		}

		// Token: 0x06002F96 RID: 12182 RVA: 0x0008F844 File Offset: 0x0008DA44
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this.dimensions);
			foreach (global::System.Collections.Generic.KeyValuePair<global::NPOI.HSSF.Record.Chart.SeriesIndexRecord, global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>> keyValuePair in this.dicData)
			{
				rv.VisitRecord(keyValuePair.Key);
				foreach (global::NPOI.HSSF.Record.Record r in keyValuePair.Value)
				{
					rv.VisitRecord(r);
				}
			}
		}

		// Token: 0x04001535 RID: 5429
		private global::NPOI.HSSF.Record.DimensionsRecord dimensions;

		// Token: 0x04001536 RID: 5430
		private global::System.Collections.Generic.Dictionary<global::NPOI.HSSF.Record.Chart.SeriesIndexRecord, global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>> dicData = new global::System.Collections.Generic.Dictionary<global::NPOI.HSSF.Record.Chart.SeriesIndexRecord, global::System.Collections.Generic.List<global::NPOI.HSSF.Record.Record>>();
	}
}
