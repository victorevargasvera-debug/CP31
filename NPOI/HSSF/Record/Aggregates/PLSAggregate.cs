using System;
using System.Collections.Generic;
using NPOI.HSSF.Model;

namespace NPOI.HSSF.Record.Aggregates
{
	// Token: 0x020004D4 RID: 1236
	internal class PLSAggregate : global::NPOI.HSSF.Record.Aggregates.RecordAggregate
	{
		// Token: 0x06002F0C RID: 12044 RVA: 0x0008BAAC File Offset: 0x00089CAC
		public PLSAggregate(global::NPOI.HSSF.Model.RecordStream rs)
		{
			this._pls = rs.GetNext();
			if (rs.PeekNextSid() == 60)
			{
				global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ContinueRecord> list = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.ContinueRecord>();
				while (rs.PeekNextSid() == 60)
				{
					list.Add((global::NPOI.HSSF.Record.ContinueRecord)rs.GetNext());
				}
				this._plsContinues = new global::NPOI.HSSF.Record.ContinueRecord[list.Count];
				this._plsContinues = list.ToArray();
				return;
			}
			this._plsContinues = global::NPOI.HSSF.Record.Aggregates.PLSAggregate.EMPTY_CONTINUE_RECORD_ARRAY;
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x0008BB24 File Offset: 0x00089D24
		public override void VisitContainedRecords(global::NPOI.HSSF.Record.Aggregates.RecordVisitor rv)
		{
			rv.VisitRecord(this._pls);
			for (int i = 0; i < this._plsContinues.Length; i++)
			{
				rv.VisitRecord(this._plsContinues[i]);
			}
		}

		// Token: 0x04001480 RID: 5248
		private static global::NPOI.HSSF.Record.ContinueRecord[] EMPTY_CONTINUE_RECORD_ARRAY = new global::NPOI.HSSF.Record.ContinueRecord[0];

		// Token: 0x04001481 RID: 5249
		private global::NPOI.HSSF.Record.Record _pls;

		// Token: 0x04001482 RID: 5250
		private global::NPOI.HSSF.Record.ContinueRecord[] _plsContinues;
	}
}
