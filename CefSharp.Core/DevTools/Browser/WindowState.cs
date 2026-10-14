using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x0200032F RID: 815
	public enum WindowState
	{
		// Token: 0x04000CBC RID: 3260
		[global::System.Runtime.Serialization.EnumMember(Value = "normal")]
		Normal,
		// Token: 0x04000CBD RID: 3261
		[global::System.Runtime.Serialization.EnumMember(Value = "minimized")]
		Minimized,
		// Token: 0x04000CBE RID: 3262
		[global::System.Runtime.Serialization.EnumMember(Value = "maximized")]
		Maximized,
		// Token: 0x04000CBF RID: 3263
		[global::System.Runtime.Serialization.EnumMember(Value = "fullscreen")]
		Fullscreen
	}
}
