using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAudio
{
	// Token: 0x020000E0 RID: 224
	[global::System.Runtime.Serialization.DataContract]
	public class NodeParamDisconnectedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00009CC8 File Offset: 0x00007EC8
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00009CD0 File Offset: 0x00007ED0
		[global::System.Runtime.Serialization.DataMember(Name = "contextId", IsRequired = true)]
		public string ContextId { get; private set; }

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00009CD9 File Offset: 0x00007ED9
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00009CE1 File Offset: 0x00007EE1
		[global::System.Runtime.Serialization.DataMember(Name = "sourceId", IsRequired = true)]
		public string SourceId { get; private set; }

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00009CEA File Offset: 0x00007EEA
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00009CF2 File Offset: 0x00007EF2
		[global::System.Runtime.Serialization.DataMember(Name = "destinationId", IsRequired = true)]
		public string DestinationId { get; private set; }

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00009CFB File Offset: 0x00007EFB
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00009D03 File Offset: 0x00007F03
		[global::System.Runtime.Serialization.DataMember(Name = "sourceOutputIndex", IsRequired = false)]
		public double? SourceOutputIndex { get; private set; }
	}
}
