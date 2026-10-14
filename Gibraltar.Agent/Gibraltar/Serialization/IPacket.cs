using System;

namespace Gibraltar.Serialization
{
	// Token: 0x02000100 RID: 256
	internal interface IPacket
	{
		// Token: 0x06000AB5 RID: 2741
		global::Gibraltar.Serialization.IPacket[] GetRequiredPackets();

		// Token: 0x06000AB6 RID: 2742
		global::Gibraltar.Serialization.PacketDefinition GetPacketDefinition();

		// Token: 0x06000AB7 RID: 2743
		void WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet);

		// Token: 0x06000AB8 RID: 2744
		void ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet);
	}
}
