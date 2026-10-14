using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200046E RID: 1134
	public class Ed448KeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002BCB RID: 11211 RVA: 0x000BBDE5 File Offset: 0x000B9FE5
		public virtual void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			this.random = parameters.Random;
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x000BBDF4 File Offset: 0x000B9FF4
		public virtual global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters privateKey = new global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters(this.random);
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(privateKey.GeneratePublicKey(), privateKey);
		}

		// Token: 0x0400122D RID: 4653
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
