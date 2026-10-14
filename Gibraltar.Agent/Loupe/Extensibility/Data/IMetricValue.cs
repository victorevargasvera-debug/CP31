using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000071 RID: 113
	internal interface IMetricValue : global::System.IComparable<global::Loupe.Extensibility.Data.IMetricValue>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricValue>
	{
		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600056F RID: 1391
		global::Loupe.Extensibility.Data.IMetricValueCollection ValueCollection { get; }

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000570 RID: 1392
		global::System.DateTimeOffset Timestamp { get; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000571 RID: 1393
		global::System.DateTime LocalTimestamp { get; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000572 RID: 1394
		double Value { get; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000573 RID: 1395
		double PercentageValue { get; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000574 RID: 1396
		long Sequence { get; }
	}
}
