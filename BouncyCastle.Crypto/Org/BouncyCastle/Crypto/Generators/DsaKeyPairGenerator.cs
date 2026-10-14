using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200046A RID: 1130
	public class DsaKeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002BAD RID: 11181 RVA: 0x000BB320 File Offset: 0x000B9520
		public void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			if (parameters == null)
			{
				throw new global::System.ArgumentNullException("parameters");
			}
			this.param = (global::Org.BouncyCastle.Crypto.Parameters.DsaKeyGenerationParameters)parameters;
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x000BB33C File Offset: 0x000B953C
		public global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Crypto.Parameters.DsaParameters dsaParams = this.param.Parameters;
			global::Org.BouncyCastle.Math.BigInteger x = global::Org.BouncyCastle.Crypto.Generators.DsaKeyPairGenerator.GeneratePrivateKey(dsaParams.Q, this.param.Random);
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(new global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters(global::Org.BouncyCastle.Crypto.Generators.DsaKeyPairGenerator.CalculatePublicKey(dsaParams.P, dsaParams.G, x), dsaParams), new global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters(x, dsaParams));
		}

		// Token: 0x06002BAF RID: 11183 RVA: 0x000BB390 File Offset: 0x000B9590
		private static global::Org.BouncyCastle.Math.BigInteger GeneratePrivateKey(global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			int minWeight = q.BitLength >> 2;
			global::Org.BouncyCastle.Math.BigInteger x;
			do
			{
				x = global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomInRange(global::Org.BouncyCastle.Crypto.Generators.DsaKeyPairGenerator.One, q.Subtract(global::Org.BouncyCastle.Crypto.Generators.DsaKeyPairGenerator.One), random);
			}
			while (global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetNafWeight(x) < minWeight);
			return x;
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x000BB3C7 File Offset: 0x000B95C7
		private static global::Org.BouncyCastle.Math.BigInteger CalculatePublicKey(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger x)
		{
			return g.ModPow(x, p);
		}

		// Token: 0x0400121F RID: 4639
		private static readonly global::Org.BouncyCastle.Math.BigInteger One = global::Org.BouncyCastle.Math.BigInteger.One;

		// Token: 0x04001220 RID: 4640
		private global::Org.BouncyCastle.Crypto.Parameters.DsaKeyGenerationParameters param;
	}
}
