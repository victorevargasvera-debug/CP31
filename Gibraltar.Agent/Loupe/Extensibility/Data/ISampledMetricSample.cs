using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000076 RID: 118
	internal interface ISampledMetricSample : global::Loupe.Extensibility.Data.IMetricSample, global::System.IComparable<global::Loupe.Extensibility.Data.IMetricSample>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricSample>
	{
		// Token: 0x06000596 RID: 1430
		double ComputeValue();

		// Token: 0x06000597 RID: 1431
		double ComputeValue(global::Loupe.Extensibility.Data.ISampledMetricSample baselineSample);

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000598 RID: 1432
		bool RequiresMultipleSamples { get; }
	}
}
