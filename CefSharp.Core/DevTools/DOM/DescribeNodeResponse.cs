using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002CC RID: 716
	[global::System.Runtime.Serialization.DataContract]
	public class DescribeNodeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00017C58 File Offset: 0x00015E58
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x00017C60 File Offset: 0x00015E60
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.DOM.Node node { get; set; }

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00017C69 File Offset: 0x00015E69
		public global::CefSharp.DevTools.DOM.Node Node
		{
			get
			{
				return this.node;
			}
		}
	}
}
