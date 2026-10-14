using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200036E RID: 878
	[global::System.Runtime.Serialization.DataContract]
	public class InspectorIssue : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0001C25C File Offset: 0x0001A45C
		// (set) Token: 0x06001A8C RID: 6796 RVA: 0x0001C278 File Offset: 0x0001A478
		public global::CefSharp.DevTools.Audits.InspectorIssueCode Code
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.InspectorIssueCode)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.InspectorIssueCode), this.code);
			}
			set
			{
				this.code = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x0001C28B File Offset: 0x0001A48B
		// (set) Token: 0x06001A8E RID: 6798 RVA: 0x0001C293 File Offset: 0x0001A493
		[global::System.Runtime.Serialization.DataMember(Name = "code", IsRequired = true)]
		internal string code { get; set; }

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x0001C29C File Offset: 0x0001A49C
		// (set) Token: 0x06001A90 RID: 6800 RVA: 0x0001C2A4 File Offset: 0x0001A4A4
		[global::System.Runtime.Serialization.DataMember(Name = "details", IsRequired = true)]
		public global::CefSharp.DevTools.Audits.InspectorIssueDetails Details { get; set; }

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x0001C2AD File Offset: 0x0001A4AD
		// (set) Token: 0x06001A92 RID: 6802 RVA: 0x0001C2B5 File Offset: 0x0001A4B5
		[global::System.Runtime.Serialization.DataMember(Name = "issueId", IsRequired = false)]
		public string IssueId { get; set; }
	}
}
