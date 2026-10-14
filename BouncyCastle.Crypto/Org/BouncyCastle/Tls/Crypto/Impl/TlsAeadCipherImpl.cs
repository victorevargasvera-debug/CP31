using System;

namespace Org.BouncyCastle.Tls.Crypto.Impl
{
	// Token: 0x0200015D RID: 349
	public interface TlsAeadCipherImpl
	{
		// Token: 0x06000DA5 RID: 3493
		void SetKey(byte[] key, int keyOff, int keyLen);

		// Token: 0x06000DA6 RID: 3494
		void Init(byte[] nonce, int macSize, byte[] additionalData);

		// Token: 0x06000DA7 RID: 3495
		int GetOutputSize(int inputLength);

		// Token: 0x06000DA8 RID: 3496
		int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset);
	}
}
