using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x0200038E RID: 910
	[global::System.Runtime.Serialization.DataContract]
	public class GetChildAXNodesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06001B65 RID: 7013 RVA: 0x0001CD43 File Offset: 0x0001AF43
		// (set) Token: 0x06001B66 RID: 7014 RVA: 0x0001CD4B File Offset: 0x0001AF4B
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXNode> nodes { get; set; }

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x0001CD54 File Offset: 0x0001AF54
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXNode> Nodes
		{
			get
			{
				return this.nodes;
			}
		}
	}
}
