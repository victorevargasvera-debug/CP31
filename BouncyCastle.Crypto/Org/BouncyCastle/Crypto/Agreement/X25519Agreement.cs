using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Agreement
{
	// Token: 0x020004F5 RID: 1269
	public sealed class X25519Agreement : global::Org.BouncyCastle.Crypto.IRawAgreement
	{
		// Token: 0x060031DE RID: 12766 RVA: 0x000EFEAF File Offset: 0x000EE0AF
		public void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.privateKey = (global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters)parameters;
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060031DF RID: 12767 RVA: 0x000EFEBD File Offset: 0x000EE0BD
		public int AgreementSize
		{
			get
			{
				return global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters.SecretSize;
			}
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x000EFEC4 File Offset: 0x000EE0C4
		public void CalculateAgreement(global::Org.BouncyCastle.Crypto.ICipherParameters publicKey, byte[] buf, int off)
		{
			this.privateKey.GenerateSecret((global::Org.BouncyCastle.Crypto.Parameters.X25519PublicKeyParameters)publicKey, buf, off);
		}

		// Token: 0x040015F2 RID: 5618
		private global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters privateKey;
	}
}
