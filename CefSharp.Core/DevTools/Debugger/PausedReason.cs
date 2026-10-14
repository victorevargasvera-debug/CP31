using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000084 RID: 132
	public enum PausedReason
	{
		// Token: 0x040001D6 RID: 470
		[global::System.Runtime.Serialization.EnumMember(Value = "ambiguous")]
		Ambiguous,
		// Token: 0x040001D7 RID: 471
		[global::System.Runtime.Serialization.EnumMember(Value = "assert")]
		Assert,
		// Token: 0x040001D8 RID: 472
		[global::System.Runtime.Serialization.EnumMember(Value = "CSPViolation")]
		CSPViolation,
		// Token: 0x040001D9 RID: 473
		[global::System.Runtime.Serialization.EnumMember(Value = "debugCommand")]
		DebugCommand,
		// Token: 0x040001DA RID: 474
		[global::System.Runtime.Serialization.EnumMember(Value = "DOM")]
		DOM,
		// Token: 0x040001DB RID: 475
		[global::System.Runtime.Serialization.EnumMember(Value = "EventListener")]
		EventListener,
		// Token: 0x040001DC RID: 476
		[global::System.Runtime.Serialization.EnumMember(Value = "exception")]
		Exception,
		// Token: 0x040001DD RID: 477
		[global::System.Runtime.Serialization.EnumMember(Value = "instrumentation")]
		Instrumentation,
		// Token: 0x040001DE RID: 478
		[global::System.Runtime.Serialization.EnumMember(Value = "OOM")]
		OOM,
		// Token: 0x040001DF RID: 479
		[global::System.Runtime.Serialization.EnumMember(Value = "other")]
		Other,
		// Token: 0x040001E0 RID: 480
		[global::System.Runtime.Serialization.EnumMember(Value = "promiseRejection")]
		PromiseRejection,
		// Token: 0x040001E1 RID: 481
		[global::System.Runtime.Serialization.EnumMember(Value = "XHR")]
		XHR,
		// Token: 0x040001E2 RID: 482
		[global::System.Runtime.Serialization.EnumMember(Value = "step")]
		Step
	}
}
