using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000167 RID: 359
	public enum GatedAPIFeatures
	{
		// Token: 0x0400050D RID: 1293
		[global::System.Runtime.Serialization.EnumMember(Value = "SharedArrayBuffers")]
		SharedArrayBuffers,
		// Token: 0x0400050E RID: 1294
		[global::System.Runtime.Serialization.EnumMember(Value = "SharedArrayBuffersTransferAllowed")]
		SharedArrayBuffersTransferAllowed,
		// Token: 0x0400050F RID: 1295
		[global::System.Runtime.Serialization.EnumMember(Value = "PerformanceMeasureMemory")]
		PerformanceMeasureMemory,
		// Token: 0x04000510 RID: 1296
		[global::System.Runtime.Serialization.EnumMember(Value = "PerformanceProfile")]
		PerformanceProfile
	}
}
