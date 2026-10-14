using System;
using NPOI.Util;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x02000302 RID: 770
	public interface IEncryptionInfoBuilder
	{
		// Token: 0x06001653 RID: 5715
		void Initialize(global::NPOI.POIFS.Crypt.EncryptionInfo ei, global::NPOI.Util.ILittleEndianInput dis);

		// Token: 0x06001654 RID: 5716
		void Initialize(global::NPOI.POIFS.Crypt.EncryptionInfo ei, global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode);

		// Token: 0x06001655 RID: 5717
		global::NPOI.POIFS.Crypt.EncryptionHeader GetHeader();

		// Token: 0x06001656 RID: 5718
		global::NPOI.POIFS.Crypt.EncryptionVerifier GetVerifier();

		// Token: 0x06001657 RID: 5719
		global::NPOI.POIFS.Crypt.Decryptor GetDecryptor();

		// Token: 0x06001658 RID: 5720
		global::NPOI.POIFS.Crypt.Encryptor GetEncryptor();
	}
}
