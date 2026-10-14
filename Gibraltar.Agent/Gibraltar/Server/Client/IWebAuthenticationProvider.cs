using System;
using System.Net;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000129 RID: 297
	internal interface IWebAuthenticationProvider
	{
		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06000C1C RID: 3100
		bool IsAuthenticated { get; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06000C1D RID: 3101
		bool LogoutIsSupported { get; }

		// Token: 0x06000C1E RID: 3102
		void Login(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client);

		// Token: 0x06000C1F RID: 3103
		void Logout(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client);

		// Token: 0x06000C20 RID: 3104
		void PreProcessRequest(global::Gibraltar.Server.Client.WebChannel channel, global::System.Net.WebClient client, string resourceUrl, bool requestSupportsAuthentication);
	}
}
