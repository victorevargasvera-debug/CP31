using System;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.BinaryRC4
{
	// Token: 0x0200031C RID: 796
	public class BinaryRC4EncryptionInfoBuilder : global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder
	{
		// Token: 0x0600170B RID: 5899 RVA: 0x00044AB4 File Offset: 0x00042CB4
		public void Initialize(global::NPOI.POIFS.Crypt.EncryptionInfo info, global::NPOI.Util.ILittleEndianInput dis)
		{
			this.info = info;
			int versionMajor = info.VersionMajor;
			int versionMinor = info.VersionMinor;
			this.header = new global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionHeader();
			this.verifier = new global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionVerifier(dis);
			this.decryptor = new global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Decryptor(this);
			this.encryptor = new global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Encryptor(this);
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00044B05 File Offset: 0x00042D05
		public void Initialize(global::NPOI.POIFS.Crypt.EncryptionInfo info, global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode)
		{
			this.info = info;
			this.header = new global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionHeader();
			this.verifier = new global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionVerifier();
			this.decryptor = new global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Decryptor(this);
			this.encryptor = new global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Encryptor(this);
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x00044B3C File Offset: 0x00042D3C
		public global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionHeader GetHeader()
		{
			return this.header;
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00044B44 File Offset: 0x00042D44
		public global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionVerifier GetVerifier()
		{
			return this.verifier;
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x00044B4C File Offset: 0x00042D4C
		public global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Decryptor GetDecryptor()
		{
			return this.decryptor;
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00044B54 File Offset: 0x00042D54
		public global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Encryptor GetEncryptor()
		{
			return this.encryptor;
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00044B5C File Offset: 0x00042D5C
		public global::NPOI.POIFS.Crypt.EncryptionInfo GetEncryptionInfo()
		{
			return this.info;
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00044B64 File Offset: 0x00042D64
		global::NPOI.POIFS.Crypt.EncryptionHeader global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetHeader()
		{
			return this.GetHeader();
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00044B6C File Offset: 0x00042D6C
		global::NPOI.POIFS.Crypt.EncryptionVerifier global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetVerifier()
		{
			return this.GetVerifier();
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00044B74 File Offset: 0x00042D74
		global::NPOI.POIFS.Crypt.Decryptor global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetDecryptor()
		{
			return this.GetDecryptor();
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x00044B7C File Offset: 0x00042D7C
		global::NPOI.POIFS.Crypt.Encryptor global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder.GetEncryptor()
		{
			return this.GetEncryptor();
		}

		// Token: 0x0400096B RID: 2411
		private global::NPOI.POIFS.Crypt.EncryptionInfo info;

		// Token: 0x0400096C RID: 2412
		private global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionHeader header;

		// Token: 0x0400096D RID: 2413
		private global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionVerifier verifier;

		// Token: 0x0400096E RID: 2414
		private global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Decryptor decryptor;

		// Token: 0x0400096F RID: 2415
		private global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Encryptor encryptor;
	}
}
