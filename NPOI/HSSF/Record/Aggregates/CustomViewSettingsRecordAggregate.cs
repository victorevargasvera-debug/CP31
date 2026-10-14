using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004CF RID: 1231
	public class CustomViewSettingsRecordAggregate : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x06002EAC RID: 11948 RVA: 0x0008A648 File Offset: 0x00088848
		public CustomViewSettingsRecordAggregate(global::NPOI.HSSF.Model.RecordStream rs)
		{
			this._begin = rs.GetNext();
			if (this._begin.Sid != 426)
			{
				throw new global::System.InvalidOperationException("Bad begin record");
			}
			global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase>();
			while (rs.PeekNextSid() != 427)
			{
				if (global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock.IsComponentRecord(rs.PeekNextSid()))
				{
					if (this._psBlock != null)
					{
						if (rs.PeekNextSid() != 2204)
						{
							throw new global::System.InvalidOperationException("Found more than one PageSettingsBlock in chart sub-stream, had sid: " + rs.PeekNextSid().ToString());
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
			this._end = rs.GetNext();
			if (this._end.Sid != 427)
			{
				throw new global::System.InvalidOperationException("Bad custom view Settings end record");
			}
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x0008A74C File Offset: 0x0008894C
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			if (this._recs.Count == 0)
			{
				return;
			}
			rv.VisitRecord(this._begin);
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
			rv.VisitRecord(this._end);
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x0008A7C4 File Offset: 0x000889C4
		public static bool IsBeginRecord(int sid)
		{
			return sid == 426;
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x0008A7CE File Offset: 0x000889CE
		public void Append(global::NPOI.HSSF.Record.RecordBase r)
		{
			this._recs.Add(r);
		}

		// Token: 0x04001463 RID: 5219
		private global::NPOI.HSSF.Record.Record _begin;

		// Token: 0x04001464 RID: 5220
		private global::NPOI.HSSF.Record.Record _end;

		// Token: 0x04001465 RID: 5221
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.RecordBase> _recs;

		// Token: 0x04001466 RID: 5222
		private global::NPOI.HSSF.Record.Aggregates.PageSettingsBlock _psBlock;
	}
}
