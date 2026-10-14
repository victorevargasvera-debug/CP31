using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x02000405 RID: 1029
	public class RsaBlindingParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x0600286D RID: 10349 RVA: 0x000ACAC7 File Offset: 0x000AACC7
		public RsaBlindingParameters(global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters publicKey, global::Org.BouncyCastle.Math.BigInteger blindingFactor)
		{
			if (publicKey.IsPrivate)
			{
				throw new global::System.ArgumentException("RSA parameters should be for a public key");
			}
			this.publicKey = publicKey;
			this.blindingFactor = blindingFactor;
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x000ACAF0 File Offset: 0x000AACF0
		public global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters PublicKey
		{
			get
			{
				return this.publicKey;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600286F RID: 10351 RVA: 0x000ACAF8 File Offset: 0x000AACF8
		public global::Org.BouncyCastle.Math.BigInteger BlindingFactor
		{
			get
			{
				return this.blindingFactor;
			}
		}

		// Token: 0x04001068 RID: 4200
		private readonly global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters publicKey;

		// Token: 0x04001069 RID: 4201
		private readonly global::Org.BouncyCastle.Math.BigInteger blindingFactor;
	}
}
