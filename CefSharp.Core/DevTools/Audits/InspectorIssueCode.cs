using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200036C RID: 876
	public enum InspectorIssueCode
	{
		// Token: 0x04000E0C RID: 3596
		[global::System.Runtime.Serialization.EnumMember(Value = "CookieIssue")]
		CookieIssue,
		// Token: 0x04000E0D RID: 3597
		[global::System.Runtime.Serialization.EnumMember(Value = "MixedContentIssue")]
		MixedContentIssue,
		// Token: 0x04000E0E RID: 3598
		[global::System.Runtime.Serialization.EnumMember(Value = "BlockedByResponseIssue")]
		BlockedByResponseIssue,
		// Token: 0x04000E0F RID: 3599
		[global::System.Runtime.Serialization.EnumMember(Value = "HeavyAdIssue")]
		HeavyAdIssue,
		// Token: 0x04000E10 RID: 3600
		[global::System.Runtime.Serialization.EnumMember(Value = "ContentSecurityPolicyIssue")]
		ContentSecurityPolicyIssue,
		// Token: 0x04000E11 RID: 3601
		[global::System.Runtime.Serialization.EnumMember(Value = "SharedArrayBufferIssue")]
		SharedArrayBufferIssue,
		// Token: 0x04000E12 RID: 3602
		[global::System.Runtime.Serialization.EnumMember(Value = "TrustedWebActivityIssue")]
		TrustedWebActivityIssue,
		// Token: 0x04000E13 RID: 3603
		[global::System.Runtime.Serialization.EnumMember(Value = "LowTextContrastIssue")]
		LowTextContrastIssue,
		// Token: 0x04000E14 RID: 3604
		[global::System.Runtime.Serialization.EnumMember(Value = "CorsIssue")]
		CorsIssue,
		// Token: 0x04000E15 RID: 3605
		[global::System.Runtime.Serialization.EnumMember(Value = "AttributionReportingIssue")]
		AttributionReportingIssue,
		// Token: 0x04000E16 RID: 3606
		[global::System.Runtime.Serialization.EnumMember(Value = "QuirksModeIssue")]
		QuirksModeIssue,
		// Token: 0x04000E17 RID: 3607
		[global::System.Runtime.Serialization.EnumMember(Value = "NavigatorUserAgentIssue")]
		NavigatorUserAgentIssue,
		// Token: 0x04000E18 RID: 3608
		[global::System.Runtime.Serialization.EnumMember(Value = "GenericIssue")]
		GenericIssue,
		// Token: 0x04000E19 RID: 3609
		[global::System.Runtime.Serialization.EnumMember(Value = "DeprecationIssue")]
		DeprecationIssue,
		// Token: 0x04000E1A RID: 3610
		[global::System.Runtime.Serialization.EnumMember(Value = "ClientHintIssue")]
		ClientHintIssue,
		// Token: 0x04000E1B RID: 3611
		[global::System.Runtime.Serialization.EnumMember(Value = "FederatedAuthRequestIssue")]
		FederatedAuthRequestIssue,
		// Token: 0x04000E1C RID: 3612
		[global::System.Runtime.Serialization.EnumMember(Value = "BounceTrackingIssue")]
		BounceTrackingIssue
	}
}
