using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x02000070 RID: 112
	[global::System.Runtime.Serialization.DataContract]
	public class ReportHeapSnapshotProgressEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00006D1D File Offset: 0x00004F1D
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00006D25 File Offset: 0x00004F25
		[global::System.Runtime.Serialization.DataMember(Name = "done", IsRequired = true)]
		public int Done { get; private set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00006D2E File Offset: 0x00004F2E
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00006D36 File Offset: 0x00004F36
		[global::System.Runtime.Serialization.DataMember(Name = "total", IsRequired = true)]
		public int Total { get; private set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00006D3F File Offset: 0x00004F3F
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00006D47 File Offset: 0x00004F47
		[global::System.Runtime.Serialization.DataMember(Name = "finished", IsRequired = false)]
		public bool? Finished { get; private set; }
	}
}
