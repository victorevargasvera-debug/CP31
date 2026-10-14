using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000367 RID: 871
	[global::System.Runtime.Serialization.DataContract]
	public class BounceTrackingIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001A59 RID: 6745 RVA: 0x0001C079 File Offset: 0x0001A279
		// (set) Token: 0x06001A5A RID: 6746 RVA: 0x0001C081 File Offset: 0x0001A281
		[global::System.Runtime.Serialization.DataMember(Name = "trackingSites", IsRequired = true)]
		public string[] TrackingSites { get; set; }
	}
}
