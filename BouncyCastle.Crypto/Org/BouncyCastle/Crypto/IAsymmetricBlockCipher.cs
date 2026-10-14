using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002C2 RID: 706
	public interface IAsymmetricBlockCipher
	{
		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001F65 RID: 8037
		string AlgorithmName { get; }

		// Token: 0x06001F66 RID: 8038
		void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x06001F67 RID: 8039
		int GetInputBlockSize();

		// Token: 0x06001F68 RID: 8040
		int GetOutputBlockSize();

		// Token: 0x06001F69 RID: 8041
		byte[] ProcessBlock(byte[] inBuf, int inOff, int inLen);
	}
}
