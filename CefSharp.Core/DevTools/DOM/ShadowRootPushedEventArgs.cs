using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002C9 RID: 713
	[global::System.Runtime.Serialization.DataContract]
	public class ShadowRootPushedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x060015EA RID: 5610 RVA: 0x00017BEC File Offset: 0x00015DEC
		// (set) Token: 0x060015EB RID: 5611 RVA: 0x00017BF4 File Offset: 0x00015DF4
		[global::System.Runtime.Serialization.DataMember(Name = "hostId", IsRequired = true)]
		public int HostId { get; private set; }

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x00017BFD File Offset: 0x00015DFD
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x00017C05 File Offset: 0x00015E05
		[global::System.Runtime.Serialization.DataMember(Name = "root", IsRequired = true)]
		public global::CefSharp.DevTools.DOM.Node Root { get; private set; }
	}
}
