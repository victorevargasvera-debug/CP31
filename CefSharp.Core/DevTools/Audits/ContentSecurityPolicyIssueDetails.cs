using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000359 RID: 857
	[global::System.Runtime.Serialization.DataContract]
	public class ContentSecurityPolicyIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x0001BBF0 File Offset: 0x00019DF0
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x0001BBF8 File Offset: 0x00019DF8
		[global::System.Runtime.Serialization.DataMember(Name = "blockedURL", IsRequired = false)]
		public string BlockedURL { get; set; }

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x0001BC01 File Offset: 0x00019E01
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x0001BC09 File Offset: 0x00019E09
		[global::System.Runtime.Serialization.DataMember(Name = "violatedDirective", IsRequired = true)]
		public string ViolatedDirective { get; set; }

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x0001BC12 File Offset: 0x00019E12
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x0001BC1A File Offset: 0x00019E1A
		[global::System.Runtime.Serialization.DataMember(Name = "isReportOnly", IsRequired = true)]
		public bool IsReportOnly { get; set; }

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x0001BC23 File Offset: 0x00019E23
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x0001BC3F File Offset: 0x00019E3F
		public global::CefSharp.DevTools.Audits.ContentSecurityPolicyViolationType ContentSecurityPolicyViolationType
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.ContentSecurityPolicyViolationType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.ContentSecurityPolicyViolationType), this.contentSecurityPolicyViolationType);
			}
			set
			{
				this.contentSecurityPolicyViolationType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x0001BC52 File Offset: 0x00019E52
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x0001BC5A File Offset: 0x00019E5A
		[global::System.Runtime.Serialization.DataMember(Name = "contentSecurityPolicyViolationType", IsRequired = true)]
		internal string contentSecurityPolicyViolationType { get; set; }

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x0001BC63 File Offset: 0x00019E63
		// (set) Token: 0x060019F0 RID: 6640 RVA: 0x0001BC6B File Offset: 0x00019E6B
		[global::System.Runtime.Serialization.DataMember(Name = "frameAncestor", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.AffectedFrame FrameAncestor { get; set; }

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x0001BC74 File Offset: 0x00019E74
		// (set) Token: 0x060019F2 RID: 6642 RVA: 0x0001BC7C File Offset: 0x00019E7C
		[global::System.Runtime.Serialization.DataMember(Name = "sourceCodeLocation", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.SourceCodeLocation SourceCodeLocation { get; set; }

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x0001BC85 File Offset: 0x00019E85
		// (set) Token: 0x060019F4 RID: 6644 RVA: 0x0001BC8D File Offset: 0x00019E8D
		[global::System.Runtime.Serialization.DataMember(Name = "violatingNodeId", IsRequired = false)]
		public int? ViolatingNodeId { get; set; }
	}
}
