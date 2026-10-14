using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000552 RID: 1362
	public class Pkcs5Scheme2Utf8PbeKey : global::Org.BouncyCastle.Cms.CmsPbeKey
	{
		// Token: 0x0600344D RID: 13389 RVA: 0x000FA2B2 File Offset: 0x000F84B2
		[global::System.Obsolete("Use version taking 'char[]' instead")]
		public Pkcs5Scheme2Utf8PbeKey(string password, byte[] salt, int iterationCount) : this(password.ToCharArray(), salt, iterationCount)
		{
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x000FA2C2 File Offset: 0x000F84C2
		[global::System.Obsolete("Use version taking 'char[]' instead")]
		public Pkcs5Scheme2Utf8PbeKey(string password, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm) : this(password.ToCharArray(), keyDerivationAlgorithm)
		{
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x000FA2D1 File Offset: 0x000F84D1
		public Pkcs5Scheme2Utf8PbeKey(char[] password, byte[] salt, int iterationCount) : base(password, salt, iterationCount)
		{
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x000FA2DC File Offset: 0x000F84DC
		public Pkcs5Scheme2Utf8PbeKey(char[] password, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier keyDerivationAlgorithm) : base(password, keyDerivationAlgorithm)
		{
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x000FA2E6 File Offset: 0x000F84E6
		internal override global::Org.BouncyCastle.Crypto.Parameters.KeyParameter GetEncoded(string algorithmOid)
		{
			global::Org.BouncyCastle.Crypto.Generators.Pkcs5S2ParametersGenerator pkcs5S2ParametersGenerator = new global::Org.BouncyCastle.Crypto.Generators.Pkcs5S2ParametersGenerator();
			pkcs5S2ParametersGenerator.Init(global::Org.BouncyCastle.Crypto.PbeParametersGenerator.Pkcs5PasswordToUtf8Bytes(this.password), this.salt, this.iterationCount);
			return (global::Org.BouncyCastle.Crypto.Parameters.KeyParameter)pkcs5S2ParametersGenerator.GenerateDerivedParameters(algorithmOid, global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.Instance.GetKeySize(algorithmOid));
		}
	}
}
