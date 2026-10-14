using System;

namespace Org.BouncyCastle.Tls.Crypto.Impl
{
	// Token: 0x0200015F RID: 351
	public interface TlsBlockCipherImpl
	{
		// Token: 0x06000DB5 RID: 3509
		void SetKey(byte[] key, int keyOff, int keyLen);

		// Token: 0x06000DB6 RID: 3510
		void Init(byte[] iv, int ivOff, int ivLen);

		// Token: 0x06000DB7 RID: 3511
		int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset);

		// Token: 0x06000DB8 RID: 3512
		int GetBlockSize();
	}
}
