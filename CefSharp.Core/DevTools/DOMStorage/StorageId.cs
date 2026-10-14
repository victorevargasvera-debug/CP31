using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMStorage
{
	// Token: 0x02000297 RID: 663
	[global::System.Runtime.Serialization.DataContract]
	public class StorageId : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x000166E0 File Offset: 0x000148E0
		// (set) Token: 0x06001409 RID: 5129 RVA: 0x000166E8 File Offset: 0x000148E8
		[global::System.Runtime.Serialization.DataMember(Name = "securityOrigin", IsRequired = false)]
		public string SecurityOrigin { get; set; }

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x000166F1 File Offset: 0x000148F1
		// (set) Token: 0x0600140B RID: 5131 RVA: 0x000166F9 File Offset: 0x000148F9
		[global::System.Runtime.Serialization.DataMember(Name = "storageKey", IsRequired = false)]
		public string StorageKey { get; set; }

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00016702 File Offset: 0x00014902
		// (set) Token: 0x0600140D RID: 5133 RVA: 0x0001670A File Offset: 0x0001490A
		[global::System.Runtime.Serialization.DataMember(Name = "isLocalStorage", IsRequired = true)]
		public bool IsLocalStorage { get; set; }
	}
}
