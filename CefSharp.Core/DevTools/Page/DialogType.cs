using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000179 RID: 377
	public enum DialogType
	{
		// Token: 0x040005C1 RID: 1473
		[global::System.Runtime.Serialization.EnumMember(Value = "alert")]
		Alert,
		// Token: 0x040005C2 RID: 1474
		[global::System.Runtime.Serialization.EnumMember(Value = "confirm")]
		Confirm,
		// Token: 0x040005C3 RID: 1475
		[global::System.Runtime.Serialization.EnumMember(Value = "prompt")]
		Prompt,
		// Token: 0x040005C4 RID: 1476
		[global::System.Runtime.Serialization.EnumMember(Value = "beforeunload")]
		Beforeunload
	}
}
