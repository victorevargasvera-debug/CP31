using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002C2 RID: 706
	[global::System.Runtime.Serialization.DataContract]
	public class ChildNodeRemovedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00017AD7 File Offset: 0x00015CD7
		// (set) Token: 0x060015CA RID: 5578 RVA: 0x00017ADF File Offset: 0x00015CDF
		[global::System.Runtime.Serialization.DataMember(Name = "parentNodeId", IsRequired = true)]
		public int ParentNodeId { get; private set; }

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x00017AE8 File Offset: 0x00015CE8
		// (set) Token: 0x060015CC RID: 5580 RVA: 0x00017AF0 File Offset: 0x00015CF0
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; private set; }
	}
}
