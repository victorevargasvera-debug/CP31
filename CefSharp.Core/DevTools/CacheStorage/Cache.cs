using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CacheStorage
{
	// Token: 0x020002ED RID: 749
	[global::System.Runtime.Serialization.DataContract]
	public class Cache : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x00019387 File Offset: 0x00017587
		// (set) Token: 0x060016E2 RID: 5858 RVA: 0x0001938F File Offset: 0x0001758F
		[global::System.Runtime.Serialization.DataMember(Name = "cacheId", IsRequired = true)]
		public string CacheId { get; set; }

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x00019398 File Offset: 0x00017598
		// (set) Token: 0x060016E4 RID: 5860 RVA: 0x000193A0 File Offset: 0x000175A0
		[global::System.Runtime.Serialization.DataMember(Name = "securityOrigin", IsRequired = true)]
		public string SecurityOrigin { get; set; }

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x000193A9 File Offset: 0x000175A9
		// (set) Token: 0x060016E6 RID: 5862 RVA: 0x000193B1 File Offset: 0x000175B1
		[global::System.Runtime.Serialization.DataMember(Name = "storageKey", IsRequired = true)]
		public string StorageKey { get; set; }

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x000193BA File Offset: 0x000175BA
		// (set) Token: 0x060016E8 RID: 5864 RVA: 0x000193C2 File Offset: 0x000175C2
		[global::System.Runtime.Serialization.DataMember(Name = "cacheName", IsRequired = true)]
		public string CacheName { get; set; }
	}
}
