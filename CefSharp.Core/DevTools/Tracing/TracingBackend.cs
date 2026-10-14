using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Tracing
{
	// Token: 0x020000F4 RID: 244
	public enum TracingBackend
	{
		// Token: 0x04000394 RID: 916
		[global::System.Runtime.Serialization.EnumMember(Value = "auto")]
		Auto,
		// Token: 0x04000395 RID: 917
		[global::System.Runtime.Serialization.EnumMember(Value = "chrome")]
		Chrome,
		// Token: 0x04000396 RID: 918
		[global::System.Runtime.Serialization.EnumMember(Value = "system")]
		System
	}
}
