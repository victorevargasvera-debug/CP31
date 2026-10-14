using System;
using System.Net;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000131 RID: 305
	[global::System.Serializable]
	internal class WebChannelException : global::Gibraltar.GibraltarException
	{
		// Token: 0x06000C84 RID: 3204 RVA: 0x00021838 File Offset: 0x0001FA38
		public WebChannelException(string message, global::System.Exception innerException, global::System.Uri requestUri) : base(message, innerException)
		{
			this.RequestUri = requestUri;
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x0002184C File Offset: 0x0001FA4C
		public WebChannelException(string message) : base(message)
		{
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x00021858 File Offset: 0x0001FA58
		public global::System.Net.WebException WebException
		{
			get
			{
				return base.InnerException as global::System.Net.WebException;
			}
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00021868 File Offset: 0x0001FA68
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x00021870 File Offset: 0x0001FA70
		public global::System.Uri RequestUri { get; private set; }
	}
}
