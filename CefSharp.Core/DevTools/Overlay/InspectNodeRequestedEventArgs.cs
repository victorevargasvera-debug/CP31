using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001D4 RID: 468
	[global::System.Runtime.Serialization.DataContract]
	public class InspectNodeRequestedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x0001020C File Offset: 0x0000E40C
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00010214 File Offset: 0x0000E414
		[global::System.Runtime.Serialization.DataMember(Name = "backendNodeId", IsRequired = true)]
		public int BackendNodeId { get; private set; }
	}
}
