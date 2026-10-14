using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000034 RID: 52
	public enum RemoteObjectType
	{
		// Token: 0x04000089 RID: 137
		[global::System.Runtime.Serialization.EnumMember(Value = "object")]
		Object,
		// Token: 0x0400008A RID: 138
		[global::System.Runtime.Serialization.EnumMember(Value = "function")]
		Function,
		// Token: 0x0400008B RID: 139
		[global::System.Runtime.Serialization.EnumMember(Value = "undefined")]
		Undefined,
		// Token: 0x0400008C RID: 140
		[global::System.Runtime.Serialization.EnumMember(Value = "string")]
		String,
		// Token: 0x0400008D RID: 141
		[global::System.Runtime.Serialization.EnumMember(Value = "number")]
		Number,
		// Token: 0x0400008E RID: 142
		[global::System.Runtime.Serialization.EnumMember(Value = "boolean")]
		Boolean,
		// Token: 0x0400008F RID: 143
		[global::System.Runtime.Serialization.EnumMember(Value = "symbol")]
		Symbol,
		// Token: 0x04000090 RID: 144
		[global::System.Runtime.Serialization.EnumMember(Value = "bigint")]
		Bigint
	}
}
