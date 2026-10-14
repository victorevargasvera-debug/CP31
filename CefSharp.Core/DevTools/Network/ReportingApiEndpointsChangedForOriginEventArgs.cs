using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000236 RID: 566
	[global::System.Runtime.Serialization.DataContract]
	public class ReportingApiEndpointsChangedForOriginEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x00012A2A File Offset: 0x00010C2A
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x00012A32 File Offset: 0x00010C32
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		public string Origin { get; private set; }

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x00012A3B File Offset: 0x00010C3B
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x00012A43 File Offset: 0x00010C43
		[global::System.Runtime.Serialization.DataMember(Name = "endpoints", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.ReportingApiEndpoint> Endpoints { get; private set; }
	}
}
