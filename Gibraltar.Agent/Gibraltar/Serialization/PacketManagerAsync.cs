using System;
using System.IO;

namespace Gibraltar.Serialization
{
	// Token: 0x02000107 RID: 263
	internal class PacketManagerAsync : global::Gibraltar.Serialization.PacketManagerBase
	{
		// Token: 0x06000AEF RID: 2799 RVA: 0x0001B8B4 File Offset: 0x00019AB4
		public PacketManagerAsync(global::System.IO.Stream stream)
		{
			this.m_Stream = stream;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0001B8C4 File Offset: 0x00019AC4
		public override global::System.IO.MemoryStream GetNextPacket()
		{
			return null;
		}

		// Token: 0x04000300 RID: 768
		private readonly global::System.IO.Stream m_Stream;
	}
}
