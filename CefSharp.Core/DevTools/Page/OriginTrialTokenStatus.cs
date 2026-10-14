using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200016C RID: 364
	public enum OriginTrialTokenStatus
	{
		// Token: 0x0400056C RID: 1388
		[global::System.Runtime.Serialization.EnumMember(Value = "Success")]
		Success,
		// Token: 0x0400056D RID: 1389
		[global::System.Runtime.Serialization.EnumMember(Value = "NotSupported")]
		NotSupported,
		// Token: 0x0400056E RID: 1390
		[global::System.Runtime.Serialization.EnumMember(Value = "Insecure")]
		Insecure,
		// Token: 0x0400056F RID: 1391
		[global::System.Runtime.Serialization.EnumMember(Value = "Expired")]
		Expired,
		// Token: 0x04000570 RID: 1392
		[global::System.Runtime.Serialization.EnumMember(Value = "WrongOrigin")]
		WrongOrigin,
		// Token: 0x04000571 RID: 1393
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidSignature")]
		InvalidSignature,
		// Token: 0x04000572 RID: 1394
		[global::System.Runtime.Serialization.EnumMember(Value = "Malformed")]
		Malformed,
		// Token: 0x04000573 RID: 1395
		[global::System.Runtime.Serialization.EnumMember(Value = "WrongVersion")]
		WrongVersion,
		// Token: 0x04000574 RID: 1396
		[global::System.Runtime.Serialization.EnumMember(Value = "FeatureDisabled")]
		FeatureDisabled,
		// Token: 0x04000575 RID: 1397
		[global::System.Runtime.Serialization.EnumMember(Value = "TokenDisabled")]
		TokenDisabled,
		// Token: 0x04000576 RID: 1398
		[global::System.Runtime.Serialization.EnumMember(Value = "FeatureDisabledForUser")]
		FeatureDisabledForUser,
		// Token: 0x04000577 RID: 1399
		[global::System.Runtime.Serialization.EnumMember(Value = "UnknownTrial")]
		UnknownTrial
	}
}
