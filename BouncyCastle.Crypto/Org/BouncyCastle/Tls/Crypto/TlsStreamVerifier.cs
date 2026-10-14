using System;
using System.IO;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000157 RID: 343
	public interface TlsStreamVerifier
	{
		// Token: 0x06000D64 RID: 3428
		global::System.IO.Stream GetOutputStream();

		// Token: 0x06000D65 RID: 3429
		bool IsVerified();
	}
}
