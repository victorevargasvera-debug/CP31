using System;
using System.Collections;
using System.IO;
using NPOI.HSSF.Record;

namespace NPOI.HSSF.EventModel
{
	// Token: 0x0200033C RID: 828
	public class EventRecordFactory
	{
		// Token: 0x060018A8 RID: 6312 RVA: 0x0004B5EC File Offset: 0x000497EC
		public EventRecordFactory(global::NPOI.HSSF.EventModel.IERFListener listener, global::System.Collections.ArrayList sids)
		{
			this._listener = listener;
			this._sids = sids;
			if (this._sids == null)
			{
				this._sids = null;
				return;
			}
			if (this._sids == null)
			{
				this._sids = new global::System.Collections.ArrayList();
			}
			this._sids.Sort();
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0004B63B File Offset: 0x0004983B
		private bool IsSidIncluded(int sid)
		{
			return this._sids == null || this._sids.BinarySearch((short)sid) >= 0;
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0004B65F File Offset: 0x0004985F
		private bool ProcessRecord(global::NPOI.HSSF.Record.Record record)
		{
			return !this.IsSidIncluded((int)record.Sid) || this._listener.ProcessRecord(record);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0004B680 File Offset: 0x00049880
		public void ProcessRecords(global::System.IO.Stream in1)
		{
			global::NPOI.HSSF.Record.Record record = null;
			global::NPOI.HSSF.Record.RecordInputStream recordInputStream = new global::NPOI.HSSF.Record.RecordInputStream(in1);
			while (recordInputStream.HasNextRecord)
			{
				recordInputStream.NextRecord();
				global::NPOI.HSSF.Record.Record[] array = global::NPOI.HSSF.Record.RecordFactory.CreateRecord(recordInputStream);
				if (array.Length > 1)
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (record != null && !this.ProcessRecord(record))
						{
							return;
						}
						record = array[i];
					}
				}
				else
				{
					global::NPOI.HSSF.Record.Record record2 = array[0];
					if (record2 != null)
					{
						if (record != null && !this.ProcessRecord(record))
						{
							return;
						}
						record = record2;
					}
				}
			}
			if (record != null)
			{
				this.ProcessRecord(record);
			}
		}

		// Token: 0x040009E9 RID: 2537
		private global::NPOI.HSSF.EventModel.IERFListener _listener;

		// Token: 0x040009EA RID: 2538
		private global::System.Collections.ArrayList _sids;
	}
}
