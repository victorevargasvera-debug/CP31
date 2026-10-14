using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200034F RID: 847
	public enum MixedContentResolutionStatus
	{
		// Token: 0x04000D4C RID: 3404
		[global::System.Runtime.Serialization.EnumMember(Value = "MixedContentBlocked")]
		MixedContentBlocked,
		// Token: 0x04000D4D RID: 3405
		[global::System.Runtime.Serialization.EnumMember(Value = "MixedContentAutomaticallyUpgraded")]
		MixedContentAutomaticallyUpgraded,
		// Token: 0x04000D4E RID: 3406
		[global::System.Runtime.Serialization.EnumMember(Value = "MixedContentWarning")]
		MixedContentWarning
	}
}
