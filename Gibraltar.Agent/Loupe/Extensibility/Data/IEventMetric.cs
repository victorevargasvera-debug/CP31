using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000063 RID: 99
	internal interface IEventMetric : global::Loupe.Extensibility.Data.IMetric
	{
		// Token: 0x06000501 RID: 1281
		global::Loupe.Extensibility.Data.IMetricValueCollection CalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset? startDateTime, global::System.DateTimeOffset? endDateTime, global::Loupe.Extensibility.Data.IEventMetricValueDefinition trendValue);
	}
}
