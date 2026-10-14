using System;
using System.Diagnostics;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x0200021D RID: 541
	[global::System.Serializable]
	internal class PerfCounterMetricPacket : global::Gibraltar.Monitor.Internal.SampledMetricPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.Metric, global::Gibraltar.Monitor.MetricDefinition>, global::System.IComparable<global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket>
	{
		// Token: 0x06001B5D RID: 7005 RVA: 0x0005F6E8 File Offset: 0x0005D8E8
		public PerfCounterMetricPacket(global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket metricDefinitionPacket, global::System.Diagnostics.PerformanceCounter counter) : base(metricDefinitionPacket, counter.InstanceName)
		{
			if (counter == null)
			{
				throw new global::System.ArgumentNullException("counter", "No performance counter object was provided and one is required.");
			}
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0005F710 File Offset: 0x0005D910
		public PerfCounterMetricPacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0005F71C File Offset: 0x0005D91C
		public int CompareTo(global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0005F728 File Offset: 0x0005D928
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0005F738 File Offset: 0x0005D938
		public bool Equals(global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket other)
		{
			return base.Equals(other);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0005F744 File Offset: 0x0005D944
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0005F74C File Offset: 0x0005D94C
		global::Gibraltar.Monitor.Metric global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.Metric, global::Gibraltar.Monitor.MetricDefinition>.GetDataObject(global::Gibraltar.Monitor.MetricDefinition optionalParent)
		{
			return new global::Gibraltar.Monitor.PerfCounterMetric((global::Gibraltar.Monitor.PerfCounterMetricDefinition)optionalParent, this);
		}
	}
}
