using System;
using System.Net;

namespace SSLMangrComp.Connectors
{
	// Token: 0x02000032 RID: 50
	internal interface b
	{
		// Token: 0x06000120 RID: 288
		void Connect(global::System.Net.IPAddress pnIpAddress, int portNumber, global::SSLMangrComp.SecureClientConfiguration clientConfig);

		// Token: 0x06000121 RID: 289
		void Connect(global::System.Net.IPAddress pnIpAddress, int portNumber);

		// Token: 0x06000122 RID: 290
		void ShutdownClient();

		// Token: 0x06000123 RID: 291
		void WriteData(byte[] dataToWrite);
	}
}
