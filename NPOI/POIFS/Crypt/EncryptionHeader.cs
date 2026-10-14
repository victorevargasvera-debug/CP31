using System;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x02000300 RID: 768
	public abstract class EncryptionHeader
	{
		// Token: 0x06001624 RID: 5668 RVA: 0x00042506 File Offset: 0x00040706
		[global::System.Obsolete("use ChainingMode.ecmaId", true)]
		public int GetCipherMode()
		{
			return this.ChainingMode.ecmaId;
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00042513 File Offset: 0x00040713
		// (set) Token: 0x06001626 RID: 5670 RVA: 0x0004251B File Offset: 0x0004071B
		public global::NPOI.POIFS.Crypt.ChainingMode ChainingMode { get; set; }

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00042524 File Offset: 0x00040724
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x0004252C File Offset: 0x0004072C
		public int Flags { get; set; }

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x00042535 File Offset: 0x00040735
		// (set) Token: 0x0600162A RID: 5674 RVA: 0x0004253D File Offset: 0x0004073D
		public int SizeExtra { get; set; }

		// Token: 0x0600162B RID: 5675 RVA: 0x00042546 File Offset: 0x00040746
		[global::System.Obsolete("use CipherAlgorithm")]
		public int GetAlgorithm()
		{
			return this.CipherAlgorithm.ecmaId;
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x00042553 File Offset: 0x00040753
		// (set) Token: 0x0600162D RID: 5677 RVA: 0x0004255B File Offset: 0x0004075B
		public global::NPOI.POIFS.Crypt.CipherAlgorithm CipherAlgorithm { get; set; }

		// Token: 0x0600162E RID: 5678 RVA: 0x00042564 File Offset: 0x00040764
		[global::System.Obsolete("use HashAlgorithmEx")]
		public int GetHashAlgorithm()
		{
			return this.HashAlgorithm.ecmaId;
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x00042571 File Offset: 0x00040771
		// (set) Token: 0x06001630 RID: 5680 RVA: 0x00042579 File Offset: 0x00040779
		public global::NPOI.POIFS.Crypt.HashAlgorithm HashAlgorithm { get; set; }

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x00042582 File Offset: 0x00040782
		// (set) Token: 0x06001632 RID: 5682 RVA: 0x0004258A File Offset: 0x0004078A
		public int KeySize { get; set; }

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x00042593 File Offset: 0x00040793
		// (set) Token: 0x06001634 RID: 5684 RVA: 0x0004259B File Offset: 0x0004079B
		public int BlockSize { get; set; }

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x000425A4 File Offset: 0x000407A4
		// (set) Token: 0x06001636 RID: 5686 RVA: 0x000425AC File Offset: 0x000407AC
		public byte[] KeySalt { get; set; }

		// Token: 0x06001637 RID: 5687 RVA: 0x000425B5 File Offset: 0x000407B5
		[global::System.Obsolete("use CipherProvider")]
		public int GetProviderType()
		{
			return this.CipherProvider.ecmaId;
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x000425C2 File Offset: 0x000407C2
		// (set) Token: 0x06001639 RID: 5689 RVA: 0x000425CA File Offset: 0x000407CA
		public global::NPOI.POIFS.Crypt.CipherProvider CipherProvider { get; set; }

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x000425D3 File Offset: 0x000407D3
		// (set) Token: 0x0600163B RID: 5691 RVA: 0x000425DB File Offset: 0x000407DB
		public string CspName { get; set; }

		// Token: 0x040008FD RID: 2301
		public static int ALGORITHM_RC4 = global::NPOI.POIFS.Crypt.CipherAlgorithm.rc4.ecmaId;

		// Token: 0x040008FE RID: 2302
		public static int ALGORITHM_AES_128 = global::NPOI.POIFS.Crypt.CipherAlgorithm.aes128.ecmaId;

		// Token: 0x040008FF RID: 2303
		public static int ALGORITHM_AES_192 = global::NPOI.POIFS.Crypt.CipherAlgorithm.aes192.ecmaId;

		// Token: 0x04000900 RID: 2304
		public static int ALGORITHM_AES_256 = global::NPOI.POIFS.Crypt.CipherAlgorithm.aes256.ecmaId;

		// Token: 0x04000901 RID: 2305
		public static int HASH_NONE = global::NPOI.POIFS.Crypt.HashAlgorithm.none.ecmaId;

		// Token: 0x04000902 RID: 2306
		public static int HASH_SHA1 = global::NPOI.POIFS.Crypt.HashAlgorithm.sha1.ecmaId;

		// Token: 0x04000903 RID: 2307
		public static int HASH_SHA256 = global::NPOI.POIFS.Crypt.HashAlgorithm.sha256.ecmaId;

		// Token: 0x04000904 RID: 2308
		public static int HASH_SHA384 = global::NPOI.POIFS.Crypt.HashAlgorithm.sha384.ecmaId;

		// Token: 0x04000905 RID: 2309
		public static int HASH_SHA512 = global::NPOI.POIFS.Crypt.HashAlgorithm.sha512.ecmaId;

		// Token: 0x04000906 RID: 2310
		public static int PROVIDER_RC4 = global::NPOI.POIFS.Crypt.CipherProvider.rc4.ecmaId;

		// Token: 0x04000907 RID: 2311
		public static int PROVIDER_AES = global::NPOI.POIFS.Crypt.CipherProvider.aes.ecmaId;

		// Token: 0x04000908 RID: 2312
		public static int MODE_ECB = global::NPOI.POIFS.Crypt.ChainingMode.ecb.ecmaId;

		// Token: 0x04000909 RID: 2313
		public static int MODE_CBC = global::NPOI.POIFS.Crypt.ChainingMode.cbc.ecmaId;

		// Token: 0x0400090A RID: 2314
		public static int MODE_CFB = global::NPOI.POIFS.Crypt.ChainingMode.cfb.ecmaId;
	}
}
