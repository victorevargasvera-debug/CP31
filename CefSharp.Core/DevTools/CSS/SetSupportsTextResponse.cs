using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000327 RID: 807
	[global::System.Runtime.Serialization.DataContract]
	public class SetSupportsTextResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x060018A4 RID: 6308 RVA: 0x0001A4CF File Offset: 0x000186CF
		// (set) Token: 0x060018A5 RID: 6309 RVA: 0x0001A4D7 File Offset: 0x000186D7
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.CSSSupports supports { get; set; }

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x060018A6 RID: 6310 RVA: 0x0001A4E0 File Offset: 0x000186E0
		public global::CefSharp.DevTools.CSS.CSSSupports Supports
		{
			get
			{
				return this.supports;
			}
		}
	}
}
