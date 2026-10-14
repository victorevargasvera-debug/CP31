using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000369 RID: 873
	public class TlsDssSigner : global::Org.BouncyCastle.Crypto.Tls.TlsDsaSigner
	{
		// Token: 0x0600236C RID: 9068 RVA: 0x0009B5A8 File Offset: 0x000997A8
		public override bool IsValidPublicKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			return publicKey is global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters;
		}

		// Token: 0x0600236D RID: 9069 RVA: 0x0009B5B3 File Offset: 0x000997B3
		protected override global::Org.BouncyCastle.Crypto.IDsa CreateDsaImpl(byte hashAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Signers.DsaSigner(new global::Org.BouncyCastle.Crypto.Signers.HMacDsaKCalculator(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm)));
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x0600236E RID: 9070 RVA: 0x0009B5C5 File Offset: 0x000997C5
		protected override byte SignatureAlgorithm
		{
			get
			{
				return 2;
			}
		}
	}
}
