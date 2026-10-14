using System;
using System.Collections.Generic;

namespace Motorola.Common.LogUtility.PerformanceMeasurement
{
	// Token: 0x0200001F RID: 31
	internal interface IPerformanceWatch
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000109 RID: 265
		string Duration { get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600010A RID: 266
		global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails OverallState { get; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010B RID: 267
		global::Motorola.Common.LogUtility.PerformanceMeasurement.SystemState SystemState { get; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600010C RID: 268
		global::System.Collections.Generic.List<global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceDetails> Steps { get; }

		// Token: 0x0600010D RID: 269
		void Init();

		// Token: 0x0600010E RID: 270
		void Start();

		// Token: 0x0600010F RID: 271
		bool Stop();
	}
}
