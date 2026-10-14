using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x0200007D RID: 125
	public enum BreakLocationType
	{
		// Token: 0x040001C0 RID: 448
		[global::System.Runtime.Serialization.EnumMember(Value = "debuggerStatement")]
		DebuggerStatement,
		// Token: 0x040001C1 RID: 449
		[global::System.Runtime.Serialization.EnumMember(Value = "call")]
		Call,
		// Token: 0x040001C2 RID: 450
		[global::System.Runtime.Serialization.EnumMember(Value = "return")]
		Return
	}
}
