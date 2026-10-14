using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002C4 RID: 708
	[global::System.Runtime.Serialization.DataContract]
	public class InlineStyleInvalidatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00017B2B File Offset: 0x00015D2B
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00017B33 File Offset: 0x00015D33
		[global::System.Runtime.Serialization.DataMember(Name = "nodeIds", IsRequired = true)]
		public int[] NodeIds { get; private set; }
	}
}
