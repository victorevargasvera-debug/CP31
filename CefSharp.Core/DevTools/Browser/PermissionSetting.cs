using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x02000332 RID: 818
	public enum PermissionSetting
	{
		// Token: 0x04000CE2 RID: 3298
		[global::System.Runtime.Serialization.EnumMember(Value = "granted")]
		Granted,
		// Token: 0x04000CE3 RID: 3299
		[global::System.Runtime.Serialization.EnumMember(Value = "denied")]
		Denied,
		// Token: 0x04000CE4 RID: 3300
		[global::System.Runtime.Serialization.EnumMember(Value = "prompt")]
		Prompt
	}
}
