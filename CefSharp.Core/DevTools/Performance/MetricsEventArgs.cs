using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Performance
{
	// Token: 0x0200015D RID: 349
	[global::System.Runtime.Serialization.DataContract]
	public class MetricsEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0000D60E File Offset: 0x0000B80E
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x0000D616 File Offset: 0x0000B816
		[global::System.Runtime.Serialization.DataMember(Name = "metrics", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Performance.Metric> Metrics { get; private set; }

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0000D61F File Offset: 0x0000B81F
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x0000D627 File Offset: 0x0000B827
		[global::System.Runtime.Serialization.DataMember(Name = "title", IsRequired = true)]
		public string Title { get; private set; }
	}
}
