using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000171 RID: 369
	[global::System.Runtime.Serialization.DataContract]
	public class OriginTrial : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0000D98B File Offset: 0x0000BB8B
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x0000D993 File Offset: 0x0000BB93
		[global::System.Runtime.Serialization.DataMember(Name = "trialName", IsRequired = true)]
		public string TrialName { get; set; }

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0000D99C File Offset: 0x0000BB9C
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x0000D9B8 File Offset: 0x0000BBB8
		public global::CefSharp.DevTools.Page.OriginTrialStatus Status
		{
			get
			{
				return (global::CefSharp.DevTools.Page.OriginTrialStatus)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.OriginTrialStatus), this.status);
			}
			set
			{
				this.status = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0000D9CB File Offset: 0x0000BBCB
		// (set) Token: 0x06000B42 RID: 2882 RVA: 0x0000D9D3 File Offset: 0x0000BBD3
		[global::System.Runtime.Serialization.DataMember(Name = "status", IsRequired = true)]
		internal string status { get; set; }

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0000D9DC File Offset: 0x0000BBDC
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
		[global::System.Runtime.Serialization.DataMember(Name = "tokensWithStatus", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.OriginTrialTokenWithStatus> TokensWithStatus { get; set; }
	}
}
