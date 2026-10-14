using System;
using AcpCommonLib;

namespace AcpUILib
{
	// Token: 0x02000009 RID: 9
	public interface IAcpRecNavToolbar
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000020 RID: 32
		// (set) Token: 0x06000021 RID: 33
		global::AcpCommonLib.IAcpRecordset MyRecordsetDataSource { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000022 RID: 34
		// (set) Token: 0x06000023 RID: 35
		global::AcpCommonLib.IAcpRecordset MySecondaryRecordsetDataSource { get; set; }

		// Token: 0x06000024 RID: 36
		void SyncDataSources();
	}
}
