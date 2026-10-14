using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200036B RID: 875
	[global::System.Runtime.Serialization.DataContract]
	public class ClientHintIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x0001C0DA File Offset: 0x0001A2DA
		// (set) Token: 0x06001A62 RID: 6754 RVA: 0x0001C0E2 File Offset: 0x0001A2E2
		[global::System.Runtime.Serialization.DataMember(Name = "sourceCodeLocation", IsRequired = true)]
		public global::CefSharp.DevTools.Audits.SourceCodeLocation SourceCodeLocation { get; set; }

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x0001C0EB File Offset: 0x0001A2EB
		// (set) Token: 0x06001A64 RID: 6756 RVA: 0x0001C107 File Offset: 0x0001A307
		public global::CefSharp.DevTools.Audits.ClientHintIssueReason ClientHintIssueReason
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.ClientHintIssueReason)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.ClientHintIssueReason), this.clientHintIssueReason);
			}
			set
			{
				this.clientHintIssueReason = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06001A65 RID: 6757 RVA: 0x0001C11A File Offset: 0x0001A31A
		// (set) Token: 0x06001A66 RID: 6758 RVA: 0x0001C122 File Offset: 0x0001A322
		[global::System.Runtime.Serialization.DataMember(Name = "clientHintIssueReason", IsRequired = true)]
		internal string clientHintIssueReason { get; set; }
	}
}
