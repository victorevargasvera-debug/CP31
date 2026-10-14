using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x0200012E RID: 302
	[global::System.Runtime.Serialization.DataContract]
	public class CacheStorageContentUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0000BE30 File Offset: 0x0000A030
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0000BE38 File Offset: 0x0000A038
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		public string Origin { get; private set; }

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0000BE41 File Offset: 0x0000A041
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0000BE49 File Offset: 0x0000A049
		[global::System.Runtime.Serialization.DataMember(Name = "storageKey", IsRequired = true)]
		public string StorageKey { get; private set; }

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0000BE52 File Offset: 0x0000A052
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x0000BE5A File Offset: 0x0000A05A
		[global::System.Runtime.Serialization.DataMember(Name = "cacheName", IsRequired = true)]
		public string CacheName { get; private set; }
	}
}
