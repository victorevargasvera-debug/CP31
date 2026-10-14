using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002CD RID: 717
	public interface IDerivationFunction
	{
		// Token: 0x06001F91 RID: 8081
		void Init(global::Org.BouncyCastle.Crypto.IDerivationParameters parameters);

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001F92 RID: 8082
		global::Org.BouncyCastle.Crypto.IDigest Digest { get; }

		// Token: 0x06001F93 RID: 8083
		int GenerateBytes(byte[] output, int outOff, int length);
	}
}
