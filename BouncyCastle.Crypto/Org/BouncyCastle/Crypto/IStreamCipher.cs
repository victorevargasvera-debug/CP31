using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002E1 RID: 737
	public interface IStreamCipher
	{
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001FCF RID: 8143
		string AlgorithmName { get; }

		// Token: 0x06001FD0 RID: 8144
		void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x06001FD1 RID: 8145
		byte ReturnByte(byte input);

		// Token: 0x06001FD2 RID: 8146
		void ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff);

		// Token: 0x06001FD3 RID: 8147
		void Reset();
	}
}
