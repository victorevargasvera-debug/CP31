using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x020004F6 RID: 1270
	public sealed class X448Agreement : global::Org.BouncyCastle.Crypto.IRawAgreement
	{
		// Token: 0x060031E2 RID: 12770 RVA: 0x000EFEE1 File Offset: 0x000EE0E1
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.privateKey = (global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters)parameters;
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060031E3 RID: 12771 RVA: 0x000EFEEF File Offset: 0x000EE0EF
		public int AgreementSize
		{
			get
			{
				return global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters.SecretSize;
			}
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x000EFEF6 File Offset: 0x000EE0F6
		public void CalculateAgreement(global::Org.BouncyCastle.Crypto.ICipherParameters publicKey, byte[] buf, int off)
		{
			this.privateKey.GenerateSecret((global::Org.BouncyCastle.Crypto.Parameters.X448PublicKeyParameters)publicKey, buf, off);
		}

		// Token: 0x040015F3 RID: 5619
		private global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters privateKey;
	}
}
