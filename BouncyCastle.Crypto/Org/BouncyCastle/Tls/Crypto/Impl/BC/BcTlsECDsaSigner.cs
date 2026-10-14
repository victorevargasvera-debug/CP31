using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000177 RID: 375
	public class BcTlsECDsaSigner : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDssSigner
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x00035DCD File Offset: 0x00033FCD
		public BcTlsECDsaSigner(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privateKey) : base(crypto, privateKey)
		{
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00035DD7 File Offset: 0x00033FD7
		protected override global::Org.BouncyCastle.Crypto.IDsa CreateDsaImpl(int cryptoHashAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Signers.ECDsaSigner(new global::Org.BouncyCastle.Crypto.Signers.HMacDsaKCalculator(this.m_crypto.CreateDigest(cryptoHashAlgorithm)));
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00035DEF File Offset: 0x00033FEF
		protected override short SignatureAlgorithm
		{
			get
			{
				return 3;
			}
		}
	}
}
