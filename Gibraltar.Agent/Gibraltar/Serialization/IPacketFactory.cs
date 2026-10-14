using System;

namespace Gibraltar.Serialization
{
	// Token: 0x02000101 RID: 257
	internal interface IPacketFactory
	{
		// Token: 0x06000AB9 RID: 2745
		global::Gibraltar.Serialization.IPacket CreatePacket(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.IFieldReader reader);
	}
}
