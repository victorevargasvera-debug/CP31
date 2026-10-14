using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002C3 RID: 707
	public interface IAsymmetricCipherKeyPairGenerator
	{
		// Token: 0x06001F6A RID: 8042
		void Init(global::Org.BouncyCastle.Crypto.KeyGenerationParameters parameters);

		// Token: 0x06001F6B RID: 8043
		global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair GenerateKeyPair();
	}
}
