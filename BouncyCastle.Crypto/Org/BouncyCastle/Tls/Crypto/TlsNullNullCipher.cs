using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x0200014F RID: 335
	public sealed class TlsNullNullCipher : global::Org.BouncyCastle.Tls.Crypto.TlsCipher
	{
		// Token: 0x06000D46 RID: 3398 RVA: 0x00032521 File Offset: 0x00030721
		public int GetCiphertextDecodeLimit(int plaintextLimit)
		{
			return plaintextLimit;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00032524 File Offset: 0x00030724
		public int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
		{
			return plaintextLength;
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00032527 File Offset: 0x00030727
		public int GetPlaintextLimit(int ciphertextLimit)
		{
			return ciphertextLimit;
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x0003252C File Offset: 0x0003072C
		public global::Org.BouncyCastle.Tls.Crypto.TlsEncodeResult EncodePlaintext(long seqNo, short contentType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len)
		{
			byte[] result = new byte[headerAllocation + len];
			global::System.Array.Copy(plaintext, offset, result, headerAllocation, len);
			return new global::Org.BouncyCastle.Tls.Crypto.TlsEncodeResult(result, 0, result.Length, contentType);
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x0003255D File Offset: 0x0003075D
		public global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len)
		{
			return new global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult(ciphertext, offset, len, recordType);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x0003256B File Offset: 0x0003076B
		public void RekeyDecoder()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00032574 File Offset: 0x00030774
		public void RekeyEncoder()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x0003257D File Offset: 0x0003077D
		public bool UsesOpaqueRecordType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040007D4 RID: 2004
		public static readonly global::Org.BouncyCastle.Tls.Crypto.TlsNullNullCipher Instance = new global::Org.BouncyCastle.Tls.Crypto.TlsNullNullCipher();
	}
}
