using System;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x02000309 RID: 777
	public class HashAlgorithm
	{
		// Token: 0x06001687 RID: 5767 RVA: 0x00042CB7 File Offset: 0x00040EB7
		public HashAlgorithm(string jceId, int ecmaId, string ecmaString, int hashSize, string jceHmacId, bool needsBouncyCastle)
		{
			this.jceId = jceId;
			this.ecmaId = ecmaId;
			this.ecmaString = ecmaString;
			this.hashSize = hashSize;
			this.jceHmacId = jceHmacId;
			this.needsBouncyCastle = needsBouncyCastle;
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00042CEC File Offset: 0x00040EEC
		public static global::NPOI.POIFS.Crypt.HashAlgorithm FromEcmaId(int ecmaId)
		{
			foreach (global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm in global::NPOI.POIFS.Crypt.HashAlgorithm.values)
			{
				if (hashAlgorithm.ecmaId == ecmaId)
				{
					return hashAlgorithm;
				}
			}
			throw new global::NPOI.EncryptedDocumentException("hash algorithm not found");
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00042D28 File Offset: 0x00040F28
		public static global::NPOI.POIFS.Crypt.HashAlgorithm FromEcmaId(string ecmaString)
		{
			foreach (global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm in global::NPOI.POIFS.Crypt.HashAlgorithm.values)
			{
				if (hashAlgorithm.ecmaString.Equals(ecmaString))
				{
					return hashAlgorithm;
				}
			}
			throw new global::NPOI.EncryptedDocumentException("hash algorithm not found");
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00042D68 File Offset: 0x00040F68
		public static global::NPOI.POIFS.Crypt.HashAlgorithm FromString(string string1)
		{
			foreach (global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm in global::NPOI.POIFS.Crypt.HashAlgorithm.values)
			{
				if (hashAlgorithm.ecmaString.Equals(string1, global::System.StringComparison.CurrentCultureIgnoreCase) || hashAlgorithm.jceId.Equals(string1, global::System.StringComparison.CurrentCultureIgnoreCase))
				{
					return hashAlgorithm;
				}
			}
			throw new global::NPOI.EncryptedDocumentException("hash algorithm not found");
		}

		// Token: 0x04000939 RID: 2361
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm none = new global::NPOI.POIFS.Crypt.HashAlgorithm("", 0, "", 0, "", false);

		// Token: 0x0400093A RID: 2362
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm sha1 = new global::NPOI.POIFS.Crypt.HashAlgorithm("SHA-1", 32772, "SHA1", 20, "HmacSHA1", false);

		// Token: 0x0400093B RID: 2363
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm sha256 = new global::NPOI.POIFS.Crypt.HashAlgorithm("SHA-256", 32780, "SHA256", 32, "HmacSHA256", false);

		// Token: 0x0400093C RID: 2364
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm sha384 = new global::NPOI.POIFS.Crypt.HashAlgorithm("SHA-384", 32781, "SHA384", 48, "HmacSHA384", false);

		// Token: 0x0400093D RID: 2365
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm sha512 = new global::NPOI.POIFS.Crypt.HashAlgorithm("SHA-512", 32782, "SHA512", 64, "HmacSHA512", false);

		// Token: 0x0400093E RID: 2366
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm md5 = new global::NPOI.POIFS.Crypt.HashAlgorithm("MD5", -1, "MD5", 16, "HmacMD5", false);

		// Token: 0x0400093F RID: 2367
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm md2 = new global::NPOI.POIFS.Crypt.HashAlgorithm("MD2", -1, "MD2", 16, "Hmac-MD2", true);

		// Token: 0x04000940 RID: 2368
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm md4 = new global::NPOI.POIFS.Crypt.HashAlgorithm("MD4", -1, "MD4", 16, "Hmac-MD4", true);

		// Token: 0x04000941 RID: 2369
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm ripemd128 = new global::NPOI.POIFS.Crypt.HashAlgorithm("RipeMD128", -1, "RIPEMD-128", 16, "HMac-RipeMD128", true);

		// Token: 0x04000942 RID: 2370
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm ripemd160 = new global::NPOI.POIFS.Crypt.HashAlgorithm("RipeMD160", -1, "RIPEMD-160", 20, "HMac-RipeMD160", true);

		// Token: 0x04000943 RID: 2371
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm whirlpool = new global::NPOI.POIFS.Crypt.HashAlgorithm("Whirlpool", -1, "WHIRLPOOL", 64, "HMac-Whirlpool", true);

		// Token: 0x04000944 RID: 2372
		public static readonly global::NPOI.POIFS.Crypt.HashAlgorithm sha224 = new global::NPOI.POIFS.Crypt.HashAlgorithm("SHA-224", -1, "SHA224", 28, "HmacSHA224", true);

		// Token: 0x04000945 RID: 2373
		public static global::NPOI.POIFS.Crypt.HashAlgorithm[] values = new global::NPOI.POIFS.Crypt.HashAlgorithm[]
		{
			global::NPOI.POIFS.Crypt.HashAlgorithm.none,
			global::NPOI.POIFS.Crypt.HashAlgorithm.sha1,
			global::NPOI.POIFS.Crypt.HashAlgorithm.sha256,
			global::NPOI.POIFS.Crypt.HashAlgorithm.sha384,
			global::NPOI.POIFS.Crypt.HashAlgorithm.sha512,
			global::NPOI.POIFS.Crypt.HashAlgorithm.md5,
			global::NPOI.POIFS.Crypt.HashAlgorithm.md4,
			global::NPOI.POIFS.Crypt.HashAlgorithm.md2,
			global::NPOI.POIFS.Crypt.HashAlgorithm.ripemd128,
			global::NPOI.POIFS.Crypt.HashAlgorithm.ripemd160,
			global::NPOI.POIFS.Crypt.HashAlgorithm.whirlpool,
			global::NPOI.POIFS.Crypt.HashAlgorithm.sha224
		};

		// Token: 0x04000946 RID: 2374
		public string jceId;

		// Token: 0x04000947 RID: 2375
		public int ecmaId;

		// Token: 0x04000948 RID: 2376
		public string ecmaString;

		// Token: 0x04000949 RID: 2377
		public int hashSize;

		// Token: 0x0400094A RID: 2378
		public string jceHmacId;

		// Token: 0x0400094B RID: 2379
		public bool needsBouncyCastle;
	}
}
