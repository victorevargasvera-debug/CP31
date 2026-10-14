using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200018B RID: 395
	public enum BackForwardCacheNotRestoredReasonType
	{
		// Token: 0x04000689 RID: 1673
		[global::System.Runtime.Serialization.EnumMember(Value = "SupportPending")]
		SupportPending,
		// Token: 0x0400068A RID: 1674
		[global::System.Runtime.Serialization.EnumMember(Value = "PageSupportNeeded")]
		PageSupportNeeded,
		// Token: 0x0400068B RID: 1675
		[global::System.Runtime.Serialization.EnumMember(Value = "Circumstantial")]
		Circumstantial
	}
}
