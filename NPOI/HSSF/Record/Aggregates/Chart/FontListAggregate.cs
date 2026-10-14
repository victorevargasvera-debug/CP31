using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004E9 RID: 1257
	public class FontListAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F88 RID: 12168 RVA: 0x0008F044 File Offset: 0x0008D244
		public FontListAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("FONTLIST", container)
		{
			this.frtFontList = (global::NPOI.HSSF.Record.Chart.FrtFontListRecord)rs.GetNext();
			this.startObject = (global::NPOI.HSSF.Record.Chart.ChartStartObjectRecord)rs.GetNext();
			while (rs.PeekNextChartSid() == 49)
			{
				global::NPOI.HSSF.Record.FontRecord key = (global::NPOI.HSSF.Record.FontRecord)rs.GetNext();
				global::NPOI.HSSF.Record.Chart.FbiRecord value;
				if (rs.PeekNextChartSid() == 4192)
				{
					value = (global::NPOI.HSSF.Record.Chart.FbiRecord)rs.GetNext();
				}
				else
				{
					value = null;
				}
				this.dicFonts.Add(key, value);
			}
			this.endObject = (global::NPOI.HSSF.Record.Chart.ChartEndObjectRecord)rs.GetNext();
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x0008F0E4 File Offset: 0x0008D2E4
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			base.WriteStartBlock(rv);
			rv.VisitRecord(this.frtFontList);
			rv.VisitRecord(this.startObject);
			base.IsInStartObject = true;
			foreach (global::System.Collections.Generic.KeyValuePair<global::NPOI.HSSF.Record.FontRecord, global::NPOI.HSSF.Record.Chart.FbiRecord> keyValuePair in this.dicFonts)
			{
				rv.VisitRecord(keyValuePair.Key);
				if (keyValuePair.Value != null)
				{
					rv.VisitRecord(keyValuePair.Value);
				}
			}
			base.IsInStartObject = false;
			rv.VisitRecord(this.endObject);
		}

		// Token: 0x04001517 RID: 5399
		private global::NPOI.HSSF.Record.Chart.FrtFontListRecord frtFontList;

		// Token: 0x04001518 RID: 5400
		private global::NPOI.HSSF.Record.Chart.ChartStartObjectRecord startObject;

		// Token: 0x04001519 RID: 5401
		private global::System.Collections.Generic.Dictionary<global::NPOI.HSSF.Record.FontRecord, global::NPOI.HSSF.Record.Chart.FbiRecord> dicFonts = new global::System.Collections.Generic.Dictionary<global::NPOI.HSSF.Record.FontRecord, global::NPOI.HSSF.Record.Chart.FbiRecord>();

		// Token: 0x0400151A RID: 5402
		private global::NPOI.HSSF.Record.Chart.ChartEndObjectRecord endObject;
	}
}
