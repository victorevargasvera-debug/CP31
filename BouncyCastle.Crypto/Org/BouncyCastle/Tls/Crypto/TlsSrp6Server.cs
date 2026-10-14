using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000153 RID: 339
	public interface TlsSrp6Server
	{
		// Token: 0x06000D5C RID: 3420
		global::Org.BouncyCastle.Math.BigInteger GenerateServerCredentials();

		// Token: 0x06000D5D RID: 3421
		global::Org.BouncyCastle.Math.BigInteger CalculateSecret(global::Org.BouncyCastle.Math.BigInteger clientA);
	}
}
