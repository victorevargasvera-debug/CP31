using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Cast
{
	// Token: 0x020002E7 RID: 743
	[global::System.Runtime.Serialization.DataContract]
	public class Sink : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x000190E5 File Offset: 0x000172E5
		// (set) Token: 0x060016B7 RID: 5815 RVA: 0x000190ED File Offset: 0x000172ED
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060016B8 RID: 5816 RVA: 0x000190F6 File Offset: 0x000172F6
		// (set) Token: 0x060016B9 RID: 5817 RVA: 0x000190FE File Offset: 0x000172FE
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; set; }

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x00019107 File Offset: 0x00017307
		// (set) Token: 0x060016BB RID: 5819 RVA: 0x0001910F File Offset: 0x0001730F
		[global::System.Runtime.Serialization.DataMember(Name = "session", IsRequired = false)]
		public string Session { get; set; }
	}
}
