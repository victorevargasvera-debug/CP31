using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x0200006E RID: 110
	[global::System.Runtime.Serialization.DataContract]
	public class HeapStatsUpdateEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x00006CDA File Offset: 0x00004EDA
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x00006CE2 File Offset: 0x00004EE2
		[global::System.Runtime.Serialization.DataMember(Name = "statsUpdate", IsRequired = true)]
		public int[] StatsUpdate { get; private set; }
	}
}
