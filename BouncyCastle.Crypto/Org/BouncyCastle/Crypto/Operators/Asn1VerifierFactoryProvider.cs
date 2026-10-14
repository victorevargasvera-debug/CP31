using System;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x0200042B RID: 1067
	public class Asn1VerifierFactoryProvider : global::Org.BouncyCastle.Crypto.IVerifierFactoryProvider
	{
		// Token: 0x0600292E RID: 10542 RVA: 0x000AEEEF File Offset: 0x000AD0EF
		public Asn1VerifierFactoryProvider(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			this.publicKey = publicKey;
		}

		// Token: 0x0600292F RID: 10543 RVA: 0x000AEEFE File Offset: 0x000AD0FE
		public global::Org.BouncyCastle.Crypto.IVerifierFactory CreateVerifierFactory(object algorithmDetails)
		{
			return new global::Org.BouncyCastle.Crypto.Operators.Asn1VerifierFactory((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)algorithmDetails, this.publicKey);
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06002930 RID: 10544 RVA: 0x000AEF11 File Offset: 0x000AD111
		public global::System.Collections.IEnumerable SignatureAlgNames
		{
			get
			{
				return global::Org.BouncyCastle.Crypto.Operators.X509Utilities.GetAlgNames();
			}
		}

		// Token: 0x040010B2 RID: 4274
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey;
	}
}
