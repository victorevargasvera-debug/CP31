using System;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000130 RID: 304
	[global::System.Serializable]
	internal class WebChannelConnectFailureException : global::Gibraltar.Server.Client.WebChannelException
	{
		// Token: 0x06000C82 RID: 3202 RVA: 0x00021820 File Offset: 0x0001FA20
		public WebChannelConnectFailureException(string message, global::System.Exception innerException, global::System.Uri requestUri) : base(message, innerException, requestUri)
		{
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x0002182C File Offset: 0x0001FA2C
		public WebChannelConnectFailureException(string message) : base(message)
		{
		}
	}
}
