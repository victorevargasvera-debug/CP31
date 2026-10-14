using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200038A RID: 906
	public interface TlsSrpGroupVerifier
	{
		// Token: 0x060024C7 RID: 9415
		bool Accept(global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters group);
	}
}
