using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CacheStorage
{
	// Token: 0x020002EC RID: 748
	[global::System.Runtime.Serialization.DataContract]
	public class DataEntry : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x000192C8 File Offset: 0x000174C8
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x000192D0 File Offset: 0x000174D0
		[global::System.Runtime.Serialization.DataMember(Name = "requestURL", IsRequired = true)]
		public string RequestURL { get; set; }

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x000192D9 File Offset: 0x000174D9
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x000192E1 File Offset: 0x000174E1
		[global::System.Runtime.Serialization.DataMember(Name = "requestMethod", IsRequired = true)]
		public string RequestMethod { get; set; }

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x000192EA File Offset: 0x000174EA
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x000192F2 File Offset: 0x000174F2
		[global::System.Runtime.Serialization.DataMember(Name = "requestHeaders", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CacheStorage.Header> RequestHeaders { get; set; }

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x000192FB File Offset: 0x000174FB
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x00019303 File Offset: 0x00017503
		[global::System.Runtime.Serialization.DataMember(Name = "responseTime", IsRequired = true)]
		public double ResponseTime { get; set; }

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x0001930C File Offset: 0x0001750C
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x00019314 File Offset: 0x00017514
		[global::System.Runtime.Serialization.DataMember(Name = "responseStatus", IsRequired = true)]
		public int ResponseStatus { get; set; }

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x0001931D File Offset: 0x0001751D
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x00019325 File Offset: 0x00017525
		[global::System.Runtime.Serialization.DataMember(Name = "responseStatusText", IsRequired = true)]
		public string ResponseStatusText { get; set; }

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x0001932E File Offset: 0x0001752E
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x0001934A File Offset: 0x0001754A
		public global::CefSharp.DevTools.CacheStorage.CachedResponseType ResponseType
		{
			get
			{
				return (global::CefSharp.DevTools.CacheStorage.CachedResponseType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.CacheStorage.CachedResponseType), this.responseType);
			}
			set
			{
				this.responseType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x0001935D File Offset: 0x0001755D
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x00019365 File Offset: 0x00017565
		[global::System.Runtime.Serialization.DataMember(Name = "responseType", IsRequired = true)]
		internal string responseType { get; set; }

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x0001936E File Offset: 0x0001756E
		// (set) Token: 0x060016DF RID: 5855 RVA: 0x00019376 File Offset: 0x00017576
		[global::System.Runtime.Serialization.DataMember(Name = "responseHeaders", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CacheStorage.Header> ResponseHeaders { get; set; }
	}
}
