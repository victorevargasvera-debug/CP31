using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200003E RID: 62
	[global::System.Runtime.Serialization.DataContract]
	public class EntryPreview : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000285 RID: 645 RVA: 0x000054D3 File Offset: 0x000036D3
		// (set) Token: 0x06000286 RID: 646 RVA: 0x000054DB File Offset: 0x000036DB
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.ObjectPreview Key { get; set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000287 RID: 647 RVA: 0x000054E4 File Offset: 0x000036E4
		// (set) Token: 0x06000288 RID: 648 RVA: 0x000054EC File Offset: 0x000036EC
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public global::CefSharp.DevTools.Runtime.ObjectPreview Value { get; set; }
	}
}
