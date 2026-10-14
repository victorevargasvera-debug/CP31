using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000303 RID: 771
	public enum CSSMediaSource
	{
		// Token: 0x04000C50 RID: 3152
		[global::System.Runtime.Serialization.EnumMember(Value = "mediaRule")]
		MediaRule,
		// Token: 0x04000C51 RID: 3153
		[global::System.Runtime.Serialization.EnumMember(Value = "importRule")]
		ImportRule,
		// Token: 0x04000C52 RID: 3154
		[global::System.Runtime.Serialization.EnumMember(Value = "linkedSheet")]
		LinkedSheet,
		// Token: 0x04000C53 RID: 3155
		[global::System.Runtime.Serialization.EnumMember(Value = "inlineSheet")]
		InlineSheet
	}
}
