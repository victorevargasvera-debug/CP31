using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200016D RID: 365
	public enum OriginTrialStatus
	{
		// Token: 0x04000579 RID: 1401
		[global::System.Runtime.Serialization.EnumMember(Value = "Enabled")]
		Enabled,
		// Token: 0x0400057A RID: 1402
		[global::System.Runtime.Serialization.EnumMember(Value = "ValidTokenNotProvided")]
		ValidTokenNotProvided,
		// Token: 0x0400057B RID: 1403
		[global::System.Runtime.Serialization.EnumMember(Value = "OSNotSupported")]
		OSNotSupported,
		// Token: 0x0400057C RID: 1404
		[global::System.Runtime.Serialization.EnumMember(Value = "TrialNotAllowed")]
		TrialNotAllowed
	}
}
