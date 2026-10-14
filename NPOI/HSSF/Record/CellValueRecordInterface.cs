using System;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003B4 RID: 948
	public interface CellValueRecordInterface
	{
		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060020E6 RID: 8422
		// (set) Token: 0x060020E7 RID: 8423
		int Row { get; set; }

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060020E8 RID: 8424
		// (set) Token: 0x060020E9 RID: 8425
		int Column { get; set; }

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060020EA RID: 8426
		// (set) Token: 0x060020EB RID: 8427
		short XFIndex { get; set; }
	}
}
