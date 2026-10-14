using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Performance
{
	// Token: 0x0200015E RID: 350
	[global::System.Runtime.Serialization.DataContract]
	public class GetMetricsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x0000D638 File Offset: 0x0000B838
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x0000D640 File Offset: 0x0000B840
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Performance.Metric> metrics { get; set; }

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x0000D649 File Offset: 0x0000B849
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Performance.Metric> Metrics
		{
			get
			{
				return this.metrics;
			}
		}
	}
}
