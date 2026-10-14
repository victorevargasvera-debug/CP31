using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200035B RID: 859
	[global::System.Runtime.Serialization.DataContract]
	public class SharedArrayBufferIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x0001BC9E File Offset: 0x00019E9E
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0001BCA6 File Offset: 0x00019EA6
		[global::System.Runtime.Serialization.DataMember(Name = "sourceCodeLocation", IsRequired = true)]
		public global::CefSharp.DevTools.Audits.SourceCodeLocation SourceCodeLocation { get; set; }

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x0001BCAF File Offset: 0x00019EAF
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x0001BCB7 File Offset: 0x00019EB7
		[global::System.Runtime.Serialization.DataMember(Name = "isWarning", IsRequired = true)]
		public bool IsWarning { get; set; }

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x0001BCC0 File Offset: 0x00019EC0
		// (set) Token: 0x060019FB RID: 6651 RVA: 0x0001BCDC File Offset: 0x00019EDC
		public global::CefSharp.DevTools.Audits.SharedArrayBufferIssueType Type
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.SharedArrayBufferIssueType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.SharedArrayBufferIssueType), this.type);
			}
			set
			{
				this.type = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x0001BCEF File Offset: 0x00019EEF
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x0001BCF7 File Offset: 0x00019EF7
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		internal string type { get; set; }
	}
}
