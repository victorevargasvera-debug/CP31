using System;
using System.Text;
using NPOI.Util;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002F8 RID: 760
	public class CryptoFunctions
	{
		// Token: 0x060015E8 RID: 5608 RVA: 0x000418DF File Offset: 0x0003FADF
		public static byte[] HashPassword(string password, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, byte[] salt, int spinCount)
		{
			return global::NPOI.POIFS.Crypt.CryptoFunctions.HashPassword(password, hashAlgorithm, salt, spinCount, true);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x000418EC File Offset: 0x0003FAEC
		public static byte[] HashPassword(string password, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, byte[] salt, int spinCount, bool iteratorFirst)
		{
			if (password == null)
			{
				password = global::NPOI.POIFS.Crypt.Decryptor.DEFAULT_PASSWORD;
			}
			global::NPOI.POIFS.Crypt.MessageDigest messageDigest = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(hashAlgorithm);
			messageDigest.Update(salt);
			byte[] array = messageDigest.Digest(global::NPOI.Util.StringUtil.GetToUnicodeLE(password));
			byte[] array2 = new byte[4];
			byte[] passwordHash = iteratorFirst ? array2 : array;
			byte[] passwordHash2 = iteratorFirst ? array : array2;
			try
			{
				for (int i = 0; i < spinCount; i++)
				{
					global::NPOI.Util.LittleEndian.PutInt(array2, 0, i);
					messageDigest.Reset();
					messageDigest.Update(passwordHash);
					messageDigest.Update(passwordHash2);
					messageDigest.Digest(array, 0, array.Length);
				}
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException("error in password hashing", cause);
			}
			return array;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00041994 File Offset: 0x0003FB94
		public static byte[] GenerateIv(global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, byte[] salt, byte[] blockKey, int blockSize)
		{
			byte[] hash = salt;
			if (blockKey != null)
			{
				global::NPOI.POIFS.Crypt.MessageDigest messageDigest = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(hashAlgorithm);
				messageDigest.Update(salt);
				hash = messageDigest.Digest(blockKey);
			}
			return global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock36(hash, blockSize);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x000419C1 File Offset: 0x0003FBC1
		public static byte[] GenerateKey(byte[] passwordHash, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, byte[] blockKey, int keySize)
		{
			global::NPOI.POIFS.Crypt.MessageDigest messageDigest = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(hashAlgorithm);
			messageDigest.Update(passwordHash);
			return global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock36(messageDigest.Digest(blockKey), keySize);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x000419DC File Offset: 0x0003FBDC
		public static global::NPOI.POIFS.Crypt.Cipher GetCipher(global::NPOI.POIFS.Crypt.ISecretKey key, global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.ChainingMode chain, byte[] vec, int cipherMode)
		{
			return global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(key, cipherAlgorithm, chain, vec, cipherMode, null);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000419EC File Offset: 0x0003FBEC
		public static global::NPOI.POIFS.Crypt.Cipher GetCipher(global::NPOI.POIFS.Crypt.IKey key, global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.ChainingMode chain, byte[] vec, int cipherMode, string padding)
		{
			int num = key.GetEncoded().Length;
			if (padding == null)
			{
				padding = "NoPadding";
			}
			global::NPOI.POIFS.Crypt.Cipher result;
			try
			{
				if (global::NPOI.POIFS.Crypt.Cipher.GetMaxAllowedKeyLength(cipherAlgorithm.jceId) < num * 8)
				{
					throw new global::NPOI.EncryptedDocumentException("Export Restrictions in place - please install JCE Unlimited Strength Jurisdiction Policy files");
				}
				global::NPOI.POIFS.Crypt.Cipher instance;
				if (cipherAlgorithm == global::NPOI.POIFS.Crypt.CipherAlgorithm.rc4)
				{
					instance = global::NPOI.POIFS.Crypt.Cipher.GetInstance(cipherAlgorithm.jceId);
				}
				else if (cipherAlgorithm.needsBouncyCastle)
				{
					global::NPOI.POIFS.Crypt.CryptoFunctions.registerBouncyCastle();
					instance = global::NPOI.POIFS.Crypt.Cipher.GetInstance(string.Concat(new string[]
					{
						cipherAlgorithm.jceId,
						"/",
						chain.jceId,
						"/",
						padding
					}), "BC");
				}
				else
				{
					instance = global::NPOI.POIFS.Crypt.Cipher.GetInstance(string.Concat(new string[]
					{
						cipherAlgorithm.jceId,
						"/",
						chain.jceId,
						"/",
						padding
					}));
				}
				if (vec == null)
				{
					instance.Init(cipherMode, key);
				}
				else
				{
					global::NPOI.POIFS.Crypt.AlgorithmParameterSpec aps;
					if (cipherAlgorithm == global::NPOI.POIFS.Crypt.CipherAlgorithm.rc2)
					{
						aps = new global::NPOI.POIFS.Crypt.RC2ParameterSpec(key.GetEncoded().Length * 8, vec);
					}
					else
					{
						aps = new global::NPOI.POIFS.Crypt.IvParameterSpec(vec);
					}
					instance.Init(cipherMode, key, aps);
				}
				result = instance;
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException(cause);
			}
			return result;
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00041B1C File Offset: 0x0003FD1C
		private static byte[] GetBlock36(byte[] hash, int size)
		{
			return global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlockX(hash, size, 54);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00041B27 File Offset: 0x0003FD27
		public static byte[] GetBlock0(byte[] hash, int size)
		{
			return global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlockX(hash, size, 0);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00041B34 File Offset: 0x0003FD34
		private static byte[] GetBlockX(byte[] hash, int size, byte Fill)
		{
			if (hash.Length == size)
			{
				return hash;
			}
			byte[] array = new byte[size];
			global::NPOI.Util.Arrays.Fill(array, Fill);
			global::System.Array.Copy(hash, 0, array, 0, global::System.Math.Min(array.Length, hash.Length));
			return array;
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00041B6C File Offset: 0x0003FD6C
		public static global::NPOI.POIFS.Crypt.MessageDigest GetMessageDigest(global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm)
		{
			global::NPOI.POIFS.Crypt.MessageDigest instance;
			try
			{
				if (hashAlgorithm.needsBouncyCastle)
				{
					global::NPOI.POIFS.Crypt.CryptoFunctions.registerBouncyCastle();
					instance = global::NPOI.POIFS.Crypt.MessageDigest.GetInstance(hashAlgorithm.jceId, "BC");
				}
				else
				{
					instance = global::NPOI.POIFS.Crypt.MessageDigest.GetInstance(hashAlgorithm.jceId);
				}
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException("hash algo not supported", cause);
			}
			return instance;
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00041BC8 File Offset: 0x0003FDC8
		public static global::NPOI.POIFS.Crypt.CryptoFunctions.Mac GetMac(global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm)
		{
			global::NPOI.POIFS.Crypt.CryptoFunctions.Mac instance;
			try
			{
				if (hashAlgorithm.needsBouncyCastle)
				{
					global::NPOI.POIFS.Crypt.CryptoFunctions.registerBouncyCastle();
					instance = global::NPOI.POIFS.Crypt.CryptoFunctions.Mac.GetInstance(hashAlgorithm.jceHmacId, "BC");
				}
				else
				{
					instance = global::NPOI.POIFS.Crypt.CryptoFunctions.Mac.GetInstance(hashAlgorithm.jceHmacId);
				}
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException("hmac algo not supported", cause);
			}
			return instance;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x00019A7F File Offset: 0x00017C7F
		[global::System.Obsolete("not necessary for npoi")]
		public static void registerBouncyCastle()
		{
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00041C24 File Offset: 0x0003FE24
		public static int CreateXorVerifier1(string password)
		{
			byte[] array = global::NPOI.POIFS.Crypt.CryptoFunctions.toAnsiPassword(password);
			short num = 0;
			if (!"".Equals(password))
			{
				for (int i = array.Length - 1; i >= 0; i--)
				{
					num = global::NPOI.POIFS.Crypt.CryptoFunctions.rotateLeftBase15Bit(num);
					num ^= (short)array[i];
				}
				num = global::NPOI.POIFS.Crypt.CryptoFunctions.rotateLeftBase15Bit(num);
				num ^= (short)array.Length;
				num ^= -12725;
			}
			return (int)num & 65535;
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00041C84 File Offset: 0x0003FE84
		public static int CreateXorVerifier2(string password)
		{
			byte[] data = new byte[4];
			int num = 15;
			if (!"".Equals(password))
			{
				password = password.Substring(0, global::System.Math.Min(password.Length, num));
				byte[] array = global::NPOI.POIFS.Crypt.CryptoFunctions.toAnsiPassword(password);
				int num2 = global::NPOI.POIFS.Crypt.CryptoFunctions.INITIAL_CODE_ARRAY[array.Length - 1];
				for (int i = 0; i < array.Length; i++)
				{
					int num3 = num - array.Length + i;
					for (int j = 0; j < 7; j++)
					{
						if (((int)array[i] & 1 << j) != 0)
						{
							num2 ^= global::NPOI.POIFS.Crypt.CryptoFunctions.ENCRYPTION_MATRIX[num3][j];
						}
					}
				}
				int num4 = global::NPOI.POIFS.Crypt.CryptoFunctions.CreateXorVerifier1(password);
				global::NPOI.Util.LittleEndian.PutShort(data, 0, (short)num4);
				global::NPOI.Util.LittleEndian.PutShort(data, 2, (short)num2);
			}
			return global::NPOI.Util.LittleEndian.GetInt(data);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00041D3C File Offset: 0x0003FF3C
		public static string XorHashPassword(string password)
		{
			int num = global::NPOI.POIFS.Crypt.CryptoFunctions.CreateXorVerifier2(password);
			return string.Format("%1$08X", num);
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00041D60 File Offset: 0x0003FF60
		public static string XorHashPasswordReversed(string password)
		{
			int operand = global::NPOI.POIFS.Crypt.CryptoFunctions.CreateXorVerifier2(password);
			return string.Format("%1$02X%2$02X%3$02X%4$02X", new object[]
			{
				global::NPOI.Util.Operator.UnsignedRightShift(operand, 0) & 255,
				global::NPOI.Util.Operator.UnsignedRightShift(operand, 8) & 255,
				global::NPOI.Util.Operator.UnsignedRightShift(operand, 16) & 255,
				global::NPOI.Util.Operator.UnsignedRightShift(operand, 24) & 255
			});
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00041DDA File Offset: 0x0003FFDA
		public static int CreateXorKey1(string password)
		{
			return global::NPOI.Util.Operator.UnsignedRightShift(global::NPOI.POIFS.Crypt.CryptoFunctions.CreateXorVerifier2(password), 16);
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00041DEC File Offset: 0x0003FFEC
		public static byte[] CreateXorArray1(string password)
		{
			if (password.Length > 15)
			{
				password = password.Substring(0, 15);
			}
			byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(password);
			byte[] array = new byte[16];
			global::System.Array.Copy(bytes, 0, array, 0, bytes.Length);
			global::System.Array.Copy(global::NPOI.POIFS.Crypt.CryptoFunctions.PAD_ARRAY, 0, array, bytes.Length, global::NPOI.POIFS.Crypt.CryptoFunctions.PAD_ARRAY.Length - bytes.Length + 1);
			int num = global::NPOI.POIFS.Crypt.CryptoFunctions.CreateXorKey1(password);
			int shift = 2;
			int num2 = global::NPOI.Util.Operator.UnsignedRightShift(num, 8);
			byte[] array2 = new byte[]
			{
				(byte)(num & 255),
				(byte)(num2 & 255)
			};
			for (int i = 0; i < array.Length; i++)
			{
				byte[] array3 = array;
				int num3 = i;
				array3[num3] ^= array2[i & 1];
				array[i] = global::NPOI.POIFS.Crypt.CryptoFunctions.rotateLeft(array[i], shift);
			}
			return array;
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x00041EB0 File Offset: 0x000400B0
		private static byte[] toAnsiPassword(string password)
		{
			byte[] array = new byte[password.Length];
			for (int i = 0; i < password.Length; i++)
			{
				char c = password[i];
				byte b = (byte)(c & 'ÿ');
				byte b2 = (byte)(global::NPOI.Util.Operator.UnsignedRightShift((int)c, 8) & 255);
				array[i] = ((b != 0) ? b : b2);
			}
			return array;
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x00041F03 File Offset: 0x00040103
		private static byte rotateLeft(byte bits, int Shift)
		{
			return (byte)((int)(bits & byte.MaxValue) << Shift | global::NPOI.Util.Operator.UnsignedRightShift((int)(bits & byte.MaxValue), 8 - Shift));
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00041F24 File Offset: 0x00040124
		private static short rotateLeftBase15Bit(short verifier)
		{
			short num = ((verifier & 16384) == 0) ? 0 : 1;
			short num2 = (short)((int)verifier << 1 & 32767);
			return num | num2;
		}

		// Token: 0x040008EE RID: 2286
		private static int[] INITIAL_CODE_ARRAY = new int[]
		{
			57840,
			7439,
			52380,
			33984,
			4364,
			3600,
			61902,
			12606,
			6258,
			57657,
			54287,
			34041,
			10252,
			43370,
			20163
		};

		// Token: 0x040008EF RID: 2287
		private static byte[] PAD_ARRAY = new byte[]
		{
			187,
			byte.MaxValue,
			byte.MaxValue,
			186,
			byte.MaxValue,
			byte.MaxValue,
			185,
			128,
			0,
			190,
			15,
			0,
			191,
			15,
			0
		};

		// Token: 0x040008F0 RID: 2288
		private static int[][] ENCRYPTION_MATRIX = new int[][]
		{
			new int[]
			{
				44796,
				19929,
				39858,
				10053,
				20106,
				40212,
				10761
			},
			new int[]
			{
				31585,
				63170,
				64933,
				60267,
				50935,
				40399,
				11199
			},
			new int[]
			{
				17763,
				35526,
				1453,
				2906,
				5812,
				11624,
				23248
			},
			new int[]
			{
				885,
				1770,
				3540,
				7080,
				14160,
				28320,
				56640
			},
			new int[]
			{
				55369,
				41139,
				20807,
				41614,
				21821,
				43642,
				17621
			},
			new int[]
			{
				28485,
				56970,
				44341,
				19019,
				38038,
				14605,
				29210
			},
			new int[]
			{
				60195,
				50791,
				40175,
				10751,
				21502,
				43004,
				24537
			},
			new int[]
			{
				18387,
				36774,
				3949,
				7898,
				15796,
				31592,
				63184
			},
			new int[]
			{
				47201,
				24803,
				49606,
				37805,
				14203,
				28406,
				56812
			},
			new int[]
			{
				17824,
				35648,
				1697,
				3394,
				6788,
				13576,
				27152
			},
			new int[]
			{
				43601,
				17539,
				35078,
				557,
				1114,
				2228,
				4456
			},
			new int[]
			{
				30388,
				60776,
				51953,
				34243,
				7079,
				14158,
				28316
			},
			new int[]
			{
				14128,
				28256,
				56512,
				43425,
				17251,
				34502,
				7597
			},
			new int[]
			{
				13105,
				26210,
				52420,
				35241,
				883,
				1766,
				3532
			},
			new int[]
			{
				4129,
				8258,
				16516,
				33032,
				4657,
				9314,
				18628
			}
		};

		// Token: 0x020005B2 RID: 1458
		public class Mac
		{
			// Token: 0x060034AC RID: 13484 RVA: 0x00008C75 File Offset: 0x00006E75
			internal static global::NPOI.POIFS.Crypt.CryptoFunctions.Mac GetInstance(string jceHmacId, string v)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x060034AD RID: 13485 RVA: 0x00008C75 File Offset: 0x00006E75
			internal static global::NPOI.POIFS.Crypt.CryptoFunctions.Mac GetInstance(string jceHmacId)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x060034AE RID: 13486 RVA: 0x00008C75 File Offset: 0x00006E75
			public byte[] DoFinal(object encoded)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x060034AF RID: 13487 RVA: 0x00008C75 File Offset: 0x00006E75
			public byte[] DoFinal()
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x060034B0 RID: 13488 RVA: 0x00008C75 File Offset: 0x00006E75
			public void Init(global::NPOI.POIFS.Crypt.ISecretKey secretKey)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x060034B1 RID: 13489 RVA: 0x00008C75 File Offset: 0x00006E75
			public void Update(byte[] buf, int v, int readBytes)
			{
				throw new global::System.NotImplementedException();
			}
		}
	}
}
