using System;
using System.Collections.Generic;

namespace NPOI.HSSF.Record
{
	// Token: 0x0200043C RID: 1084
	public class VerticalPageBreakRecord : global::NPOI.HSSF.Record.PageBreakRecord
	{
		// Token: 0x06002803 RID: 10243 RVA: 0x0006C66E File Offset: 0x0006A86E
		public VerticalPageBreakRecord()
		{
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x0006C676 File Offset: 0x0006A876
		public VerticalPageBreakRecord(global::NPOI.HSSF.Record.RecordInputStream in1) : base(in1)
		{
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06002805 RID: 10245 RVA: 0x00078AA8 File Offset: 0x00076CA8
		public override short Sid
		{
			get
			{
				return 26;
			}
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00078AAC File Offset: 0x00076CAC
		public override object Clone()
		{
			global::NPOI.HSSF.Record.PageBreakRecord pageBreakRecord = new global::NPOI.HSSF.Record.VerticalPageBreakRecord();
			global::System.Collections.Generic.IEnumerator<global::NPOI.HSSF.Record.PageBreakRecord.Break> breaksEnumerator = base.GetBreaksEnumerator();
			while (breaksEnumerator.MoveNext())
			{
				global::NPOI.HSSF.Record.PageBreakRecord.Break @break = breaksEnumerator.Current;
				pageBreakRecord.AddBreak(@break.main, @break.subFrom, @break.subTo);
			}
			return pageBreakRecord;
		}

		// Token: 0x040010FE RID: 4350
		public new const short sid = 26;
	}
}
