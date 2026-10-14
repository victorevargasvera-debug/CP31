using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x0200038D RID: 909
	[global::System.Runtime.Serialization.DataContract]
	public class GetAXNodeAndAncestorsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06001B61 RID: 7009 RVA: 0x0001CD22 File Offset: 0x0001AF22
		// (set) Token: 0x06001B62 RID: 7010 RVA: 0x0001CD2A File Offset: 0x0001AF2A
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXNode> nodes { get; set; }

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x0001CD33 File Offset: 0x0001AF33
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXNode> Nodes
		{
			get
			{
				return this.nodes;
			}
		}
	}
}
