using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000353 RID: 851
	[global::System.Runtime.Serialization.DataContract]
	public class BlockedByResponseIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0001BA90 File Offset: 0x00019C90
		// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0001BA98 File Offset: 0x00019C98
		[global::System.Runtime.Serialization.DataMember(Name = "request", IsRequired = true)]
		public global::CefSharp.DevTools.Audits.AffectedRequest Request { get; set; }

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0001BAA1 File Offset: 0x00019CA1
		// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0001BAA9 File Offset: 0x00019CA9
		[global::System.Runtime.Serialization.DataMember(Name = "parentFrame", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.AffectedFrame ParentFrame { get; set; }

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x0001BAB2 File Offset: 0x00019CB2
		// (set) Token: 0x060019CB RID: 6603 RVA: 0x0001BABA File Offset: 0x00019CBA
		[global::System.Runtime.Serialization.DataMember(Name = "blockedFrame", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.AffectedFrame BlockedFrame { get; set; }

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x0001BAC3 File Offset: 0x00019CC3
		// (set) Token: 0x060019CD RID: 6605 RVA: 0x0001BADF File Offset: 0x00019CDF
		public global::CefSharp.DevTools.Audits.BlockedByResponseReason Reason
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.BlockedByResponseReason)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.BlockedByResponseReason), this.reason);
			}
			set
			{
				this.reason = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x0001BAF2 File Offset: 0x00019CF2
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x0001BAFA File Offset: 0x00019CFA
		[global::System.Runtime.Serialization.DataMember(Name = "reason", IsRequired = true)]
		internal string reason { get; set; }
	}
}
