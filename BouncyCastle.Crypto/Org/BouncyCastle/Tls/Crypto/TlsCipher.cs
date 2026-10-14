using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x0200013D RID: 317
	public interface TlsCipher
	{
		// Token: 0x06000CF0 RID: 3312
		int GetCiphertextDecodeLimit(int plaintextLimit);

		// Token: 0x06000CF1 RID: 3313
		int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit);

		// Token: 0x06000CF2 RID: 3314
		int GetPlaintextLimit(int ciphertextLimit);

		// Token: 0x06000CF3 RID: 3315
		global::Org.BouncyCastle.Tls.Crypto.TlsEncodeResult EncodePlaintext(long seqNo, short contentType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len);

		// Token: 0x06000CF4 RID: 3316
		global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len);

		// Token: 0x06000CF5 RID: 3317
		void RekeyDecoder();

		// Token: 0x06000CF6 RID: 3318
		void RekeyEncoder();

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000CF7 RID: 3319
		bool UsesOpaqueRecordType { get; }
	}
}
