using System;
using NPOI.SS.Util;

namespace NPOI.HSSF.Record.Common
{
	// Token: 0x0200045D RID: 1117
	public interface IFutureRecord
	{
		// Token: 0x0600294E RID: 10574
		short GetFutureRecordType();

		// Token: 0x0600294F RID: 10575
		global::NPOI.HSSF.Record.Common.FtrHeader GetFutureHeader();

		// Token: 0x06002950 RID: 10576
		global::NPOI.SS.Util.CellRangeAddress GetAssociatedRange();
	}
}
