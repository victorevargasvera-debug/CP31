using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000363 RID: 867
	[global::System.Runtime.Serialization.DataContract]
	public class NavigatorUserAgentIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x0001BF99 File Offset: 0x0001A199
		// (set) Token: 0x06001A43 RID: 6723 RVA: 0x0001BFA1 File Offset: 0x0001A1A1
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001A44 RID: 6724 RVA: 0x0001BFAA File Offset: 0x0001A1AA
		// (set) Token: 0x06001A45 RID: 6725 RVA: 0x0001BFB2 File Offset: 0x0001A1B2
		[global::System.Runtime.Serialization.DataMember(Name = "location", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.SourceCodeLocation Location { get; set; }
	}
}
