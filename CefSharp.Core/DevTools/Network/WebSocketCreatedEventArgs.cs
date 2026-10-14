using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000223 RID: 547
	[global::System.Runtime.Serialization.DataContract]
	public class WebSocketCreatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00012511 File Offset: 0x00010711
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x00012519 File Offset: 0x00010719
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x00012522 File Offset: 0x00010722
		// (set) Token: 0x060010EB RID: 4331 RVA: 0x0001252A File Offset: 0x0001072A
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x00012533 File Offset: 0x00010733
		// (set) Token: 0x060010ED RID: 4333 RVA: 0x0001253B File Offset: 0x0001073B
		[global::System.Runtime.Serialization.DataMember(Name = "initiator", IsRequired = false)]
		public global::CefSharp.DevTools.Network.Initiator Initiator { get; private set; }
	}
}
