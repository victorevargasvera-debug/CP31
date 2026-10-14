using System;
using NPOI.HSSF.Record;

namespace NPOI.HSSF.EventUserModel
{
	// Token: 0x02000349 RID: 841
	public interface IHSSFListener
	{
		// Token: 0x06001920 RID: 6432
		void ProcessRecord(global::NPOI.HSSF.Record.Record record);
	}
}
