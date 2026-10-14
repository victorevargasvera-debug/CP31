using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002B1 RID: 689
	[global::System.Runtime.Serialization.DataContract]
	public class BackendNode : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x00017588 File Offset: 0x00015788
		// (set) Token: 0x06001534 RID: 5428 RVA: 0x00017590 File Offset: 0x00015790
		[global::System.Runtime.Serialization.DataMember(Name = "nodeType", IsRequired = true)]
		public int NodeType { get; set; }

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x00017599 File Offset: 0x00015799
		// (set) Token: 0x06001536 RID: 5430 RVA: 0x000175A1 File Offset: 0x000157A1
		[global::System.Runtime.Serialization.DataMember(Name = "nodeName", IsRequired = true)]
		public string NodeName { get; set; }

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x000175AA File Offset: 0x000157AA
		// (set) Token: 0x06001538 RID: 5432 RVA: 0x000175B2 File Offset: 0x000157B2
		[global::System.Runtime.Serialization.DataMember(Name = "backendNodeId", IsRequired = true)]
		public int BackendNodeId { get; set; }
	}
}
