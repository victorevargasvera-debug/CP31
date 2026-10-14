using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200003C RID: 60
	public enum PropertyPreviewSubtype
	{
		// Token: 0x040000DF RID: 223
		[global::System.Runtime.Serialization.EnumMember(Value = "array")]
		Array,
		// Token: 0x040000E0 RID: 224
		[global::System.Runtime.Serialization.EnumMember(Value = "null")]
		Null,
		// Token: 0x040000E1 RID: 225
		[global::System.Runtime.Serialization.EnumMember(Value = "node")]
		Node,
		// Token: 0x040000E2 RID: 226
		[global::System.Runtime.Serialization.EnumMember(Value = "regexp")]
		Regexp,
		// Token: 0x040000E3 RID: 227
		[global::System.Runtime.Serialization.EnumMember(Value = "date")]
		Date,
		// Token: 0x040000E4 RID: 228
		[global::System.Runtime.Serialization.EnumMember(Value = "map")]
		Map,
		// Token: 0x040000E5 RID: 229
		[global::System.Runtime.Serialization.EnumMember(Value = "set")]
		Set,
		// Token: 0x040000E6 RID: 230
		[global::System.Runtime.Serialization.EnumMember(Value = "weakmap")]
		Weakmap,
		// Token: 0x040000E7 RID: 231
		[global::System.Runtime.Serialization.EnumMember(Value = "weakset")]
		Weakset,
		// Token: 0x040000E8 RID: 232
		[global::System.Runtime.Serialization.EnumMember(Value = "iterator")]
		Iterator,
		// Token: 0x040000E9 RID: 233
		[global::System.Runtime.Serialization.EnumMember(Value = "generator")]
		Generator,
		// Token: 0x040000EA RID: 234
		[global::System.Runtime.Serialization.EnumMember(Value = "error")]
		Error,
		// Token: 0x040000EB RID: 235
		[global::System.Runtime.Serialization.EnumMember(Value = "proxy")]
		Proxy,
		// Token: 0x040000EC RID: 236
		[global::System.Runtime.Serialization.EnumMember(Value = "promise")]
		Promise,
		// Token: 0x040000ED RID: 237
		[global::System.Runtime.Serialization.EnumMember(Value = "typedarray")]
		Typedarray,
		// Token: 0x040000EE RID: 238
		[global::System.Runtime.Serialization.EnumMember(Value = "arraybuffer")]
		Arraybuffer,
		// Token: 0x040000EF RID: 239
		[global::System.Runtime.Serialization.EnumMember(Value = "dataview")]
		Dataview,
		// Token: 0x040000F0 RID: 240
		[global::System.Runtime.Serialization.EnumMember(Value = "webassemblymemory")]
		Webassemblymemory,
		// Token: 0x040000F1 RID: 241
		[global::System.Runtime.Serialization.EnumMember(Value = "wasmvalue")]
		Wasmvalue
	}
}
