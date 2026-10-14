using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200036F RID: 879
	[global::System.Runtime.Serialization.DataContract]
	public class IssueAddedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0001C2C6 File Offset: 0x0001A4C6
		// (set) Token: 0x06001A95 RID: 6805 RVA: 0x0001C2CE File Offset: 0x0001A4CE
		[global::System.Runtime.Serialization.DataMember(Name = "issue", IsRequired = true)]
		public global::CefSharp.DevTools.Audits.InspectorIssue Issue { get; private set; }
	}
}
