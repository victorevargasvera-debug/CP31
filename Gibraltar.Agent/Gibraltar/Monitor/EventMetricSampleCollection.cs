using System;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x020001B8 RID: 440
	internal class EventMetricSampleCollection : global::Gibraltar.Monitor.MetricSampleCollection
	{
		// Token: 0x060013FC RID: 5116 RVA: 0x0003B0B4 File Offset: 0x000392B4
		public EventMetricSampleCollection(global::Gibraltar.Monitor.EventMetric metric) : base(metric)
		{
			this.m_EventMetric = metric;
		}

		// Token: 0x060013FD RID: 5117 RVA: 0x0003B0C4 File Offset: 0x000392C4
		public void Add(global::Gibraltar.Monitor.EventMetricSample newMetricSample)
		{
			if (newMetricSample == null)
			{
				throw new global::System.ArgumentNullException("newMetricSample", "A new custom sampled metric sample object must be provided to add it to the collection.");
			}
			base.Add(newMetricSample);
		}

		// Token: 0x060013FE RID: 5118 RVA: 0x0003B0EC File Offset: 0x000392EC
		internal global::Gibraltar.Monitor.EventMetricSample Add(global::Gibraltar.Monitor.Internal.EventMetricSamplePacket newMetricSamplePacket)
		{
			if (newMetricSamplePacket == null)
			{
				throw new global::System.ArgumentNullException("newMetricSamplePacket", "A new custom sampled metric sample packet object must be provided to add it to the collection.");
			}
			global::Gibraltar.Monitor.EventMetricSample eventMetricSample = new global::Gibraltar.Monitor.EventMetricSample(this.m_EventMetric, newMetricSamplePacket);
			this.Add(eventMetricSample);
			return eventMetricSample;
		}

		// Token: 0x1700072D RID: 1837
		public global::Gibraltar.Monitor.EventMetricSample this[int index]
		{
			get
			{
				return (global::Gibraltar.Monitor.EventMetricSample)base[index];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x0003B140 File Offset: 0x00039340
		public new global::Gibraltar.Monitor.EventMetric Metric
		{
			get
			{
				return (global::Gibraltar.Monitor.EventMetric)base.Metric;
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x0003B150 File Offset: 0x00039350
		public new global::Gibraltar.Monitor.EventMetricSample First
		{
			get
			{
				return (global::Gibraltar.Monitor.EventMetricSample)base.First;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x0003B160 File Offset: 0x00039360
		public new global::Gibraltar.Monitor.EventMetricSample Last
		{
			get
			{
				return (global::Gibraltar.Monitor.EventMetricSample)base.Last;
			}
		}

		// Token: 0x0400069A RID: 1690
		private readonly global::Gibraltar.Monitor.EventMetric m_EventMetric;
	}
}
