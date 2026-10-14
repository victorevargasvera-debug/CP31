using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Log
{
	// Token: 0x0200024D RID: 589
	public enum LogEntryLevel
	{
		// Token: 0x040009D4 RID: 2516
		[global::System.Runtime.Serialization.EnumMember(Value = "verbose")]
		Verbose,
		// Token: 0x040009D5 RID: 2517
		[global::System.Runtime.Serialization.EnumMember(Value = "info")]
		Info,
		// Token: 0x040009D6 RID: 2518
		[global::System.Runtime.Serialization.EnumMember(Value = "warning")]
		Warning,
		// Token: 0x040009D7 RID: 2519
		[global::System.Runtime.Serialization.EnumMember(Value = "error")]
		Error
	}
}
