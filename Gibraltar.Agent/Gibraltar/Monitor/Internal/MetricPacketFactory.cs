using System;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000206 RID: 518
	internal class MetricPacketFactory : global::Gibraltar.Serialization.IPacketFactory
	{
		// Token: 0x06001999 RID: 6553 RVA: 0x0005A0D4 File Offset: 0x000582D4
		public MetricPacketFactory(global::Gibraltar.Monitor.Session session)
		{
			this.m_Session = session;
			this.m_MetricPacketType = typeof(global::Gibraltar.Monitor.Internal.MetricPacket).Name;
			this.m_SampledMetricPacketType = typeof(global::Gibraltar.Monitor.Internal.SampledMetricPacket).Name;
			this.m_EventMetricPacketType = typeof(global::Gibraltar.Monitor.Internal.EventMetricPacket).Name;
			this.m_CustomSampledMetricPacketType = typeof(global::Gibraltar.Monitor.Internal.CustomSampledMetricPacket).Name;
			this.m_PerfCounterMetricPacketType = typeof(global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket).Name;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x0005A15C File Offset: 0x0005835C
		public void Register(global::Gibraltar.Serialization.IPacketReader packetReader)
		{
			packetReader.RegisterFactory(this.m_MetricPacketType, this);
			packetReader.RegisterFactory(this.m_SampledMetricPacketType, this);
			packetReader.RegisterFactory(this.m_EventMetricPacketType, this);
			packetReader.RegisterFactory(this.m_CustomSampledMetricPacketType, this);
			packetReader.RegisterFactory(this.m_PerfCounterMetricPacketType, this);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x0005A1B0 File Offset: 0x000583B0
		public global::Gibraltar.Serialization.IPacket CreatePacket(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.IFieldReader reader)
		{
			if (definition.TypeName == this.m_MetricPacketType)
			{
				throw new global::System.ArgumentOutOfRangeException("definition", definition.TypeName, "Metric objects can't be created, only derived classes can.");
			}
			if (definition.TypeName == this.m_SampledMetricPacketType)
			{
				throw new global::System.ArgumentOutOfRangeException("definition", definition.TypeName, "Sampled Metric objects can't be created, only derived classes can.");
			}
			global::Gibraltar.Serialization.IPacket packet;
			if (definition.TypeName == this.m_EventMetricPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.EventMetricPacket(this.m_Session);
			}
			else if (definition.TypeName == this.m_CustomSampledMetricPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.CustomSampledMetricPacket(this.m_Session);
			}
			else
			{
				if (!(definition.TypeName == this.m_PerfCounterMetricPacketType))
				{
					throw new global::System.ArgumentOutOfRangeException("definition", definition.TypeName, "This packet factory doesn't undersatnd how to create packets for the provided type.");
				}
				packet = new global::Gibraltar.Monitor.Internal.PerfCounterMetricPacket(this.m_Session);
			}
			definition.ReadFields(packet, reader);
			return packet;
		}

		// Token: 0x0400094F RID: 2383
		private readonly global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x04000950 RID: 2384
		private readonly string m_MetricPacketType;

		// Token: 0x04000951 RID: 2385
		private readonly string m_SampledMetricPacketType;

		// Token: 0x04000952 RID: 2386
		private readonly string m_EventMetricPacketType;

		// Token: 0x04000953 RID: 2387
		private readonly string m_CustomSampledMetricPacketType;

		// Token: 0x04000954 RID: 2388
		private readonly string m_PerfCounterMetricPacketType;
	}
}
