using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002C5 RID: 709
	public interface IBlockCipher
	{
		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001F6F RID: 8047
		string AlgorithmName { get; }

		// Token: 0x06001F70 RID: 8048
		void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x06001F71 RID: 8049
		int GetBlockSize();

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001F72 RID: 8050
		bool IsPartialBlockOkay { get; }

		// Token: 0x06001F73 RID: 8051
		int ProcessBlock(byte[] inBuf, int inOff, byte[] outBuf, int outOff);

		// Token: 0x06001F74 RID: 8052
		void Reset();
	}
}
