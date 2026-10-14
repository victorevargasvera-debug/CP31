using System;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.Standard
{
	// Token: 0x02000312 RID: 786
	public class StandardEncryptionVerifier : global::NPOI.POIFS.Crypt.EncryptionVerifier, global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
	{
		// Token: 0x060016CA RID: 5834 RVA: 0x000439CC File Offset: 0x00041BCC
		internal StandardEncryptionVerifier(global::NPOI.Util.ILittleEndianInput is1, global::NPOI.POIFS.Crypt.Standard.StandardEncryptionHeader header)
		{
			if (is1.ReadInt() != 16)
			{
				throw new global::System.Exception("Salt size != 16 !?");
			}
			byte[] array = new byte[16];
			is1.ReadFully(array);
			this.SetSalt(array);
			byte[] array2 = new byte[16];
			is1.ReadFully(array2);
			this.SetEncryptedVerifier(array2);
			this.verifierHashSize = is1.ReadInt();
			byte[] array3 = new byte[header.CipherAlgorithm.encryptedVerifierHashLength];
			is1.ReadFully(array3);
			this.SetEncryptedVerifierHash(array3);
			base.SpinCount = global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier.SPIN_COUNT;
			base.CipherAlgorithm = header.CipherAlgorithm;
			base.ChainingMode = header.ChainingMode;
			base.EncryptedKey = null;
			base.HashAlgorithm = header.HashAlgorithm;
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x00043A81 File Offset: 0x00041C81
		protected internal StandardEncryptionVerifier(global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode)
		{
			base.CipherAlgorithm = cipherAlgorithm;
			base.HashAlgorithm = hashAlgorithm;
			base.ChainingMode = chainingMode;
			base.SpinCount = global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier.SPIN_COUNT;
			this.verifierHashSize = hashAlgorithm.hashSize;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x00043AB6 File Offset: 0x00041CB6
		protected internal void SetSalt(byte[] salt)
		{
			if (salt == null || salt.Length != 16)
			{
				throw new global::NPOI.EncryptedDocumentException("invalid verifier salt");
			}
			base.Salt = salt;
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00043AD4 File Offset: 0x00041CD4
		protected internal void SetEncryptedVerifier(byte[] encryptedVerifier)
		{
			base.EncryptedVerifier = encryptedVerifier;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00043ADD File Offset: 0x00041CDD
		protected internal void SetEncryptedVerifierHash(byte[] encryptedVerifierHash)
		{
			base.EncryptedVerifierHash = encryptedVerifierHash;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x00043AE8 File Offset: 0x00041CE8
		public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream bos)
		{
			byte[] salt = base.Salt;
			bos.WriteInt(salt.Length);
			bos.Write(salt);
			byte[] encryptedVerifier = base.EncryptedVerifier;
			bos.Write(encryptedVerifier);
			bos.WriteInt(20);
			byte[] encryptedVerifierHash = base.EncryptedVerifierHash;
			bos.Write(encryptedVerifierHash);
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00043B30 File Offset: 0x00041D30
		protected int GetVerifierHashSize()
		{
			return this.verifierHashSize;
		}

		// Token: 0x0400095B RID: 2395
		private static int SPIN_COUNT = 50000;

		// Token: 0x0400095C RID: 2396
		private int verifierHashSize;
	}
}
