using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000351 RID: 849
	[global::System.Runtime.Serialization.DataContract]
	public class MixedContentIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x060019B5 RID: 6581 RVA: 0x0001B9C4 File Offset: 0x00019BC4
		// (set) Token: 0x060019B6 RID: 6582 RVA: 0x0001B9E0 File Offset: 0x00019BE0
		public global::CefSharp.DevTools.Audits.MixedContentResourceType? ResourceType
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.MixedContentResourceType?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.MixedContentResourceType?), this.resourceType);
			}
			set
			{
				this.resourceType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x060019B7 RID: 6583 RVA: 0x0001B9F3 File Offset: 0x00019BF3
		// (set) Token: 0x060019B8 RID: 6584 RVA: 0x0001B9FB File Offset: 0x00019BFB
		[global::System.Runtime.Serialization.DataMember(Name = "resourceType", IsRequired = false)]
		internal string resourceType { get; set; }

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x060019B9 RID: 6585 RVA: 0x0001BA04 File Offset: 0x00019C04
		// (set) Token: 0x060019BA RID: 6586 RVA: 0x0001BA20 File Offset: 0x00019C20
		public global::CefSharp.DevTools.Audits.MixedContentResolutionStatus ResolutionStatus
		{
			get
			{
				return (global::CefSharp.DevTools.Audits.MixedContentResolutionStatus)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Audits.MixedContentResolutionStatus), this.resolutionStatus);
			}
			set
			{
				this.resolutionStatus = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x060019BB RID: 6587 RVA: 0x0001BA33 File Offset: 0x00019C33
		// (set) Token: 0x060019BC RID: 6588 RVA: 0x0001BA3B File Offset: 0x00019C3B
		[global::System.Runtime.Serialization.DataMember(Name = "resolutionStatus", IsRequired = true)]
		internal string resolutionStatus { get; set; }

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x060019BD RID: 6589 RVA: 0x0001BA44 File Offset: 0x00019C44
		// (set) Token: 0x060019BE RID: 6590 RVA: 0x0001BA4C File Offset: 0x00019C4C
		[global::System.Runtime.Serialization.DataMember(Name = "insecureURL", IsRequired = true)]
		public string InsecureURL { get; set; }

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x0001BA55 File Offset: 0x00019C55
		// (set) Token: 0x060019C0 RID: 6592 RVA: 0x0001BA5D File Offset: 0x00019C5D
		[global::System.Runtime.Serialization.DataMember(Name = "mainResourceURL", IsRequired = true)]
		public string MainResourceURL { get; set; }

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x0001BA66 File Offset: 0x00019C66
		// (set) Token: 0x060019C2 RID: 6594 RVA: 0x0001BA6E File Offset: 0x00019C6E
		[global::System.Runtime.Serialization.DataMember(Name = "request", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.AffectedRequest Request { get; set; }

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x0001BA77 File Offset: 0x00019C77
		// (set) Token: 0x060019C4 RID: 6596 RVA: 0x0001BA7F File Offset: 0x00019C7F
		[global::System.Runtime.Serialization.DataMember(Name = "frame", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.AffectedFrame Frame { get; set; }
	}
}
