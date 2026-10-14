using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x0200038F RID: 911
	[global::System.Runtime.Serialization.DataContract]
	public class QueryAXTreeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x0001CD64 File Offset: 0x0001AF64
		// (set) Token: 0x06001B6A RID: 7018 RVA: 0x0001CD6C File Offset: 0x0001AF6C
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXNode> nodes { get; set; }

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0001CD75 File Offset: 0x0001AF75
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXNode> Nodes
		{
			get
			{
				return this.nodes;
			}
		}
	}
}
