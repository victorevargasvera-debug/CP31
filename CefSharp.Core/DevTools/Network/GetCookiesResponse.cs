using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000238 RID: 568
	[global::System.Runtime.Serialization.DataContract]
	public class GetCookiesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00012A75 File Offset: 0x00010C75
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x00012A7D File Offset: 0x00010C7D
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.Cookie> cookies { get; set; }

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00012A86 File Offset: 0x00010C86
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.Cookie> Cookies
		{
			get
			{
				return this.cookies;
			}
		}
	}
}
