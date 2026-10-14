using System;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.CryptoAPI
{
	// Token: 0x02000317 RID: 791
	public class CryptoAPIEncryptionInfoBuilder : global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder
	{
		// Token: 0x060016EB RID: 5867 RVA: 0x000442D8 File Offset: 0x000424D8
		public void Initialize(global::NPOI.POIFS.Crypt.EncryptionInfo info, global::NPOI.Util.ILittleEndianInput dis)
		{
			this.info = info;
			dis.ReadInt();
			this.header = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionHeader(dis);
			this.verifier = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionVerifier(dis, this.header);
			this.decryptor = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor(this);
			this.encryptor = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptor(this);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x0004432C File Offset: 0x0004252C
		public void Initialize(global::NPOI.POIFS.Crypt.EncryptionInfo info, global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode)
		{
			this.info = info;
			if (cipherAlgorithm == null)
			{
				cipherAlgorithm = global::NPOI.POIFS.Crypt.CipherAlgorithm.rc4;
			}
			if (hashAlgorithm == null)
			{
				hashAlgorithm = global::NPOI.POIFS.Crypt.HashAlgorithm.sha1;
			}
			if (keyBits == -1)
			{
				keyBits = 40;
			}
			this.header = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionHeader(cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode);
			this.verifier = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionVerifier(cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode);
			this.decryptor = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor(this);
			this.encryptor = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptor(this);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x0004439B File Offset: 0x0004259B
		public global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionHeader GetHeader()
		{
			return this.header;
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x000443A3 File Offset: 0x000425A3
		public global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionVerifier GetVerifier()
		{
			return this.verifier;
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x000443AB File Offset: 0x000425AB
		public global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor GetDecryptor()
		{
			return this.decryptor;
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x000443B3 File Offset: 0x000425B3
		public global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptor GetEncryptor()
		{
			return this.encryptor;
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x000443BB File Offset: 0x000425BB
		public global::NPOI.POIFS.Crypt.EncryptionInfo GetEncryptionInfo()
		{
			return this.info;
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x000443C3 File Offset: 0x000425C3
		global::NPOI.POIFS.Crypt.EncryptionHeader global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetHeader()
		{
			return this.GetHeader();
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x000443CB File Offset: 0x000425CB
		global::NPOI.POIFS.Crypt.EncryptionVerifier global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetVerifier()
		{
			return this.GetVerifier();
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x000443D3 File Offset: 0x000425D3
		global::NPOI.POIFS.Crypt.Decryptor global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetDecryptor()
		{
			return this.GetDecryptor();
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x000443DB File Offset: 0x000425DB
		global::NPOI.POIFS.Crypt.Encryptor global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetEncryptor()
		{
			return this.GetEncryptor();
		}

		// Token: 0x04000964 RID: 2404
		private global::NPOI.POIFS.Crypt.EncryptionInfo info;

		// Token: 0x04000965 RID: 2405
		private global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionHeader header;

		// Token: 0x04000966 RID: 2406
		private global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionVerifier verifier;

		// Token: 0x04000967 RID: 2407
		private global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor decryptor;

		// Token: 0x04000968 RID: 2408
		private global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptor encryptor;
	}
}
