using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200036D RID: 877
	[global::System.Runtime.Serialization.DataContract]
	public class InspectorIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x0001C133 File Offset: 0x0001A333
		// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0001C13B File Offset: 0x0001A33B
		[global::System.Runtime.Serialization.DataMember(Name = "cookieIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.CookieIssueDetails CookieIssueDetails { get; set; }

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06001A6A RID: 6762 RVA: 0x0001C144 File Offset: 0x0001A344
		// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0001C14C File Offset: 0x0001A34C
		[global::System.Runtime.Serialization.DataMember(Name = "mixedContentIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.MixedContentIssueDetails MixedContentIssueDetails { get; set; }

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06001A6C RID: 6764 RVA: 0x0001C155 File Offset: 0x0001A355
		// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0001C15D File Offset: 0x0001A35D
		[global::System.Runtime.Serialization.DataMember(Name = "blockedByResponseIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.BlockedByResponseIssueDetails BlockedByResponseIssueDetails { get; set; }

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06001A6E RID: 6766 RVA: 0x0001C166 File Offset: 0x0001A366
		// (set) Token: 0x06001A6F RID: 6767 RVA: 0x0001C16E File Offset: 0x0001A36E
		[global::System.Runtime.Serialization.DataMember(Name = "heavyAdIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.HeavyAdIssueDetails HeavyAdIssueDetails { get; set; }

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06001A70 RID: 6768 RVA: 0x0001C177 File Offset: 0x0001A377
		// (set) Token: 0x06001A71 RID: 6769 RVA: 0x0001C17F File Offset: 0x0001A37F
		[global::System.Runtime.Serialization.DataMember(Name = "contentSecurityPolicyIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.ContentSecurityPolicyIssueDetails ContentSecurityPolicyIssueDetails { get; set; }

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06001A72 RID: 6770 RVA: 0x0001C188 File Offset: 0x0001A388
		// (set) Token: 0x06001A73 RID: 6771 RVA: 0x0001C190 File Offset: 0x0001A390
		[global::System.Runtime.Serialization.DataMember(Name = "sharedArrayBufferIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.SharedArrayBufferIssueDetails SharedArrayBufferIssueDetails { get; set; }

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06001A74 RID: 6772 RVA: 0x0001C199 File Offset: 0x0001A399
		// (set) Token: 0x06001A75 RID: 6773 RVA: 0x0001C1A1 File Offset: 0x0001A3A1
		[global::System.Runtime.Serialization.DataMember(Name = "twaQualityEnforcementDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.TrustedWebActivityIssueDetails TwaQualityEnforcementDetails { get; set; }

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x0001C1AA File Offset: 0x0001A3AA
		// (set) Token: 0x06001A77 RID: 6775 RVA: 0x0001C1B2 File Offset: 0x0001A3B2
		[global::System.Runtime.Serialization.DataMember(Name = "lowTextContrastIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.LowTextContrastIssueDetails LowTextContrastIssueDetails { get; set; }

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0001C1BB File Offset: 0x0001A3BB
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0001C1C3 File Offset: 0x0001A3C3
		[global::System.Runtime.Serialization.DataMember(Name = "corsIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.CorsIssueDetails CorsIssueDetails { get; set; }

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x0001C1CC File Offset: 0x0001A3CC
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0001C1D4 File Offset: 0x0001A3D4
		[global::System.Runtime.Serialization.DataMember(Name = "attributionReportingIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.AttributionReportingIssueDetails AttributionReportingIssueDetails { get; set; }

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0001C1DD File Offset: 0x0001A3DD
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0001C1E5 File Offset: 0x0001A3E5
		[global::System.Runtime.Serialization.DataMember(Name = "quirksModeIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.QuirksModeIssueDetails QuirksModeIssueDetails { get; set; }

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0001C1EE File Offset: 0x0001A3EE
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0001C1F6 File Offset: 0x0001A3F6
		[global::System.Runtime.Serialization.DataMember(Name = "navigatorUserAgentIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.NavigatorUserAgentIssueDetails NavigatorUserAgentIssueDetails { get; set; }

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0001C1FF File Offset: 0x0001A3FF
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0001C207 File Offset: 0x0001A407
		[global::System.Runtime.Serialization.DataMember(Name = "genericIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.GenericIssueDetails GenericIssueDetails { get; set; }

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0001C210 File Offset: 0x0001A410
		// (set) Token: 0x06001A83 RID: 6787 RVA: 0x0001C218 File Offset: 0x0001A418
		[global::System.Runtime.Serialization.DataMember(Name = "deprecationIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.DeprecationIssueDetails DeprecationIssueDetails { get; set; }

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0001C221 File Offset: 0x0001A421
		// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0001C229 File Offset: 0x0001A429
		[global::System.Runtime.Serialization.DataMember(Name = "clientHintIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.ClientHintIssueDetails ClientHintIssueDetails { get; set; }

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001A86 RID: 6790 RVA: 0x0001C232 File Offset: 0x0001A432
		// (set) Token: 0x06001A87 RID: 6791 RVA: 0x0001C23A File Offset: 0x0001A43A
		[global::System.Runtime.Serialization.DataMember(Name = "federatedAuthRequestIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.FederatedAuthRequestIssueDetails FederatedAuthRequestIssueDetails { get; set; }

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001A88 RID: 6792 RVA: 0x0001C243 File Offset: 0x0001A443
		// (set) Token: 0x06001A89 RID: 6793 RVA: 0x0001C24B File Offset: 0x0001A44B
		[global::System.Runtime.Serialization.DataMember(Name = "bounceTrackingIssueDetails", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.BounceTrackingIssueDetails BounceTrackingIssueDetails { get; set; }
	}
}
