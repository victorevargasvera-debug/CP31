using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x0200012F RID: 303
	[global::System.Runtime.Serialization.DataContract]
	public class CacheStorageListUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x0000BE6B File Offset: 0x0000A06B
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x0000BE73 File Offset: 0x0000A073
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		public string Origin { get; private set; }

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0000BE7C File Offset: 0x0000A07C
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x0000BE84 File Offset: 0x0000A084
		[global::System.Runtime.Serialization.DataMember(Name = "storageKey", IsRequired = true)]
		public string StorageKey { get; private set; }
	}
}
