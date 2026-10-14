using System;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x020001FD RID: 509
	internal class AnalysisPacketFactory : global::Gibraltar.Serialization.IPacketFactory
	{
		// Token: 0x0600193A RID: 6458 RVA: 0x00058F14 File Offset: 0x00057114
		public AnalysisPacketFactory()
		{
			this.m_AnalysisPacketType = typeof(global::Gibraltar.Monitor.Internal.AnalysisPacket).Name;
			this.m_CommentPacketType = typeof(global::Gibraltar.Monitor.Internal.CommentPacket).Name;
			this.m_DataExtensionPacketType = typeof(global::Gibraltar.Monitor.Internal.DataExtensionPacket).Name;
			this.m_MarkerPacketType = typeof(global::Gibraltar.Monitor.Internal.MarkerPacket).Name;
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00058F80 File Offset: 0x00057180
		public global::Gibraltar.Serialization.IPacket CreatePacket(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.IFieldReader reader)
		{
			global::Gibraltar.Serialization.IPacket packet;
			if (definition.TypeName == this.m_AnalysisPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.AnalysisPacket();
			}
			else if (definition.TypeName == this.m_CommentPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.CommentPacket();
			}
			else if (definition.TypeName == this.m_DataExtensionPacketType)
			{
				packet = new global::Gibraltar.Monitor.Internal.DataExtensionPacket();
			}
			else
			{
				if (!(definition.TypeName == this.m_MarkerPacketType))
				{
					throw new global::System.ArgumentOutOfRangeException("definition", definition.TypeName, "This packet factory doesn't undersatnd how to create packets for the provided type.");
				}
				packet = new global::Gibraltar.Monitor.Internal.MarkerPacket();
			}
			definition.ReadFields(packet, reader);
			return packet;
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00059034 File Offset: 0x00057234
		public void Register(global::Gibraltar.Serialization.IPacketReader packetReader)
		{
			packetReader.RegisterFactory(this.m_AnalysisPacketType, this);
			packetReader.RegisterFactory(this.m_CommentPacketType, this);
			packetReader.RegisterFactory(this.m_DataExtensionPacketType, this);
			packetReader.RegisterFactory(this.m_MarkerPacketType, this);
		}

		// Token: 0x04000925 RID: 2341
		private readonly string m_AnalysisPacketType;

		// Token: 0x04000926 RID: 2342
		private readonly string m_CommentPacketType;

		// Token: 0x04000927 RID: 2343
		private readonly string m_DataExtensionPacketType;

		// Token: 0x04000928 RID: 2344
		private readonly string m_MarkerPacketType;
	}
}
