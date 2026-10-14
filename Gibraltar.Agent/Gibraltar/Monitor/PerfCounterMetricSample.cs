using System;
using System.Diagnostics;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x020001CA RID: 458
	internal sealed class PerfCounterMetricSample : global::Gibraltar.Monitor.SampledMetricSample, global::System.IComparable<global::Gibraltar.Monitor.PerfCounterMetricSample>, global::System.IEquatable<global::Gibraltar.Monitor.PerfCounterMetricSample>
	{
		// Token: 0x060015C2 RID: 5570 RVA: 0x00041694 File Offset: 0x0003F894
		internal PerfCounterMetricSample(global::Gibraltar.Monitor.PerfCounterMetric metric, global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket metricSamplePacket) : base(metric, metricSamplePacket, metric.Definition.RequiresMultipleSamples)
		{
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000416B8 File Offset: 0x0003F8B8
		public override double ComputeValue(global::Gibraltar.Monitor.SampledMetricSample baselineSample)
		{
			double num;
			if (base.RequiresMultipleSamples)
			{
				if (baselineSample == null)
				{
					throw new global::System.ArgumentNullException("baselineSample", "A baseline metric sample is required and none was provided.");
				}
				if (baselineSample.Timestamp > this.Timestamp)
				{
					throw new global::System.ArgumentOutOfRangeException("baselineSample", baselineSample.Timestamp, "The baseline sample must be for a date & time before this sample to be valid for comparison.");
				}
				num = (double)global::System.Diagnostics.CounterSampleCalculator.ComputeCounterValue((global::Gibraltar.Monitor.PerfCounterMetricSample)baselineSample, this.Packet.CounterSample);
			}
			else
			{
				num = (double)global::System.Diagnostics.CounterSampleCalculator.ComputeCounterValue(this.Packet.CounterSample);
			}
			if (this.Metric.Definition.IsPercentage)
			{
				num /= 100.0;
			}
			return num;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x00041778 File Offset: 0x0003F978
		public static implicit operator global::System.Diagnostics.CounterSample(global::Gibraltar.Monitor.PerfCounterMetricSample sample)
		{
			return sample.CounterSample;
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00041780 File Offset: 0x0003F980
		public global::System.Diagnostics.CounterSample ToCounterSample()
		{
			return this.CounterSample;
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060015C6 RID: 5574 RVA: 0x00041788 File Offset: 0x0003F988
		public global::System.Diagnostics.CounterSample CounterSample
		{
			get
			{
				return this.Packet;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x00041798 File Offset: 0x0003F998
		public new global::Gibraltar.Monitor.PerfCounterMetric Metric
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetric)base.Metric;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x000417A8 File Offset: 0x0003F9A8
		public override double Value
		{
			get
			{
				return (double)this.Packet.CounterSample.RawValue;
			}
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x000417D0 File Offset: 0x0003F9D0
		public int CompareTo(global::Gibraltar.Monitor.PerfCounterMetricSample other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x000417DC File Offset: 0x0003F9DC
		public bool Equals(global::Gibraltar.Monitor.PerfCounterMetricSample other)
		{
			return base.Equals(other);
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x000417E8 File Offset: 0x0003F9E8
		internal new global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket Packet
		{
			get
			{
				return (global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket)base.Packet;
			}
		}
	}
}
