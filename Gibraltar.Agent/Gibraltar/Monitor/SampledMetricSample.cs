using System;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001D0 RID: 464
	internal abstract class SampledMetricSample : global::Gibraltar.Monitor.MetricSample, global::Loupe.Extensibility.Data.ISampledMetricSample, global::Loupe.Extensibility.Data.IMetricSample, global::System.IComparable<global::Loupe.Extensibility.Data.IMetricSample>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricSample>
	{
		// Token: 0x060015FE RID: 5630 RVA: 0x0004263C File Offset: 0x0004083C
		internal SampledMetricSample(global::Gibraltar.Monitor.SampledMetric metric, global::Gibraltar.Monitor.Internal.SampledMetricSamplePacket metricSamplePacket, bool requiresMultipleSamples) : base(metric, metricSamplePacket)
		{
			this.m_RequiresMultipleSamples = requiresMultipleSamples;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00042650 File Offset: 0x00040850
		public double ComputeValue()
		{
			return this.ComputeValue(null);
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0004265C File Offset: 0x0004085C
		public double ComputeValue(global::Loupe.Extensibility.Data.ISampledMetricSample baselineSample)
		{
			return this.ComputeValue((global::Gibraltar.Monitor.SampledMetricSample)baselineSample);
		}

		// Token: 0x06001601 RID: 5633
		public abstract double ComputeValue(global::Gibraltar.Monitor.SampledMetricSample baselineSample);

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x0004266C File Offset: 0x0004086C
		public bool RequiresMultipleSamples
		{
			get
			{
				return this.m_RequiresMultipleSamples;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x00042674 File Offset: 0x00040874
		public new global::Gibraltar.Monitor.SampledMetric Metric
		{
			get
			{
				return (global::Gibraltar.Monitor.SampledMetric)base.Metric;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x00042684 File Offset: 0x00040884
		public override double Value
		{
			get
			{
				return ((global::Gibraltar.Monitor.Internal.SampledMetricSamplePacket)this.Packet).RawValue;
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00042698 File Offset: 0x00040898
		public int CompareTo(global::Gibraltar.Monitor.SampledMetricSample other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x04000714 RID: 1812
		private readonly bool m_RequiresMultipleSamples;
	}
}
