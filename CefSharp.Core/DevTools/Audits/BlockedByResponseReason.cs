using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000352 RID: 850
	public enum BlockedByResponseReason
	{
		// Token: 0x04000D72 RID: 3442
		[global::System.Runtime.Serialization.EnumMember(Value = "CoepFrameResourceNeedsCoepHeader")]
		CoepFrameResourceNeedsCoepHeader,
		// Token: 0x04000D73 RID: 3443
		[global::System.Runtime.Serialization.EnumMember(Value = "CoopSandboxedIFrameCannotNavigateToCoopPage")]
		CoopSandboxedIFrameCannotNavigateToCoopPage,
		// Token: 0x04000D74 RID: 3444
		[global::System.Runtime.Serialization.EnumMember(Value = "CorpNotSameOrigin")]
		CorpNotSameOrigin,
		// Token: 0x04000D75 RID: 3445
		[global::System.Runtime.Serialization.EnumMember(Value = "CorpNotSameOriginAfterDefaultedToSameOriginByCoep")]
		CorpNotSameOriginAfterDefaultedToSameOriginByCoep,
		// Token: 0x04000D76 RID: 3446
		[global::System.Runtime.Serialization.EnumMember(Value = "CorpNotSameSite")]
		CorpNotSameSite
	}
}
