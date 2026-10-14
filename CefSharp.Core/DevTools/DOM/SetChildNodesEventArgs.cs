using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002C7 RID: 711
	[global::System.Runtime.Serialization.DataContract]
	public class SetChildNodesEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x00017B98 File Offset: 0x00015D98
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x00017BA0 File Offset: 0x00015DA0
		[global::System.Runtime.Serialization.DataMember(Name = "parentId", IsRequired = true)]
		public int ParentId { get; private set; }

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00017BA9 File Offset: 0x00015DA9
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x00017BB1 File Offset: 0x00015DB1
		[global::System.Runtime.Serialization.DataMember(Name = "nodes", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.DOM.Node> Nodes { get; private set; }
	}
}
