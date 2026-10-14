using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x0200038A RID: 906
	[global::System.Runtime.Serialization.DataContract]
	public class GetPartialAXTreeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x0001CCBF File Offset: 0x0001AEBF
		// (set) Token: 0x06001B56 RID: 6998 RVA: 0x0001CCC7 File Offset: 0x0001AEC7
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXNode> nodes { get; set; }

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x0001CCD0 File Offset: 0x0001AED0
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Accessibility.AXNode> Nodes
		{
			get
			{
				return this.nodes;
			}
		}
	}
}
