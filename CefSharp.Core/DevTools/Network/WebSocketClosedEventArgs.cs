using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000222 RID: 546
	[global::System.Runtime.Serialization.DataContract]
	public class WebSocketClosedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x000124E7 File Offset: 0x000106E7
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x000124EF File Offset: 0x000106EF
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x000124F8 File Offset: 0x000106F8
		// (set) Token: 0x060010E6 RID: 4326 RVA: 0x00012500 File Offset: 0x00010700
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }
	}
}
