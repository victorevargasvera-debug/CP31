using System;
using System.Collections;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.Chart;

namespace NPOI.HSSF.Model
{
	// Token: 0x02000335 RID: 821
	public class RecordStream
	{
		// Token: 0x06001774 RID: 6004 RVA: 0x000466E0 File Offset: 0x000448E0
		public RecordStream(global::System.Collections.IList inputList, int startIndex, int endIx)
		{
			this._list = inputList;
			this._nextIndex = startIndex;
			this._endIx = endIx;
			this._countRead = 0;
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00046704 File Offset: 0x00044904
		public RecordStream(global::System.Collections.IList records, int startIx) : this(records, startIx, records.Count)
		{
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00046714 File Offset: 0x00044914
		public bool HasNext()
		{
			return this._nextIndex < this._endIx;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00046724 File Offset: 0x00044924
		public global::NPOI.HSSF.Record.Record GetNext()
		{
			if (this._nextIndex >= this._list.Count)
			{
				throw new global::System.Exception("Attempt to Read past end of record stream");
			}
			this._countRead++;
			global::System.Collections.IList list = this._list;
			int nextIndex = this._nextIndex;
			this._nextIndex = nextIndex + 1;
			return (global::NPOI.HSSF.Record.Record)list[nextIndex];
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0004677E File Offset: 0x0004497E
		public int PeekNextSid()
		{
			if (!this.HasNext())
			{
				return -1;
			}
			return (int)((global::NPOI.HSSF.Record.Record)this._list[this._nextIndex]).Sid;
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x000467A5 File Offset: 0x000449A5
		public global::System.Type PeekNextClass()
		{
			if (this._nextIndex >= this._list.Count)
			{
				return null;
			}
			return this._list[this._nextIndex].GetType();
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x000467D2 File Offset: 0x000449D2
		public int GetCountRead()
		{
			return this._countRead;
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x000467DA File Offset: 0x000449DA
		public int PeekNextChartSid()
		{
			if (!this.HasNext())
			{
				return -1;
			}
			while (this.PeekNextSid() == (int)global::NPOI.HSSF.Record.Chart.StartBlockRecord.sid || this.PeekNextSid() == 2131)
			{
				this.GetNext();
			}
			return this.PeekNextSid();
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00046810 File Offset: 0x00044A10
		public void FindChartSubStream()
		{
			while (this.PeekNextSid() > -1)
			{
				global::NPOI.HSSF.Record.Record next = this.GetNext();
				if (next.Sid == 2057 && (next as global::NPOI.HSSF.Record.BOFRecord).Type == global::NPOI.HSSF.Record.BOFRecordType.Chart)
				{
					this._nextIndex--;
					this._countRead--;
					return;
				}
			}
		}

		// Token: 0x040009A1 RID: 2465
		private global::System.Collections.IList _list;

		// Token: 0x040009A2 RID: 2466
		private int _nextIndex;

		// Token: 0x040009A3 RID: 2467
		private int _endIx;

		// Token: 0x040009A4 RID: 2468
		private int _countRead;
	}
}
