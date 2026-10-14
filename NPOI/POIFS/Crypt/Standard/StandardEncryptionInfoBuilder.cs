using System;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.Standard
{
	// Token: 0x02000311 RID: 785
	public class StandardEncryptionInfoBuilder : global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder
	{
		// Token: 0x060016BE RID: 5822 RVA: 0x00043804 File Offset: 0x00041A04
		public void Initialize(global::NPOI.POIFS.Crypt.EncryptionInfo info, global::NPOI.Util.ILittleEndianInput dis)
		{
			this.info = info;
			dis.ReadInt();
			this.header = new global::NPOI.POIFS.Crypt.Standard.StandardEncryptionHeader(dis);
			this.verifier = new global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier(dis, this.header);
			if (info.VersionMinor == 2 && (info.VersionMajor == 3 || info.VersionMajor == 4))
			{
				this.decryptor = new global::NPOI.POIFS.Crypt.Standard.StandardDecryptor(this);
			}
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00043864 File Offset: 0x00041A64
		public void Initialize(global::NPOI.POIFS.Crypt.EncryptionInfo info, global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode)
		{
			this.info = info;
			if (cipherAlgorithm == null)
			{
				cipherAlgorithm = global::NPOI.POIFS.Crypt.CipherAlgorithm.aes128;
			}
			if (cipherAlgorithm != global::NPOI.POIFS.Crypt.CipherAlgorithm.aes128 && cipherAlgorithm != global::NPOI.POIFS.Crypt.CipherAlgorithm.aes192 && cipherAlgorithm != global::NPOI.POIFS.Crypt.CipherAlgorithm.aes256)
			{
				throw new global::NPOI.EncryptedDocumentException("Standard encryption only supports AES128/192/256.");
			}
			if (hashAlgorithm == null)
			{
				hashAlgorithm = global::NPOI.POIFS.Crypt.HashAlgorithm.sha1;
			}
			if (hashAlgorithm != global::NPOI.POIFS.Crypt.HashAlgorithm.sha1)
			{
				throw new global::NPOI.EncryptedDocumentException("Standard encryption only supports SHA-1.");
			}
			if (chainingMode == null)
			{
				chainingMode = global::NPOI.POIFS.Crypt.ChainingMode.ecb;
			}
			if (chainingMode != global::NPOI.POIFS.Crypt.ChainingMode.ecb)
			{
				throw new global::NPOI.EncryptedDocumentException("Standard encryption only supports ECB chaining.");
			}
			if (keyBits == -1)
			{
				keyBits = cipherAlgorithm.defaultKeySize;
			}
			if (blockSize == -1)
			{
				blockSize = cipherAlgorithm.blockSize;
			}
			bool flag = false;
			foreach (int num in cipherAlgorithm.allowedKeySize)
			{
				flag |= (num == keyBits);
			}
			if (!flag)
			{
				throw new global::NPOI.EncryptedDocumentException("KeySize " + keyBits.ToString() + " not allowed for Cipher " + cipherAlgorithm.ToString());
			}
			this.header = new global::NPOI.POIFS.Crypt.Standard.StandardEncryptionHeader(cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode);
			this.verifier = new global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier(cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode);
			this.decryptor = new global::NPOI.POIFS.Crypt.Standard.StandardDecryptor(this);
			this.encryptor = new global::NPOI.POIFS.Crypt.Standard.StandardEncryptor(this);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00043981 File Offset: 0x00041B81
		public global::NPOI.POIFS.Crypt.Standard.StandardEncryptionHeader GetHeader()
		{
			return this.header;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00043989 File Offset: 0x00041B89
		public global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier GetVerifier()
		{
			return this.verifier;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00043991 File Offset: 0x00041B91
		public global::NPOI.POIFS.Crypt.Standard.StandardDecryptor GetDecryptor()
		{
			return this.decryptor;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x00043999 File Offset: 0x00041B99
		public global::NPOI.POIFS.Crypt.Standard.StandardEncryptor GetEncryptor()
		{
			return this.encryptor;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000439A1 File Offset: 0x00041BA1
		public global::NPOI.POIFS.Crypt.EncryptionInfo GetEncryptionInfo()
		{
			return this.info;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000439A9 File Offset: 0x00041BA9
		global::NPOI.POIFS.Crypt.EncryptionHeader global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetHeader()
		{
			return this.GetHeader();
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000439B1 File Offset: 0x00041BB1
		global::NPOI.POIFS.Crypt.EncryptionVerifier global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetVerifier()
		{
			return this.GetVerifier();
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000439B9 File Offset: 0x00041BB9
		global::NPOI.POIFS.Crypt.Decryptor global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetDecryptor()
		{
			return this.GetDecryptor();
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x000439C1 File Offset: 0x00041BC1
		global::NPOI.POIFS.Crypt.Encryptor global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetEncryptor()
		{
			return this.GetEncryptor();
		}

		// Token: 0x04000956 RID: 2390
		private global::NPOI.POIFS.Crypt.EncryptionInfo info;

		// Token: 0x04000957 RID: 2391
		private global::NPOI.POIFS.Crypt.Standard.StandardEncryptionHeader header;

		// Token: 0x04000958 RID: 2392
		private global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier verifier;

		// Token: 0x04000959 RID: 2393
		private global::NPOI.POIFS.Crypt.Standard.StandardDecryptor decryptor;

		// Token: 0x0400095A RID: 2394
		private global::NPOI.POIFS.Crypt.Standard.StandardEncryptor encryptor;
	}
}
