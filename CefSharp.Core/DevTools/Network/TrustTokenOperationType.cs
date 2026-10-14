using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001EF RID: 495
	public enum TrustTokenOperationType
	{
		// Token: 0x0400082A RID: 2090
		[global::System.Runtime.Serialization.EnumMember(Value = "Issuance")]
		Issuance,
		// Token: 0x0400082B RID: 2091
		[global::System.Runtime.Serialization.EnumMember(Value = "Redemption")]
		Redemption,
		// Token: 0x0400082C RID: 2092
		[global::System.Runtime.Serialization.EnumMember(Value = "Signing")]
		Signing
	}
}
