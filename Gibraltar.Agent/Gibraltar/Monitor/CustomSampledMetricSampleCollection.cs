using System;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x020001B3 RID: 435
	internal sealed class CustomSampledMetricSampleCollection : global::Gibraltar.Monitor.MetricSampleCollection
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x00039E78 File Offset: 0x00038078
		internal CustomSampledMetricSampleCollection(global::Gibraltar.Monitor.CustomSampledMetric metric) : base(metric)
		{
			this.m_CustomSampledMetric = metric;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00039E88 File Offset: 0x00038088
		public void Add(global::Gibraltar.Monitor.CustomSampledMetricSample newMetricSample)
		{
			if (newMetricSample == null)
			{
				throw new global::System.ArgumentNullException("newMetricSample", "A new custom sampled metric sample object must be provided to add it to the collection.");
			}
			base.Add(newMetricSample);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00039EB0 File Offset: 0x000380B0
		internal global::Gibraltar.Monitor.CustomSampledMetricSample Add(global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket newMetricSamplePacket)
		{
			if (newMetricSamplePacket == null)
			{
				throw new global::System.ArgumentNullException("newMetricSamplePacket", "A new custom sampled metric sample packet object must be provided to add it to the collection.");
			}
			global::Gibraltar.Monitor.CustomSampledMetricSample customSampledMetricSample = new global::Gibraltar.Monitor.CustomSampledMetricSample(this.m_CustomSampledMetric, newMetricSamplePacket);
			this.Add(customSampledMetricSample);
			return customSampledMetricSample;
		}

		// Token: 0x1700070D RID: 1805
		public global::Gibraltar.Monitor.CustomSampledMetricSample this[int index]
		{
			get
			{
				return (global::Gibraltar.Monitor.CustomSampledMetricSample)base[index];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00039F04 File Offset: 0x00038104
		public new global::Gibraltar.Monitor.CustomSampledMetric Metric
		{
			get
			{
				return this.m_CustomSampledMetric;
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x00039F0C File Offset: 0x0003810C
		public new global::Gibraltar.Monitor.CustomSampledMetricSample First
		{
			get
			{
				return (global::Gibraltar.Monitor.CustomSampledMetricSample)base.First;
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00039F1C File Offset: 0x0003811C
		public new global::Gibraltar.Monitor.CustomSampledMetricSample Last
		{
			get
			{
				return (global::Gibraltar.Monitor.CustomSampledMetricSample)base.Last;
			}
		}

		// Token: 0x04000684 RID: 1668
		private readonly global::Gibraltar.Monitor.CustomSampledMetric m_CustomSampledMetric;
	}
}
