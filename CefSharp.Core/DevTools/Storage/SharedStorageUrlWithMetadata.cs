using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x0200012A RID: 298
	[global::System.Runtime.Serialization.DataContract]
	public class SharedStorageUrlWithMetadata : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x0000BCC8 File Offset: 0x00009EC8
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x0000BCD9 File Offset: 0x00009ED9
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x0000BCE1 File Offset: 0x00009EE1
		[global::System.Runtime.Serialization.DataMember(Name = "reportingMetadata", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Storage.SharedStorageReportingMetadata> ReportingMetadata { get; set; }
	}
}
