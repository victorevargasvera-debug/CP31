using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000DE RID: 222
	[global::System.Runtime.Serialization.DataContract]
	public class NodesDisconnectedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00009C1F File Offset: 0x00007E1F
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x00009C27 File Offset: 0x00007E27
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; private set; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00009C30 File Offset: 0x00007E30
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00009C38 File Offset: 0x00007E38
		[global::System.Runtime.Serialization.DataMember(Name = "sourceId", IsRequired = true)]
		public string SourceId { get; private set; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x00009C41 File Offset: 0x00007E41
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x00009C49 File Offset: 0x00007E49
		[global::System.Runtime.Serialization.DataMember(Name = "destinationId", IsRequired = true)]
		public string DestinationId { get; private set; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x00009C52 File Offset: 0x00007E52
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x00009C5A File Offset: 0x00007E5A
		[global::System.Runtime.Serialization.DataMember(Name = "sourceOutputIndex", IsRequired = false)]
		public double? SourceOutputIndex { get; private set; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x00009C63 File Offset: 0x00007E63
		// (set) Token: 0x06000739 RID: 1849 RVA: 0x00009C6B File Offset: 0x00007E6B
		[global::System.Runtime.Serialization.DataMember(Name = "destinationInputIndex", IsRequired = false)]
		public double? DestinationInputIndex { get; private set; }
	}
}
