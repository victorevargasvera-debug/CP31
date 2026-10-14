using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200022A RID: 554
	[global::System.Runtime.Serialization.DataContract]
	public class WebTransportConnectionEstablishedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x000126D0 File Offset: 0x000108D0
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x000126D8 File Offset: 0x000108D8
		[global::System.Runtime.Serialization.DataMember(Name = "transportId", IsRequired = true)]
		public string TransportId { get; private set; }

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x000126E1 File Offset: 0x000108E1
		// (set) Token: 0x06001120 RID: 4384 RVA: 0x000126E9 File Offset: 0x000108E9
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }
	}
}
