using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001E4 RID: 484
	public enum RequestReferrerPolicy
	{
		// Token: 0x040007C0 RID: 1984
		[global::System.Runtime.Serialization.EnumMember(Value = "unsafe-url")]
		UnsafeUrl,
		// Token: 0x040007C1 RID: 1985
		[global::System.Runtime.Serialization.EnumMember(Value = "no-referrer-when-downgrade")]
		NoReferrerWhenDowngrade,
		// Token: 0x040007C2 RID: 1986
		[global::System.Runtime.Serialization.EnumMember(Value = "no-referrer")]
		NoReferrer,
		// Token: 0x040007C3 RID: 1987
		[global::System.Runtime.Serialization.EnumMember(Value = "origin")]
		Origin,
		// Token: 0x040007C4 RID: 1988
		[global::System.Runtime.Serialization.EnumMember(Value = "origin-when-cross-origin")]
		OriginWhenCrossOrigin,
		// Token: 0x040007C5 RID: 1989
		[global::System.Runtime.Serialization.EnumMember(Value = "same-origin")]
		SameOrigin,
		// Token: 0x040007C6 RID: 1990
		[global::System.Runtime.Serialization.EnumMember(Value = "strict-origin")]
		StrictOrigin,
		// Token: 0x040007C7 RID: 1991
		[global::System.Runtime.Serialization.EnumMember(Value = "strict-origin-when-cross-origin")]
		StrictOriginWhenCrossOrigin
	}
}
