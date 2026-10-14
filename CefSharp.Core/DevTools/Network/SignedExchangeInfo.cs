using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000208 RID: 520
	[global::System.Runtime.Serialization.DataContract]
	public class SignedExchangeInfo : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00011B77 File Offset: 0x0000FD77
		// (set) Token: 0x06000FF8 RID: 4088 RVA: 0x00011B7F File Offset: 0x0000FD7F
		[global::System.Runtime.Serialization.DataMember(Name = "outerResponse", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Response OuterResponse { get; set; }

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00011B88 File Offset: 0x0000FD88
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x00011B90 File Offset: 0x0000FD90
		[global::System.Runtime.Serialization.DataMember(Name = "header", IsRequired = false)]
		public global::CefSharp.DevTools.Network.SignedExchangeHeader Header { get; set; }

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00011B99 File Offset: 0x0000FD99
		// (set) Token: 0x06000FFC RID: 4092 RVA: 0x00011BA1 File Offset: 0x0000FDA1
		[global::System.Runtime.Serialization.DataMember(Name = "securityDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Network.SecurityDetails SecurityDetails { get; set; }

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00011BAA File Offset: 0x0000FDAA
		// (set) Token: 0x06000FFE RID: 4094 RVA: 0x00011BB2 File Offset: 0x0000FDB2
		[global::System.Runtime.Serialization.DataMember(Name = "errors", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.SignedExchangeError> Errors { get; set; }
	}
}
