using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x0200038B RID: 907
	[global::System.Runtime.Serialization.DataContract]
	public class GetFullAXTreeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06001B59 RID: 7001 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
		// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0001CCE8 File Offset: 0x0001AEE8
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXNode> nodes { get; set; }

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x0001CCF1 File Offset: 0x0001AEF1
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXNode> Nodes
		{
			get
			{
				return this.nodes;
			}
		}
	}
}
