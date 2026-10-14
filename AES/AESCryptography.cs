using System;
using System.Globalization;
using System.Text;
using AesOfb;

namespace authAES
{
	// Token: 0x02000005 RID: 5
	public static class AESCryptography
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000021C4 File Offset: 0x000003C4
		public static string AESEncryptWithDefKey(string plainPwd)
		{
			short num = (short)566755329;
			if (num != 0)
			{
			}
			num = (short)850026259;
			short num2 = num;
			num = (short)952327955;
			switch (num2 == num)
			{
			}
			num = (short)185139200;
			short num3 = num;
			num = (short)1164574720;
			if (num != 0)
			{
			}
			return global::authAES.AESCryptography.AESEncrypt(plainPwd, global::authAES.AESCryptography.CIPHER_DEF_KEY);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002278 File Offset: 0x00000478
		public static string AESDecryptWithDefKey(string encryptedPwd)
		{
			short num = (short)2081028520;
			short num2 = num;
			num = (short)124451240;
			switch (num2 == num)
			{
			}
			num = (short)1517682689;
			if (num != 0)
			{
			}
			num = (short)887488512;
			short num3 = num;
			num = (short)2051801088;
			if (num != 0)
			{
			}
			return global::authAES.AESCryptography.AESDecrypt(encryptedPwd, global::authAES.AESCryptography.CIPHER_DEF_KEY);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000232C File Offset: 0x0000052C
		public static string AESEncrypt(string plainPwd, byte[] cipherKeyBytes)
		{
			int a_ = 14;
			short num = (short)1611726848;
			switch (num)
			{
			default:
			{
				num = (short)391512080;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1CA;
					case 1:
						goto IL_F1;
					case 2:
						goto IL_F1;
					case 3:
						goto IL_2F9;
					case 4:
					{
						string text;
						return text;
					}
					case 5:
					{
						num = (short)1665735012;
						short num3 = num;
						num = (short)1062017380;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_35F;
						default:
							goto IL_395;
						}
						break;
					}
					case 6:
					{
						int num4;
						if (num4 >= cipherKeyBytes.Length)
						{
							num = (short)1868693516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						array[num4] = cipherKeyBytes[num4];
						num4++;
						num = (short)1017249795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						int num5 = 0;
						num = (short)876216321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_1A8;
					case 9:
					{
						int num6;
						byte[] array2;
						if (num6 >= array2.Length)
						{
							num = (short)2115239943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[num6] = global::authAES.AESCryptography.b;
						num6++;
						num = (short)239927307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						int num4 = 0;
						num = (short)2040201234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_35F;
					case 12:
					{
						byte[] array;
						global::System.Array.Copy(global::authAES.AESCryptography.a, 0, array, 8, 8);
						byte[] array2;
						byte[] array3 = new global::AesOfb.AesOfb().Encrypt(array2, array);
						int num7 = 0;
						num = (short)1734279168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						num = (short)2076966913;
						if (num != 0)
						{
						}
						byte[] array3;
						int num7;
						if (num7 >= array3.Length)
						{
							num = (short)1231028228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = array3[num7];
						string text;
						text += string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::authAES.EncryptionDecrytionFailedException.b("ݻ乽멿\uda81뚃ﮅ", a_), b);
						num7++;
						num = (short)750321679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_3B1;
					case 15:
						goto IL_1CA;
					case 16:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					case 17:
					{
						int num5;
						byte[] bytes;
						if (num5 >= bytes.Length)
						{
							num = (short)1353908234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)787677184;
						short num8 = num;
						byte[] array2;
						array2[num5] = bytes[num5];
						num5++;
						num = (short)101384194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_2F9;
					case 19:
					{
						if (cipherKeyBytes.Length != 8)
						{
							num = (short)1921515528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = string.Empty;
						byte[] bytes = global::System.Text.Encoding.Unicode.GetBytes(plainPwd);
						byte[] array = new byte[(int)global::authAES.AESCryptography.c];
						byte[] array2 = new byte[(int)(global::authAES.AESCryptography.c * 3)];
						new byte[(int)(global::authAES.AESCryptography.c * 3)];
						int num6 = 0;
						num = (short)920453134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9D:
					if (plainPwd.Length > 24)
					{
						num = (short)386007045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)95617043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F1:
					num = (short)1483014161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CA:
					num = (short)1863581709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F9:
					num = (short)502267910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B1:
					num = (short)10354697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35F:
					goto IL_3B1;
				}
				IL_1A8:
				throw new global::authAES.EncryptionDecrytionFailedException();
				IL_395:
				num = (short)694222848;
				if (num != 0)
				{
				}
				throw new global::authAES.EncryptionDecrytionFailedException();
			}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002780 File Offset: 0x00000980
		public static string AESDecrypt(string encryptedPwd, byte[] cipherKeyBytes)
		{
			short num = (short)2067857408;
			switch (num)
			{
			default:
			{
				num = (short)1713045505;
				if (num != 0)
				{
				}
				num = (short)1420361732;
				int num2 = (int)((global::System.IntPtr)num);
				byte[] array;
				byte[] bytes;
				byte[] input;
				for (;;)
				{
					num = (short)1207608760;
					short num3 = num;
					num = (short)1546823096;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_214;
					default:
					{
						num = (short)1340473344;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_168;
						case 1:
						{
							if (cipherKeyBytes.Length != 8)
							{
								num = (short)1265500163;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array = new byte[(int)global::authAES.AESCryptography.c];
							bytes = new byte[(int)(global::authAES.AESCryptography.c * 3)];
							input = global::authAES.AESCryptography.HexString2Bytes(encryptedPwd);
							int num4 = 0;
							num = (short)72220674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_12F;
						case 3:
							goto IL_1CF;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_D7;
							}
							continue;
						case 5:
							goto IL_FD;
						case 6:
						{
							int num4;
							if (num4 >= cipherKeyBytes.Length)
							{
								num = (short)34799616;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array[num4] = cipherKeyBytes[num4];
							num4++;
							num = (short)504889351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							goto IL_12F;
						}
						IL_D7:
						if (encryptedPwd.Length != 96)
						{
							num = (short)764084229;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						num = (short)1497628672;
						short num5 = num;
						num = (short)198508545;
						num2 = (int)((global::System.IntPtr)num);
						break;
						IL_12F:
						num = (short)1483145222;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_FD:
				throw new global::authAES.EncryptionDecrytionFailedException();
				IL_168:
				goto IL_214;
				IL_1CF:
				throw new global::authAES.EncryptionDecrytionFailedException();
				IL_214:
				global::System.Array.Copy(global::authAES.AESCryptography.a, 0, array, 8, 8);
				bytes = new global::AesOfb.AesOfb().Decrypt(input, array);
				return global::authAES.AESCryptography.a(global::System.Text.Encoding.Unicode.GetString(bytes));
			}
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000029CC File Offset: 0x00000BCC
		public static string AESEncryptWithDefKey_ForWiFiPassword(string plainPwd)
		{
			short num = (short)1691621533;
			short num2 = num;
			num = (short)141629597;
			switch (num2 == num)
			{
			}
			num = (short)1801125889;
			if (num != 0)
			{
			}
			num = (short)1654128640;
			short num3 = num;
			num = (short)1601699840;
			if (num != 0)
			{
			}
			return global::authAES.AESCryptography.AESEncrypt_Ex(plainPwd, global::authAES.AESCryptography.CIPHER_DEF_KEY, 0, 4);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002A84 File Offset: 0x00000C84
		public static string AESDecryptWithDefKey_ForWiFiPassword(string encryptedPwd)
		{
			short num = (short)2119696385;
			if (num != 0)
			{
			}
			num = (short)2147129832;
			short num2 = num;
			num = (short)543267304;
			switch (num2 == num)
			{
			}
			num = (short)465043456;
			short num3 = num;
			num = (short)650575872;
			if (num != 0)
			{
			}
			return global::authAES.AESCryptography.AESDecrypt_Ex(encryptedPwd, global::authAES.AESCryptography.CIPHER_DEF_KEY, 0, 4);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002B38 File Offset: 0x00000D38
		public static string AESEncryptWithDefKey_ForDataModemPassword(string plainPwd)
		{
			short num = (short)1675757636;
			short num2 = num;
			num = (short)1787234372;
			switch (num2 == num)
			{
			}
			num = (short)16384001;
			if (num != 0)
			{
			}
			num = (short)1253703680;
			short num3 = num;
			num = (short)1408040960;
			if (num != 0)
			{
			}
			return global::authAES.AESCryptography.AESEncrypt_Ex(plainPwd, global::authAES.AESCryptography.CIPHER_DEF_KEY, 0, 3);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002BEC File Offset: 0x00000DEC
		public static string AESDecryptWithDefKey_ForDataModemPassword(string encryptedPwd)
		{
			short num = (short)317456897;
			short num2 = num;
			num = (short)935657985;
			switch (num2 == num)
			{
			}
			num = (short)1140654081;
			if (num != 0)
			{
			}
			num = (short)1403650048;
			short num3 = num;
			num = (short)1498021888;
			if (num != 0)
			{
			}
			return global::authAES.AESCryptography.AESDecrypt_Ex(encryptedPwd, global::authAES.AESCryptography.CIPHER_DEF_KEY, 0, 3);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002CA4 File Offset: 0x00000EA4
		public static string AESEncrypt_Ex(string plainPwd, byte[] cipherKeyBytes, int encoding, int block_num)
		{
			int a_ = 2;
			short num = (short)118685696;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				byte[] array;
				string text;
				for (;;)
				{
					IL_30:
					byte[] array2;
					byte[] array4;
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_2AE;
					case 1:
						if (encoding == 1)
						{
							num = (short)247005193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B3;
					case 2:
						array = global::System.Text.Encoding.ASCII.GetBytes(plainPwd);
						num = (short)1838350349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_3DD;
					case 4:
					{
						global::System.Array.Copy(global::authAES.AESCryptography.a, 0, array2, 8, 8);
						byte[] array3 = new global::AesOfb.AesOfb().Encrypt(array4, array2, block_num);
						int num3 = 0;
						num = (short)1845690389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int num4;
						if (num4 >= cipherKeyBytes.Length)
						{
							num = (short)899416068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array2[num4] = cipherKeyBytes[num4];
						num4++;
						num = (short)1960116231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_150;
					case 7:
						goto IL_34A;
					case 8:
						if (num5 >= array4.Length)
						{
							num = (short)946208778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array4[num5] = global::authAES.AESCryptography.b;
						num5++;
						num = (short)1425866768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						array = global::System.Text.Encoding.Unicode.GetBytes(plainPwd);
						num = (short)1641086988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)1972493346;
						short num6 = num;
						num = (short)1993202722;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2AE;
						default:
						{
							num = (short)1512636416;
							if (num != 0)
							{
							}
							int num7 = 0;
							num = (short)1518796800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 11:
					{
						int num4 = 0;
						num = (short)1115750420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_2B3;
					case 13:
						goto IL_2B3;
					case 14:
						return text;
					case 15:
					{
						byte[] array3;
						int num3;
						if (num3 >= array3.Length)
						{
							num = (short)1734017038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = array3[num3];
						text += string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::authAES.EncryptionDecrytionFailedException.b("୯䉱乳⹵䩷ݹ", a_), b);
						num3++;
						num = (short)1286078481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_3DD;
					case 17:
						goto IL_251;
					case 18:
					{
						num = (short)2115895296;
						short num8 = num;
						num = (short)1591607297;
						if (num != 0)
						{
						}
						if (encoding == 0)
						{
							num = (short)1714814978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)849870849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						int num7;
						if (num7 >= array.Length)
						{
							num = (short)2088501259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array4[num7] = array[num7];
						num7++;
						num = (short)491323398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_34A;
					case 21:
						goto IL_251;
					}
					goto IL_8F;
					IL_150:
					num = (short)355794963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AE:
					goto IL_150;
					IL_251:
					num = (short)1756954639;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B3:
					array2 = new byte[(int)global::authAES.AESCryptography.c];
					array4 = new byte[(int)global::authAES.AESCryptography.c * block_num];
					new byte[(int)global::authAES.AESCryptography.c * block_num];
					num5 = 0;
					num = (short)404160515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34A:
					num = (short)1297350661;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DD:
					num = (short)1858928648;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_8F:
				text = string.Empty;
				array = null;
				num = (short)1972502546;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003144 File Offset: 0x00001344
		public static string AESDecrypt_Ex(string encryptedPwd, byte[] cipherKeyBytes, int encoding, int block_num)
		{
			short num = (short)320929792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				int num3;
				byte[] array;
				byte[] bytes;
				string a_;
				byte[] input;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (num3 >= cipherKeyBytes.Length)
						{
							num = (short)171245573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num3] = cipherKeyBytes[num3];
						num3++;
						num = (short)1228210180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1C2;
					case 2:
						goto IL_254;
					case 3:
						a_ = global::System.Text.Encoding.Unicode.GetString(bytes);
						num = (short)1689321473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						num = (short)660103359;
						short num4 = num;
						num = (short)988176575;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_206;
						default:
							num = (short)798621696;
							if (num != 0)
							{
							}
							goto IL_1C7;
						}
						break;
					}
					case 5:
						global::System.Array.Copy(global::authAES.AESCryptography.a, 0, array, 8, 8);
						bytes = new global::AesOfb.AesOfb().Decrypt(input, array, block_num);
						num = (short)1961033737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1C7;
					case 7:
						if (encoding == 1)
						{
							num = (short)730005507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_256;
					case 8:
						goto IL_206;
					case 9:
						if (encoding == 0)
						{
							num = (short)859701256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)547356679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56;
					IL_1C7:
					num = (short)594477056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_206:
					num = (short)840040448;
					short num5 = num;
					a_ = global::System.Text.Encoding.ASCII.GetString(bytes);
					num = (short)1808007170;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1C2:
				IL_254:
				IL_256:
				num = (short)1140654081;
				if (num != 0)
				{
				}
				return global::authAES.AESCryptography.a(a_);
				IL_56:
				a_ = string.Empty;
				array = new byte[(int)global::authAES.AESCryptography.c];
				bytes = new byte[(int)global::authAES.AESCryptography.c * block_num];
				input = global::authAES.AESCryptography.HexString2Bytes(encryptedPwd);
				num3 = 0;
				num = (short)14352390;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000033D8 File Offset: 0x000015D8
		public static string HEXString(byte[] bytes)
		{
			int a_ = 0;
			short num = (short)1849098240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				string text;
				int num3;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						return text;
					case 1:
						goto IL_6B;
					case 2:
						goto IL_6B;
					case 3:
					{
						num = (short)190251009;
						if (num != 0)
						{
						}
						if (num3 >= bytes.Length)
						{
							num = (short)1839792128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = bytes[num3];
						string str = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::authAES.EncryptionDecrytionFailedException.b("ᕭ䁯䡱ⱳ୵", a_), (b & 240) >> 4);
						string str2 = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::authAES.EncryptionDecrytionFailedException.b("ᕭ䁯䡱ⱳ୵", a_), (int)(b & 15));
						text = text + str + str2;
						num3++;
						num = (short)1038286850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_48;
					IL_6B:
					num = (short)1463673336;
					short num4 = num;
					num = (short)2082136568;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48;
					default:
					{
						num = (short)2116485120;
						if (num != 0)
						{
						}
						num = (short)2062614528;
						short num5 = num;
						num = (short)1725366275;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return text;
				IL_48:
				text = string.Empty;
				num3 = 0;
				num = (short)1883439105;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000035A4 File Offset: 0x000017A4
		public static byte[] HexString2Bytes(string hexString)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			byte[] array;
			short num2;
			int num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return array;
				case 1:
					goto IL_47;
				case 2:
				{
					num2 = (short)1418113317;
					short num3 = num2;
					num2 = (short)915124517;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CD;
					default:
						num2 = (short)525074433;
						if (num2 != 0)
						{
						}
						num2 = (short)1669332992;
						if (num2 != 0)
						{
						}
						goto IL_47;
					}
					break;
				}
				case 3:
				{
					num2 = (short)1904410624;
					short num4 = num2;
					if (num5 >= hexString.Length)
					{
						num2 = (short)1919614976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					array[num5 / 2] = byte.Parse(hexString.Substring(num5, 2), global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture);
					num5++;
					num5++;
					goto IL_CD;
				}
				}
				goto IL_20;
				IL_47:
				num2 = (short)1219493891;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_CD:
				num2 = (short)1296564226;
				num = (int)((global::System.IntPtr)num2);
			}
			return array;
			IL_20:
			array = new byte[hexString.Length / 2];
			num5 = 0;
			num2 = (short)558497793;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00003710 File Offset: 0x00001910
		private static string a(string A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					A_0 = A_0.Substring(0, num2);
					num3 = (short)1860829188;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					goto IL_151;
				case 2:
					if (num2 > 0)
					{
						num3 = (short)62914560;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_153;
				case 3:
					if (num2 == 0)
					{
						num3 = (short)1551499269;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_FC;
				case 4:
				{
					num3 = (short)518856700;
					short num4 = num3;
					num3 = (short)143532028;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FC;
					default:
						goto IL_B8;
					}
					break;
				}
				case 5:
					A_0 = "";
					num3 = (short)307036161;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				goto IL_28;
				IL_FC:
				num3 = (short)349831170;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_B8:
			num3 = (short)1503657984;
			if (num3 != 0)
			{
			}
			num3 = (short)757858304;
			short num5 = num3;
			IL_151:
			IL_153:
			num3 = (short)955056129;
			if (num3 != 0)
			{
			}
			return A_0;
			IL_28:
			num2 = A_0.IndexOf('\0');
			num3 = (short)1925578755;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000389C File Offset: 0x00001A9C
		// Note: this type is marked as 'beforefieldinit'.
		static AESCryptography()
		{
			short num = (short)1210842761;
			short num2 = num;
			num = (short)24706697;
			switch (num2 == num)
			{
			}
			num = (short)1546452993;
			if (num != 0)
			{
			}
			num = (short)941621248;
			short num3 = num;
			num = (short)368574464;
			if (num != 0)
			{
			}
			global::authAES.AESCryptography.CIPHER_DEF_KEY = new byte[]
			{
				65,
				66,
				67,
				68,
				49,
				50,
				51,
				52
			};
			global::authAES.AESCryptography.a = new byte[]
			{
				77,
				111,
				116,
				45,
				83,
				111,
				108,
				115
			};
			global::authAES.AESCryptography.b = 0;
			global::authAES.AESCryptography.c = 16;
		}

		// Token: 0x04000005 RID: 5
		public static readonly byte[] CIPHER_DEF_KEY;

		// Token: 0x04000006 RID: 6
		private static readonly byte[] a;

		// Token: 0x04000007 RID: 7
		private static readonly byte b;

		// Token: 0x04000008 RID: 8
		private static readonly byte c;
	}
}
