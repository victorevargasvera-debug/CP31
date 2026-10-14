using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200006F RID: 111
	internal interface IMetricSample : global::System.IComparable<global::Loupe.Extensibility.Data.IMetricSample>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricSample>
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000567 RID: 1383
		global::System.Guid Id { get; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000568 RID: 1384
		global::Loupe.Extensibility.Data.IMetric Metric { get; }

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000569 RID: 1385
		long Sequence { get; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600056A RID: 1386
		global::System.DateTimeOffset Timestamp { get; }

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600056B RID: 1387
		double Value { get; }
	}
}
