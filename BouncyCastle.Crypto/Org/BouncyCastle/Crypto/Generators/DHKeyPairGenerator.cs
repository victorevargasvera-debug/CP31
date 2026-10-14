using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000467 RID: 1127
	public class DHKeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002BA2 RID: 11170 RVA: 0x000BB032 File Offset: 0x000B9232
		public virtual void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			this.param = (global::Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters)parameters;
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x000BB040 File Offset: 0x000B9240
		public virtual global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper instance = global::Org.BouncyCastle.Crypto.Generators.DHKeyGeneratorHelper.Instance;
			global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhp = this.param.Parameters;
			global::Org.BouncyCastle.Math.BigInteger x = instance.CalculatePrivate(dhp, this.param.Random);
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(new global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(instance.CalculatePublic(dhp, x), dhp), new global::Org.BouncyCastle.Crypto.Parameters.DHPrivateKeyParameters(x, dhp));
		}

		// Token: 0x04001217 RID: 4631
		private global::Org.BouncyCastle.Crypto.Parameters.DHKeyGenerationParameters param;
	}
}
