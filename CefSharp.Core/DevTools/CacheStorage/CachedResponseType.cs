using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CacheStorage
{
	// Token: 0x020002EB RID: 747
	public enum CachedResponseType
	{
		// Token: 0x04000BED RID: 3053
		[global::System.Runtime.Serialization.EnumMember(Value = "basic")]
		Basic,
		// Token: 0x04000BEE RID: 3054
		[global::System.Runtime.Serialization.EnumMember(Value = "cors")]
		Cors,
		// Token: 0x04000BEF RID: 3055
		[global::System.Runtime.Serialization.EnumMember(Value = "default")]
		Default,
		// Token: 0x04000BF0 RID: 3056
		[global::System.Runtime.Serialization.EnumMember(Value = "error")]
		Error,
		// Token: 0x04000BF1 RID: 3057
		[global::System.Runtime.Serialization.EnumMember(Value = "opaqueResponse")]
		OpaqueResponse,
		// Token: 0x04000BF2 RID: 3058
		[global::System.Runtime.Serialization.EnumMember(Value = "opaqueRedirect")]
		OpaqueRedirect
	}
}
