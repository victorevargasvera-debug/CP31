using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200020A RID: 522
	public enum PrivateNetworkRequestPolicy
	{
		// Token: 0x040008E5 RID: 2277
		[global::System.Runtime.Serialization.EnumMember(Value = "Allow")]
		Allow,
		// Token: 0x040008E6 RID: 2278
		[global::System.Runtime.Serialization.EnumMember(Value = "BlockFromInsecureToMorePrivate")]
		BlockFromInsecureToMorePrivate,
		// Token: 0x040008E7 RID: 2279
		[global::System.Runtime.Serialization.EnumMember(Value = "WarnFromInsecureToMorePrivate")]
		WarnFromInsecureToMorePrivate,
		// Token: 0x040008E8 RID: 2280
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightBlock")]
		PreflightBlock,
		// Token: 0x040008E9 RID: 2281
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightWarn")]
		PreflightWarn
	}
}
