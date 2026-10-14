using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x02000389 RID: 905
	[global::System.Runtime.Serialization.DataContract]
	public class NodesUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0001CCA6 File Offset: 0x0001AEA6
		// (set) Token: 0x06001B53 RID: 6995 RVA: 0x0001CCAE File Offset: 0x0001AEAE
		[global::System.Runtime.Serialization.DataMember(Name = "nodes", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXNode> Nodes { get; private set; }
	}
}
