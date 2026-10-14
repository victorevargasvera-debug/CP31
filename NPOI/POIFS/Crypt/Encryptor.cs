using System;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x02000308 RID: 776
	public abstract class Encryptor
	{
		// Token: 0x0600167C RID: 5756
		public abstract global::NPOI.Util.OutputStream GetDataStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir);

		// Token: 0x0600167D RID: 5757
		public abstract void ConfirmPassword(string password, byte[] keySpec, byte[] keySalt, byte[] verifier, byte[] verifierSalt, byte[] integritySalt);

		// Token: 0x0600167E RID: 5758
		public abstract void ConfirmPassword(string password);

		// Token: 0x0600167F RID: 5759 RVA: 0x00042C76 File Offset: 0x00040E76
		public static global::NPOI.POIFS.Crypt.Encryptor GetInstance(global::NPOI.POIFS.Crypt.EncryptionInfo info)
		{
			return info.Encryptor;
		}

		// Token: 0x06001680 RID: 5760 RVA: 0x00042C7E File Offset: 0x00040E7E
		public global::NPOI.Util.OutputStream GetDataStream(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs)
		{
			return this.GetDataStream(fs.Root);
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00042C8C File Offset: 0x00040E8C
		public global::NPOI.Util.OutputStream GetDataStream(global::NPOI.POIFS.FileSystem.OPOIFSFileSystem fs)
		{
			return this.GetDataStream(fs.Root);
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00042C7E File Offset: 0x00040E7E
		public global::NPOI.Util.OutputStream GetDataStream(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs)
		{
			return this.GetDataStream(fs.Root);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00042C9A File Offset: 0x00040E9A
		public global::NPOI.POIFS.Crypt.ISecretKey GetSecretKey()
		{
			return this.secretKey;
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00042CA2 File Offset: 0x00040EA2
		protected void SetSecretKey(global::NPOI.POIFS.Crypt.ISecretKey secretKey)
		{
			this.secretKey = secretKey;
		}

		// Token: 0x04000937 RID: 2359
		internal static string DEFAULT_POIFS_ENTRY = global::NPOI.POIFS.Crypt.Decryptor.DEFAULT_POIFS_ENTRY;

		// Token: 0x04000938 RID: 2360
		private global::NPOI.POIFS.Crypt.ISecretKey secretKey;
	}
}
