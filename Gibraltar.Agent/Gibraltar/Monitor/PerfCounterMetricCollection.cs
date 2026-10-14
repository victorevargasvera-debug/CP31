using System;
using System.Diagnostics;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001C9 RID: 457
	internal sealed class PerfCounterMetricCollection : global::Gibraltar.Monitor.MetricCollection
	{
		// Token: 0x060015B7 RID: 5559 RVA: 0x00041544 File Offset: 0x0003F744
		internal PerfCounterMetricCollection(global::Gibraltar.Monitor.PerfCounterMetricDefinition metricDefinition) : base(metricDefinition)
		{
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00041550 File Offset: 0x0003F750
		public global::Gibraltar.Monitor.PerfCounterMetric Add(global::System.Diagnostics.PerformanceCounter newPerfCounter)
		{
			if (newPerfCounter == null)
			{
				throw new global::System.ArgumentNullException("newPerfCounter", "A performance counter object must be provided to add it to the collection.");
			}
			string key = global::Gibraltar.Monitor.PerfCounterMetricDefinition.GetKey(newPerfCounter);
			if (base.Definition.Name != key)
			{
				throw new global::System.ArgumentOutOfRangeException("newPerfCounter");
			}
			return new global::Gibraltar.Monitor.PerfCounterMetric((global::Gibraltar.Monitor.PerfCounterMetricDefinition)base.Definition, newPerfCounter);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000415B0 File Offset: 0x0003F7B0
		public bool TryGetValue(global::System.Diagnostics.PerformanceCounter key, out global::Loupe.Extensibility.Data.IMetric value)
		{
			return base.TryGetValue(global::Gibraltar.Monitor.PerfCounterMetric.GetKey(key), out value);
		}

		// Token: 0x170007BB RID: 1979
		public global::Gibraltar.Monitor.PerfCounterMetric this[global::System.Diagnostics.PerformanceCounter counter]
		{
			get
			{
				global::Loupe.Extensibility.Data.IMetric metric;
				if (!this.TryGetValue(counter, out metric))
				{
					metric = this.Add(counter);
				}
				global::Gibraltar.Monitor.PerfCounterMetric perfCounterMetric = metric as global::Gibraltar.Monitor.PerfCounterMetric;
				if (perfCounterMetric == null)
				{
					throw new global::System.InvalidCastException("There is already a metric with the same name as the performance counter, but it is not a performance counter metric.");
				}
				return perfCounterMetric;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x00041604 File Offset: 0x0003F804
		public new global::Gibraltar.Monitor.PerfCounterMetricDefinition Definition
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetricDefinition)base.Definition;
			}
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00041614 File Offset: 0x0003F814
		public bool TryGetValue(global::System.Guid key, out global::Gibraltar.Monitor.PerfCounterMetric value)
		{
			global::Loupe.Extensibility.Data.IMetric metric;
			bool result = base.TryGetValue(key, out metric);
			value = (global::Gibraltar.Monitor.PerfCounterMetric)metric;
			return result;
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00041638 File Offset: 0x0003F838
		public bool TryGetValue(string key, out global::Gibraltar.Monitor.PerfCounterMetric value)
		{
			global::Loupe.Extensibility.Data.IMetric metric;
			bool result = base.TryGetValue(key, out metric);
			value = (global::Gibraltar.Monitor.PerfCounterMetric)metric;
			return result;
		}

		// Token: 0x170007BD RID: 1981
		public global::Gibraltar.Monitor.PerfCounterMetric this[int index]
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetric)base[index];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x170007BE RID: 1982
		public global::Gibraltar.Monitor.PerfCounterMetric this[global::System.Guid Id]
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetric)base[Id];
			}
		}

		// Token: 0x170007BF RID: 1983
		public global::Gibraltar.Monitor.PerfCounterMetric this[string key]
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetric)base[key];
			}
		}
	}
}
