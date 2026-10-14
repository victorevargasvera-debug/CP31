using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000152 RID: 338
	public interface TlsSrp6Client
	{
		// Token: 0x06000D5A RID: 3418
		global::Org.BouncyCastle.Math.BigInteger CalculateSecret(global::Org.BouncyCastle.Math.BigInteger serverB);

		// Token: 0x06000D5B RID: 3419
		global::Org.BouncyCastle.Math.BigInteger GenerateClientCredentials(byte[] salt, byte[] identity, byte[] password);
	}
}
