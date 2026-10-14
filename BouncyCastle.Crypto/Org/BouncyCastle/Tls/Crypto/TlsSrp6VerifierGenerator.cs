using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000154 RID: 340
	public interface TlsSrp6VerifierGenerator
	{
		// Token: 0x06000D5E RID: 3422
		global::Org.BouncyCastle.Math.BigInteger GenerateVerifier(byte[] salt, byte[] identity, byte[] password);
	}
}
