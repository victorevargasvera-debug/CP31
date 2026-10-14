using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Network;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000137 RID: 311
	[global::System.Runtime.Serialization.DataContract]
	public class GetCookiesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x0000C065 File Offset: 0x0000A265
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x0000C06D File Offset: 0x0000A26D
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.Cookie> cookies { get; set; }

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x0000C076 File Offset: 0x0000A276
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.Cookie> Cookies
		{
			get
			{
				return this.cookies;
			}
		}
	}
}
