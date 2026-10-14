using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000149 RID: 329
	public interface TlsHash
	{
		// Token: 0x06000D32 RID: 3378
		void Update(byte[] input, int inOff, int length);

		// Token: 0x06000D33 RID: 3379
		byte[] CalculateHash();

		// Token: 0x06000D34 RID: 3380
		global::Org.BouncyCastle.Tls.Crypto.TlsHash CloneHash();

		// Token: 0x06000D35 RID: 3381
		void Reset();
	}
}
