using System;

namespace Gibraltar.Serialization.Internal
{
	// Token: 0x02000112 RID: 274
	internal class GenericPacketFactory : global::Gibraltar.Serialization.IPacketFactory
	{
		// Token: 0x06000B7D RID: 2941 RVA: 0x0001D298 File Offset: 0x0001B498
		public global::Gibraltar.Serialization.IPacket CreatePacket(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.IFieldReader reader)
		{
			return new global::Gibraltar.Serialization.GenericPacket(definition, reader);
		}
	}
}
