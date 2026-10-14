using System;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x0200020C RID: 524
	internal class MetricSamplePacketFactory : global::Gibraltar.Serialization.IPacketFactory
	{
		// Token: 0x06001A2C RID: 6700 RVA: 0x0005BFC0 File Offset: 0x0005A1C0
		public MetricSamplePacketFactory(global::Gibraltar.Monitor.Session session)
		{
			this.m_Session = session;
			this.m_MetricSamplePacketType = typeof(global::Gibraltar.Monitor.Internal.MetricSamplePacket).Name;
			this.m_SampledMetricSamplePacketType = typeof(global::Gibraltar.Monitor.Internal.SampledMetricSamplePacket).Name;
			this.m_EventMetricSamplePacketType = typeof(global::Gibraltar.Monitor.Internal.EventMetricSamplePacket).Name;
			this.m_CustomSampledMetricSamplePacketType = typeof(global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket).Name;
			this.m_PerfCounterMetricSamplePacketType = typeof(global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket).Name;
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0005C048 File Offset: 0x0005A248
		public void Register(global::Gibraltar.Serialization.IPacketReader packetReader)
		{
			packetReader.RegisterFactory(this.m_MetricSamplePacketType, this);
			packetReader.RegisterFactory(this.m_SampledMetricSamplePacketType, this);
			packetReader.RegisterFactory(this.m_EventMetricSamplePacketType, this);
			packetReader.RegisterFactory(this.m_CustomSampledMetricSamplePacketType, this);
			packetReader.RegisterFactory(this.m_PerfCounterMetricSamplePacketType, this);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0005C09C File Offset: 0x0005A29C
		public global::Gibraltar.Serialization.IPacket CreatePacket(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.IFieldReader reader)
		{
			if (definition.TypeName == this.m_MetricSamplePacketType)
			{
				throw new global::System.ArgumentOutOfRangeException("definition", definition.TypeName, "Metric objects can't be created, only derived classes can.");
			}
			if (definition.TypeName == this.m_SampledMetricSamplePacketType)
			{
				throw new global::System.ArgumentOutOfRangeException("definition", definition.TypeName, "Sampled Metric objects can't be created, only derived classes can.");
			}
			global::Gibraltar.Serialization.IPacket packet;
			if (definition.TypeName == this.m_EventMetricSamplePacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.EventMetricSamplePacket(this.m_Session);
			}
			else if (definition.TypeName == this.m_CustomSampledMetricSamplePacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket(this.m_Session);
			}
			else
			{
				if (!(definition.TypeName == this.m_PerfCounterMetricSamplePacketType))
				{
					throw new global::System.ArgumentOutOfRangeException("definition", definition.TypeName, "This packet factory doesn't undersatnd how to create packets for the provided type.");
				}
				packet = new global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket(this.m_Session);
			}
			definition.ReadFields(packet, reader);
			return packet;
		}

		// Token: 0x04000992 RID: 2450
		private readonly global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x04000993 RID: 2451
		private readonly string m_MetricSamplePacketType;

		// Token: 0x04000994 RID: 2452
		private readonly string m_SampledMetricSamplePacketType;

		// Token: 0x04000995 RID: 2453
		private readonly string m_CustomSampledMetricSamplePacketType;

		// Token: 0x04000996 RID: 2454
		private readonly string m_PerfCounterMetricSamplePacketType;

		// Token: 0x04000997 RID: 2455
		private readonly string m_EventMetricSamplePacketType;
	}
}
