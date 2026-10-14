using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x0200033E RID: 830
	[global::System.Runtime.Serialization.DataContract]
	public class GetWindowBoundsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x0001B060 File Offset: 0x00019260
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x0001B068 File Offset: 0x00019268
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Browser.Bounds bounds { get; set; }

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x0001B071 File Offset: 0x00019271
		public global::CefSharp.DevTools.Browser.Bounds Bounds
		{
			get
			{
				return this.bounds;
			}
		}
	}
}
