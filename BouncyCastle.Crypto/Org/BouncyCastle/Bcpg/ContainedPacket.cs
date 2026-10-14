using System;
using System.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200056E RID: 1390
	public abstract class ContainedPacket : global::Org.BouncyCastle.Bcpg.Packet
	{
		// Token: 0x06003520 RID: 13600 RVA: 0x000FDA10 File Offset: 0x000FBC10
		public byte[] GetEncoded()
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(memoryStream).WritePacket(this);
			return memoryStream.ToArray();
		}

		// Token: 0x06003521 RID: 13601
		public abstract void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut);
	}
}
