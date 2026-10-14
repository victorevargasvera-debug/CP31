using System;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003A9 RID: 937
	public interface BiffHeaderInput
	{
		// Token: 0x06002069 RID: 8297
		int ReadRecordSID();

		// Token: 0x0600206A RID: 8298
		int ReadDataSize();

		// Token: 0x0600206B RID: 8299
		int Available();
	}
}
