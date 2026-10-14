using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMStorage
{
	// Token: 0x02000299 RID: 665
	[global::System.Runtime.Serialization.DataContract]
	public class DomStorageItemRemovedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x00016756 File Offset: 0x00014956
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x0001675E File Offset: 0x0001495E
		[global::System.Runtime.Serialization.DataMember(Name = "storageId", IsRequired = true)]
		public global::CefSharp.DevTools.DOMStorage.StorageId StorageId { get; private set; }

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x00016767 File Offset: 0x00014967
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x0001676F File Offset: 0x0001496F
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = true)]
		public string Key { get; private set; }
	}
}
