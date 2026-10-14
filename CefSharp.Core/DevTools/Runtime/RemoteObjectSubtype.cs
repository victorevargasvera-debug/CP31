using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000035 RID: 53
	public enum RemoteObjectSubtype
	{
		// Token: 0x04000092 RID: 146
		[global::System.Runtime.Serialization.EnumMember(Value = "array")]
		Array,
		// Token: 0x04000093 RID: 147
		[global::System.Runtime.Serialization.EnumMember(Value = "null")]
		Null,
		// Token: 0x04000094 RID: 148
		[global::System.Runtime.Serialization.EnumMember(Value = "node")]
		Node,
		// Token: 0x04000095 RID: 149
		[global::System.Runtime.Serialization.EnumMember(Value = "regexp")]
		Regexp,
		// Token: 0x04000096 RID: 150
		[global::System.Runtime.Serialization.EnumMember(Value = "date")]
		Date,
		// Token: 0x04000097 RID: 151
		[global::System.Runtime.Serialization.EnumMember(Value = "map")]
		Map,
		// Token: 0x04000098 RID: 152
		[global::System.Runtime.Serialization.EnumMember(Value = "set")]
		Set,
		// Token: 0x04000099 RID: 153
		[global::System.Runtime.Serialization.EnumMember(Value = "weakmap")]
		Weakmap,
		// Token: 0x0400009A RID: 154
		[global::System.Runtime.Serialization.EnumMember(Value = "weakset")]
		Weakset,
		// Token: 0x0400009B RID: 155
		[global::System.Runtime.Serialization.EnumMember(Value = "iterator")]
		Iterator,
		// Token: 0x0400009C RID: 156
		[global::System.Runtime.Serialization.EnumMember(Value = "generator")]
		Generator,
		// Token: 0x0400009D RID: 157
		[global::System.Runtime.Serialization.EnumMember(Value = "error")]
		Error,
		// Token: 0x0400009E RID: 158
		[global::System.Runtime.Serialization.EnumMember(Value = "proxy")]
		Proxy,
		// Token: 0x0400009F RID: 159
		[global::System.Runtime.Serialization.EnumMember(Value = "promise")]
		Promise,
		// Token: 0x040000A0 RID: 160
		[global::System.Runtime.Serialization.EnumMember(Value = "typedarray")]
		Typedarray,
		// Token: 0x040000A1 RID: 161
		[global::System.Runtime.Serialization.EnumMember(Value = "arraybuffer")]
		Arraybuffer,
		// Token: 0x040000A2 RID: 162
		[global::System.Runtime.Serialization.EnumMember(Value = "dataview")]
		Dataview,
		// Token: 0x040000A3 RID: 163
		[global::System.Runtime.Serialization.EnumMember(Value = "webassemblymemory")]
		Webassemblymemory,
		// Token: 0x040000A4 RID: 164
		[global::System.Runtime.Serialization.EnumMember(Value = "wasmvalue")]
		Wasmvalue
	}
}
