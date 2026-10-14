using System;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x0200043B RID: 1083
	public interface IAeadCipher
	{
		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x060029E2 RID: 10722
		string AlgorithmName { get; }

		// Token: 0x060029E3 RID: 10723
		void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x060029E4 RID: 10724
		void ProcessAadByte(byte input);

		// Token: 0x060029E5 RID: 10725
		void ProcessAadBytes(byte[] inBytes, int inOff, int len);

		// Token: 0x060029E6 RID: 10726
		int ProcessByte(byte input, byte[] outBytes, int outOff);

		// Token: 0x060029E7 RID: 10727
		int ProcessBytes(byte[] inBytes, int inOff, int len, byte[] outBytes, int outOff);

		// Token: 0x060029E8 RID: 10728
		int DoFinal(byte[] outBytes, int outOff);

		// Token: 0x060029E9 RID: 10729
		byte[] GetMac();

		// Token: 0x060029EA RID: 10730
		int GetUpdateOutputSize(int len);

		// Token: 0x060029EB RID: 10731
		int GetOutputSize(int len);

		// Token: 0x060029EC RID: 10732
		void Reset();
	}
}
