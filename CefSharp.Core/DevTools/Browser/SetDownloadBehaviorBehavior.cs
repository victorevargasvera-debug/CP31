using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x02000340 RID: 832
	public enum SetDownloadBehaviorBehavior
	{
		// Token: 0x04000D0C RID: 3340
		[global::System.Runtime.Serialization.EnumMember(Value = "deny")]
		Deny,
		// Token: 0x04000D0D RID: 3341
		[global::System.Runtime.Serialization.EnumMember(Value = "allow")]
		Allow,
		// Token: 0x04000D0E RID: 3342
		[global::System.Runtime.Serialization.EnumMember(Value = "allowAndName")]
		AllowAndName,
		// Token: 0x04000D0F RID: 3343
		[global::System.Runtime.Serialization.EnumMember(Value = "default")]
		Default
	}
}
