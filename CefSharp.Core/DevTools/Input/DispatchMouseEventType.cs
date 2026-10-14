using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Input
{
	// Token: 0x0200026C RID: 620
	public enum DispatchMouseEventType
	{
		// Token: 0x04000A44 RID: 2628
		[global::System.Runtime.Serialization.EnumMember(Value = "mousePressed")]
		MousePressed,
		// Token: 0x04000A45 RID: 2629
		[global::System.Runtime.Serialization.EnumMember(Value = "mouseReleased")]
		MouseReleased,
		// Token: 0x04000A46 RID: 2630
		[global::System.Runtime.Serialization.EnumMember(Value = "mouseMoved")]
		MouseMoved,
		// Token: 0x04000A47 RID: 2631
		[global::System.Runtime.Serialization.EnumMember(Value = "mouseWheel")]
		MouseWheel
	}
}
