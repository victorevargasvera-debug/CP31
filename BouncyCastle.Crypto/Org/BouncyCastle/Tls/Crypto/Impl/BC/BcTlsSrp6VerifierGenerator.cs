using System;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000189 RID: 393
	internal sealed class BcTlsSrp6VerifierGenerator : global::Org.BouncyCastle.Tls.Crypto.TlsSrp6VerifierGenerator
	{
		// Token: 0x06000ED3 RID: 3795 RVA: 0x00036C00 File Offset: 0x00034E00
		internal BcTlsSrp6VerifierGenerator(global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6VerifierGenerator srp6VerifierGenerator)
		{
			this.m_srp6VerifierGenerator = srp6VerifierGenerator;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00036C0F File Offset: 0x00034E0F
		public global::Org.BouncyCastle.Math.BigInteger GenerateVerifier(byte[] salt, byte[] identity, byte[] password)
		{
			return this.m_srp6VerifierGenerator.GenerateVerifier(salt, identity, password);
		}

		// Token: 0x0400083B RID: 2107
		private readonly global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6VerifierGenerator m_srp6VerifierGenerator;
	}
}
