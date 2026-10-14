using System;
using System.Net;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200012F RID: 303
	[global::System.Serializable]
	internal class WebChannelAuthorizationException : global::Gibraltar.Server.Client.WebChannelException
	{
		// Token: 0x06000C80 RID: 3200 RVA: 0x00021808 File Offset: 0x0001FA08
		public WebChannelAuthorizationException(string message, global::System.Net.WebException innerException, global::System.Uri requestUri) : base(message, innerException, requestUri)
		{
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00021814 File Offset: 0x0001FA14
		public WebChannelAuthorizationException(string message) : base(message)
		{
		}
	}
}
