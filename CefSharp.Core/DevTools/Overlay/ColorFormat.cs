using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001C9 RID: 457
	public enum ColorFormat
	{
		// Token: 0x04000747 RID: 1863
		[global::System.Runtime.Serialization.EnumMember(Value = "rgb")]
		Rgb,
		// Token: 0x04000748 RID: 1864
		[global::System.Runtime.Serialization.EnumMember(Value = "hsl")]
		Hsl,
		// Token: 0x04000749 RID: 1865
		[global::System.Runtime.Serialization.EnumMember(Value = "hwb")]
		Hwb,
		// Token: 0x0400074A RID: 1866
		[global::System.Runtime.Serialization.EnumMember(Value = "hex")]
		Hex
	}
}
