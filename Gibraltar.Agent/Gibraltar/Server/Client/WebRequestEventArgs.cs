using System;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000134 RID: 308
	internal class WebRequestEventArgs : global::System.EventArgs
	{
		// Token: 0x06000C97 RID: 3223 RVA: 0x00021B10 File Offset: 0x0001FD10
		internal WebRequestEventArgs(global::Gibraltar.Server.Client.WebRequestState state)
		{
			this.State = state;
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00021B20 File Offset: 0x0001FD20
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x00021B28 File Offset: 0x0001FD28
		public global::Gibraltar.Server.Client.WebRequestState State { get; private set; }
	}
}
