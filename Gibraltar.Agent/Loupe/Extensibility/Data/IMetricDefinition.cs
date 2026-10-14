using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200006D RID: 109
	internal interface IMetricDefinition : global::System.IComparable<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricDefinition>
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000552 RID: 1362
		global::System.Guid Id { get; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000553 RID: 1363
		string Name { get; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000554 RID: 1364
		string Caption { get; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000555 RID: 1365
		string Description { get; }

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000556 RID: 1366
		global::Loupe.Extensibility.Data.MetricSampleInterval Interval { get; }

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000557 RID: 1367
		string MetricTypeName { get; }

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000558 RID: 1368
		global::Loupe.Extensibility.Data.IMetricDefinitionCollection Definitions { get; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000559 RID: 1369
		global::Loupe.Extensibility.Data.IMetricCollection Metrics { get; }

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600055A RID: 1370
		string CategoryName { get; }

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600055B RID: 1371
		string[] CategoryNames { get; }

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600055C RID: 1372
		string CounterName { get; }

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600055D RID: 1373
		global::Loupe.Extensibility.Data.SampleType SampleType { get; }
	}
}
