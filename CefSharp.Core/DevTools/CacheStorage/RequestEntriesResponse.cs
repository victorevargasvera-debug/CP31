using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CacheStorage
{
	// Token: 0x020002F2 RID: 754
	[global::System.Runtime.Serialization.DataContract]
	public class RequestEntriesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x00019458 File Offset: 0x00017658
		// (set) Token: 0x060016FB RID: 5883 RVA: 0x00019460 File Offset: 0x00017660
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CacheStorage.DataEntry> cacheDataEntries { get; set; }

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x00019469 File Offset: 0x00017669
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CacheStorage.DataEntry> CacheDataEntries
		{
			get
			{
				return this.cacheDataEntries;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x00019471 File Offset: 0x00017671
		// (set) Token: 0x060016FE RID: 5886 RVA: 0x00019479 File Offset: 0x00017679
		[global::System.Runtime.Serialization.DataMember]
		internal double returnCount { get; set; }

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00019482 File Offset: 0x00017682
		public double ReturnCount
		{
			get
			{
				return this.returnCount;
			}
		}
	}
}
