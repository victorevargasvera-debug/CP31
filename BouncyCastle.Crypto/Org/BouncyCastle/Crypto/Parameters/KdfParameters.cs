using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003F6 RID: 1014
	public class KdfParameters : global::Org.BouncyCastle.Crypto.IDerivationParameters
	{
		// Token: 0x06002833 RID: 10291 RVA: 0x000AC5B4 File Offset: 0x000AA7B4
		public KdfParameters(byte[] shared, byte[] iv)
		{
			this.shared = shared;
			this.iv = iv;
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x000AC5CA File Offset: 0x000AA7CA
		public byte[] GetSharedSecret()
		{
			return this.shared;
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x000AC5D2 File Offset: 0x000AA7D2
		public byte[] GetIV()
		{
			return this.iv;
		}

		// Token: 0x0400104C RID: 4172
		private byte[] iv;

		// Token: 0x0400104D RID: 4173
		private byte[] shared;
	}
}
