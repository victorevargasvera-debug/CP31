using System;
using System.Collections;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200006E RID: 110
	internal interface IMetricDefinitionCollection : global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600055E RID: 1374
		global::Loupe.Extensibility.Data.IMetric Metric(global::System.Guid metricId);

		// Token: 0x0600055F RID: 1375
		bool ContainsKey(global::System.Guid key);

		// Token: 0x06000560 RID: 1376
		bool ContainsKey(string name);

		// Token: 0x06000561 RID: 1377
		bool ContainsKey(string metricTypeName, string categoryName, string counterName);

		// Token: 0x06000562 RID: 1378
		bool ContainsMetricKey(global::System.Guid key);

		// Token: 0x06000563 RID: 1379
		bool TryGetValue(global::System.Guid key, out global::Loupe.Extensibility.Data.IMetricDefinition value);

		// Token: 0x06000564 RID: 1380
		bool TryGetValue(string name, out global::Loupe.Extensibility.Data.IMetricDefinition value);

		// Token: 0x06000565 RID: 1381
		bool TryGetValue(string metricTypeName, string categoryName, string counterName, out global::Loupe.Extensibility.Data.IMetricDefinition value);

		// Token: 0x06000566 RID: 1382
		bool TryGetMetricValue(global::System.Guid key, out global::Loupe.Extensibility.Data.IMetric value);
	}
}
