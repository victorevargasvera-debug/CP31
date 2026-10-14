using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000186 RID: 390
	public enum ReferrerPolicy
	{
		// Token: 0x040005F9 RID: 1529
		[global::System.Runtime.Serialization.EnumMember(Value = "noReferrer")]
		NoReferrer,
		// Token: 0x040005FA RID: 1530
		[global::System.Runtime.Serialization.EnumMember(Value = "noReferrerWhenDowngrade")]
		NoReferrerWhenDowngrade,
		// Token: 0x040005FB RID: 1531
		[global::System.Runtime.Serialization.EnumMember(Value = "origin")]
		Origin,
		// Token: 0x040005FC RID: 1532
		[global::System.Runtime.Serialization.EnumMember(Value = "originWhenCrossOrigin")]
		OriginWhenCrossOrigin,
		// Token: 0x040005FD RID: 1533
		[global::System.Runtime.Serialization.EnumMember(Value = "sameOrigin")]
		SameOrigin,
		// Token: 0x040005FE RID: 1534
		[global::System.Runtime.Serialization.EnumMember(Value = "strictOrigin")]
		StrictOrigin,
		// Token: 0x040005FF RID: 1535
		[global::System.Runtime.Serialization.EnumMember(Value = "strictOriginWhenCrossOrigin")]
		StrictOriginWhenCrossOrigin,
		// Token: 0x04000600 RID: 1536
		[global::System.Runtime.Serialization.EnumMember(Value = "unsafeUrl")]
		UnsafeUrl
	}
}
