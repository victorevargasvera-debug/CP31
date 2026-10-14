using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000049 RID: 73
	public enum ConsoleAPICalledType
	{
		// Token: 0x0400012A RID: 298
		[global::System.Runtime.Serialization.EnumMember(Value = "log")]
		Log,
		// Token: 0x0400012B RID: 299
		[global::System.Runtime.Serialization.EnumMember(Value = "debug")]
		Debug,
		// Token: 0x0400012C RID: 300
		[global::System.Runtime.Serialization.EnumMember(Value = "info")]
		Info,
		// Token: 0x0400012D RID: 301
		[global::System.Runtime.Serialization.EnumMember(Value = "error")]
		Error,
		// Token: 0x0400012E RID: 302
		[global::System.Runtime.Serialization.EnumMember(Value = "warning")]
		Warning,
		// Token: 0x0400012F RID: 303
		[global::System.Runtime.Serialization.EnumMember(Value = "dir")]
		Dir,
		// Token: 0x04000130 RID: 304
		[global::System.Runtime.Serialization.EnumMember(Value = "dirxml")]
		Dirxml,
		// Token: 0x04000131 RID: 305
		[global::System.Runtime.Serialization.EnumMember(Value = "table")]
		Table,
		// Token: 0x04000132 RID: 306
		[global::System.Runtime.Serialization.EnumMember(Value = "trace")]
		Trace,
		// Token: 0x04000133 RID: 307
		[global::System.Runtime.Serialization.EnumMember(Value = "clear")]
		Clear,
		// Token: 0x04000134 RID: 308
		[global::System.Runtime.Serialization.EnumMember(Value = "startGroup")]
		StartGroup,
		// Token: 0x04000135 RID: 309
		[global::System.Runtime.Serialization.EnumMember(Value = "startGroupCollapsed")]
		StartGroupCollapsed,
		// Token: 0x04000136 RID: 310
		[global::System.Runtime.Serialization.EnumMember(Value = "endGroup")]
		EndGroup,
		// Token: 0x04000137 RID: 311
		[global::System.Runtime.Serialization.EnumMember(Value = "assert")]
		Assert,
		// Token: 0x04000138 RID: 312
		[global::System.Runtime.Serialization.EnumMember(Value = "profile")]
		Profile,
		// Token: 0x04000139 RID: 313
		[global::System.Runtime.Serialization.EnumMember(Value = "profileEnd")]
		ProfileEnd,
		// Token: 0x0400013A RID: 314
		[global::System.Runtime.Serialization.EnumMember(Value = "count")]
		Count,
		// Token: 0x0400013B RID: 315
		[global::System.Runtime.Serialization.EnumMember(Value = "timeEnd")]
		TimeEnd
	}
}
