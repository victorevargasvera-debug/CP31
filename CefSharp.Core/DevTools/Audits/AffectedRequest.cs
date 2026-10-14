using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000349 RID: 841
	[global::System.Runtime.Serialization.DataContract]
	public class AffectedRequest : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x0001B86E File Offset: 0x00019A6E
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x0001B876 File Offset: 0x00019A76
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; set; }

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x0001B87F File Offset: 0x00019A7F
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x0001B887 File Offset: 0x00019A87
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = false)]
		public string Url { get; set; }
	}
}
