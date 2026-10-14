using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CacheStorage
{
	// Token: 0x020002EF RID: 751
	[global::System.Runtime.Serialization.DataContract]
	public class CachedResponse : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x000193FD File Offset: 0x000175FD
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x00019405 File Offset: 0x00017605
		[global::System.Runtime.Serialization.DataMember(Name = "body", IsRequired = true)]
		public byte[] Body { get; set; }
	}
}
