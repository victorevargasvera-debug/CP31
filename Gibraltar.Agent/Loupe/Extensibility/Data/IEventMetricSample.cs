using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000065 RID: 101
	internal interface IEventMetricSample : global::Loupe.Extensibility.Data.IMetricSample, global::System.IComparable<global::Loupe.Extensibility.Data.IMetricSample>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricSample>
	{
		// Token: 0x06000504 RID: 1284
		double ComputeValue(global::Loupe.Extensibility.Data.IEventMetricSample baselineSample, global::Loupe.Extensibility.Data.IEventMetricValueDefinition trendValue);

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000505 RID: 1285
		object[] Values { get; }
	}
}
