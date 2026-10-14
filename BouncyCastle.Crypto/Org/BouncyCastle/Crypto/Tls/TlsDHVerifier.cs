using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000367 RID: 871
	public interface TlsDHVerifier
	{
		// Token: 0x06002362 RID: 9058
		bool Accept(global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParameters);
	}
}
