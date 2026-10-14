using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Security
{
	// Token: 0x0200014E RID: 334
	[global::System.Runtime.Serialization.DataContract]
	public class VisibleSecurityState : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0000D02F File Offset: 0x0000B22F
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x0000D04B File Offset: 0x0000B24B
		public global::CefSharp.DevTools.Security.SecurityState SecurityState
		{
			get
			{
				return (global::CefSharp.DevTools.Security.SecurityState)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Security.SecurityState), this.securityState);
			}
			set
			{
				this.securityState = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x0000D05E File Offset: 0x0000B25E
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x0000D066 File Offset: 0x0000B266
		[global::System.Runtime.Serialization.DataMember(Name = "securityState", IsRequired = true)]
		internal string securityState { get; set; }

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x0000D06F File Offset: 0x0000B26F
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x0000D077 File Offset: 0x0000B277
		[global::System.Runtime.Serialization.DataMember(Name = "certificateSecurityState", IsRequired = false)]
		public global::CefSharp.DevTools.Security.CertificateSecurityState CertificateSecurityState { get; set; }

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0000D080 File Offset: 0x0000B280
		// (set) Token: 0x06000A79 RID: 2681 RVA: 0x0000D088 File Offset: 0x0000B288
		[global::System.Runtime.Serialization.DataMember(Name = "safetyTipInfo", IsRequired = false)]
		public global::CefSharp.DevTools.Security.SafetyTipInfo SafetyTipInfo { get; set; }

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0000D091 File Offset: 0x0000B291
		// (set) Token: 0x06000A7B RID: 2683 RVA: 0x0000D099 File Offset: 0x0000B299
		[global::System.Runtime.Serialization.DataMember(Name = "securityStateIssueIds", IsRequired = true)]
		public string[] SecurityStateIssueIds { get; set; }
	}
}
