using System;
using NPOI.POIFS.Crypt.Standard;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.CryptoAPI
{
	// Token: 0x02000318 RID: 792
	public class CryptoAPIEncryptionVerifier : global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier
	{
		// Token: 0x060016F6 RID: 5878 RVA: 0x000443E3 File Offset: 0x000425E3
		protected internal CryptoAPIEncryptionVerifier(global::NPOI.Util.ILittleEndianInput is1, global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionHeader header) : base(is1, header)
		{
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x000443ED File Offset: 0x000425ED
		protected internal CryptoAPIEncryptionVerifier(global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode) : base(cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode)
		{
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x000443FC File Offset: 0x000425FC
		protected new void SetSalt(byte[] salt)
		{
			base.SetSalt(salt);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00044405 File Offset: 0x00042605
		protected new void SetEncryptedVerifier(byte[] encryptedVerifier)
		{
			base.SetEncryptedVerifier(encryptedVerifier);
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x0004440E File Offset: 0x0004260E
		protected new void SetEncryptedVerifierHash(byte[] encryptedVerifierHash)
		{
			base.SetEncryptedVerifierHash(encryptedVerifierHash);
		}
	}
}
