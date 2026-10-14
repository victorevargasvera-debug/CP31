using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000B3 RID: 179
	public enum PlayerMessageLevel
	{
		// Token: 0x040002C2 RID: 706
		[global::System.Runtime.Serialization.EnumMember(Value = "error")]
		Error,
		// Token: 0x040002C3 RID: 707
		[global::System.Runtime.Serialization.EnumMember(Value = "warning")]
		Warning,
		// Token: 0x040002C4 RID: 708
		[global::System.Runtime.Serialization.EnumMember(Value = "info")]
		Info,
		// Token: 0x040002C5 RID: 709
		[global::System.Runtime.Serialization.EnumMember(Value = "debug")]
		Debug
	}
}
