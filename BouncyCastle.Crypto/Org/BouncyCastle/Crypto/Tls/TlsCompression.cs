using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000360 RID: 864
	public interface TlsCompression
	{
		// Token: 0x06002324 RID: 8996
		global::System.IO.Stream Compress(global::System.IO.Stream output);

		// Token: 0x06002325 RID: 8997
		global::System.IO.Stream Decompress(global::System.IO.Stream output);
	}
}
