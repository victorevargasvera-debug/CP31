using System;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x0200001C RID: 28
	public interface IPerformanceMeasurer
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000FA RID: 250
		global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo OperationInfo { get; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000FB RID: 251
		global::System.TimeSpan? OperationDuration { get; }

		// Token: 0x060000FC RID: 252
		global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer StartSubMeasurer(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operation);

		// Token: 0x060000FD RID: 253
		global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer StartSubMeasurer(string operationName);

		// Token: 0x060000FE RID: 254
		global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer StartAutomaticSubMeasurer(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operation);

		// Token: 0x060000FF RID: 255
		global::Motorola.Common.LogUtility.PerformanceMeasurement.IAutomaticPerformanceMeasurer StartAutomaticSubMeasurer(string operationName);

		// Token: 0x06000100 RID: 256
		void Pause();

		// Token: 0x06000101 RID: 257
		void Resume();

		// Token: 0x06000102 RID: 258
		void Stop();
	}
}
