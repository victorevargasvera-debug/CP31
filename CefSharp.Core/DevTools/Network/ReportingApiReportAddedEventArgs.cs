using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000234 RID: 564
	[global::System.Runtime.Serialization.DataContract]
	public class ReportingApiReportAddedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x000129F8 File Offset: 0x00010BF8
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x00012A00 File Offset: 0x00010C00
		[global::System.Runtime.Serialization.DataMember(Name = "report", IsRequired = true)]
		public global::CefSharp.DevTools.Network.ReportingApiReport Report { get; private set; }
	}
}
