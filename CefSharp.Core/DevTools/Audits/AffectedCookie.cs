using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000348 RID: 840
	[global::System.Runtime.Serialization.DataContract]
	public class AffectedCookie : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x0600198F RID: 6543 RVA: 0x0001B833 File Offset: 0x00019A33
		// (set) Token: 0x06001990 RID: 6544 RVA: 0x0001B83B File Offset: 0x00019A3B
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001991 RID: 6545 RVA: 0x0001B844 File Offset: 0x00019A44
		// (set) Token: 0x06001992 RID: 6546 RVA: 0x0001B84C File Offset: 0x00019A4C
		[global::System.Runtime.Serialization.DataMember(Name = "path", IsRequired = true)]
		public string Path { get; set; }

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001993 RID: 6547 RVA: 0x0001B855 File Offset: 0x00019A55
		// (set) Token: 0x06001994 RID: 6548 RVA: 0x0001B85D File Offset: 0x00019A5D
		[global::System.Runtime.Serialization.DataMember(Name = "domain", IsRequired = true)]
		public string Domain { get; set; }
	}
}
