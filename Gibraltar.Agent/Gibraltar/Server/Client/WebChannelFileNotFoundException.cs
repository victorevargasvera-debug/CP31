using System;
using System.Net;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000132 RID: 306
	[global::System.Serializable]
	internal class WebChannelFileNotFoundException : global::Gibraltar.Server.Client.WebChannelException
	{
		// Token: 0x06000C89 RID: 3209 RVA: 0x0002187C File Offset: 0x0001FA7C
		public WebChannelFileNotFoundException(string message, global::System.Net.WebException innerException, global::System.Uri requestUri) : base(message, innerException, requestUri)
		{
		}
	}
}
