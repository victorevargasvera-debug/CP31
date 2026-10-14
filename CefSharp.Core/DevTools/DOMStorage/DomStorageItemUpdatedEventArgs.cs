using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMStorage
{
	// Token: 0x0200029A RID: 666
	[global::System.Runtime.Serialization.DataContract]
	public class DomStorageItemUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x00016780 File Offset: 0x00014980
		// (set) Token: 0x0600141C RID: 5148 RVA: 0x00016788 File Offset: 0x00014988
		[global::System.Runtime.Serialization.DataMember(Name = "storageId", IsRequired = true)]
		public global::CefSharp.DevTools.DOMStorage.StorageId StorageId { get; private set; }

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600141D RID: 5149 RVA: 0x00016791 File Offset: 0x00014991
		// (set) Token: 0x0600141E RID: 5150 RVA: 0x00016799 File Offset: 0x00014999
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = true)]
		public string Key { get; private set; }

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x0600141F RID: 5151 RVA: 0x000167A2 File Offset: 0x000149A2
		// (set) Token: 0x06001420 RID: 5152 RVA: 0x000167AA File Offset: 0x000149AA
		[global::System.Runtime.Serialization.DataMember(Name = "oldValue", IsRequired = true)]
		public string OldValue { get; private set; }

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001421 RID: 5153 RVA: 0x000167B3 File Offset: 0x000149B3
		// (set) Token: 0x06001422 RID: 5154 RVA: 0x000167BB File Offset: 0x000149BB
		[global::System.Runtime.Serialization.DataMember(Name = "newValue", IsRequired = true)]
		public string NewValue { get; private set; }
	}
}
