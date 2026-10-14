using System;
using NPOI.HSSF.Record;

namespace NPOI.HSSF.EventModel
{
	// Token: 0x0200033B RID: 827
	public interface IERFListener
	{
		// Token: 0x060018A7 RID: 6311
		bool ProcessRecord(global::NPOI.HSSF.Record.Record rec);
	}
}
