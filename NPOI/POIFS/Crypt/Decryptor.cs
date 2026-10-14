using System;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002FF RID: 767
	public abstract class Decryptor
	{
		// Token: 0x06001610 RID: 5648 RVA: 0x00042445 File Offset: 0x00040645
		protected Decryptor(global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder)
		{
			this.builder = builder;
		}

		// Token: 0x06001611 RID: 5649
		public abstract global::NPOI.Util.InputStream GetDataStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir);

		// Token: 0x06001612 RID: 5650
		public abstract bool VerifyPassword(string password);

		// Token: 0x06001613 RID: 5651
		public abstract long GetLength();

		// Token: 0x06001614 RID: 5652 RVA: 0x00042454 File Offset: 0x00040654
		public static global::NPOI.POIFS.Crypt.Decryptor GetInstance(global::NPOI.POIFS.Crypt.EncryptionInfo info)
		{
			global::NPOI.POIFS.Crypt.Decryptor decryptor = info.Decryptor;
			if (decryptor == null)
			{
				throw new global::NPOI.EncryptedDocumentException("Unsupported version");
			}
			return decryptor;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x0004246A File Offset: 0x0004066A
		public global::NPOI.Util.InputStream GetDataStream(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs)
		{
			return this.GetDataStream(fs.Root);
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x00042478 File Offset: 0x00040678
		public global::NPOI.Util.InputStream GetDataStream(global::NPOI.POIFS.FileSystem.OPOIFSFileSystem fs)
		{
			return this.GetDataStream(fs.Root);
		}

		// Token: 0x06001617 RID: 5655 RVA: 0x0004246A File Offset: 0x0004066A
		public global::NPOI.Util.InputStream GetDataStream(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs)
		{
			return this.GetDataStream(fs.Root);
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x00042486 File Offset: 0x00040686
		public byte[] GetVerifier()
		{
			return this.verifier;
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x0004248E File Offset: 0x0004068E
		public global::NPOI.POIFS.Crypt.ISecretKey GetSecretKey()
		{
			return this.secretKey;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x00042496 File Offset: 0x00040696
		public byte[] GetIntegrityHmacKey()
		{
			return this.integrityHmacKey;
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x0004249E File Offset: 0x0004069E
		public byte[] GetIntegrityHmacValue()
		{
			return this.integrityHmacValue;
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000424A6 File Offset: 0x000406A6
		protected void SetSecretKey(global::NPOI.POIFS.Crypt.ISecretKey secretKey)
		{
			this.secretKey = secretKey;
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000424AF File Offset: 0x000406AF
		protected void SetVerifier(byte[] verifier)
		{
			this.verifier = verifier;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000424B8 File Offset: 0x000406B8
		protected void SetIntegrityHmacKey(byte[] integrityHmacKey)
		{
			this.integrityHmacKey = integrityHmacKey;
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000424C1 File Offset: 0x000406C1
		protected void SetIntegrityHmacValue(byte[] integrityHmacValue)
		{
			this.integrityHmacValue = integrityHmacValue;
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000424CA File Offset: 0x000406CA
		protected int GetBlockSizeInBytes()
		{
			return this.builder.GetHeader().BlockSize;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x000424DC File Offset: 0x000406DC
		protected int GetKeySizeInBytes()
		{
			return this.builder.GetHeader().KeySize / 8;
		}

		// Token: 0x040008F6 RID: 2294
		public static string DEFAULT_PASSWORD = "VelvetSweatshop";

		// Token: 0x040008F7 RID: 2295
		public static string DEFAULT_POIFS_ENTRY = "EncryptedPackage";

		// Token: 0x040008F8 RID: 2296
		protected internal global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder;

		// Token: 0x040008F9 RID: 2297
		private global::NPOI.POIFS.Crypt.ISecretKey secretKey;

		// Token: 0x040008FA RID: 2298
		private byte[] verifier;

		// Token: 0x040008FB RID: 2299
		private byte[] integrityHmacKey;

		// Token: 0x040008FC RID: 2300
		private byte[] integrityHmacValue;
	}
}
