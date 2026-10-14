using System;
using Org.BouncyCastle.Crypto.Prng;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200017F RID: 383
	internal sealed class BcTlsNonceGenerator : global::Org.BouncyCastle.Tls.Crypto.TlsNonceGenerator
	{
		// Token: 0x06000EAD RID: 3757 RVA: 0x00036119 File Offset: 0x00034319
		internal BcTlsNonceGenerator(global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator randomGenerator)
		{
			this.m_randomGenerator = randomGenerator;
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00036128 File Offset: 0x00034328
		public byte[] GenerateNonce(int size)
		{
			byte[] nonce = new byte[size];
			this.m_randomGenerator.NextBytes(nonce);
			return nonce;
		}

		// Token: 0x0400082F RID: 2095
		private readonly global::Org.BouncyCastle.Crypto.Prng.IRandomGenerator m_randomGenerator;
	}
}
