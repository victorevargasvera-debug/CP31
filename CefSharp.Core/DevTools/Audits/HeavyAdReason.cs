using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000355 RID: 853
	public enum HeavyAdReason
	{
		// Token: 0x04000D7F RID: 3455
		[global::System.Runtime.Serialization.EnumMember(Value = "NetworkTotalLimit")]
		NetworkTotalLimit,
		// Token: 0x04000D80 RID: 3456
		[global::System.Runtime.Serialization.EnumMember(Value = "CpuTotalLimit")]
		CpuTotalLimit,
		// Token: 0x04000D81 RID: 3457
		[global::System.Runtime.Serialization.EnumMember(Value = "CpuPeakLimit")]
		CpuPeakLimit
	}
}
