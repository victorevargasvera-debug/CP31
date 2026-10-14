using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000032 RID: 50
	public enum WebDriverValueType
	{
		// Token: 0x0400006E RID: 110
		[global::System.Runtime.Serialization.EnumMember(Value = "undefined")]
		Undefined,
		// Token: 0x0400006F RID: 111
		[global::System.Runtime.Serialization.EnumMember(Value = "null")]
		Null,
		// Token: 0x04000070 RID: 112
		[global::System.Runtime.Serialization.EnumMember(Value = "string")]
		String,
		// Token: 0x04000071 RID: 113
		[global::System.Runtime.Serialization.EnumMember(Value = "number")]
		Number,
		// Token: 0x04000072 RID: 114
		[global::System.Runtime.Serialization.EnumMember(Value = "boolean")]
		Boolean,
		// Token: 0x04000073 RID: 115
		[global::System.Runtime.Serialization.EnumMember(Value = "bigint")]
		Bigint,
		// Token: 0x04000074 RID: 116
		[global::System.Runtime.Serialization.EnumMember(Value = "regexp")]
		Regexp,
		// Token: 0x04000075 RID: 117
		[global::System.Runtime.Serialization.EnumMember(Value = "date")]
		Date,
		// Token: 0x04000076 RID: 118
		[global::System.Runtime.Serialization.EnumMember(Value = "symbol")]
		Symbol,
		// Token: 0x04000077 RID: 119
		[global::System.Runtime.Serialization.EnumMember(Value = "array")]
		Array,
		// Token: 0x04000078 RID: 120
		[global::System.Runtime.Serialization.EnumMember(Value = "object")]
		Object,
		// Token: 0x04000079 RID: 121
		[global::System.Runtime.Serialization.EnumMember(Value = "function")]
		Function,
		// Token: 0x0400007A RID: 122
		[global::System.Runtime.Serialization.EnumMember(Value = "map")]
		Map,
		// Token: 0x0400007B RID: 123
		[global::System.Runtime.Serialization.EnumMember(Value = "set")]
		Set,
		// Token: 0x0400007C RID: 124
		[global::System.Runtime.Serialization.EnumMember(Value = "weakmap")]
		Weakmap,
		// Token: 0x0400007D RID: 125
		[global::System.Runtime.Serialization.EnumMember(Value = "weakset")]
		Weakset,
		// Token: 0x0400007E RID: 126
		[global::System.Runtime.Serialization.EnumMember(Value = "error")]
		Error,
		// Token: 0x0400007F RID: 127
		[global::System.Runtime.Serialization.EnumMember(Value = "proxy")]
		Proxy,
		// Token: 0x04000080 RID: 128
		[global::System.Runtime.Serialization.EnumMember(Value = "promise")]
		Promise,
		// Token: 0x04000081 RID: 129
		[global::System.Runtime.Serialization.EnumMember(Value = "typedarray")]
		Typedarray,
		// Token: 0x04000082 RID: 130
		[global::System.Runtime.Serialization.EnumMember(Value = "arraybuffer")]
		Arraybuffer,
		// Token: 0x04000083 RID: 131
		[global::System.Runtime.Serialization.EnumMember(Value = "node")]
		Node,
		// Token: 0x04000084 RID: 132
		[global::System.Runtime.Serialization.EnumMember(Value = "window")]
		Window
	}
}
