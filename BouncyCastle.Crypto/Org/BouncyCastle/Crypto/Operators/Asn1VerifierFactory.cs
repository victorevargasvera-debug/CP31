using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x0200042A RID: 1066
	public class Asn1VerifierFactory : global::Org.BouncyCastle.Crypto.IVerifierFactory
	{
		// Token: 0x0600292A RID: 10538 RVA: 0x000AEE50 File Offset: 0x000AD050
		public Asn1VerifierFactory(string algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			if (publicKey == null)
			{
				throw new global::System.ArgumentNullException("publicKey");
			}
			if (publicKey.IsPrivate)
			{
				throw new global::System.ArgumentException("Key for verifying must be public", "publicKey");
			}
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOid = global::Org.BouncyCastle.Crypto.Operators.X509Utilities.GetAlgorithmOid(algorithm);
			this.publicKey = publicKey;
			this.algID = global::Org.BouncyCastle.Crypto.Operators.X509Utilities.GetSigAlgID(sigOid, algorithm);
		}

		// Token: 0x0600292B RID: 10539 RVA: 0x000AEEB2 File Offset: 0x000AD0B2
		public Asn1VerifierFactory(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			this.publicKey = publicKey;
			this.algID = algorithm;
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x0600292C RID: 10540 RVA: 0x000AEEC8 File Offset: 0x000AD0C8
		public object AlgorithmDetails
		{
			get
			{
				return this.algID;
			}
		}

		// Token: 0x0600292D RID: 10541 RVA: 0x000AEED0 File Offset: 0x000AD0D0
		public global::Org.BouncyCastle.Crypto.IStreamCalculator CreateCalculator()
		{
			return new global::Org.BouncyCastle.Crypto.Operators.DefaultVerifierCalculator(global::Org.BouncyCastle.Security.SignerUtilities.InitSigner(global::Org.BouncyCastle.Crypto.Operators.X509Utilities.GetSignatureName(this.algID), false, this.publicKey, null));
		}

		// Token: 0x040010B0 RID: 4272
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID;

		// Token: 0x040010B1 RID: 4273
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey;
	}
}
