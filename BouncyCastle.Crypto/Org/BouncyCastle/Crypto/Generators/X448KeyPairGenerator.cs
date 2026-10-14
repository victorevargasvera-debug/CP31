using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x02000485 RID: 1157
	public class X448KeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002C4D RID: 11341 RVA: 0x000BF6A5 File Offset: 0x000BD8A5
		public virtual void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			this.random = parameters.Random;
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x000BF6B4 File Offset: 0x000BD8B4
		public virtual global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters privateKey = new global::Org.BouncyCastle.Crypto.Parameters.X448PrivateKeyParameters(this.random);
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(privateKey.GeneratePublicKey(), privateKey);
		}

		// Token: 0x0400127A RID: 4730
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
