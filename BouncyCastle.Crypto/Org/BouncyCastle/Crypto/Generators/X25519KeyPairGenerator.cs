using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000484 RID: 1156
	public class X25519KeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002C4A RID: 11338 RVA: 0x000BF667 File Offset: 0x000BD867
		public virtual void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			this.random = parameters.Random;
		}

		// Token: 0x06002C4B RID: 11339 RVA: 0x000BF678 File Offset: 0x000BD878
		public virtual global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters privateKey = new global::Org.BouncyCastle.Crypto.Parameters.X25519PrivateKeyParameters(this.random);
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(privateKey.GeneratePublicKey(), privateKey);
		}

		// Token: 0x04001279 RID: 4729
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
