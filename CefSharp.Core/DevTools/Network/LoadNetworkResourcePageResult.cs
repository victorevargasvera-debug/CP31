using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000216 RID: 534
	[global::System.Runtime.Serialization.DataContract]
	public class LoadNetworkResourcePageResult : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001047 RID: 4167 RVA: 0x00011EED File Offset: 0x000100ED
		// (set) Token: 0x06001048 RID: 4168 RVA: 0x00011EF5 File Offset: 0x000100F5
		[global::System.Runtime.Serialization.DataMember(Name = "success", IsRequired = true)]
		public bool Success { get; set; }

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x00011EFE File Offset: 0x000100FE
		// (set) Token: 0x0600104A RID: 4170 RVA: 0x00011F06 File Offset: 0x00010106
		[global::System.Runtime.Serialization.DataMember(Name = "netError", IsRequired = false)]
		public double? NetError { get; set; }

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x00011F0F File Offset: 0x0001010F
		// (set) Token: 0x0600104C RID: 4172 RVA: 0x00011F17 File Offset: 0x00010117
		[global::System.Runtime.Serialization.DataMember(Name = "netErrorName", IsRequired = false)]
		public string NetErrorName { get; set; }

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600104D RID: 4173 RVA: 0x00011F20 File Offset: 0x00010120
		// (set) Token: 0x0600104E RID: 4174 RVA: 0x00011F28 File Offset: 0x00010128
		[global::System.Runtime.Serialization.DataMember(Name = "httpStatusCode", IsRequired = false)]
		public double? HttpStatusCode { get; set; }

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x00011F31 File Offset: 0x00010131
		// (set) Token: 0x06001050 RID: 4176 RVA: 0x00011F39 File Offset: 0x00010139
		[global::System.Runtime.Serialization.DataMember(Name = "stream", IsRequired = false)]
		public string Stream { get; set; }

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x00011F42 File Offset: 0x00010142
		// (set) Token: 0x06001052 RID: 4178 RVA: 0x00011F4A File Offset: 0x0001014A
		[global::System.Runtime.Serialization.DataMember(Name = "headers", IsRequired = false)]
		public global::CefSharp.DevTools.Network.Headers Headers { get; set; }
	}
}
