using System;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000209 RID: 521
	internal class SessionPacketFactory : global::Gibraltar.Serialization.IPacketFactory
	{
		// Token: 0x060019BB RID: 6587 RVA: 0x0005A708 File Offset: 0x00058908
		public SessionPacketFactory()
		{
			this.m_AssemblyInfoPacketType = typeof(global::Gibraltar.Monitor.Internal.AssemblyInfoPacket).Name;
			this.m_SessionStartInfoPacketType = typeof(global::Gibraltar.Monitor.Internal.SessionSummaryPacket).Name;
			this.m_SessionEndInfoPacketType = typeof(global::Gibraltar.Monitor.Internal.SessionClosePacket).Name;
			this.m_SessionFilePacketType = typeof(global::Gibraltar.Monitor.Internal.SessionFragmentPacket).Name;
			this.m_ThreadInfoPacketType = typeof(global::Gibraltar.Monitor.Internal.ThreadInfoPacket).Name;
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0005A788 File Offset: 0x00058988
		public global::Gibraltar.Serialization.IPacket CreatePacket(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.IFieldReader reader)
		{
			global::Gibraltar.Serialization.IPacket packet;
			if (definition.TypeName == this.m_ThreadInfoPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.ThreadInfoPacket();
			}
			else if (definition.TypeName == this.m_AssemblyInfoPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.AssemblyInfoPacket();
			}
			else if (definition.TypeName == this.m_SessionStartInfoPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.SessionSummaryPacket();
			}
			else if (definition.TypeName == this.m_SessionEndInfoPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.SessionClosePacket();
			}
			else
			{
				if (!(definition.TypeName == this.m_SessionFilePacketType))
				{
					throw new global::System.ArgumentOutOfRangeException("definition", definition.TypeName, "This packet factory doesn't understand how to create packets for the provided type.");
				}
				packet = new global::Gibraltar.Monitor.Internal.SessionFragmentPacket();
			}
			definition.ReadFields(packet, reader);
			return packet;
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0005A860 File Offset: 0x00058A60
		public void Register(global::Gibraltar.Serialization.IPacketReader packetReader)
		{
			packetReader.RegisterFactory(this.m_AssemblyInfoPacketType, this);
			packetReader.RegisterFactory(this.m_SessionStartInfoPacketType, this);
			packetReader.RegisterFactory(this.m_SessionEndInfoPacketType, this);
			packetReader.RegisterFactory(this.m_SessionFilePacketType, this);
			packetReader.RegisterFactory(this.m_ThreadInfoPacketType, this);
		}

		// Token: 0x0400095D RID: 2397
		private readonly string m_AssemblyInfoPacketType;

		// Token: 0x0400095E RID: 2398
		private readonly string m_SessionStartInfoPacketType;

		// Token: 0x0400095F RID: 2399
		private readonly string m_SessionEndInfoPacketType;

		// Token: 0x04000960 RID: 2400
		private readonly string m_SessionFilePacketType;

		// Token: 0x04000961 RID: 2401
		private readonly string m_ThreadInfoPacketType;
	}
}
