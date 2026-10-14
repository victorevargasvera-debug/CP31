using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x02000336 RID: 822
	[global::System.Runtime.Serialization.DataContract]
	public class Histogram : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x0001AE65 File Offset: 0x00019065
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x0001AE6D File Offset: 0x0001906D
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x0001AE76 File Offset: 0x00019076
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x0001AE7E File Offset: 0x0001907E
		[global::System.Runtime.Serialization.DataMember(Name = "sum", IsRequired = true)]
		public int Sum { get; set; }

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x0001AE87 File Offset: 0x00019087
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x0001AE8F File Offset: 0x0001908F
		[global::System.Runtime.Serialization.DataMember(Name = "count", IsRequired = true)]
		public int Count { get; set; }

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x0001AE98 File Offset: 0x00019098
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x0001AEA0 File Offset: 0x000190A0
		[global::System.Runtime.Serialization.DataMember(Name = "buckets", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Browser.Bucket> Buckets { get; set; }
	}
}
