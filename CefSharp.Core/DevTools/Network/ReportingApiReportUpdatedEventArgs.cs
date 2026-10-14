using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000235 RID: 565
	[global::System.Runtime.Serialization.DataContract]
	public class ReportingApiReportUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x00012A11 File Offset: 0x00010C11
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x00012A19 File Offset: 0x00010C19
		[global::System.Runtime.Serialization.DataMember(Name = "report", IsRequired = true)]
		public global::CefSharp.DevTools.Network.ReportingApiReport Report { get; private set; }
	}
}
