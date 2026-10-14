using System;
using System.Diagnostics;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001C5 RID: 453
	internal sealed class PerfCounterMetric : global::Gibraltar.Monitor.SampledMetric, global::System.IComparable<global::Gibraltar.Monitor.PerfCounterMetric>, global::System.IEquatable<global::Gibraltar.Monitor.PerfCounterMetric>
	{
		// Token: 0x0600158F RID: 5519 RVA: 0x00040E28 File Offset: 0x0003F028
		public PerfCounterMetric(global::Gibraltar.Monitor.PerfCounterMetricDefinition definition, global::System.Diagnostics.PerformanceCounter counter) : base(definition, new global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket(definition.Packet, counter))
		{
			this.m_InstanceAlias = global::Gibraltar.Monitor.PerfCounterInstanceAlias.None;
			this.m_PollingState = global::Gibraltar.Monitor.PerfCounterPollingState.Inactive;
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x00040E4C File Offset: 0x0003F04C
		public PerfCounterMetric(global::Gibraltar.Monitor.PerfCounterMetricDefinition definition, global::System.Diagnostics.PerformanceCounter counter, global::Gibraltar.Monitor.PerfCounterInstanceAlias alias) : base(definition, new global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket(definition.Packet, counter))
		{
			this.m_InstanceAlias = alias;
			this.m_PollingState = global::Gibraltar.Monitor.PerfCounterPollingState.Inactive;
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x00040E70 File Offset: 0x0003F070
		internal PerfCounterMetric(global::Gibraltar.Monitor.PerfCounterMetricDefinition definition, global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket packet) : base(definition, packet)
		{
			this.m_InstanceAlias = global::Gibraltar.Monitor.PerfCounterInstanceAlias.None;
			this.m_PollingState = global::Gibraltar.Monitor.PerfCounterPollingState.Inactive;
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x00040E88 File Offset: 0x0003F088
		public static global::Gibraltar.Monitor.PerfCounterMetric AddOrGet(string categoryName, string counterName)
		{
			return global::Gibraltar.Monitor.PerfCounterMetric.AddOrGet(categoryName, counterName, string.Empty);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x00040E98 File Offset: 0x0003F098
		public static global::Gibraltar.Monitor.PerfCounterMetric AddOrGet(string categoryName, string counterName, global::Gibraltar.Monitor.PerfCounterInstanceAlias alias)
		{
			if (string.IsNullOrEmpty(categoryName))
			{
				throw new global::System.ArgumentNullException("categoryName", "No category name was provided and one is required.");
			}
			if (string.IsNullOrEmpty(counterName))
			{
				throw new global::System.ArgumentNullException("counterName", "No counter name was provided and one is required.");
			}
			string instanceName = global::Gibraltar.Monitor.PerfCounterMetric.GetInstanceName(alias);
			return global::Gibraltar.Monitor.PerfCounterMetric.AddOrGet(global::Gibraltar.Monitor.PerfCounterMetric.GetPerformanceCounter(categoryName, counterName, instanceName), alias);
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00040EF4 File Offset: 0x0003F0F4
		public static global::Gibraltar.Monitor.PerfCounterMetric AddOrGet(string categoryName, string counterName, string instanceName)
		{
			if (string.IsNullOrEmpty(categoryName))
			{
				throw new global::System.ArgumentNullException("categoryName", "No category name was provided and one is required.");
			}
			if (string.IsNullOrEmpty(counterName))
			{
				throw new global::System.ArgumentNullException("counterName", "No counter name was provided and one is required.");
			}
			return global::Gibraltar.Monitor.PerfCounterMetric.AddOrGet(global::Gibraltar.Monitor.PerfCounterMetric.GetPerformanceCounter(categoryName, counterName, instanceName));
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x00040F48 File Offset: 0x0003F148
		public static global::Gibraltar.Monitor.PerfCounterMetric AddOrGet(global::System.Diagnostics.PerformanceCounter newPerformanceCounter)
		{
			return global::Gibraltar.Monitor.PerfCounterMetric.AddOrGet(newPerformanceCounter, global::Gibraltar.Monitor.PerfCounterInstanceAlias.None);
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00040F54 File Offset: 0x0003F154
		public static global::Gibraltar.Monitor.PerfCounterMetric AddOrGet(global::System.Diagnostics.PerformanceCounter newPerformanceCounter, global::Gibraltar.Monitor.PerfCounterInstanceAlias alias)
		{
			string key = global::Gibraltar.Monitor.PerfCounterMetricDefinition.GetKey(newPerformanceCounter);
			global::Loupe.Extensibility.Data.IMetricDefinition metricDefinition;
			if (global::Gibraltar.Monitor.Log.Metrics.TryGetValue(key, out metricDefinition))
			{
				if (!(metricDefinition is global::Gibraltar.Monitor.PerfCounterMetricDefinition))
				{
					throw new global::System.ArgumentException("A metric already exists with the provided type, category, and counter name but it is not compatible with being a performance counter metric.  This indicates a programming error in a client application or Gibraltar.");
				}
			}
			else
			{
				metricDefinition = new global::Gibraltar.Monitor.PerfCounterMetricDefinition(global::Gibraltar.Monitor.Log.Metrics, newPerformanceCounter);
			}
			string key2 = global::Gibraltar.Monitor.PerfCounterMetric.GetKey(newPerformanceCounter);
			object @lock = ((global::Gibraltar.Monitor.MetricCollection)metricDefinition.Metrics).Lock;
			global::Loupe.Extensibility.Data.IMetric metric;
			lock (@lock)
			{
				if (!metricDefinition.Metrics.TryGetValue(key2, out metric))
				{
					metric = new global::Gibraltar.Monitor.PerfCounterMetric((global::Gibraltar.Monitor.PerfCounterMetricDefinition)metricDefinition, newPerformanceCounter, alias);
				}
			}
			return (global::Gibraltar.Monitor.PerfCounterMetric)metric;
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00041000 File Offset: 0x0003F200
		public global::System.Diagnostics.PerformanceCounter GetPerformanceCounter()
		{
			string instanceName = base.InstanceName;
			if (this.m_InstanceAlias != global::Gibraltar.Monitor.PerfCounterInstanceAlias.None)
			{
				instanceName = global::Gibraltar.Monitor.PerfCounterMetric.GetInstanceName(this.m_InstanceAlias);
			}
			return global::Gibraltar.Monitor.PerfCounterMetric.GetPerformanceCounter(base.CategoryName, base.CounterName, instanceName);
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x00041044 File Offset: 0x0003F244
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x0004104C File Offset: 0x0003F24C
		public global::Gibraltar.Monitor.PerfCounterPollingState PollingState
		{
			get
			{
				return this.m_PollingState;
			}
			set
			{
				this.m_PollingState = value;
			}
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00041058 File Offset: 0x0003F258
		public int CompareTo(global::Gibraltar.Monitor.PerfCounterMetric other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00041064 File Offset: 0x0003F264
		public bool Equals(global::Gibraltar.Monitor.PerfCounterMetric other)
		{
			return base.Equals(other);
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00041070 File Offset: 0x0003F270
		public new global::Gibraltar.Monitor.PerfCounterMetricDefinition Definition
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetricDefinition)base.Definition;
			}
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00041080 File Offset: 0x0003F280
		internal static string GetInstanceName(global::Gibraltar.Monitor.PerfCounterInstanceAlias alias)
		{
			string result = string.Empty;
			if (alias != global::Gibraltar.Monitor.PerfCounterInstanceAlias.None)
			{
				if (alias != global::Gibraltar.Monitor.PerfCounterInstanceAlias.CurrentProcess)
				{
					throw new global::System.ArgumentOutOfRangeException("alias");
				}
				result = global::Gibraltar.Monitor.PerfCounterMetric.GetCurrentProcessInstanceName();
			}
			return result;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x000410BC File Offset: 0x0003F2BC
		internal static string GetKey(global::System.Diagnostics.PerformanceCounter newPerfCounter)
		{
			return global::Gibraltar.Monitor.MetricDefinition.GetKey(global::Gibraltar.Monitor.PerfCounterMetricDefinition.PerfCounterMetricType, newPerfCounter.CategoryName, newPerfCounter.CounterName, newPerfCounter.InstanceName);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x000410EC File Offset: 0x0003F2EC
		internal static string GetKey(global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket counter)
		{
			return counter.Name;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x000410F4 File Offset: 0x0003F2F4
		internal static string GetKey(string categoryName, string counterName, string instanceName)
		{
			return global::Gibraltar.Monitor.MetricDefinition.GetKey(global::Gibraltar.Monitor.PerfCounterMetricDefinition.PerfCounterMetricType, categoryName, counterName, instanceName);
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x00041104 File Offset: 0x0003F304
		internal new global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket Packet
		{
			get
			{
				return (global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket)base.Packet;
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00041114 File Offset: 0x0003F314
		internal new global::Gibraltar.Monitor.PerfCounterMetricSampleCollection Samples
		{
			get
			{
				return (global::Gibraltar.Monitor.PerfCounterMetricSampleCollection)base.Samples;
			}
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x00041124 File Offset: 0x0003F324
		private static string GetCurrentProcessInstanceName()
		{
			object obj = global::Gibraltar.Monitor.PerfCounterMetric.s_ProcessNameLock;
			string result;
			lock (obj)
			{
				if (global::Gibraltar.Monitor.PerfCounterMetric.s_OurPid < 0)
				{
					global::Gibraltar.Monitor.PerfCounterMetric.s_OurPid = global::System.Diagnostics.Process.GetCurrentProcess().Id;
				}
				if (string.IsNullOrEmpty(global::Gibraltar.Monitor.PerfCounterMetric.s_OurProcessInstanceName) || global::Gibraltar.Monitor.PerfCounterMetric.s_OurProcessInstanceNameExpirationDt < global::System.DateTimeOffset.Now)
				{
					global::Gibraltar.Monitor.PerfCounterMetric.s_OurProcessInstanceNameExpirationDt = global::System.DateTimeOffset.Now.AddSeconds(1.0);
					global::Gibraltar.Monitor.PerfCounterMetric.s_OurProcessInstanceName = global::Gibraltar.Monitor.PerfCounterMetric.GetProcessInstanceName(global::Gibraltar.Monitor.PerfCounterMetric.s_OurPid, ref global::Gibraltar.Monitor.PerfCounterMetric.s_OurProcessInstanceNamePrefix);
				}
				result = global::Gibraltar.Monitor.PerfCounterMetric.s_OurProcessInstanceName;
			}
			return result;
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x000411D4 File Offset: 0x0003F3D4
		private static string GetProcessInstanceName(int pid, ref string prefixHint)
		{
			string text = string.Empty;
			foreach (string text2 in new global::System.Diagnostics.PerformanceCounterCategory("Process").GetInstanceNames())
			{
				if (string.IsNullOrEmpty(prefixHint) || text2.StartsWith(prefixHint))
				{
					try
					{
						using (global::System.Diagnostics.PerformanceCounter performanceCounter = global::Gibraltar.Monitor.PerfCounterMetric.GetPerformanceCounter("Process", "ID Process", text2))
						{
							if ((int)performanceCounter.RawValue == pid)
							{
								text = text2;
								break;
							}
						}
					}
					catch
					{
					}
				}
			}
			if (!string.IsNullOrEmpty(text) && string.IsNullOrEmpty(prefixHint))
			{
				int num = text.LastIndexOf("%");
				if (num <= 0)
				{
					prefixHint = text;
				}
				else
				{
					prefixHint = text.Substring(0, num - 1).TrimEnd(new char[0]);
				}
			}
			return text;
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x000412DC File Offset: 0x0003F4DC
		private static global::System.Diagnostics.PerformanceCounter GetPerformanceCounter(string categoryName, string counterName, string instanceName)
		{
			global::System.Diagnostics.PerformanceCounter result;
			if (string.IsNullOrEmpty(instanceName))
			{
				result = new global::System.Diagnostics.PerformanceCounter(categoryName, counterName, true);
			}
			else
			{
				result = new global::System.Diagnostics.PerformanceCounter(categoryName, counterName, instanceName, true);
			}
			return result;
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00041314 File Offset: 0x0003F514
		internal override global::Gibraltar.Monitor.MetricSample OnMetricSampleRead(global::Gibraltar.Monitor.Internal.MetricSamplePacket packet)
		{
			return new global::Gibraltar.Monitor.PerfCounterMetricSample(this, (global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket)packet);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00041324 File Offset: 0x0003F524
		protected override global::Gibraltar.Monitor.MetricSampleCollection OnSampleCollectionCreate()
		{
			return new global::Gibraltar.Monitor.PerfCounterMetricSampleCollection(this);
		}

		// Token: 0x040006FA RID: 1786
		private readonly global::Gibraltar.Monitor.PerfCounterInstanceAlias m_InstanceAlias;

		// Token: 0x040006FB RID: 1787
		private global::Gibraltar.Monitor.PerfCounterPollingState m_PollingState;

		// Token: 0x040006FC RID: 1788
		private static volatile int s_OurPid = -1;

		// Token: 0x040006FD RID: 1789
		private static readonly object s_ProcessNameLock = new object();

		// Token: 0x040006FE RID: 1790
		private static string s_OurProcessInstanceNamePrefix;

		// Token: 0x040006FF RID: 1791
		private static string s_OurProcessInstanceName;

		// Token: 0x04000700 RID: 1792
		private static global::System.DateTimeOffset s_OurProcessInstanceNameExpirationDt;
	}
}
