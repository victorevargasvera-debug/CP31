using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000219 RID: 537
	[global::System.Runtime.Serialization.DataContract]
	public class EventSourceMessageReceivedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x00011FD1 File Offset: 0x000101D1
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x00011FD9 File Offset: 0x000101D9
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x00011FE2 File Offset: 0x000101E2
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x00011FEA File Offset: 0x000101EA
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x00011FF3 File Offset: 0x000101F3
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x00011FFB File Offset: 0x000101FB
		[global::System.Runtime.Serialization.DataMember(Name = "eventName", IsRequired = true)]
		public string EventName { get; private set; }

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x00012004 File Offset: 0x00010204
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x0001200C File Offset: 0x0001020C
		[global::System.Runtime.Serialization.DataMember(Name = "eventId", IsRequired = true)]
		public string EventId { get; private set; }

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x00012015 File Offset: 0x00010215
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x0001201D File Offset: 0x0001021D
		[global::System.Runtime.Serialization.DataMember(Name = "data", IsRequired = true)]
		public string Data { get; private set; }
	}
}
