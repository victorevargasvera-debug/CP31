using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000229 RID: 553
	[global::System.Runtime.Serialization.DataContract]
	public class WebTransportCreatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x00012684 File Offset: 0x00010884
		// (set) Token: 0x06001115 RID: 4373 RVA: 0x0001268C File Offset: 0x0001088C
		[global::System.Runtime.Serialization.DataMember(Name = "transportId", IsRequired = true)]
		public string TransportId { get; private set; }

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x00012695 File Offset: 0x00010895
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x0001269D File Offset: 0x0001089D
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x000126A6 File Offset: 0x000108A6
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x000126AE File Offset: 0x000108AE
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x000126B7 File Offset: 0x000108B7
		// (set) Token: 0x0600111B RID: 4379 RVA: 0x000126BF File Offset: 0x000108BF
		[global::System.Runtime.Serialization.DataMember(Name = "initiator", IsRequired = false)]
		public global::CefSharp.DevTools.Network.Initiator Initiator { get; private set; }
	}
}
