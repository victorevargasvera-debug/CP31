using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000225 RID: 549
	[global::System.Runtime.Serialization.DataContract]
	public class WebSocketFrameReceivedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x00012587 File Offset: 0x00010787
		// (set) Token: 0x060010F7 RID: 4343 RVA: 0x0001258F File Offset: 0x0001078F
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x00012598 File Offset: 0x00010798
		// (set) Token: 0x060010F9 RID: 4345 RVA: 0x000125A0 File Offset: 0x000107A0
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x000125A9 File Offset: 0x000107A9
		// (set) Token: 0x060010FB RID: 4347 RVA: 0x000125B1 File Offset: 0x000107B1
		[global::System.Runtime.Serialization.DataMember(Name = "response", IsRequired = true)]
		public global::CefSharp.DevTools.Network.WebSocketFrame Response { get; private set; }
	}
}
