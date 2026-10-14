using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200016F RID: 367
	public class BcTlsDsaSigner : global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDssSigner
	{
		// Token: 0x06000E6C RID: 3692 RVA: 0x0003589D File Offset: 0x00033A9D
		public BcTlsDsaSigner(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters privateKey) : base(crypto, privateKey)
		{
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x000358A7 File Offset: 0x00033AA7
		protected override global::Org.BouncyCastle.Crypto.IDsa CreateDsaImpl(int cryptoHashAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Signers.DsaSigner(new global::Org.BouncyCastle.Crypto.Signers.HMacDsaKCalculator(this.m_crypto.CreateDigest(cryptoHashAlgorithm)));
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x000358BF File Offset: 0x00033ABF
		protected override short SignatureAlgorithm
		{
			get
			{
				return 2;
			}
		}
	}
}
