using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000178 RID: 376
	public class BcTlsECDsaVerifier : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDssVerifier
	{
		// Token: 0x06000E90 RID: 3728 RVA: 0x00035DF2 File Offset: 0x00033FF2
		public BcTlsECDsaVerifier(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters publicKey) : base(crypto, publicKey)
		{
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00035DFC File Offset: 0x00033FFC
		protected override global::Org.BouncyCastle.Crypto.IDsa CreateDsaImpl(int cryptoHashAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Signers.ECDsaSigner(new global::Org.BouncyCastle.Crypto.Signers.HMacDsaKCalculator(this.m_crypto.CreateDigest(cryptoHashAlgorithm)));
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000E92 RID: 3730 RVA: 0x00035E14 File Offset: 0x00034014
		protected override short SignatureAlgorithm
		{
			get
			{
				return 3;
			}
		}
	}
}
