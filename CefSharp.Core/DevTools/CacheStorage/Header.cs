using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CacheStorage
{
	// Token: 0x020002EE RID: 750
	[global::System.Runtime.Serialization.DataContract]
	public class Header : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x000193D3 File Offset: 0x000175D3
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x000193DB File Offset: 0x000175DB
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x000193E4 File Offset: 0x000175E4
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x000193EC File Offset: 0x000175EC
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }
	}
}
