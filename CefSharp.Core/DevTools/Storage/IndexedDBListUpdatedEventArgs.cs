using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000131 RID: 305
	[global::System.Runtime.Serialization.DataContract]
	public class IndexedDBListUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0000BEE1 File Offset: 0x0000A0E1
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x0000BEE9 File Offset: 0x0000A0E9
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		public string Origin { get; private set; }

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0000BEF2 File Offset: 0x0000A0F2
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x0000BEFA File Offset: 0x0000A0FA
		[global::System.Runtime.Serialization.DataMember(Name = "storageKey", IsRequired = true)]
		public string StorageKey { get; private set; }
	}
}
