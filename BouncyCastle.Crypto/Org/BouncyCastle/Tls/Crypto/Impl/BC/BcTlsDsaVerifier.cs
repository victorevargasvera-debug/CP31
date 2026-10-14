using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000170 RID: 368
	public class BcTlsDsaVerifier : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDssVerifier
	{
		// Token: 0x06000E6F RID: 3695 RVA: 0x000358C2 File Offset: 0x00033AC2
		public BcTlsDsaVerifier(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters publicKey) : base(crypto, publicKey)
		{
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x000358CC File Offset: 0x00033ACC
		protected override global::Org.BouncyCastle.Crypto.IDsa CreateDsaImpl(int cryptoHashAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Signers.DsaSigner(new global::Org.BouncyCastle.Crypto.Signers.HMacDsaKCalculator(this.m_crypto.CreateDigest(cryptoHashAlgorithm)));
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x000358E4 File Offset: 0x00033AE4
		protected override short SignatureAlgorithm
		{
			get
			{
				return 2;
			}
		}
	}
}
