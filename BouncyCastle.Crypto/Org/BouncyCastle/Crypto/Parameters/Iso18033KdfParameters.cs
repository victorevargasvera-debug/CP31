using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003F2 RID: 1010
	public class Iso18033KdfParameters : global::Org.BouncyCastle.Crypto.IDerivationParameters
	{
		// Token: 0x06002819 RID: 10265 RVA: 0x000AC313 File Offset: 0x000AA513
		public Iso18033KdfParameters(byte[] seed)
		{
			this.seed = seed;
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x000AC322 File Offset: 0x000AA522
		public byte[] GetSeed()
		{
			return this.seed;
		}

		// Token: 0x0400103C RID: 4156
		private byte[] seed;
	}
}
