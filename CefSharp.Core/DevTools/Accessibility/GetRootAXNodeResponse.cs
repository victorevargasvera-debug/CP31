using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x0200038C RID: 908
	[global::System.Runtime.Serialization.DataContract]
	public class GetRootAXNodeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x0001CD01 File Offset: 0x0001AF01
		// (set) Token: 0x06001B5E RID: 7006 RVA: 0x0001CD09 File Offset: 0x0001AF09
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Accessibility.AXNode node { get; set; }

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x0001CD12 File Offset: 0x0001AF12
		public global::CefSharp.DevTools.Accessibility.AXNode Node
		{
			get
			{
				return this.node;
			}
		}
	}
}
