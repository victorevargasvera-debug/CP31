using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x02000274 RID: 628
	public enum KeyType
	{
		// Token: 0x04000A62 RID: 2658
		[global::System.Runtime.Serialization.EnumMember(Value = "number")]
		Number,
		// Token: 0x04000A63 RID: 2659
		[global::System.Runtime.Serialization.EnumMember(Value = "string")]
		String,
		// Token: 0x04000A64 RID: 2660
		[global::System.Runtime.Serialization.EnumMember(Value = "date")]
		Date,
		// Token: 0x04000A65 RID: 2661
		[global::System.Runtime.Serialization.EnumMember(Value = "array")]
		Array
	}
}
