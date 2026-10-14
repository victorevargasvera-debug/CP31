using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000039 RID: 57
	public enum ObjectPreviewSubtype
	{
		// Token: 0x040000BB RID: 187
		[global::System.Runtime.Serialization.EnumMember(Value = "array")]
		Array,
		// Token: 0x040000BC RID: 188
		[global::System.Runtime.Serialization.EnumMember(Value = "null")]
		Null,
		// Token: 0x040000BD RID: 189
		[global::System.Runtime.Serialization.EnumMember(Value = "node")]
		Node,
		// Token: 0x040000BE RID: 190
		[global::System.Runtime.Serialization.EnumMember(Value = "regexp")]
		Regexp,
		// Token: 0x040000BF RID: 191
		[global::System.Runtime.Serialization.EnumMember(Value = "date")]
		Date,
		// Token: 0x040000C0 RID: 192
		[global::System.Runtime.Serialization.EnumMember(Value = "map")]
		Map,
		// Token: 0x040000C1 RID: 193
		[global::System.Runtime.Serialization.EnumMember(Value = "set")]
		Set,
		// Token: 0x040000C2 RID: 194
		[global::System.Runtime.Serialization.EnumMember(Value = "weakmap")]
		Weakmap,
		// Token: 0x040000C3 RID: 195
		[global::System.Runtime.Serialization.EnumMember(Value = "weakset")]
		Weakset,
		// Token: 0x040000C4 RID: 196
		[global::System.Runtime.Serialization.EnumMember(Value = "iterator")]
		Iterator,
		// Token: 0x040000C5 RID: 197
		[global::System.Runtime.Serialization.EnumMember(Value = "generator")]
		Generator,
		// Token: 0x040000C6 RID: 198
		[global::System.Runtime.Serialization.EnumMember(Value = "error")]
		Error,
		// Token: 0x040000C7 RID: 199
		[global::System.Runtime.Serialization.EnumMember(Value = "proxy")]
		Proxy,
		// Token: 0x040000C8 RID: 200
		[global::System.Runtime.Serialization.EnumMember(Value = "promise")]
		Promise,
		// Token: 0x040000C9 RID: 201
		[global::System.Runtime.Serialization.EnumMember(Value = "typedarray")]
		Typedarray,
		// Token: 0x040000CA RID: 202
		[global::System.Runtime.Serialization.EnumMember(Value = "arraybuffer")]
		Arraybuffer,
		// Token: 0x040000CB RID: 203
		[global::System.Runtime.Serialization.EnumMember(Value = "dataview")]
		Dataview,
		// Token: 0x040000CC RID: 204
		[global::System.Runtime.Serialization.EnumMember(Value = "webassemblymemory")]
		Webassemblymemory,
		// Token: 0x040000CD RID: 205
		[global::System.Runtime.Serialization.EnumMember(Value = "wasmvalue")]
		Wasmvalue
	}
}
