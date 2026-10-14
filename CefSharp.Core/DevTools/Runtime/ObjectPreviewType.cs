using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000038 RID: 56
	public enum ObjectPreviewType
	{
		// Token: 0x040000B2 RID: 178
		[global::System.Runtime.Serialization.EnumMember(Value = "object")]
		Object,
		// Token: 0x040000B3 RID: 179
		[global::System.Runtime.Serialization.EnumMember(Value = "function")]
		Function,
		// Token: 0x040000B4 RID: 180
		[global::System.Runtime.Serialization.EnumMember(Value = "undefined")]
		Undefined,
		// Token: 0x040000B5 RID: 181
		[global::System.Runtime.Serialization.EnumMember(Value = "string")]
		String,
		// Token: 0x040000B6 RID: 182
		[global::System.Runtime.Serialization.EnumMember(Value = "number")]
		Number,
		// Token: 0x040000B7 RID: 183
		[global::System.Runtime.Serialization.EnumMember(Value = "boolean")]
		Boolean,
		// Token: 0x040000B8 RID: 184
		[global::System.Runtime.Serialization.EnumMember(Value = "symbol")]
		Symbol,
		// Token: 0x040000B9 RID: 185
		[global::System.Runtime.Serialization.EnumMember(Value = "bigint")]
		Bigint
	}
}
