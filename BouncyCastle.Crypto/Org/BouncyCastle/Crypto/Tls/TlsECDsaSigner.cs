using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200036D RID: 877
	public class TlsECDsaSigner : global::Org.BouncyCastle.Crypto.Tls.TlsDsaSigner
	{
		// Token: 0x060023AD RID: 9133 RVA: 0x0009C51A File Offset: 0x0009A71A
		public override bool IsValidPublicKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			return publicKey is global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters;
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x0009C525 File Offset: 0x0009A725
		protected override global::Org.BouncyCastle.Crypto.IDsa CreateDsaImpl(byte hashAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Signers.ECDsaSigner(new global::Org.BouncyCastle.Crypto.Signers.HMacDsaKCalculator(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm)));
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x0009C537 File Offset: 0x0009A737
		protected override byte SignatureAlgorithm
		{
			get
			{
				return 3;
			}
		}
	}
}
