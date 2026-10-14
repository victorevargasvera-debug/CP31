using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000359 RID: 857
	public interface TlsCipher
	{
		// Token: 0x060022FC RID: 8956
		int GetPlaintextLimit(int ciphertextLimit);

		// Token: 0x060022FD RID: 8957
		byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len);

		// Token: 0x060022FE RID: 8958
		byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len);
	}
}
