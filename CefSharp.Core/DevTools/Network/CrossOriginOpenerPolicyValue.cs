using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200020E RID: 526
	public enum CrossOriginOpenerPolicyValue
	{
		// Token: 0x040008F4 RID: 2292
		[global::System.Runtime.Serialization.EnumMember(Value = "SameOrigin")]
		SameOrigin,
		// Token: 0x040008F5 RID: 2293
		[global::System.Runtime.Serialization.EnumMember(Value = "SameOriginAllowPopups")]
		SameOriginAllowPopups,
		// Token: 0x040008F6 RID: 2294
		[global::System.Runtime.Serialization.EnumMember(Value = "RestrictProperties")]
		RestrictProperties,
		// Token: 0x040008F7 RID: 2295
		[global::System.Runtime.Serialization.EnumMember(Value = "UnsafeNone")]
		UnsafeNone,
		// Token: 0x040008F8 RID: 2296
		[global::System.Runtime.Serialization.EnumMember(Value = "SameOriginPlusCoep")]
		SameOriginPlusCoep,
		// Token: 0x040008F9 RID: 2297
		[global::System.Runtime.Serialization.EnumMember(Value = "RestrictPropertiesPlusCoep")]
		RestrictPropertiesPlusCoep
	}
}
