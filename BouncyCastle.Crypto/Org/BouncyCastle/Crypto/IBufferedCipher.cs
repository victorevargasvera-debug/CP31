using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002C7 RID: 711
	public interface IBufferedCipher
	{
		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001F77 RID: 8055
		string AlgorithmName { get; }

		// Token: 0x06001F78 RID: 8056
		void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x06001F79 RID: 8057
		int GetBlockSize();

		// Token: 0x06001F7A RID: 8058
		int GetOutputSize(int inputLen);

		// Token: 0x06001F7B RID: 8059
		int GetUpdateOutputSize(int inputLen);

		// Token: 0x06001F7C RID: 8060
		byte[] ProcessByte(byte input);

		// Token: 0x06001F7D RID: 8061
		int ProcessByte(byte input, byte[] output, int outOff);

		// Token: 0x06001F7E RID: 8062
		byte[] ProcessBytes(byte[] input);

		// Token: 0x06001F7F RID: 8063
		byte[] ProcessBytes(byte[] input, int inOff, int length);

		// Token: 0x06001F80 RID: 8064
		int ProcessBytes(byte[] input, byte[] output, int outOff);

		// Token: 0x06001F81 RID: 8065
		int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff);

		// Token: 0x06001F82 RID: 8066
		byte[] DoFinal();

		// Token: 0x06001F83 RID: 8067
		byte[] DoFinal(byte[] input);

		// Token: 0x06001F84 RID: 8068
		byte[] DoFinal(byte[] input, int inOff, int length);

		// Token: 0x06001F85 RID: 8069
		int DoFinal(byte[] output, int outOff);

		// Token: 0x06001F86 RID: 8070
		int DoFinal(byte[] input, byte[] output, int outOff);

		// Token: 0x06001F87 RID: 8071
		int DoFinal(byte[] input, int inOff, int length, byte[] output, int outOff);

		// Token: 0x06001F88 RID: 8072
		void Reset();
	}
}
