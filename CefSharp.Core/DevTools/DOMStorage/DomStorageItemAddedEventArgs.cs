using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMStorage
{
	// Token: 0x02000298 RID: 664
	[global::System.Runtime.Serialization.DataContract]
	public class DomStorageItemAddedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0001671B File Offset: 0x0001491B
		// (set) Token: 0x06001410 RID: 5136 RVA: 0x00016723 File Offset: 0x00014923
		[global::System.Runtime.Serialization.DataMember(Name = "storageId", IsRequired = true)]
		public global::CefSharp.DevTools.DOMStorage.StorageId StorageId { get; private set; }

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06001411 RID: 5137 RVA: 0x0001672C File Offset: 0x0001492C
		// (set) Token: 0x06001412 RID: 5138 RVA: 0x00016734 File Offset: 0x00014934
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = true)]
		public string Key { get; private set; }

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001413 RID: 5139 RVA: 0x0001673D File Offset: 0x0001493D
		// (set) Token: 0x06001414 RID: 5140 RVA: 0x00016745 File Offset: 0x00014945
		[global::System.Runtime.Serialization.DataMember(Name = "newValue", IsRequired = true)]
		public string NewValue { get; private set; }
	}
}
