using System;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x0200020E RID: 526
	internal class CustomSampledMetricPacket : global::Gibraltar.Monitor.Internal.SampledMetricPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.Metric, global::Gibraltar.Monitor.MetricDefinition>, global::System.IComparable<global::Gibraltar.Monitor.Internal.CustomSampledMetricPacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.CustomSampledMetricPacket>
	{
		// Token: 0x06001A3F RID: 6719 RVA: 0x0005C34C File Offset: 0x0005A54C
		public CustomSampledMetricPacket(global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket metricDefinitionPacket, string instanceName) : base(metricDefinitionPacket, instanceName)
		{
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x0005C358 File Offset: 0x0005A558
		public CustomSampledMetricPacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0005C364 File Offset: 0x0005A564
		public int CompareTo(global::Gibraltar.Monitor.Internal.CustomSampledMetricPacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0005C370 File Offset: 0x0005A570
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.CustomSampledMetricPacket);
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0005C380 File Offset: 0x0005A580
		public bool Equals(global::Gibraltar.Monitor.Internal.CustomSampledMetricPacket other)
		{
			return base.Equals(other);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0005C38C File Offset: 0x0005A58C
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0005C394 File Offset: 0x0005A594
		global::Gibraltar.Monitor.Metric global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.Metric, global::Gibraltar.Monitor.MetricDefinition>.GetDataObject(global::Gibraltar.Monitor.MetricDefinition optionalParent)
		{
			return new global::Gibraltar.Monitor.CustomSampledMetric((global::Gibraltar.Monitor.CustomSampledMetricDefinition)optionalParent, this);
		}
	}
}
