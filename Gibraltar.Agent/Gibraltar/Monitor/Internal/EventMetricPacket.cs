using System;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000211 RID: 529
	internal class EventMetricPacket : global::Gibraltar.Monitor.Internal.MetricPacket, global::Gibraltar.Serialization.ICachedPacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.Metric, global::Gibraltar.Monitor.MetricDefinition>, global::System.IComparable<global::Gibraltar.Monitor.Internal.EventMetricPacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.EventMetricPacket>
	{
		// Token: 0x06001A58 RID: 6744 RVA: 0x0005C510 File Offset: 0x0005A710
		public EventMetricPacket(global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket metricDefinitionPacket, string instanceName) : base(metricDefinitionPacket, instanceName)
		{
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0005C51C File Offset: 0x0005A71C
		public EventMetricPacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0005C528 File Offset: 0x0005A728
		public int CompareTo(global::Gibraltar.Monitor.Internal.EventMetricPacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0005C534 File Offset: 0x0005A734
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.EventMetricPacket);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0005C544 File Offset: 0x0005A744
		public bool Equals(global::Gibraltar.Monitor.Internal.EventMetricPacket other)
		{
			return base.Equals(other);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0005C550 File Offset: 0x0005A750
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0005C558 File Offset: 0x0005A758
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket eventMetricDefinitionPacket = (global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket)base.DefinitionPacket;
			global::Gibraltar.Serialization.IPacket[] array = new global::Gibraltar.Serialization.IPacket[eventMetricDefinitionPacket.MetricValues.Count];
			for (int i = 0; i < eventMetricDefinitionPacket.MetricValues.Count; i++)
			{
				array[i] = ((global::Gibraltar.Monitor.EventMetricValueDefinition)eventMetricDefinitionPacket.MetricValues[i]).Packet;
			}
			return array;
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0005C5C0 File Offset: 0x0005A7C0
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, true);
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0005C5D8 File Offset: 0x0005A7D8
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0005C5DC File Offset: 0x0005A7DC
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0005C5E0 File Offset: 0x0005A7E0
		global::Gibraltar.Monitor.Metric global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.Metric, global::Gibraltar.Monitor.MetricDefinition>.GetDataObject(global::Gibraltar.Monitor.MetricDefinition optionalParent)
		{
			return new global::Gibraltar.Monitor.EventMetric((global::Gibraltar.Monitor.EventMetricDefinition)optionalParent, this);
		}

		// Token: 0x0400099C RID: 2460
		private const int SerializationVersion = 1;
	}
}
