using System;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x0200001E RID: 30
	internal interface IPerformanceMonitor
	{
		// Token: 0x06000108 RID: 264
		global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceSnapshot GetSnapshot(bool setCurrProcess);
	}
}
