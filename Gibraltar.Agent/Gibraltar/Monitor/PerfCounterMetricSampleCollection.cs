using System;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x020001CB RID: 459
	internal sealed class PerfCounterMetricSampleCollection : global::Gibraltar.Monitor.MetricSampleCollection
	{
		// Token: 0x060015CC RID: 5580 RVA: 0x000417F8 File Offset: 0x0003F9F8
		internal PerfCounterMetricSampleCollection(global::Gibraltar.Monitor.PerfCounterMetric metric) : base(metric)
		{
			this.m_PerfCounterMetric = metric;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00041808 File Offset: 0x0003FA08
		public void Add(global::Gibraltar.Monitor.PerfCounterMetricSample newPerfCounterMetricSample)
		{
			if (newPerfCounterMetricSample == null)
			{
				throw new global::System.ArgumentNullException("newPerfCounterMetricSample", "A new performance counter metric sample object must be provided to add it to the collection.");
			}
			base.Add(newPerfCounterMetricSample);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00041830 File Offset: 0x0003FA30
		internal global::Gibraltar.Monitor.PerfCounterMetricSample Add(global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket newMetricSamplePacket)
		{
			if (newMetricSamplePacket == null)
			{
				throw new global::System.ArgumentNullException("newMetricSamplePacket", "A new performance counter metric sample packet object must be provided to add it to the collection.");
			}
			global::Gibraltar.Monitor.PerfCounterMetricSample perfCounterMetricSample = new global::Gibraltar.Monitor.PerfCounterMetricSample(this.m_PerfCounterMetric, newMetricSamplePacket);
			this.Add(perfCounterMetricSample);
			return perfCounterMetricSample;
		}

		// Token: 0x170007C4 RID: 1988
		public global::Gibraltar.Monitor.PerfCounterMetricSample this[int index]
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetricSample)base[index];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00041884 File Offset: 0x0003FA84
		public new global::Gibraltar.Monitor.PerfCounterMetric Metric
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetric)base.Metric;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060015D2 RID: 5586 RVA: 0x00041894 File Offset: 0x0003FA94
		public new global::Gibraltar.Monitor.PerfCounterMetricSample First
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetricSample)base.First;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x000418A4 File Offset: 0x0003FAA4
		public new global::Gibraltar.Monitor.PerfCounterMetricSample Last
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetricSample)base.Last;
			}
		}

		// Token: 0x0400070B RID: 1803
		private readonly global::Gibraltar.Monitor.PerfCounterMetric m_PerfCounterMetric;
	}
}
