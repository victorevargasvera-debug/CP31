using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200003B RID: 59
	public enum PropertyPreviewType
	{
		// Token: 0x040000D5 RID: 213
		[global::System.Runtime.Serialization.EnumMember(Value = "object")]
		Object,
		// Token: 0x040000D6 RID: 214
		[global::System.Runtime.Serialization.EnumMember(Value = "function")]
		Function,
		// Token: 0x040000D7 RID: 215
		[global::System.Runtime.Serialization.EnumMember(Value = "undefined")]
		Undefined,
		// Token: 0x040000D8 RID: 216
		[global::System.Runtime.Serialization.EnumMember(Value = "string")]
		String,
		// Token: 0x040000D9 RID: 217
		[global::System.Runtime.Serialization.EnumMember(Value = "number")]
		Number,
		// Token: 0x040000DA RID: 218
		[global::System.Runtime.Serialization.EnumMember(Value = "boolean")]
		Boolean,
		// Token: 0x040000DB RID: 219
		[global::System.Runtime.Serialization.EnumMember(Value = "symbol")]
		Symbol,
		// Token: 0x040000DC RID: 220
		[global::System.Runtime.Serialization.EnumMember(Value = "accessor")]
		Accessor,
		// Token: 0x040000DD RID: 221
		[global::System.Runtime.Serialization.EnumMember(Value = "bigint")]
		Bigint
	}
}
