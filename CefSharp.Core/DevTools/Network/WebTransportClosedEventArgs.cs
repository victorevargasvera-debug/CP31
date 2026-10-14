using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200022B RID: 555
	[global::System.Runtime.Serialization.DataContract]
	public class WebTransportClosedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001122 RID: 4386 RVA: 0x000126FA File Offset: 0x000108FA
		// (set) Token: 0x06001123 RID: 4387 RVA: 0x00012702 File Offset: 0x00010902
		[global::System.Runtime.Serialization.DataMember(Name = "transportId", IsRequired = true)]
		public string TransportId { get; private set; }

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x0001270B File Offset: 0x0001090B
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x00012713 File Offset: 0x00010913
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }
	}
}
