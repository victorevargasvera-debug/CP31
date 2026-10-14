using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000205 RID: 517
	[global::System.Runtime.Serialization.DataContract]
	public class SignedExchangeHeader : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00011AB0 File Offset: 0x0000FCB0
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x00011AB8 File Offset: 0x0000FCB8
		[global::System.Runtime.Serialization.DataMember(Name = "requestUrl", IsRequired = true)]
		public string RequestUrl { get; set; }

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00011AC1 File Offset: 0x0000FCC1
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x00011AC9 File Offset: 0x0000FCC9
		[global::System.Runtime.Serialization.DataMember(Name = "responseCode", IsRequired = true)]
		public int ResponseCode { get; set; }

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00011AD2 File Offset: 0x0000FCD2
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x00011ADA File Offset: 0x0000FCDA
		[global::System.Runtime.Serialization.DataMember(Name = "responseHeaders", IsRequired = true)]
		public global::CefSharp.DevTools.Network.Headers ResponseHeaders { get; set; }

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00011AE3 File Offset: 0x0000FCE3
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x00011AEB File Offset: 0x0000FCEB
		[global::System.Runtime.Serialization.DataMember(Name = "signatures", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.SignedExchangeSignature> Signatures { get; set; }

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00011AF4 File Offset: 0x0000FCF4
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x00011AFC File Offset: 0x0000FCFC
		[global::System.Runtime.Serialization.DataMember(Name = "headerIntegrity", IsRequired = true)]
		public string HeaderIntegrity { get; set; }
	}
}
