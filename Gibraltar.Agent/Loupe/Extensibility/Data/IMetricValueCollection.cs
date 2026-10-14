using System;
using System.Collections;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000072 RID: 114
	internal interface IMetricValueCollection : global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IMetricValue>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IMetricValue>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricValue>, global::System.Collections.IEnumerable
	{
		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000575 RID: 1397
		string Caption { get; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000576 RID: 1398
		string Description { get; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000577 RID: 1399
		global::Loupe.Extensibility.Data.MetricSampleInterval Interval { get; }

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000578 RID: 1400
		int Intervals { get; }

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000579 RID: 1401
		global::System.DateTimeOffset StartDateTime { get; }

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600057A RID: 1402
		global::System.DateTimeOffset EndDateTime { get; }

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600057B RID: 1403
		double MinValue { get; }

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600057C RID: 1404
		global::Loupe.Extensibility.Data.IMetricValue MinValueMetricValue { get; }

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600057D RID: 1405
		double MaxValue { get; }

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600057E RID: 1406
		global::Loupe.Extensibility.Data.IMetricValue MaxValueMetricValue { get; }

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600057F RID: 1407
		double AverageValue { get; }

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000580 RID: 1408
		double PercentileValue { get; }

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000581 RID: 1409
		string UnitCaption { get; }
	}
}
