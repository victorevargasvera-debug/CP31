using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000122 RID: 290
	[global::System.Runtime.Serialization.DataContract]
	public class TrustTokens : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000362 RID: 866
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0000BB11 File Offset: 0x00009D11
		// (set) Token: 0x06000910 RID: 2320 RVA: 0x0000BB19 File Offset: 0x00009D19
		[global::System.Runtime.Serialization.DataMember(Name = "issuerOrigin", IsRequired = true)]
		public string IssuerOrigin { get; set; }

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0000BB22 File Offset: 0x00009D22
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x0000BB2A File Offset: 0x00009D2A
		[global::System.Runtime.Serialization.DataMember(Name = "count", IsRequired = true)]
		public double Count { get; set; }
	}
}
