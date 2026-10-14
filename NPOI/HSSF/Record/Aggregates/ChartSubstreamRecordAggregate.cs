using System;
using System.Collections.Generic;
using System.IO;
using NPOI.HSSF.Model;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004CA RID: 1226
	public class ChartSubstreamRecordAggregate : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x06002E5C RID: 11868 RVA: 0x00088D34 File Offset: 0x00086F34
		public ChartSubstreamRecordAggregate(global::NPOI.HSSF.Model.RecordStream rs)
		{
			this._bofRec = (global::NPOI.HSSF.Record.BOFRecord)rs.GetNext();
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase>();
			while (rs.PeekNextClass() != typeof(global::NPOI.HSSF.Record.EOFRecord))
			{
				rs.PeekNextClass();
				if (global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.IsComponentRecord(rs.PeekNextSid()))
				{
					if (this._psBlock != null)
					{
						if (rs.PeekNextSid() != 2204)
						{
							throw new global::System.IO.InvalidDataException("Found more than one PageSettingsBlock in chart sub-stream, had sid: " + rs.PeekNextSid().ToString());
						}
						this._psBlock.AddLateHeaderFooter((global::NPOI.HSSF.Record.HeaderFooterRecord)rs.GetNext());
					}
					else
					{
						this._psBlock = new global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock(rs);
						list.Add(this._psBlock);
					}
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

		// Token: 0x06002E5D RID: 11869 RVA: 0x00088E24 File Offset: 0x00087024
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

		// Token: 0x04001456 RID: 5206
		private global::NPOI.HSSF.Record.BOFRecord _bofRec;

		// Token: 0x04001457 RID: 5207
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> _recs;

		// Token: 0x04001458 RID: 5208
		private global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock _psBlock;
	}
}
