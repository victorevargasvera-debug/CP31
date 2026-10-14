using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Input
{
	// Token: 0x0200026E RID: 622
	public enum DispatchTouchEventType
	{
		// Token: 0x04000A4C RID: 2636
		[global::System.Runtime.Serialization.EnumMember(Value = "touchStart")]
		TouchStart,
		// Token: 0x04000A4D RID: 2637
		[global::System.Runtime.Serialization.EnumMember(Value = "touchEnd")]
		TouchEnd,
		// Token: 0x04000A4E RID: 2638
		[global::System.Runtime.Serialization.EnumMember(Value = "touchMove")]
		TouchMove,
		// Token: 0x04000A4F RID: 2639
		[global::System.Runtime.Serialization.EnumMember(Value = "touchCancel")]
		TouchCancel
	}
}
