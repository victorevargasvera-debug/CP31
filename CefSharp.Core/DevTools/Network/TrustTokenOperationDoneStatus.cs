using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200022E RID: 558
	public enum TrustTokenOperationDoneStatus
	{
		// Token: 0x04000985 RID: 2437
		[global::System.Runtime.Serialization.EnumMember(Value = "Ok")]
		Ok,
		// Token: 0x04000986 RID: 2438
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidArgument")]
		InvalidArgument,
		// Token: 0x04000987 RID: 2439
		[global::System.Runtime.Serialization.EnumMember(Value = "FailedPrecondition")]
		FailedPrecondition,
		// Token: 0x04000988 RID: 2440
		[global::System.Runtime.Serialization.EnumMember(Value = "ResourceExhausted")]
		ResourceExhausted,
		// Token: 0x04000989 RID: 2441
		[global::System.Runtime.Serialization.EnumMember(Value = "AlreadyExists")]
		AlreadyExists,
		// Token: 0x0400098A RID: 2442
		[global::System.Runtime.Serialization.EnumMember(Value = "Unavailable")]
		Unavailable,
		// Token: 0x0400098B RID: 2443
		[global::System.Runtime.Serialization.EnumMember(Value = "Unauthorized")]
		Unauthorized,
		// Token: 0x0400098C RID: 2444
		[global::System.Runtime.Serialization.EnumMember(Value = "BadResponse")]
		BadResponse,
		// Token: 0x0400098D RID: 2445
		[global::System.Runtime.Serialization.EnumMember(Value = "InternalError")]
		InternalError,
		// Token: 0x0400098E RID: 2446
		[global::System.Runtime.Serialization.EnumMember(Value = "UnknownError")]
		UnknownError,
		// Token: 0x0400098F RID: 2447
		[global::System.Runtime.Serialization.EnumMember(Value = "FulfilledLocally")]
		FulfilledLocally
	}
}
