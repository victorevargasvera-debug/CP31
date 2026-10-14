using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002C3 RID: 707
	[global::System.Runtime.Serialization.DataContract]
	public class DistributedNodesUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x00017B01 File Offset: 0x00015D01
		// (set) Token: 0x060015CF RID: 5583 RVA: 0x00017B09 File Offset: 0x00015D09
		[global::System.Runtime.Serialization.DataMember(Name = "insertionPointId", IsRequired = true)]
		public int InsertionPointId { get; private set; }

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x00017B12 File Offset: 0x00015D12
		// (set) Token: 0x060015D1 RID: 5585 RVA: 0x00017B1A File Offset: 0x00015D1A
		[global::System.Runtime.Serialization.DataMember(Name = "distributedNodes", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOM.BackendNode> DistributedNodes { get; private set; }
	}
}
