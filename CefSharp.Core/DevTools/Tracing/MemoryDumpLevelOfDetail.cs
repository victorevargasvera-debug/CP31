using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Tracing
{
	// Token: 0x020000F3 RID: 243
	public enum MemoryDumpLevelOfDetail
	{
		// Token: 0x04000390 RID: 912
		[global::System.Runtime.Serialization.EnumMember(Value = "background")]
		Background,
		// Token: 0x04000391 RID: 913
		[global::System.Runtime.Serialization.EnumMember(Value = "light")]
		Light,
		// Token: 0x04000392 RID: 914
		[global::System.Runtime.Serialization.EnumMember(Value = "detailed")]
		Detailed
	}
}
