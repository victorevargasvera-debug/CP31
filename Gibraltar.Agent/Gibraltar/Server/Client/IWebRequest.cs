using System;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200012B RID: 299
	internal interface IWebRequest
	{
		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06000C28 RID: 3112
		// (remove) Token: 0x06000C29 RID: 3113
		event global::Gibraltar.Server.Client.WebRequestEventHandler Canceled;

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06000C2A RID: 3114
		// (remove) Token: 0x06000C2B RID: 3115
		event global::Gibraltar.Server.Client.WebRequestEventHandler Complete;

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06000C2C RID: 3116
		bool RequiresAuthentication { get; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06000C2D RID: 3117
		bool SupportsAuthentication { get; }

		// Token: 0x06000C2E RID: 3118
		void ProcessRequest(global::Gibraltar.Server.Client.IWebChannelConnection connection);
	}
}
