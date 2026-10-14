using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000099 RID: 153
	public enum SetPauseOnExceptionsState
	{
		// Token: 0x04000233 RID: 563
		[global::System.Runtime.Serialization.EnumMember(Value = "none")]
		None,
		// Token: 0x04000234 RID: 564
		[global::System.Runtime.Serialization.EnumMember(Value = "caught")]
		Caught,
		// Token: 0x04000235 RID: 565
		[global::System.Runtime.Serialization.EnumMember(Value = "uncaught")]
		Uncaught,
		// Token: 0x04000236 RID: 566
		[global::System.Runtime.Serialization.EnumMember(Value = "all")]
		All
	}
}
