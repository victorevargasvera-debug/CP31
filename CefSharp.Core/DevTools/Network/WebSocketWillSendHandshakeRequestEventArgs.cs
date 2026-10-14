using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000228 RID: 552
	[global::System.Runtime.Serialization.DataContract]
	public class WebSocketWillSendHandshakeRequestEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x00012638 File Offset: 0x00010838
		// (set) Token: 0x0600110C RID: 4364 RVA: 0x00012640 File Offset: 0x00010840
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x00012649 File Offset: 0x00010849
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x00012651 File Offset: 0x00010851
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0001265A File Offset: 0x0001085A
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x00012662 File Offset: 0x00010862
		[global::System.Runtime.Serialization.DataMember(Name = "wallTime", IsRequired = true)]
		public double WallTime { get; private set; }

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x0001266B File Offset: 0x0001086B
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x00012673 File Offset: 0x00010873
		[global::System.Runtime.Serialization.DataMember(Name = "request", IsRequired = true)]
		public global::CefSharp.DevTools.Network.WebSocketRequest Request { get; private set; }
	}
}
