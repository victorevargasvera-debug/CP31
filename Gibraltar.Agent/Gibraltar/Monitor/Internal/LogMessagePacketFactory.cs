using System;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000203 RID: 515
	internal class LogMessagePacketFactory : global::Gibraltar.Serialization.IPacketFactory
	{
		// Token: 0x06001983 RID: 6531 RVA: 0x00059A50 File Offset: 0x00057C50
		internal LogMessagePacketFactory(global::Gibraltar.Monitor.Internal.ISessionPacketCache session)
		{
			this.m_SessionPacketCache = session;
			this.m_LogMessagePacketType = typeof(global::Gibraltar.Monitor.Internal.LogMessagePacket).Name;
			this.m_ExceptionInfoPacketType = typeof(global::Gibraltar.Monitor.Internal.ExceptionInfoPacket).Name;
			this.m_ApplicationUserPacketType = typeof(global::Gibraltar.Monitor.Internal.ApplicationUserPacket).Name;
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00059AB0 File Offset: 0x00057CB0
		public global::Gibraltar.Serialization.IPacket CreatePacket(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.IFieldReader reader)
		{
			global::Gibraltar.Serialization.IPacket packet;
			if (definition.TypeName == this.m_LogMessagePacketType)
			{
				global::Gibraltar.Monitor.Internal.LogMessagePacket logMessagePacket = new global::Gibraltar.Monitor.Internal.LogMessagePacket(this.m_SessionPacketCache);
				packet = logMessagePacket;
				if (definition != this.m_CachedLogMessagePacketDefinition)
				{
					global::Gibraltar.Serialization.PacketDefinition other = global::Gibraltar.Serialization.PacketDefinition.CreatePacketDefinition(packet);
					this.m_UseFastDeserialization = definition.Equals(other);
					this.m_CachedLogMessagePacketDefinition = definition;
				}
				if (this.m_UseFastDeserialization)
				{
					logMessagePacket.ReadFieldsFast(reader);
				}
				else
				{
					definition.ReadFields(packet, reader);
				}
			}
			else if (definition.TypeName == this.m_ExceptionInfoPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.ExceptionInfoPacket();
				definition.ReadFields(packet, reader);
			}
			else
			{
				if (!(definition.TypeName == this.m_ApplicationUserPacketType))
				{
					throw new global::System.ArgumentOutOfRangeException("definition", definition.TypeName, "This packet factory doesn't understand how to create packets for the provided type.");
				}
				packet = new global::Gibraltar.Monitor.Internal.ApplicationUserPacket();
				definition.ReadFields(packet, reader);
			}
			return packet;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00059B9C File Offset: 0x00057D9C
		public void Register(global::Gibraltar.Serialization.IPacketReader packetReader)
		{
			packetReader.RegisterFactory(this.m_LogMessagePacketType, this);
			packetReader.RegisterFactory(this.m_ExceptionInfoPacketType, this);
			packetReader.RegisterFactory(this.m_ApplicationUserPacketType, this);
		}

		// Token: 0x0400093D RID: 2365
		private readonly global::Gibraltar.Monitor.Internal.ISessionPacketCache m_SessionPacketCache;

		// Token: 0x0400093E RID: 2366
		private readonly string m_LogMessagePacketType;

		// Token: 0x0400093F RID: 2367
		private readonly string m_ExceptionInfoPacketType;

		// Token: 0x04000940 RID: 2368
		private readonly string m_ApplicationUserPacketType;

		// Token: 0x04000941 RID: 2369
		private global::Gibraltar.Serialization.PacketDefinition m_CachedLogMessagePacketDefinition;

		// Token: 0x04000942 RID: 2370
		private bool m_UseFastDeserialization;
	}
}
