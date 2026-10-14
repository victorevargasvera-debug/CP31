using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000129 RID: 297
	[global::System.Runtime.Serialization.DataContract]
	public class SharedStorageReportingMetadata : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x0000BC9E File Offset: 0x00009E9E
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x0000BCA6 File Offset: 0x00009EA6
		[global::System.Runtime.Serialization.DataMember(Name = "eventType", IsRequired = true)]
		public string EventType { get; set; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x0000BCAF File Offset: 0x00009EAF
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x0000BCB7 File Offset: 0x00009EB7
		[global::System.Runtime.Serialization.DataMember(Name = "reportingUrl", IsRequired = true)]
		public string ReportingUrl { get; set; }
	}
}
