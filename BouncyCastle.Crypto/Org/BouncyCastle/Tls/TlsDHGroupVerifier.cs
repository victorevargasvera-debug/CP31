using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000105 RID: 261
	public interface TlsDHGroupVerifier
	{
		// Token: 0x06000959 RID: 2393
		bool Accept(global::Org.BouncyCastle.Tls.Crypto.DHGroup dhGroup);
	}
}
