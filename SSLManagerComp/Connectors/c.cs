using System;

namespace SSLMangrComp.Connectors
{
	// Token: 0x02000033 RID: 51
	internal interface c
	{
		// Token: 0x06000124 RID: 292
		void Connect(global::SSLMangrComp.PNConnectionInfo connInfo);

		// Token: 0x06000125 RID: 293
		void ShutdownClient();

		// Token: 0x06000126 RID: 294
		void WriteData(byte[] dataToWrite);
	}
}
