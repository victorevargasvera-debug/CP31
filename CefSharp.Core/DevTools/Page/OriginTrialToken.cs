using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200016F RID: 367
	[global::System.Runtime.Serialization.DataContract]
	public class OriginTrialToken : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x0000D884 File Offset: 0x0000BA84
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x0000D88C File Offset: 0x0000BA8C
		[global::System.Runtime.Serialization.DataMember(Name = "origin", IsRequired = true)]
		public string Origin { get; set; }

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x0000D895 File Offset: 0x0000BA95
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x0000D89D File Offset: 0x0000BA9D
		[global::System.Runtime.Serialization.DataMember(Name = "matchSubDomains", IsRequired = true)]
		public bool MatchSubDomains { get; set; }

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0000D8A6 File Offset: 0x0000BAA6
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x0000D8AE File Offset: 0x0000BAAE
		[global::System.Runtime.Serialization.DataMember(Name = "trialName", IsRequired = true)]
		public string TrialName { get; set; }

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0000D8B7 File Offset: 0x0000BAB7
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x0000D8BF File Offset: 0x0000BABF
		[global::System.Runtime.Serialization.DataMember(Name = "expiryTime", IsRequired = true)]
		public double ExpiryTime { get; set; }

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x0000D8C8 File Offset: 0x0000BAC8
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x0000D8D0 File Offset: 0x0000BAD0
		[global::System.Runtime.Serialization.DataMember(Name = "isThirdParty", IsRequired = true)]
		public bool IsThirdParty { get; set; }

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x0000D8D9 File Offset: 0x0000BAD9
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x0000D8F5 File Offset: 0x0000BAF5
		public global::CefSharp.DevTools.Page.OriginTrialUsageRestriction UsageRestriction
		{
			get
			{
				return (global::CefSharp.DevTools.Page.OriginTrialUsageRestriction)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.OriginTrialUsageRestriction), this.usageRestriction);
			}
			set
			{
				this.usageRestriction = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x0000D908 File Offset: 0x0000BB08
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x0000D910 File Offset: 0x0000BB10
		[global::System.Runtime.Serialization.DataMember(Name = "usageRestriction", IsRequired = true)]
		internal string usageRestriction { get; set; }
	}
}
