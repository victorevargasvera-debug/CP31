using System;
using System.Collections;
using NPOI.HSSF.Record;

namespace NPOI.HSSF.EventUserModel
{
	// Token: 0x0200034B RID: 843
	public class HSSFRequest
	{
		// Token: 0x06001925 RID: 6437 RVA: 0x0004D3F4 File Offset: 0x0004B5F4
		public HSSFRequest()
		{
			this.records = new global::System.Collections.Hashtable(50);
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x0004D40C File Offset: 0x0004B60C
		public void AddListener(global::NPOI.HSSF.EventUserModel.IHSSFListener lsnr, short sid)
		{
			object obj = this.records[sid];
			global::System.Collections.IList list;
			if (obj != null)
			{
				list = (global::System.Collections.IList)obj;
				return;
			}
			list = new global::System.Collections.ArrayList(1);
			list.Add(lsnr);
			this.records[sid] = list;
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x0004D45C File Offset: 0x0004B65C
		public void AddListenerForAllRecords(global::NPOI.HSSF.EventUserModel.IHSSFListener lsnr)
		{
			short[] allKnownRecordSIDs = global::NPOI.HSSF.Record.RecordFactory.GetAllKnownRecordSIDs();
			for (int i = 0; i < allKnownRecordSIDs.Length; i++)
			{
				this.AddListener(lsnr, allKnownRecordSIDs[i]);
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x0004D488 File Offset: 0x0004B688
		public short ProcessRecord(global::NPOI.HSSF.Record.Record rec)
		{
			object obj = this.records[rec.Sid];
			short num = 0;
			if (obj != null)
			{
				global::System.Collections.IList list = (global::System.Collections.IList)obj;
				for (int i = 0; i < list.Count; i++)
				{
					object obj2 = list[i];
					if (obj2 is global::NPOI.HSSF.EventUserModel.AbortableHSSFListener)
					{
						num = ((global::NPOI.HSSF.EventUserModel.AbortableHSSFListener)obj2).AbortableProcessRecord(rec);
						if (num != 0)
						{
							break;
						}
					}
					else
					{
						((global::NPOI.HSSF.EventUserModel.IHSSFListener)obj2).ProcessRecord(rec);
					}
				}
			}
			return num;
		}

		// Token: 0x04000A08 RID: 2568
		private global::System.Collections.Hashtable records;
	}
}
