using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000226 RID: 550
	[global::System.Runtime.Serialization.DataContract]
	public class WebSocketFrameSentEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x000125C2 File Offset: 0x000107C2
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x000125CA File Offset: 0x000107CA
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x000125D3 File Offset: 0x000107D3
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x000125DB File Offset: 0x000107DB
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x000125E4 File Offset: 0x000107E4
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x000125EC File Offset: 0x000107EC
		[global::System.Runtime.Serialization.DataMember(Name = "response", IsRequired = true)]
		public global::CefSharp.DevTools.Network.WebSocketFrame Response { get; private set; }
	}
}
