using System;
using System.IO;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000156 RID: 342
	public interface TlsStreamSigner
	{
		// Token: 0x06000D62 RID: 3426
		global::System.IO.Stream GetOutputStream();

		// Token: 0x06000D63 RID: 3427
		byte[] GetSignature();
	}
}
