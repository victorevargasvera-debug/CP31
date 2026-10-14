using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000227 RID: 551
	[global::System.Runtime.Serialization.DataContract]
	public class WebSocketHandshakeResponseReceivedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x000125FD File Offset: 0x000107FD
		// (set) Token: 0x06001105 RID: 4357 RVA: 0x00012605 File Offset: 0x00010805
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x0001260E File Offset: 0x0001080E
		// (set) Token: 0x06001107 RID: 4359 RVA: 0x00012616 File Offset: 0x00010816
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0001261F File Offset: 0x0001081F
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x00012627 File Offset: 0x00010827
		[global::System.Runtime.Serialization.DataMember(Name = "response", IsRequired = true)]
		public global::CefSharp.DevTools.Network.WebSocketResponse Response { get; private set; }
	}
}
