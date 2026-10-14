using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000369 RID: 873
	[global::System.Runtime.Serialization.DataContract]
	public class FederatedAuthRequestIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001A5C RID: 6748 RVA: 0x0001C092 File Offset: 0x0001A292
		// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0001C0AE File Offset: 0x0001A2AE
		public global::CefSharp.DevTools.Audits.FederatedAuthRequestIssueReason FederatedAuthRequestIssueReason
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.FederatedAuthRequestIssueReason)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.FederatedAuthRequestIssueReason), this.federatedAuthRequestIssueReason);
			}
			set
			{
				this.federatedAuthRequestIssueReason = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001A5E RID: 6750 RVA: 0x0001C0C1 File Offset: 0x0001A2C1
		// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0001C0C9 File Offset: 0x0001A2C9
		[global::System.Runtime.Serialization.DataMember(Name = "federatedAuthRequestIssueReason", IsRequired = true)]
		internal string federatedAuthRequestIssueReason { get; set; }
	}
}
