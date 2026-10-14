using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Security
{
	// Token: 0x0200014A RID: 330
	public enum SecurityState
	{
		// Token: 0x0400049C RID: 1180
		[global::System.Runtime.Serialization.EnumMember(Value = "unknown")]
		Unknown,
		// Token: 0x0400049D RID: 1181
		[global::System.Runtime.Serialization.EnumMember(Value = "neutral")]
		Neutral,
		// Token: 0x0400049E RID: 1182
		[global::System.Runtime.Serialization.EnumMember(Value = "insecure")]
		Insecure,
		// Token: 0x0400049F RID: 1183
		[global::System.Runtime.Serialization.EnumMember(Value = "secure")]
		Secure,
		// Token: 0x040004A0 RID: 1184
		[global::System.Runtime.Serialization.EnumMember(Value = "info")]
		Info,
		// Token: 0x040004A1 RID: 1185
		[global::System.Runtime.Serialization.EnumMember(Value = "insecure-broken")]
		InsecureBroken
	}
}
