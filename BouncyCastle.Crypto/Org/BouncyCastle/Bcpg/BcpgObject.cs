using System;
using System.IO;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x0200056A RID: 1386
	public abstract class BcpgObject
	{
		// Token: 0x06003504 RID: 13572 RVA: 0x000FD3A6 File Offset: 0x000FB5A6
		public virtual byte[] GetEncoded()
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			new global::Org.BouncyCastle.Bcpg.BcpgOutputStream(memoryStream).WriteObject(this);
			return memoryStream.ToArray();
		}

		// Token: 0x06003505 RID: 13573
		public abstract void Encode(global::Org.BouncyCastle.Bcpg.BcpgOutputStream bcpgOut);
	}
}
