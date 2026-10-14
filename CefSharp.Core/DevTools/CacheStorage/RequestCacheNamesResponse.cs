using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CacheStorage
{
	// Token: 0x020002F0 RID: 752
	[global::System.Runtime.Serialization.DataContract]
	public class RequestCacheNamesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x00019416 File Offset: 0x00017616
		// (set) Token: 0x060016F3 RID: 5875 RVA: 0x0001941E File Offset: 0x0001761E
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CacheStorage.Cache> caches { get; set; }

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00019427 File Offset: 0x00017627
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CacheStorage.Cache> Caches
		{
			get
			{
				return this.caches;
			}
		}
	}
}
