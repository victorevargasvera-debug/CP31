using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000465 RID: 1125
	public class DHBasicKeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002B9B RID: 11163 RVA: 0x000BAF0C File Offset: 0x000B910C
		public virtual void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			this.param = (global::Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters)parameters;
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x000BAF1C File Offset: 0x000B911C
		public virtual global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper instance = global::Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper.Instance;
			global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhp = this.param.Parameters;
			global::Org.BouncyCastle.Math.BigInteger x = instance.CalculatePrivate(dhp, this.param.Random);
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(new global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(instance.CalculatePublic(dhp, x), dhp), new global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters(x, dhp));
		}

		// Token: 0x04001215 RID: 4629
		private global::Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters param;
	}
}
