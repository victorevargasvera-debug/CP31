using System;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002F7 RID: 759
	public class CipherProvider
	{
		// Token: 0x060015DF RID: 5599 RVA: 0x00041800 File Offset: 0x0003FA00
		public static global::NPOI.POIFS.Crypt.CipherProvider FromEcmaId(int ecmaId)
		{
			foreach (global::NPOI.POIFS.Crypt.CipherProvider cipherProvider in global::NPOI.POIFS.Crypt.CipherProvider.Values)
			{
				if (cipherProvider.ecmaId == ecmaId)
				{
					return cipherProvider;
				}
			}
			throw new global::NPOI.EncryptedDocumentException("cipher provider not found");
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x0004183A File Offset: 0x0003FA3A
		// (set) Token: 0x060015E1 RID: 5601 RVA: 0x00041842 File Offset: 0x0003FA42
		public string jceId { get; set; }

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x0004184B File Offset: 0x0003FA4B
		// (set) Token: 0x060015E3 RID: 5603 RVA: 0x00041853 File Offset: 0x0003FA53
		public int ecmaId { get; set; }

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x0004185C File Offset: 0x0003FA5C
		// (set) Token: 0x060015E5 RID: 5605 RVA: 0x00041864 File Offset: 0x0003FA64
		public string cipherProviderName { get; set; }

		// Token: 0x060015E6 RID: 5606 RVA: 0x0004186D File Offset: 0x0003FA6D
		public CipherProvider(string jceId, int ecmaId, string cipherProviderName)
		{
			this.jceId = jceId;
			this.ecmaId = ecmaId;
			this.cipherProviderName = cipherProviderName;
		}

		// Token: 0x040008E8 RID: 2280
		public static readonly global::NPOI.POIFS.Crypt.CipherProvider rc4 = new global::NPOI.POIFS.Crypt.CipherProvider("RC4", 1, "Microsoft Base Cryptographic Provider v1.0");

		// Token: 0x040008E9 RID: 2281
		public static readonly global::NPOI.POIFS.Crypt.CipherProvider aes = new global::NPOI.POIFS.Crypt.CipherProvider("AES", 24, "Microsoft Enhanced RSA and AES Cryptographic Provider");

		// Token: 0x040008EA RID: 2282
		public static global::NPOI.POIFS.Crypt.CipherProvider[] Values = new global::NPOI.POIFS.Crypt.CipherProvider[]
		{
			global::NPOI.POIFS.Crypt.CipherProvider.rc4,
			global::NPOI.POIFS.Crypt.CipherProvider.aes
		};
	}
}
