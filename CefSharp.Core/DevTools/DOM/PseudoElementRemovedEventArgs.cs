using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002C6 RID: 710
	[global::System.Runtime.Serialization.DataContract]
	public class PseudoElementRemovedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x00017B6E File Offset: 0x00015D6E
		// (set) Token: 0x060015DC RID: 5596 RVA: 0x00017B76 File Offset: 0x00015D76
		[global::System.Runtime.Serialization.DataMember(Name = "parentId", IsRequired = true)]
		public int ParentId { get; private set; }

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x00017B7F File Offset: 0x00015D7F
		// (set) Token: 0x060015DE RID: 5598 RVA: 0x00017B87 File Offset: 0x00015D87
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoElementId", IsRequired = true)]
		public int PseudoElementId { get; private set; }
	}
}
