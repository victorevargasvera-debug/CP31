using System;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x02000303 RID: 771
	public class EncryptionMode
	{
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x00042AF5 File Offset: 0x00040CF5
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x00042AFD File Offset: 0x00040CFD
		public string Builder { get; private set; }

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x00042B06 File Offset: 0x00040D06
		// (set) Token: 0x0600165C RID: 5724 RVA: 0x00042B0E File Offset: 0x00040D0E
		public int VersionMajor { get; private set; }

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x00042B17 File Offset: 0x00040D17
		// (set) Token: 0x0600165E RID: 5726 RVA: 0x00042B1F File Offset: 0x00040D1F
		public int VersionMinor { get; private set; }

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x00042B28 File Offset: 0x00040D28
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x00042B30 File Offset: 0x00040D30
		public int EncryptionFlags { get; private set; }

		// Token: 0x06001661 RID: 5729 RVA: 0x00042B39 File Offset: 0x00040D39
		public EncryptionMode(string builder, int versionMajor, int versionMinor, int encryptionFlags)
		{
			this.Builder = builder;
			this.VersionMajor = versionMajor;
			this.VersionMinor = versionMinor;
			this.EncryptionFlags = encryptionFlags;
		}

		// Token: 0x04000920 RID: 2336
		public static readonly global::NPOI.POIFS.Crypt.EncryptionMode BinaryRC4 = new global::NPOI.POIFS.Crypt.EncryptionMode("NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionInfoBuilder", 1, 1, 0);

		// Token: 0x04000921 RID: 2337
		public static readonly global::NPOI.POIFS.Crypt.EncryptionMode CryptoAPI = new global::NPOI.POIFS.Crypt.EncryptionMode("NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionInfoBuilder", 4, 2, 4);

		// Token: 0x04000922 RID: 2338
		public static readonly global::NPOI.POIFS.Crypt.EncryptionMode Standard = new global::NPOI.POIFS.Crypt.EncryptionMode("NPOI.POIFS.Crypt.Standard.StandardEncryptionInfoBuilder", 4, 2, 36);

		// Token: 0x04000923 RID: 2339
		public static readonly global::NPOI.POIFS.Crypt.EncryptionMode Agile = new global::NPOI.POIFS.Crypt.EncryptionMode("NPOI.POIFS.Crypt.Agile.AgileEncryptionInfoBuilder", 4, 4, 64);
	}
}
