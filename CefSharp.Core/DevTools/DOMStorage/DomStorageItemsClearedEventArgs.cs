using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMStorage
{
	// Token: 0x0200029B RID: 667
	[global::System.Runtime.Serialization.DataContract]
	public class DomStorageItemsClearedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x000167CC File Offset: 0x000149CC
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x000167D4 File Offset: 0x000149D4
		[global::System.Runtime.Serialization.DataMember(Name = "storageId", IsRequired = true)]
		public global::CefSharp.DevTools.DOMStorage.StorageId StorageId { get; private set; }
	}
}
