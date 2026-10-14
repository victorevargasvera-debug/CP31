using System;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent.Metrics.Internal
{
	// Token: 0x0200002F RID: 47
	internal interface IMetricDefinition : global::System.IComparable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>, global::System.IEquatable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002B4 RID: 692
		global::System.Guid Id { get; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002B5 RID: 693
		string Key { get; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002B6 RID: 694
		string Caption { get; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002B7 RID: 695
		string Description { get; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002B8 RID: 696
		global::Gibraltar.Agent.Metrics.SamplingInterval Interval { get; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002B9 RID: 697
		string MetricsSystem { get; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002BA RID: 698
		string CategoryName { get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002BB RID: 699
		string CounterName { get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002BC RID: 700
		global::Loupe.Extensibility.Data.SampleType SampleType { get; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002BD RID: 701
		bool IsReadOnly { get; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002BE RID: 702
		global::Gibraltar.Monitor.MetricDefinition WrappedDefinition { get; }
	}
}
