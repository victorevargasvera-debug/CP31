using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Log
{
	// Token: 0x0200024C RID: 588
	public enum LogEntrySource
	{
		// Token: 0x040009C6 RID: 2502
		[global::System.Runtime.Serialization.EnumMember(Value = "xml")]
		Xml,
		// Token: 0x040009C7 RID: 2503
		[global::System.Runtime.Serialization.EnumMember(Value = "javascript")]
		Javascript,
		// Token: 0x040009C8 RID: 2504
		[global::System.Runtime.Serialization.EnumMember(Value = "network")]
		Network,
		// Token: 0x040009C9 RID: 2505
		[global::System.Runtime.Serialization.EnumMember(Value = "storage")]
		Storage,
		// Token: 0x040009CA RID: 2506
		[global::System.Runtime.Serialization.EnumMember(Value = "appcache")]
		Appcache,
		// Token: 0x040009CB RID: 2507
		[global::System.Runtime.Serialization.EnumMember(Value = "rendering")]
		Rendering,
		// Token: 0x040009CC RID: 2508
		[global::System.Runtime.Serialization.EnumMember(Value = "security")]
		Security,
		// Token: 0x040009CD RID: 2509
		[global::System.Runtime.Serialization.EnumMember(Value = "deprecation")]
		Deprecation,
		// Token: 0x040009CE RID: 2510
		[global::System.Runtime.Serialization.EnumMember(Value = "worker")]
		Worker,
		// Token: 0x040009CF RID: 2511
		[global::System.Runtime.Serialization.EnumMember(Value = "violation")]
		Violation,
		// Token: 0x040009D0 RID: 2512
		[global::System.Runtime.Serialization.EnumMember(Value = "intervention")]
		Intervention,
		// Token: 0x040009D1 RID: 2513
		[global::System.Runtime.Serialization.EnumMember(Value = "recommendation")]
		Recommendation,
		// Token: 0x040009D2 RID: 2514
		[global::System.Runtime.Serialization.EnumMember(Value = "other")]
		Other
	}
}
