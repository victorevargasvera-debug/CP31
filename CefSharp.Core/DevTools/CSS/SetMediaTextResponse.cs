using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000325 RID: 805
	[global::System.Runtime.Serialization.DataContract]
	public class SetMediaTextResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x0001A48D File Offset: 0x0001868D
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x0001A495 File Offset: 0x00018695
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.CSSMedia media { get; set; }

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x0600189E RID: 6302 RVA: 0x0001A49E File Offset: 0x0001869E
		public global::CefSharp.DevTools.CSS.CSSMedia Media
		{
			get
			{
				return this.media;
			}
		}
	}
}
