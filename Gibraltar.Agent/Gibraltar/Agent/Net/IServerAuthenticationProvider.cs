using System;
using System.Net;

namespace Gibraltar.Agent.Net
{
	// Token: 0x02000017 RID: 23
	public interface IServerAuthenticationProvider
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000174 RID: 372
		bool IsAuthenticated { get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000175 RID: 373
		bool LogoutIsSupported { get; }

		// Token: 0x06000176 RID: 374
		void Login(global::System.Uri entryUri, global::System.Net.WebClient client);

		// Token: 0x06000177 RID: 375
		void Logout(global::System.Uri entryUri, global::System.Net.WebClient client);

		// Token: 0x06000178 RID: 376
		void PreProcessRequest(global::System.Uri entryUri, global::System.Net.WebClient client, string resourceUrl, bool requestSupportsAuthentication);
	}
}
