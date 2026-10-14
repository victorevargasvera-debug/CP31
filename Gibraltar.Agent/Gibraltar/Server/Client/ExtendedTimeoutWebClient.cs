using System;
using System.Net;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200011F RID: 287
	internal class ExtendedTimeoutWebClient : global::System.Net.WebClient
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0001DD60 File Offset: 0x0001BF60
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x0001DD68 File Offset: 0x0001BF68
		public int Timeout { get; set; }

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0001DD74 File Offset: 0x0001BF74
		// (set) Token: 0x06000BC8 RID: 3016 RVA: 0x0001DD7C File Offset: 0x0001BF7C
		public bool UseHttpVersion10 { get; set; }

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0001DD88 File Offset: 0x0001BF88
		protected override global::System.Net.WebRequest GetWebRequest(global::System.Uri address)
		{
			global::System.Net.WebRequest webRequest = base.GetWebRequest(address);
			if (webRequest == null)
			{
				return webRequest;
			}
			if (this.Timeout > 0)
			{
				webRequest.Timeout = this.Timeout;
			}
			if (this.UseHttpVersion10)
			{
				global::System.Net.HttpWebRequest httpWebRequest = webRequest as global::System.Net.HttpWebRequest;
				if (httpWebRequest != null && httpWebRequest.ProtocolVersion != global::System.Net.HttpVersion.Version10)
				{
					httpWebRequest.ProtocolVersion = global::System.Net.HttpVersion.Version10;
				}
			}
			return webRequest;
		}
	}
}
