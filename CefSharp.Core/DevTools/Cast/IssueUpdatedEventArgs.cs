using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Cast
{
	// Token: 0x020002E9 RID: 745
	[global::System.Runtime.Serialization.DataContract]
	public class IssueUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x00019139 File Offset: 0x00017339
		// (set) Token: 0x060016C1 RID: 5825 RVA: 0x00019141 File Offset: 0x00017341
		[global::System.Runtime.Serialization.DataMember(Name = "issueMessage", IsRequired = true)]
		public string IssueMessage { get; private set; }
	}
}
