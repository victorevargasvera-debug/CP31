using System;
using System.Collections.Generic;

namespace SSLAdminTool
{
	// Token: 0x02000004 RID: 4
	public interface IDataStoreDecryptHandler
	{
		// Token: 0x0600000E RID: 14
		string PatDataStoreRead();

		// Token: 0x0600000F RID: 15
		global::System.Collections.Generic.List<global::SSLAdminTool.PNServer> XStoreRead();

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16
		bool XStoreAvailable { get; }

		// Token: 0x06000011 RID: 17
		bool IsXStoreValid();

		// Token: 0x06000012 RID: 18
		void dhUpdateEventThread();

		// Token: 0x06000013 RID: 19
		bool isDHkeyExpired();

		// Token: 0x06000014 RID: 20
		global::SSLAdminTool.RawData GetRawCertData(string SerName);
	}
}
