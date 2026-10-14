using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x02000429 RID: 1065
	public class Asn1SignatureFactory : global::Org.BouncyCastle.Crypto.ISignatureFactory
	{
		// Token: 0x06002925 RID: 10533 RVA: 0x000AEDA5 File Offset: 0x000ACFA5
		public Asn1SignatureFactory(string algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey) : this(algorithm, privateKey, null)
		{
		}

		// Token: 0x06002926 RID: 10534 RVA: 0x000AEDB0 File Offset: 0x000ACFB0
		public Asn1SignatureFactory(string algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			if (algorithm == null)
			{
				throw new global::System.ArgumentNullException("algorithm");
			}
			if (privateKey == null)
			{
				throw new global::System.ArgumentNullException("privateKey");
			}
			if (!privateKey.IsPrivate)
			{
				throw new global::System.ArgumentException("Key for signing must be private", "privateKey");
			}
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOid = global::Org.BouncyCastle.Crypto.Operators.X509Utilities.GetAlgorithmOid(algorithm);
			this.algorithm = algorithm;
			this.privateKey = privateKey;
			this.random = random;
			this.algID = global::Org.BouncyCastle.Crypto.Operators.X509Utilities.GetSigAlgID(sigOid, algorithm);
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002927 RID: 10535 RVA: 0x000AEE20 File Offset: 0x000AD020
		public object AlgorithmDetails
		{
			get
			{
				return this.algID;
			}
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x000AEE28 File Offset: 0x000AD028
		public global::Org.BouncyCastle.Crypto.IStreamCalculator CreateCalculator()
		{
			return new global::Org.BouncyCastle.Crypto.Operators.DefaultSignatureCalculator(global::Org.BouncyCastle.Security.SignerUtilities.InitSigner(this.algorithm, true, this.privateKey, this.random));
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06002929 RID: 10537 RVA: 0x000AEE47 File Offset: 0x000AD047
		public static global::System.Collections.IEnumerable SignatureAlgNames
		{
			get
			{
				return global::Org.BouncyCastle.Crypto.Operators.X509Utilities.GetAlgNames();
			}
		}

		// Token: 0x040010AC RID: 4268
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algID;

		// Token: 0x040010AD RID: 4269
		private readonly string algorithm;

		// Token: 0x040010AE RID: 4270
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey;

		// Token: 0x040010AF RID: 4271
		private readonly global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
