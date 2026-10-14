using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000139 RID: 313
	[global::System.Runtime.Serialization.DataContract]
	public class GetTrustTokensResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0000C0F2 File Offset: 0x0000A2F2
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x0000C0FA File Offset: 0x0000A2FA
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Storage.TrustTokens> tokens { get; set; }

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0000C103 File Offset: 0x0000A303
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Storage.TrustTokens> Tokens
		{
			get
			{
				return this.tokens;
			}
		}
	}
}
