using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200035D RID: 861
	[global::System.Runtime.Serialization.DataContract]
	public class TrustedWebActivityIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x0001BD08 File Offset: 0x00019F08
		// (set) Token: 0x06001A00 RID: 6656 RVA: 0x0001BD10 File Offset: 0x00019F10
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x0001BD19 File Offset: 0x00019F19
		// (set) Token: 0x06001A02 RID: 6658 RVA: 0x0001BD35 File Offset: 0x00019F35
		public global::CefSharp.DevTools.Audits.TwaQualityEnforcementViolationType ViolationType
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.TwaQualityEnforcementViolationType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.TwaQualityEnforcementViolationType), this.violationType);
			}
			set
			{
				this.violationType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x0001BD48 File Offset: 0x00019F48
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x0001BD50 File Offset: 0x00019F50
		[global::System.Runtime.Serialization.DataMember(Name = "violationType", IsRequired = true)]
		internal string violationType { get; set; }

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x0001BD59 File Offset: 0x00019F59
		// (set) Token: 0x06001A06 RID: 6662 RVA: 0x0001BD61 File Offset: 0x00019F61
		[global::System.Runtime.Serialization.DataMember(Name = "httpStatusCode", IsRequired = false)]
		public int? HttpStatusCode { get; set; }

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x0001BD6A File Offset: 0x00019F6A
		// (set) Token: 0x06001A08 RID: 6664 RVA: 0x0001BD72 File Offset: 0x00019F72
		[global::System.Runtime.Serialization.DataMember(Name = "packageName", IsRequired = false)]
		public string PackageName { get; set; }

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x0001BD7B File Offset: 0x00019F7B
		// (set) Token: 0x06001A0A RID: 6666 RVA: 0x0001BD83 File Offset: 0x00019F83
		[global::System.Runtime.Serialization.DataMember(Name = "signature", IsRequired = false)]
		public string Signature { get; set; }
	}
}
