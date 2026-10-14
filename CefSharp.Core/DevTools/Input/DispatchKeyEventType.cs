using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Input
{
	// Token: 0x0200026B RID: 619
	public enum DispatchKeyEventType
	{
		// Token: 0x04000A3F RID: 2623
		[global::System.Runtime.Serialization.EnumMember(Value = "keyDown")]
		KeyDown,
		// Token: 0x04000A40 RID: 2624
		[global::System.Runtime.Serialization.EnumMember(Value = "keyUp")]
		KeyUp,
		// Token: 0x04000A41 RID: 2625
		[global::System.Runtime.Serialization.EnumMember(Value = "rawKeyDown")]
		RawKeyDown,
		// Token: 0x04000A42 RID: 2626
		[global::System.Runtime.Serialization.EnumMember(Value = "char")]
		Char
	}
}
