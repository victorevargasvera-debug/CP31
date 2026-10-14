using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Input
{
	// Token: 0x0200026F RID: 623
	public enum EmulateTouchFromMouseEventType
	{
		// Token: 0x04000A51 RID: 2641
		[global::System.Runtime.Serialization.EnumMember(Value = "mousePressed")]
		MousePressed,
		// Token: 0x04000A52 RID: 2642
		[global::System.Runtime.Serialization.EnumMember(Value = "mouseReleased")]
		MouseReleased,
		// Token: 0x04000A53 RID: 2643
		[global::System.Runtime.Serialization.EnumMember(Value = "mouseMoved")]
		MouseMoved,
		// Token: 0x04000A54 RID: 2644
		[global::System.Runtime.Serialization.EnumMember(Value = "mouseWheel")]
		MouseWheel
	}
}
