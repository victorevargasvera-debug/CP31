using System;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002F6 RID: 758
	public class CipherAlgorithm
	{
		// Token: 0x060015D9 RID: 5593 RVA: 0x000412C8 File Offset: 0x0003F4C8
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm ValueOf(string alg)
		{
			string text = alg.ToLower();
			uint num = global::<PrivateImplementationDetails>.ComputeStringHash(text);
			if (num <= 1963187522U)
			{
				if (num <= 1392686224U)
				{
					if (num != 1104969097U)
					{
						if (num == 1392686224U)
						{
							if (text == "des3")
							{
								return global::NPOI.POIFS.Crypt.CipherAlgorithm.des3;
							}
						}
					}
					else if (text == "rsa")
					{
						return global::NPOI.POIFS.Crypt.CipherAlgorithm.rsa;
					}
				}
				else if (num != 1862521808U)
				{
					if (num == 1963187522U)
					{
						if (text == "rc4")
						{
							return global::NPOI.POIFS.Crypt.CipherAlgorithm.rc4;
						}
					}
				}
				else if (text == "rc2")
				{
					return global::NPOI.POIFS.Crypt.CipherAlgorithm.rc2;
				}
			}
			else if (num <= 2158592553U)
			{
				if (num != 2090349244U)
				{
					if (num == 2158592553U)
					{
						if (text == "aes128")
						{
							return global::NPOI.POIFS.Crypt.CipherAlgorithm.aes128;
						}
					}
				}
				else if (text == "aes192")
				{
					return global::NPOI.POIFS.Crypt.CipherAlgorithm.aes192;
				}
			}
			else if (num != 3529085699U)
			{
				if (num != 3577660903U)
				{
					if (num == 3900422261U)
					{
						if (text == "aes256")
						{
							return global::NPOI.POIFS.Crypt.CipherAlgorithm.aes256;
						}
					}
				}
				else if (text == "des3_112")
				{
					return global::NPOI.POIFS.Crypt.CipherAlgorithm.des3_112;
				}
			}
			else if (text == "des")
			{
				return global::NPOI.POIFS.Crypt.CipherAlgorithm.des;
			}
			throw new global::System.ArgumentException(string.Format("not found definition of cipher algorithm {0}", alg));
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x0004143C File Offset: 0x0003F63C
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00041444 File Offset: 0x0003F644
		public CipherAlgorithm(global::NPOI.POIFS.Crypt.CipherProvider provider, string jceId, int ecmaId, int defaultKeySize, int[] allowedKeySize, int blockSize, int encryptedVerifierHashLength, string xmlId, bool needsBouncyCastle)
		{
			this.provider = provider;
			this.jceId = jceId;
			this.ecmaId = ecmaId;
			this.defaultKeySize = defaultKeySize;
			this.allowedKeySize = (int[])allowedKeySize.Clone();
			this.blockSize = blockSize;
			this.encryptedVerifierHashLength = encryptedVerifierHashLength;
			this.xmlId = xmlId;
			this.needsBouncyCastle = needsBouncyCastle;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000414A8 File Offset: 0x0003F6A8
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm FromEcmaId(int ecmaId)
		{
			foreach (global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm in global::NPOI.POIFS.Crypt.CipherAlgorithm.Values)
			{
				if (cipherAlgorithm.ecmaId == ecmaId)
				{
					return cipherAlgorithm;
				}
			}
			throw new global::NPOI.EncryptedDocumentException("cipher algorithm " + ecmaId.ToString() + " not found");
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x000414F4 File Offset: 0x0003F6F4
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm FromXmlId(string xmlId, int keySize)
		{
			foreach (global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm in global::NPOI.POIFS.Crypt.CipherAlgorithm.Values)
			{
				if (cipherAlgorithm.xmlId.Equals(xmlId))
				{
					int[] array = cipherAlgorithm.allowedKeySize;
					for (int j = 0; j < array.Length; j++)
					{
						if (array[j] == keySize)
						{
							return cipherAlgorithm;
						}
					}
				}
			}
			throw new global::NPOI.EncryptedDocumentException(string.Concat(new string[]
			{
				"cipher algorithm ",
				xmlId,
				"/",
				keySize.ToString(),
				" not found"
			}));
		}

		// Token: 0x040008D4 RID: 2260
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm rc4 = new global::NPOI.POIFS.Crypt.CipherAlgorithm(global::NPOI.POIFS.Crypt.CipherProvider.rc4, "RC4", 26625, 64, new int[]
		{
			40,
			48,
			56,
			64,
			72,
			80,
			88,
			96,
			104,
			112,
			120,
			128
		}, -1, 20, "RC4", false)
		{
			name = "rc4"
		};

		// Token: 0x040008D5 RID: 2261
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm aes128 = new global::NPOI.POIFS.Crypt.CipherAlgorithm(global::NPOI.POIFS.Crypt.CipherProvider.aes, "AES", 26126, 128, new int[]
		{
			128
		}, 16, 32, "AES", false)
		{
			name = "aes128"
		};

		// Token: 0x040008D6 RID: 2262
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm aes192 = new global::NPOI.POIFS.Crypt.CipherAlgorithm(global::NPOI.POIFS.Crypt.CipherProvider.aes, "AES", 26127, 192, new int[]
		{
			192
		}, 16, 32, "AES", false)
		{
			name = "aes192"
		};

		// Token: 0x040008D7 RID: 2263
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm aes256 = new global::NPOI.POIFS.Crypt.CipherAlgorithm(global::NPOI.POIFS.Crypt.CipherProvider.aes, "AES", 26128, 256, new int[]
		{
			256
		}, 16, 32, "AES", false)
		{
			name = "aes256"
		};

		// Token: 0x040008D8 RID: 2264
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm rc2 = new global::NPOI.POIFS.Crypt.CipherAlgorithm(null, "RC2", -1, 128, new int[]
		{
			40,
			48,
			56,
			64,
			72,
			80,
			88,
			96,
			104,
			112,
			120,
			128
		}, 8, 20, "RC2", false)
		{
			name = "rc2"
		};

		// Token: 0x040008D9 RID: 2265
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm des = new global::NPOI.POIFS.Crypt.CipherAlgorithm(null, "DES", -1, 64, new int[]
		{
			64
		}, 8, 32, "DES", false)
		{
			name = "des"
		};

		// Token: 0x040008DA RID: 2266
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm des3 = new global::NPOI.POIFS.Crypt.CipherAlgorithm(null, "DESede", -1, 192, new int[]
		{
			192
		}, 8, 32, "3DES", false)
		{
			name = "des3"
		};

		// Token: 0x040008DB RID: 2267
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm des3_112 = new global::NPOI.POIFS.Crypt.CipherAlgorithm(null, "DESede", -1, 128, new int[]
		{
			128
		}, 8, 32, "3DES_112", true)
		{
			name = "des3_112"
		};

		// Token: 0x040008DC RID: 2268
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm rsa = new global::NPOI.POIFS.Crypt.CipherAlgorithm(null, "RSA", -1, 1024, new int[]
		{
			1024,
			2048,
			3072,
			4096
		}, -1, -1, "", false)
		{
			name = "rsa"
		};

		// Token: 0x040008DD RID: 2269
		public static global::NPOI.POIFS.Crypt.CipherAlgorithm[] Values = new global::NPOI.POIFS.Crypt.CipherAlgorithm[]
		{
			global::NPOI.POIFS.Crypt.CipherAlgorithm.rc4,
			global::NPOI.POIFS.Crypt.CipherAlgorithm.aes128,
			global::NPOI.POIFS.Crypt.CipherAlgorithm.aes192,
			global::NPOI.POIFS.Crypt.CipherAlgorithm.aes256,
			global::NPOI.POIFS.Crypt.CipherAlgorithm.rc2,
			global::NPOI.POIFS.Crypt.CipherAlgorithm.des,
			global::NPOI.POIFS.Crypt.CipherAlgorithm.des3,
			global::NPOI.POIFS.Crypt.CipherAlgorithm.des3_112,
			global::NPOI.POIFS.Crypt.CipherAlgorithm.rsa
		};

		// Token: 0x040008DE RID: 2270
		public global::NPOI.POIFS.Crypt.CipherProvider provider;

		// Token: 0x040008DF RID: 2271
		public string jceId;

		// Token: 0x040008E0 RID: 2272
		public int ecmaId;

		// Token: 0x040008E1 RID: 2273
		public int defaultKeySize;

		// Token: 0x040008E2 RID: 2274
		public int[] allowedKeySize;

		// Token: 0x040008E3 RID: 2275
		public int blockSize;

		// Token: 0x040008E4 RID: 2276
		public int encryptedVerifierHashLength;

		// Token: 0x040008E5 RID: 2277
		public string xmlId;

		// Token: 0x040008E6 RID: 2278
		public bool needsBouncyCastle;

		// Token: 0x040008E7 RID: 2279
		private string name;
	}
}
