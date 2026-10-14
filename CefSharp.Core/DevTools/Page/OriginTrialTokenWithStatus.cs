using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000170 RID: 368
	[global::System.Runtime.Serialization.DataContract]
	public class OriginTrialTokenWithStatus : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0000D921 File Offset: 0x0000BB21
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x0000D929 File Offset: 0x0000BB29
		[global::System.Runtime.Serialization.DataMember(Name = "rawTokenText", IsRequired = true)]
		public string RawTokenText { get; set; }

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0000D932 File Offset: 0x0000BB32
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x0000D93A File Offset: 0x0000BB3A
		[global::System.Runtime.Serialization.DataMember(Name = "parsedToken", IsRequired = false)]
		public global::CefSharp.DevTools.Page.OriginTrialToken ParsedToken { get; set; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0000D943 File Offset: 0x0000BB43
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x0000D95F File Offset: 0x0000BB5F
		public global::CefSharp.DevTools.Page.OriginTrialTokenStatus Status
		{
			get
			{
				return (global::CefSharp.DevTools.Page.OriginTrialTokenStatus)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Page.OriginTrialTokenStatus), this.status);
			}
			set
			{
				this.status = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0000D972 File Offset: 0x0000BB72
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x0000D97A File Offset: 0x0000BB7A
		[global::System.Runtime.Serialization.DataMember(Name = "status", IsRequired = true)]
		internal string status { get; set; }
	}
}
