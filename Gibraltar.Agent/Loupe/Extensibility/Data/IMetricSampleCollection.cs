using System;
using System.Collections;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000070 RID: 112
	internal interface IMetricSampleCollection : global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IMetricSample>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IMetricSample>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricSample>, global::System.Collections.IEnumerable
	{
		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600056C RID: 1388
		global::Loupe.Extensibility.Data.IMetric Metric { get; }

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600056D RID: 1389
		global::Loupe.Extensibility.Data.IMetricSample First { get; }

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600056E RID: 1390
		global::Loupe.Extensibility.Data.IMetricSample Last { get; }
	}
}
