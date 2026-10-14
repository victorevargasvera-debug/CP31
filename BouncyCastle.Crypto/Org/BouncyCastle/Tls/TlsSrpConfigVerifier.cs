using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000126 RID: 294
	public interface TlsSrpConfigVerifier
	{
		// Token: 0x06000B60 RID: 2912
		bool Accept(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig);
	}
}
