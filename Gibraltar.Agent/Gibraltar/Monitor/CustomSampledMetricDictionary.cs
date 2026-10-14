using System;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001B0 RID: 432
	internal sealed class CustomSampledMetricDictionary : global::Gibraltar.Monitor.SampledMetricCollection
	{
		// Token: 0x0600137A RID: 4986 RVA: 0x00039320 File Offset: 0x00037520
		internal CustomSampledMetricDictionary(global::Gibraltar.Monitor.CustomSampledMetricDefinition metricDefinition) : base(metricDefinition)
		{
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x0003932C File Offset: 0x0003752C
		public global::Gibraltar.Monitor.CustomSampledMetric Add(string instanceName)
		{
			return new global::Gibraltar.Monitor.CustomSampledMetric(this.Definition, instanceName);
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x0003933C File Offset: 0x0003753C
		public new global::Gibraltar.Monitor.CustomSampledMetricDefinition Definition
		{
			get
			{
				return (global::Gibraltar.Monitor.CustomSampledMetricDefinition)base.Definition;
			}
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0003934C File Offset: 0x0003754C
		public bool TryGetValue(global::System.Guid key, out global::Gibraltar.Monitor.CustomSampledMetric value)
		{
			global::Loupe.Extensibility.Data.IMetric metric;
			bool result = base.TryGetValue(key, out metric);
			value = (global::Gibraltar.Monitor.CustomSampledMetric)metric;
			return result;
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x00039370 File Offset: 0x00037570
		public bool TryGetValue(string key, out global::Gibraltar.Monitor.CustomSampledMetric value)
		{
			global::Loupe.Extensibility.Data.IMetric metric;
			bool result = base.TryGetValue(key, out metric);
			value = (global::Gibraltar.Monitor.CustomSampledMetric)metric;
			return result;
		}

		// Token: 0x17000703 RID: 1795
		public global::Gibraltar.Monitor.CustomSampledMetric this[int index]
		{
			get
			{
				return (global::Gibraltar.Monitor.CustomSampledMetric)base[index];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000704 RID: 1796
		public global::Gibraltar.Monitor.CustomSampledMetric this[global::System.Guid Id]
		{
			get
			{
				return (global::Gibraltar.Monitor.CustomSampledMetric)base[Id];
			}
		}

		// Token: 0x17000705 RID: 1797
		public global::Gibraltar.Monitor.CustomSampledMetric this[string key]
		{
			get
			{
				return (global::Gibraltar.Monitor.CustomSampledMetric)base[key];
			}
		}
	}
}
