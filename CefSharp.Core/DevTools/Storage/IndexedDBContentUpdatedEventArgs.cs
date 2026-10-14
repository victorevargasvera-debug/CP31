using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000130 RID: 304
	[global::System.Runtime.Serialization.DataContract]
	public class IndexedDBContentUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0000BE95 File Offset: 0x0000A095
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x0000BE9D File Offset: 0x0000A09D
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		public string Origin { get; private set; }

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0000BEA6 File Offset: 0x0000A0A6
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x0000BEAE File Offset: 0x0000A0AE
		[global::System.Runtime.Serialization.DataMember(Name = "storageKey", IsRequired = true)]
		public string StorageKey { get; private set; }

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0000BEB7 File Offset: 0x0000A0B7
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x0000BEBF File Offset: 0x0000A0BF
		[global::System.Runtime.Serialization.DataMember(Name = "databaseName", IsRequired = true)]
		public string DatabaseName { get; private set; }

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x0000BED0 File Offset: 0x0000A0D0
		[global::System.Runtime.Serialization.DataMember(Name = "objectStoreName", IsRequired = true)]
		public string ObjectStoreName { get; private set; }
	}
}
