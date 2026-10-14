using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002C5 RID: 709
	[global::System.Runtime.Serialization.DataContract]
	public class PseudoElementAddedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x00017B44 File Offset: 0x00015D44
		// (set) Token: 0x060015D7 RID: 5591 RVA: 0x00017B4C File Offset: 0x00015D4C
		[global::System.Runtime.Serialization.DataMember(Name = "parentId", IsRequired = true)]
		public int ParentId { get; private set; }

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00017B55 File Offset: 0x00015D55
		// (set) Token: 0x060015D9 RID: 5593 RVA: 0x00017B5D File Offset: 0x00015D5D
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoElement", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Node PseudoElement { get; private set; }
	}
}
