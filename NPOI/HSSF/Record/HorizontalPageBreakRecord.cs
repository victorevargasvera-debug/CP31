using System;
using System.Collections.Generic;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003EA RID: 1002
	public class HorizontalPageBreakRecord : global::NPOI.HSSF.Record.PageBreakRecord, global::System.ICloneable
	{
		// Token: 0x06002409 RID: 9225 RVA: 0x0006C66E File Offset: 0x0006A86E
		public HorizontalPageBreakRecord()
		{
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0006C676 File Offset: 0x0006A876
		public HorizontalPageBreakRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x0006C67F File Offset: 0x0006A87F
		public override short Sid
		{
			get
			{
				return 27;
			}
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0006C684 File Offset: 0x0006A884
		public override object Clone()
		{
			global::NPOI.HSSF.Record.PageBreakRecord pageBreakRecord = new global::NPOI.HSSF.Record.HorizontalPageBreakRecord();
			global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.Record.PageBreakRecord.Break> breaksEnumerator = base.GetBreaksEnumerator();
			while (breaksEnumerator.MoveNext())
			{
				global::NPOI.HSSF.Record.PageBreakRecord.Break @break = breaksEnumerator.Current;
				pageBreakRecord.AddBreak(@break.main, @break.subFrom, @break.subTo);
			}
			return pageBreakRecord;
		}

		// Token: 0x04000F21 RID: 3873
		public new const short sid = 27;
	}
}
