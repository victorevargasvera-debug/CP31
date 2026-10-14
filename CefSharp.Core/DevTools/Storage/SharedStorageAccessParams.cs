using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x0200012B RID: 299
	[global::System.Runtime.Serialization.DataContract]
	public class SharedStorageAccessParams : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0000BCF2 File Offset: 0x00009EF2
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x0000BCFA File Offset: 0x00009EFA
		[global::System.Runtime.Serialization.DataMember(Name = "scriptSourceUrl", IsRequired = false)]
		public string ScriptSourceUrl { get; set; }

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0000BD03 File Offset: 0x00009F03
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x0000BD0B File Offset: 0x00009F0B
		[global::System.Runtime.Serialization.DataMember(Name = "operationName", IsRequired = false)]
		public string OperationName { get; set; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x0000BD14 File Offset: 0x00009F14
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x0000BD1C File Offset: 0x00009F1C
		[global::System.Runtime.Serialization.DataMember(Name = "serializedData", IsRequired = false)]
		public string SerializedData { get; set; }

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0000BD25 File Offset: 0x00009F25
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x0000BD2D File Offset: 0x00009F2D
		[global::System.Runtime.Serialization.DataMember(Name = "urlsWithMetadata", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Storage.SharedStorageUrlWithMetadata> UrlsWithMetadata { get; set; }

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0000BD36 File Offset: 0x00009F36
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x0000BD3E File Offset: 0x00009F3E
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = false)]
		public string Key { get; set; }

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x0000BD47 File Offset: 0x00009F47
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x0000BD4F File Offset: 0x00009F4F
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public string Value { get; set; }

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x0000BD58 File Offset: 0x00009F58
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x0000BD60 File Offset: 0x00009F60
		[global::System.Runtime.Serialization.DataMember(Name = "ignoreIfPresent", IsRequired = false)]
		public bool? IgnoreIfPresent { get; set; }
	}
}
