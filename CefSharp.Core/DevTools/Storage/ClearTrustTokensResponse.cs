using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x0200013A RID: 314
	[global::System.Runtime.Serialization.DataContract]
	public class ClearTrustTokensResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0000C113 File Offset: 0x0000A313
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x0000C11B File Offset: 0x0000A31B
		[global::System.Runtime.Serialization.DataMember]
		internal bool didDeleteTokens { get; set; }

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0000C124 File Offset: 0x0000A324
		public bool DidDeleteTokens
		{
			get
			{
				return this.didDeleteTokens;
			}
		}
	}
}
