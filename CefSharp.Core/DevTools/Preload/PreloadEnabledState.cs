using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000A6 RID: 166
	public enum PreloadEnabledState
	{
		// Token: 0x0400029D RID: 669
		[global::System.Runtime.Serialization.EnumMember(Value = "Enabled")]
		Enabled,
		// Token: 0x0400029E RID: 670
		[global::System.Runtime.Serialization.EnumMember(Value = "DisabledByDataSaver")]
		DisabledByDataSaver,
		// Token: 0x0400029F RID: 671
		[global::System.Runtime.Serialization.EnumMember(Value = "DisabledByBatterySaver")]
		DisabledByBatterySaver,
		// Token: 0x040002A0 RID: 672
		[global::System.Runtime.Serialization.EnumMember(Value = "DisabledByPreference")]
		DisabledByPreference,
		// Token: 0x040002A1 RID: 673
		[global::System.Runtime.Serialization.EnumMember(Value = "NotSupported")]
		NotSupported
	}
}
