using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001F6 RID: 502
	public enum InitiatorType
	{
		// Token: 0x0400085D RID: 2141
		[global::System.Runtime.Serialization.EnumMember(Value = "parser")]
		Parser,
		// Token: 0x0400085E RID: 2142
		[global::System.Runtime.Serialization.EnumMember(Value = "script")]
		Script,
		// Token: 0x0400085F RID: 2143
		[global::System.Runtime.Serialization.EnumMember(Value = "preload")]
		Preload,
		// Token: 0x04000860 RID: 2144
		[global::System.Runtime.Serialization.EnumMember(Value = "SignedExchange")]
		SignedExchange,
		// Token: 0x04000861 RID: 2145
		[global::System.Runtime.Serialization.EnumMember(Value = "preflight")]
		Preflight,
		// Token: 0x04000862 RID: 2146
		[global::System.Runtime.Serialization.EnumMember(Value = "other")]
		Other
	}
}
