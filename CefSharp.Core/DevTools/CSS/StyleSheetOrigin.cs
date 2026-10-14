using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002F4 RID: 756
	public enum StyleSheetOrigin
	{
		// Token: 0x04000C08 RID: 3080
		[global::System.Runtime.Serialization.EnumMember(Value = "injected")]
		Injected,
		// Token: 0x04000C09 RID: 3081
		[global::System.Runtime.Serialization.EnumMember(Value = "user-agent")]
		UserAgent,
		// Token: 0x04000C0A RID: 3082
		[global::System.Runtime.Serialization.EnumMember(Value = "inspector")]
		Inspector,
		// Token: 0x04000C0B RID: 3083
		[global::System.Runtime.Serialization.EnumMember(Value = "regular")]
		Regular
	}
}
