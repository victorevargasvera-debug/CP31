using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000215 RID: 533
	[global::System.Runtime.Serialization.DataContract]
	public class ReportingApiEndpoint : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001042 RID: 4162 RVA: 0x00011EC3 File Offset: 0x000100C3
		// (set) Token: 0x06001043 RID: 4163 RVA: 0x00011ECB File Offset: 0x000100CB
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001044 RID: 4164 RVA: 0x00011ED4 File Offset: 0x000100D4
		// (set) Token: 0x06001045 RID: 4165 RVA: 0x00011EDC File Offset: 0x000100DC
		[global::System.Runtime.Serialization.DataMember(Name = "groupName", IsRequired = true)]
		public string GroupName { get; set; }
	}
}
