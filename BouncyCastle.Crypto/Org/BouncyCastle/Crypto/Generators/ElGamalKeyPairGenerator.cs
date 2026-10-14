using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200046F RID: 1135
	public class ElGamalKeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002BCE RID: 11214 RVA: 0x000BBE21 File Offset: 0x000BA021
		public void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			this.param = (global::Org.BouncyCastle.Crypto.Parameters.ElGamalKeyGenerationParameters)parameters;
		}

		// Token: 0x06002BCF RID: 11215 RVA: 0x000BBE30 File Offset: 0x000BA030
		public global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper instance = global::Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper.Instance;
			global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters egp = this.param.Parameters;
			global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhp = new global::Org.BouncyCastle.Crypto.Parameters.DHParameters(egp.P, egp.G, null, 0, egp.L);
			global::Org.BouncyCastle.Math.BigInteger x = instance.CalculatePrivate(dhp, this.param.Random);
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(new global::Org.BouncyCastle.Crypto.Parameters.ElGamalPublicKeyParameters(instance.CalculatePublic(dhp, x), egp), new global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters(x, egp));
		}

		// Token: 0x0400122E RID: 4654
		private global::Org.BouncyCastle.Crypto.Parameters.ElGamalKeyGenerationParameters param;
	}
}
