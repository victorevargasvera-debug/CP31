using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001D5 RID: 469
	[global::System.Runtime.Serialization.DataContract]
	public class NodeHighlightRequestedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00010225 File Offset: 0x0000E425
		// (set) Token: 0x06000E2E RID: 3630 RVA: 0x0001022D File Offset: 0x0000E42D
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; private set; }
	}
}
