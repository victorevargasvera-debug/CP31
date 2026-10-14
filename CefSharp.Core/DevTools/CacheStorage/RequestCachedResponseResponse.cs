using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CacheStorage
{
	// Token: 0x020002F1 RID: 753
	[global::System.Runtime.Serialization.DataContract]
	public class RequestCachedResponseResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x00019437 File Offset: 0x00017637
		// (set) Token: 0x060016F7 RID: 5879 RVA: 0x0001943F File Offset: 0x0001763F
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CacheStorage.CachedResponse response { get; set; }

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x00019448 File Offset: 0x00017648
		public global::CefSharp.DevTools.CacheStorage.CachedResponse Response
		{
			get
			{
				return this.response;
			}
		}
	}
}
