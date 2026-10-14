using System;
using NPOI.POIFS.Crypt.Standard;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.CryptoAPI
{
	// Token: 0x02000316 RID: 790
	public class CryptoAPIEncryptionHeader : global::NPOI.POIFS.Crypt.Standard.StandardEncryptionHeader
	{
		// Token: 0x060016E7 RID: 5863 RVA: 0x00044234 File Offset: 0x00042434
		public CryptoAPIEncryptionHeader(global::NPOI.Util.ILittleEndianInput is1) : base(is1)
		{
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x0004423D File Offset: 0x0004243D
		protected internal CryptoAPIEncryptionHeader(global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode) : base(cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode)
		{
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x0004424C File Offset: 0x0004244C
		public void SetKeySize(int keyBits)
		{
			bool flag = false;
			int[] allowedKeySize = base.CipherAlgorithm.allowedKeySize;
			for (int i = 0; i < allowedKeySize.Length; i++)
			{
				if (allowedKeySize[i] == keyBits)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				string str = "invalid keysize ";
				string str2 = keyBits.ToString();
				string str3 = " for cipher algorithm ";
				global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm = base.CipherAlgorithm;
				throw new global::NPOI.EncryptedDocumentException(str + str2 + str3 + ((cipherAlgorithm != null) ? cipherAlgorithm.ToString() : null));
			}
			base.KeySize = keyBits;
			if (keyBits > 40)
			{
				base.CspName = "Microsoft Enhanced Cryptographic Provider v1.0";
				return;
			}
			base.CspName = global::NPOI.POIFS.Crypt.CipherProvider.rc4.cipherProviderName;
		}
	}
}
