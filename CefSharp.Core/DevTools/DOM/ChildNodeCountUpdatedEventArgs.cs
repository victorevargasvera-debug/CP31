using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002C0 RID: 704
	[global::System.Runtime.Serialization.DataContract]
	public class ChildNodeCountUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x00017A72 File Offset: 0x00015C72
		// (set) Token: 0x060015BE RID: 5566 RVA: 0x00017A7A File Offset: 0x00015C7A
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; private set; }

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00017A83 File Offset: 0x00015C83
		// (set) Token: 0x060015C0 RID: 5568 RVA: 0x00017A8B File Offset: 0x00015C8B
		[global::System.Runtime.Serialization.DataMember(Name = "childNodeCount", IsRequired = true)]
		public int ChildNodeCount { get; private set; }
	}
}
