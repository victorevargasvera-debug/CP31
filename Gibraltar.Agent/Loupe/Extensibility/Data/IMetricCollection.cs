using System;
using System.Collections;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200006C RID: 108
	internal interface IMetricCollection : global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IMetric>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IMetric>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetric>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600054B RID: 1355
		bool ContainsKey(global::System.Guid key);

		// Token: 0x0600054C RID: 1356
		bool ContainsKey(string key);

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600054D RID: 1357
		global::Loupe.Extensibility.Data.IMetricDefinition Definition { get; }

		// Token: 0x0600054E RID: 1358
		bool TryGetValue(global::System.Guid key, out global::Loupe.Extensibility.Data.IMetric value);

		// Token: 0x0600054F RID: 1359
		bool TryGetValue(string key, out global::Loupe.Extensibility.Data.IMetric value);

		// Token: 0x17000235 RID: 565
		global::Loupe.Extensibility.Data.IMetric this[global::System.Guid Id]
		{
			get;
		}

		// Token: 0x17000236 RID: 566
		global::Loupe.Extensibility.Data.IMetric this[string key]
		{
			get;
		}
	}
}
