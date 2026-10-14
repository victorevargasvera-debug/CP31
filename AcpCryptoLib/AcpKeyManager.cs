using System;
using System.Security.Cryptography;
using AcpCryptoLib.Properties;

namespace AcpCryptoLib
{
	// Token: 0x02000012 RID: 18
	internal class AcpKeyManager
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00005E54 File Offset: 0x00004054
		internal AcpKeyManager()
		{
			int a_ = 16;
			this.b = global::AcpCryptoLib.XmlEncryptionUtil.b("導夐划␔", a_);
			base..ctor();
			this.a = global::System.Security.Cryptography.Aes.Create();
			this.a.Mode = global::System.Security.Cryptography.CipherMode.CBC;
			this.a.Padding = global::System.Security.Cryptography.PaddingMode.PKCS7;
			this.a.BlockSize = 128;
			this.a.KeySize = 256;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005EC8 File Offset: 0x000040C8
		internal global::System.Security.Cryptography.SymmetricAlgorithm GetKey(byte[] passwdHint)
		{
			short num = (short)1965162496;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				int num3;
				int[] array;
				byte[] array2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_D5;
					case 1:
					{
						if (num3 >= array.Length)
						{
							num = (short)279969792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)970306893;
						short num4 = num;
						num = (short)512341325;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_19A;
						default:
						{
							num = (short)1962868736;
							if (num != 0)
							{
							}
							int num5 = array[num3] % global::AcpCryptoLib.AcpCryptoDefs.randomFactors.Length;
							array2[num3] = (byte)((int)this.c[array[num3]] ^ (global::AcpCryptoLib.AcpCryptoDefs.randomFactors[num5] + array[num3]) % 256);
							num3++;
							num = (short)1441529857;
							if (num != 0)
							{
							}
							num = (short)1350959106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_19A;
					case 3:
						goto IL_9D;
					}
					goto IL_3E;
					IL_9D:
					num = (short)1567490049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19A:
					goto IL_9D;
				}
				IL_D5:
				global::System.Security.Cryptography.PasswordDeriveBytes passwordDeriveBytes = new global::System.Security.Cryptography.PasswordDeriveBytes(array2, passwdHint, this.b, 10);
				this.a.Key = passwordDeriveBytes.GetBytes(32);
				this.a.IV = this.a(passwdHint, true);
				return this.a;
				IL_3E:
				num = (short)1682898944;
				short num6 = num;
				this.a();
				array = (int[])this.a(passwdHint);
				array2 = new byte[array.Length];
				num3 = 0;
				num = (short)1478950915;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000060B4 File Offset: 0x000042B4
		internal global::System.Security.Cryptography.SymmetricAlgorithm GetKey(byte[] passwdHint, int[] positions)
		{
			int a_ = 10;
			short num = (short)1880752128;
			switch (num)
			{
			default:
			{
				num = (short)658112513;
				if (num != 0)
				{
				}
				num = (short)523370501;
				int num2 = (int)((global::System.IntPtr)num);
				byte[] array;
				for (;;)
				{
					int num3;
					global::AcpCryptoLib.AcpRNGenerator acpRNGenerator;
					switch (num2)
					{
					case 0:
					{
						if (num3 >= passwdHint.Length)
						{
							num = (short)854458372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpRNGenerator.SNetRandomValue = (int)passwdHint[positions[num3 % 3]];
						int nextSNetRandomValue = acpRNGenerator.NextSNetRandomValue;
						array[num3] = (byte)((int)passwdHint[num3] ^ nextSNetRandomValue);
						num3++;
						num = (short)1640235010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_A9;
					case 2:
						goto IL_129;
					case 3:
						goto IL_129;
					case 4:
					{
						num = (short)1628241920;
						short num4 = num;
						num = (short)42751911;
						short num5 = num;
						num = (short)1975801767;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_93;
						default:
							goto IL_1C7;
						}
						break;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_8D;
						}
						continue;
					}
					goto IL_8D;
					IL_93:
					num = (short)440795137;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D:
					if (positions.Length != 4)
					{
						goto IL_93;
					}
					acpRNGenerator = new global::AcpCryptoLib.AcpRNGenerator();
					array = new byte[passwdHint.Length];
					num3 = 0;
					num = (short)816316419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_129:
					num = (short)1456209920;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A9:
				throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䀈攊椌樎椐瘒洔㜖嘘渚検㼞渠䔢Ԥ甦䠨䔪䨬䨮", a_));
				IL_1C7:
				num = (short)1925971968;
				if (num != 0)
				{
				}
				global::System.Security.Cryptography.PasswordDeriveBytes passwordDeriveBytes = new global::System.Security.Cryptography.PasswordDeriveBytes(array, passwdHint, global::AcpCryptoLib.XmlEncryptionUtil.b("娈䌊䰌㸎", a_), 10);
				this.a.Key = passwordDeriveBytes.GetBytes(32);
				this.a.IV = this.a(array, false);
				return this.a;
			}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000062E4 File Offset: 0x000044E4
		private byte[] a(byte[] A_0, bool A_1)
		{
			short num = (short)1904017408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				byte[] array;
				for (;;)
				{
					IL_27:
					int num3;
					int[] array2;
					switch (num2)
					{
					case 0:
						return array;
					case 1:
						if (num3 >= array.Length)
						{
							num = (short)255393795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num3] = this.c[array2[array2.Length - 2 - num3]];
						num3++;
						num = (short)993525766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_177;
					case 3:
					{
						num = (short)114009573;
						short num4 = num;
						num = (short)970302949;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8F;
						default:
							num = (short)926482433;
							if (num != 0)
							{
							}
							num = (short)1424687104;
							if (num != 0)
							{
							}
							num = (short)1724973056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_236;
					case 5:
					{
						int num5;
						if (num5 >= array.Length)
						{
							num = (short)1504968704;
							short num6 = num;
							num = (short)16646151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num5] = A_0[A_0.Length - 2 - num5];
						num5++;
						num = (short)1059520520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_236;
					case 7:
						return array;
					case 8:
						goto IL_177;
					case 9:
					{
						if (A_1)
						{
							num = (short)259129354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = 0;
						num = (short)1517879298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_8F;
					}
					goto IL_5A;
					IL_8F:
					array2 = (int[])this.a(A_0);
					num3 = 0;
					num = (short)474480644;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_177:
					num = (short)1707868165;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_236:
					num = (short)1356988417;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_5A:
				array = new byte[16];
				num = (short)1056112649;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006568 File Offset: 0x00004768
		private void a()
		{
			short num;
			try
			{
				num = (short)1119255717;
				short num2 = num;
				num = (short)72842405;
				switch (num2 == num)
				{
				}
				num = (short)1210908672;
				if (num != 0)
				{
				}
				this.c = global::System.Convert.FromBase64String(global::AcpCryptoLib.Properties.Resources.AcpcryptoDef);
			}
			catch (global::System.Exception)
			{
			}
			num = (short)510394369;
			if (num != 0)
			{
			}
			num = (short)1056702464;
			short num3 = num;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006638 File Offset: 0x00004838
		private object a(byte[] A_0)
		{
			short num = (short)575275008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				int num3;
				byte[] array;
				int num4;
				int[] array2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (num3 >= array.Length)
						{
							num = (short)1414463489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 += (int)array[num3];
						num3++;
						num = (short)1026818050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int num5 = num4 % 1024;
						int num6 = 0;
						num = (short)558563331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)2094500290;
						short num7 = num;
						num = (short)78285250;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7D;
						default:
						{
							num = (short)198508544;
							if (num != 0)
							{
							}
							num = (short)604372992;
							short num8 = num;
							goto IL_1ED;
						}
						}
						break;
					}
					case 3:
						goto IL_1B0;
					case 4:
					{
						int num6;
						if (num6 >= array2.Length)
						{
							num = (short)815792133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5;
						array2[num6] = (num5 * global::AcpCryptoLib.AcpCryptoDefs.randomFactors[num6] + 25173) % 1024;
						num5 = array2[num6];
						num6++;
						num = (short)1500577799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						return array2;
					case 6:
						goto IL_7D;
					case 7:
						goto IL_1B0;
					}
					goto IL_4E;
					IL_1B0:
					num = (short)1389035524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1ED:
					num = (short)914423808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7D:
					num = (short)270925825;
					if (num != 0)
					{
					}
					goto IL_1ED;
				}
				return array2;
				IL_4E:
				array2 = new int[20];
				num4 = 0;
				array = new global::System.Security.Cryptography.SHA1CryptoServiceProvider().ComputeHash(A_0);
				num3 = 0;
				num = (short)1732247558;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0400001E RID: 30
		private global::System.Security.Cryptography.SymmetricAlgorithm a;

		// Token: 0x0400001F RID: 31
		private string b;

		// Token: 0x04000020 RID: 32
		private byte[] c;
	}
}
