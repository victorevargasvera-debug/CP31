using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x0200014E RID: 334
	public interface TlsNonceGenerator
	{
		// Token: 0x06000D45 RID: 3397
		byte[] GenerateNonce(int size);
	}
}
