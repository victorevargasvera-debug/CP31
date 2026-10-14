using System;
using System.Collections.Generic;
using System.IO;
using NPOI.HSSF.Model;

namespace NPOI.HSSF.Record.Aggregates.Chart
{
	// Token: 0x020004E2 RID: 1250
	public class ChartSheetAggregate : global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate
	{
		// Token: 0x06002F78 RID: 12152 RVA: 0x0008E6A8 File Offset: 0x0008C8A8
		public ChartSheetAggregate(global::NPOI.HSSF.Model.RecordStream rs, global::NPOI.HSSF.Record.Aggregates.Chart.ChartRecordAggregate container) : base("CHARTSHEET", container)
		{
			this._bofRec = (global::NPOI.HSSF.Record.BOFRecord)rs.GetNext();
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase>();
			while (rs.PeekNextClass() != typeof(global::NPOI.HSSF.Record.EOFRecord))
			{
				rs.PeekNextClass();
				if (global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.IsComponentRecord(rs.PeekNextChartSid()))
				{
					if (this._psBlock != null)
					{
						if (rs.PeekNextChartSid() != 2204)
						{
							throw new global::System.IO.InvalidDataException("Found more than one PageSettingsBlock in chart sub-stream");
						}
						this._psBlock.AddLateHeaderFooter((global::NPOI.HSSF.Record.HeaderFooterRecord)rs.GetNext());
					}
					else
					{
						this._psBlock = new global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock(rs);
						list.Add(this._psBlock);
					}
				}
				else if (rs.PeekNextChartSid() == 4098)
				{
					this.chartFormats = new global::NPOI.HSSF.Record.Aggregates.Chart.ChartFormatsAggregate(rs, this);
					list.Add(this.chartFormats);
				}
				else if (rs.PeekNextChartSid() == 512)
				{
					this.seriesData = new global::NPOI.HSSF.Record.Aggregates.Chart.SeriesDataAggregate(rs);
					list.Add(this.seriesData);
				}
				else
				{
					list.Add(rs.GetNext());
				}
			}
			this._recs = list;
			if (!(rs.GetNext() is global::NPOI.HSSF.Record.EOFRecord))
			{
				throw new global::System.InvalidOperationException("Bad chart EOF");
			}
		}

		// Token: 0x06002F79 RID: 12153 RVA: 0x0008E7DC File Offset: 0x0008C9DC
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			if (this._recs.Count == 0)
			{
				return;
			}
			rv.VisitRecord(this._bofRec);
			for (int i = 0; i < this._recs.Count; i++)
			{
				global::NPOI.HSSF.Record.RecordBase recordBase = this._recs[i];
				if (recordBase is global::NPOI.HSSF.Record.Aggregates.RecordAggregate)
				{
					((global::NPOI.HSSF.Record.Aggregates.RecordAggregate)recordBase).VisitContainedRecords(rv);
				}
				else
				{
					rv.VisitRecord((global::NPOI.HSSF.Record.Record)recordBase);
				}
			}
			rv.VisitRecord(global::NPOI.HSSF.Record.EOFRecord.instance);
		}

		// Token: 0x040014EF RID: 5359
		private global::NPOI.HSSF.Record.BOFRecord _bofRec;

		// Token: 0x040014F0 RID: 5360
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> _recs;

		// Token: 0x040014F1 RID: 5361
		private global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock _psBlock;

		// Token: 0x040014F2 RID: 5362
		private global::NPOI.HSSF.Record.Aggregates.Chart.ChartFormatsAggregate chartFormats;

		// Token: 0x040014F3 RID: 5363
		private global::NPOI.HSSF.Record.Aggregates.Chart.SeriesDataAggregate seriesData;

		// Token: 0x040014F4 RID: 5364
		internal int AttachLabelCount;
	}
}
