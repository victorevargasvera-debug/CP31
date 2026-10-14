using System;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000205 RID: 517
	internal class MetricDefinitionPacketFactory : global::Gibraltar.Serialization.IPacketFactory
	{
		// Token: 0x06001996 RID: 6550 RVA: 0x00059EB8 File Offset: 0x000580B8
		public MetricDefinitionPacketFactory(global::Gibraltar.Monitor.Session session)
		{
			this.m_Session = session;
			this.m_MetricDefinitionPacketType = typeof(global::Gibraltar.Monitor.Internal.MetricDefinitionPacket).Name;
			this.m_SampledMetricDefinitionPacketType = typeof(global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket).Name;
			this.m_EventMetricDefinitionPacketType = typeof(global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket).Name;
			this.m_EventMetricValueDefinitionPacketType = typeof(global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket).Name;
			this.m_CustomSampledMetricDefinitionPacketType = typeof(global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket).Name;
			this.m_PerfCounterMetricDefinitionPacketType = typeof(global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket).Name;
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00059F54 File Offset: 0x00058154
		public void Register(global::Gibraltar.Serialization.IPacketReader packetReader)
		{
			packetReader.RegisterFactory(this.m_MetricDefinitionPacketType, this);
			packetReader.RegisterFactory(this.m_SampledMetricDefinitionPacketType, this);
			packetReader.RegisterFactory(this.m_EventMetricDefinitionPacketType, this);
			packetReader.RegisterFactory(this.m_EventMetricValueDefinitionPacketType, this);
			packetReader.RegisterFactory(this.m_CustomSampledMetricDefinitionPacketType, this);
			packetReader.RegisterFactory(this.m_PerfCounterMetricDefinitionPacketType, this);
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00059FB4 File Offset: 0x000581B4
		public global::Gibraltar.Serialization.IPacket CreatePacket(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.IFieldReader reader)
		{
			if (definition.TypeName == this.m_SampledMetricDefinitionPacketType)
			{
				throw new global::System.ArgumentOutOfRangeException("definition", definition.TypeName, "Sampled Metric objects can't be created, only derived classes can.");
			}
			global::Gibraltar.Serialization.IPacket packet;
			if (definition.TypeName == this.m_MetricDefinitionPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.MetricDefinitionPacket(this.m_Session);
			}
			else if (definition.TypeName == this.m_EventMetricDefinitionPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket(this.m_Session);
			}
			else if (definition.TypeName == this.m_EventMetricValueDefinitionPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket(this.m_Session);
			}
			else if (definition.TypeName == this.m_CustomSampledMetricDefinitionPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket(this.m_Session);
			}
			else
			{
				if (!(definition.TypeName == this.m_PerfCounterMetricDefinitionPacketType))
				{
					throw new global::System.ArgumentOutOfRangeException("definition", definition.TypeName, "This packet factory doesn't undersatnd how to create packets for the provided type.");
				}
				packet = new global::Gibraltar.Monitor.Internal.PerfCounterMetricDefinitionPacket(this.m_Session);
			}
			definition.ReadFields(packet, reader);
			return packet;
		}

		// Token: 0x04000948 RID: 2376
		private readonly global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x04000949 RID: 2377
		private readonly string m_MetricDefinitionPacketType;

		// Token: 0x0400094A RID: 2378
		private readonly string m_SampledMetricDefinitionPacketType;

		// Token: 0x0400094B RID: 2379
		private readonly string m_EventMetricDefinitionPacketType;

		// Token: 0x0400094C RID: 2380
		private readonly string m_EventMetricValueDefinitionPacketType;

		// Token: 0x0400094D RID: 2381
		private readonly string m_CustomSampledMetricDefinitionPacketType;

		// Token: 0x0400094E RID: 2382
		private readonly string m_PerfCounterMetricDefinitionPacketType;
	}
}
