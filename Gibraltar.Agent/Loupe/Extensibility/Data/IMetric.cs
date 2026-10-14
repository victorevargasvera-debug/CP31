using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200006B RID: 107
	internal interface IMetric
	{
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600053A RID: 1338
		global::System.Guid Id { get; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600053B RID: 1339
		string Name { get; }

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600053C RID: 1340
		string Caption { get; }

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600053D RID: 1341
		string Description { get; }

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600053E RID: 1342
		global::Loupe.Extensibility.Data.IMetricDefinition Definition { get; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600053F RID: 1343
		string MetricTypeName { get; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000540 RID: 1344
		string CategoryName { get; }

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000541 RID: 1345
		string CounterName { get; }

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000542 RID: 1346
		string InstanceName { get; }

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000543 RID: 1347
		bool IsDefault { get; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000544 RID: 1348
		global::System.DateTimeOffset StartDateTime { get; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000545 RID: 1349
		global::System.DateTimeOffset EndDateTime { get; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000546 RID: 1350
		global::Loupe.Extensibility.Data.SampleType SampleType { get; }

		// Token: 0x06000547 RID: 1351
		global::Loupe.Extensibility.Data.IMetricValueCollection CalculateValues();

		// Token: 0x06000548 RID: 1352
		global::Loupe.Extensibility.Data.IMetricValueCollection CalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals);

		// Token: 0x06000549 RID: 1353
		global::Loupe.Extensibility.Data.IMetricValueCollection CalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset? startDateTime, global::System.DateTimeOffset? endDateTime);

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600054A RID: 1354
		global::Loupe.Extensibility.Data.IMetricSampleCollection Samples { get; }
	}
}
