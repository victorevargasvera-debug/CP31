using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000DD RID: 221
	[global::System.Runtime.Serialization.DataContract]
	public class NodesConnectedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00009BC2 File Offset: 0x00007DC2
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00009BCA File Offset: 0x00007DCA
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; private set; }

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00009BD3 File Offset: 0x00007DD3
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00009BDB File Offset: 0x00007DDB
		[global::System.Runtime.Serialization.DataMember(Name = "sourceId", IsRequired = true)]
		public string SourceId { get; private set; }

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00009BE4 File Offset: 0x00007DE4
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x00009BEC File Offset: 0x00007DEC
		[global::System.Runtime.Serialization.DataMember(Name = "destinationId", IsRequired = true)]
		public string DestinationId { get; private set; }

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00009BF5 File Offset: 0x00007DF5
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x00009BFD File Offset: 0x00007DFD
		[global::System.Runtime.Serialization.DataMember(Name = "sourceOutputIndex", IsRequired = false)]
		public double? SourceOutputIndex { get; private set; }

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00009C06 File Offset: 0x00007E06
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00009C0E File Offset: 0x00007E0E
		[global::System.Runtime.Serialization.DataMember(Name = "destinationInputIndex", IsRequired = false)]
		public double? DestinationInputIndex { get; private set; }
	}
}
