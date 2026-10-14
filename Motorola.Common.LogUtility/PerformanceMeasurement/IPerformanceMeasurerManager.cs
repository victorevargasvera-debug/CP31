using System;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x0200001D RID: 29
	internal interface IPerformanceMeasurerManager
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000103 RID: 259
		int Count { get; }

		// Token: 0x06000104 RID: 260
		global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer Get(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo);

		// Token: 0x06000105 RID: 261
		void Add(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo, global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer measurer);

		// Token: 0x06000106 RID: 262
		void Remove(global::Motorola.Common.LogUtility.PerformanceMeasurement.OperationInfo operationInfo);

		// Token: 0x06000107 RID: 263
		void Clear();
	}
}
