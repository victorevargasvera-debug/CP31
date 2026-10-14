using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000081 RID: 129
	public enum DebugSymbolsType
	{
		// Token: 0x040001CD RID: 461
		[global::System.Runtime.Serialization.EnumMember(Value = "None")]
		None,
		// Token: 0x040001CE RID: 462
		[global::System.Runtime.Serialization.EnumMember(Value = "SourceMap")]
		SourceMap,
		// Token: 0x040001CF RID: 463
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbeddedDWARF")]
		EmbeddedDWARF,
		// Token: 0x040001D0 RID: 464
		[global::System.Runtime.Serialization.EnumMember(Value = "ExternalDWARF")]
		ExternalDWARF
	}
}
