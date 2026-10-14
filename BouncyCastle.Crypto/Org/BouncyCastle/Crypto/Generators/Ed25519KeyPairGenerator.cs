using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators
{
	// Token: 0x0200046D RID: 1133
	public class Ed25519KeyPairGenerator : global::Org.BouncyCastle.Crypto.IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06002BC8 RID: 11208 RVA: 0x000BBDA7 File Offset: 0x000B9FA7
		public virtual void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters)
		{
			this.random = parameters.Random;
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000BBDB8 File Offset: 0x000B9FB8
		public virtual global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair()
		{
			global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters privateKey = new global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters(this.random);
			return new global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair(privateKey.GeneratePublicKey(), privateKey);
		}

		// Token: 0x0400122C RID: 4652
		private global::Org.BouncyCastle.Security.SecureRandom random;
	}
}
