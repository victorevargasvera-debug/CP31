using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000551 RID: 1361
	public class Pkcs5Scheme2PbeKey : global::Org.BouncyCastle.Cms.CmsPbeKey
	{
		// Token: 0x06003448 RID: 13384 RVA: 0x000FA244 File Offset: 0x000F8444
		[global::System.Obsolete("Use version taking 'char[]' instead")]
		public Pkcs5Scheme2PbeKey(string password, byte[] salt, int iterationCount) : this(password.ToCharArray(), salt, iterationCount)
		{
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x000FA254 File Offset: 0x000F8454
		[global::System.Obsolete("Use version taking 'char[]' instead")]
		public Pkcs5Scheme2PbeKey(string password, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm) : this(password.ToCharArray(), keyDerivationAlgorithm)
		{
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x000FA263 File Offset: 0x000F8463
		public Pkcs5Scheme2PbeKey(char[] password, byte[] salt, int iterationCount) : base(password, salt, iterationCount)
		{
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x000FA26E File Offset: 0x000F846E
		public Pkcs5Scheme2PbeKey(char[] password, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm) : base(password, keyDerivationAlgorithm)
		{
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x000FA278 File Offset: 0x000F8478
		internal override global::Org.BouncyCastle.Crypto.Parameters.KeyParameter GetEncoded(string algorithmOid)
		{
			global::Org.BouncyCastle.Crypto.Generators.Pkcs5S2ParametersGenerator pkcs5S2ParametersGenerator = new global::Org.BouncyCastle.Crypto.Generators.Pkcs5S2ParametersGenerator();
			pkcs5S2ParametersGenerator.Init(global::Org.BouncyCastle.Crypto.PbeParametersGenerator.Pkcs5PasswordToBytes(this.password), this.salt, this.iterationCount);
			return (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)pkcs5S2ParametersGenerator.GenerateDerivedParameters(algorithmOid, global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.Instance.GetKeySize(algorithmOid));
		}
	}
}
