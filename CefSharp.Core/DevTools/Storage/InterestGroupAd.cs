using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000124 RID: 292
	[global::System.Runtime.Serialization.DataContract]
	public class InterestGroupAd : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0000BB3B File Offset: 0x00009D3B
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x0000BB43 File Offset: 0x00009D43
		[global::System.Runtime.Serialization.DataMember(Name = "renderUrl", IsRequired = true)]
		public string RenderUrl { get; set; }

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0000BB4C File Offset: 0x00009D4C
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x0000BB54 File Offset: 0x00009D54
		[global::System.Runtime.Serialization.DataMember(Name = "metadata", IsRequired = false)]
		public string Metadata { get; set; }
	}
}
