using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000DF RID: 223
	[global::System.Runtime.Serialization.DataContract]
	public class NodeParamConnectedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00009C7C File Offset: 0x00007E7C
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00009C84 File Offset: 0x00007E84
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; private set; }

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00009C8D File Offset: 0x00007E8D
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x00009C95 File Offset: 0x00007E95
		[global::System.Runtime.Serialization.DataMember(Name = "sourceId", IsRequired = true)]
		public string SourceId { get; private set; }

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00009C9E File Offset: 0x00007E9E
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x00009CA6 File Offset: 0x00007EA6
		[global::System.Runtime.Serialization.DataMember(Name = "destinationId", IsRequired = true)]
		public string DestinationId { get; private set; }

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00009CAF File Offset: 0x00007EAF
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x00009CB7 File Offset: 0x00007EB7
		[global::System.Runtime.Serialization.DataMember(Name = "sourceOutputIndex", IsRequired = false)]
		public double? SourceOutputIndex { get; private set; }
	}
}
