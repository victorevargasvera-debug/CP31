using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001E9 RID: 489
	public enum BlockedReason
	{
		// Token: 0x040007F1 RID: 2033
		[global::System.Runtime.Serialization.EnumMember(Value = "other")]
		Other,
		// Token: 0x040007F2 RID: 2034
		[global::System.Runtime.Serialization.EnumMember(Value = "csp")]
		Csp,
		// Token: 0x040007F3 RID: 2035
		[global::System.Runtime.Serialization.EnumMember(Value = "mixed-content")]
		MixedContent,
		// Token: 0x040007F4 RID: 2036
		[global::System.Runtime.Serialization.EnumMember(Value = "origin")]
		Origin,
		// Token: 0x040007F5 RID: 2037
		[global::System.Runtime.Serialization.EnumMember(Value = "inspector")]
		Inspector,
		// Token: 0x040007F6 RID: 2038
		[global::System.Runtime.Serialization.EnumMember(Value = "subresource-filter")]
		SubresourceFilter,
		// Token: 0x040007F7 RID: 2039
		[global::System.Runtime.Serialization.EnumMember(Value = "content-type")]
		ContentType,
		// Token: 0x040007F8 RID: 2040
		[global::System.Runtime.Serialization.EnumMember(Value = "coep-frame-resource-needs-coep-header")]
		CoepFrameResourceNeedsCoepHeader,
		// Token: 0x040007F9 RID: 2041
		[global::System.Runtime.Serialization.EnumMember(Value = "coop-sandboxed-iframe-cannot-navigate-to-coop-page")]
		CoopSandboxedIframeCannotNavigateToCoopPage,
		// Token: 0x040007FA RID: 2042
		[global::System.Runtime.Serialization.EnumMember(Value = "corp-not-same-origin")]
		CorpNotSameOrigin,
		// Token: 0x040007FB RID: 2043
		[global::System.Runtime.Serialization.EnumMember(Value = "corp-not-same-origin-after-defaulted-to-same-origin-by-coep")]
		CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
		// Token: 0x040007FC RID: 2044
		[global::System.Runtime.Serialization.EnumMember(Value = "corp-not-same-site")]
		CorpNotSameSite
	}
}
