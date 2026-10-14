using System;
using System.IO;
using System.Security.Cryptography;

namespace AesOfb
{
	// Token: 0x02000005 RID: 5
	public class AesOfbCipher
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002610 File Offset: 0x00000810
		public byte[] RunCipher(global::AesOfb.AesOfbConfiguration configuration)
		{
			int a_ = 4;
			short num = (short)288948224;
			switch (num)
			{
			default:
			{
				num = (short)1408303105;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte[] array;
					byte[] key;
					int num4;
					int num3;
					byte[] array2;
					int num5;
					int num6;
					int num7;
					byte[] input;
					int num8;
					int num9;
					byte[] array3;
					int num10;
					switch (num2)
					{
					case 0:
						num = (short)1782775824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_98;
						}
						continue;
					case 2:
						array = this.a(array, key);
						num3 = num4;
						num = (short)1164509197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return array2;
					case 4:
						goto IL_3ED;
					case 5:
						if (num5 <= 0)
						{
							goto IL_18B;
						}
						goto IL_38E;
					case 6:
						goto IL_BA;
					case 7:
						if (num6 == 0)
						{
							num = (short)2093613068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3ED;
					case 8:
						num = (short)2098790410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						array2[num7] = (input[num7] ^ array[num4 - num3]);
						num = (short)738590738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (num4 - num3 < num8)
						{
							num = (short)1746141193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_388;
					case 11:
						num = (short)953745409;
						if (num != 0)
						{
						}
						if (num3 == num9)
						{
							num = (short)962068482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC;
					case 12:
						num3 = num9;
						array3.CopyTo(array, 0);
						array3 = this.a(array3, num10);
						array3.CopyTo(array, num10);
						array = this.a(array, key);
						num = (short)1552678916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_EC;
					case 14:
						goto IL_118;
					case 15:
						goto IL_38E;
					case 16:
						if (num7 >= input.Length)
						{
							num = (short)2049229497;
							short num11 = num;
							num = (short)1456521913;
							switch ((num11 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_18B;
							case 1:
								break;
							default:
							{
								num = (short)1416298496;
								short num12 = num;
								break;
							}
							}
							num = (short)1872232448;
							if (num != 0)
							{
							}
							num = (short)1628569603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_118;
					case 17:
						if (num4 - num3 >= 0)
						{
							num = (short)1540358152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_388;
					case 18:
						num7++;
						num6++;
						num3--;
						num5--;
						num = (short)562233349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_98:
					if (configuration.BlockNumber == 0)
					{
						num = (short)801112070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					input = configuration.Input;
					array3 = configuration.InitializationVector;
					key = configuration.Key;
					global::System.Array.Resize<byte>(ref input, 16 * configuration.BlockNumber);
					num6 = 0;
					num7 = 0;
					num3 = 0;
					num5 = 0;
					num4 = 16;
					num9 = 0;
					num8 = 16;
					array2 = new byte[input.Length];
					num10 = 8;
					array = new byte[16];
					num = (short)119930894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EC:
					num5 = global::System.Math.Min(input.Length - num7, num3);
					num = (short)96927759;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_118:
					num = (short)1866530823;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18B:
					num = (short)145883136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38E:
					num = (short)1858797585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3ED:
					num = (short)916520971;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BA:
				throw new global::System.ArgumentException(global::AesOfb.AesOfbConfiguration.b("\udfb2\udab4풶트鮺펼쪾곀ꇂꃄ뗆ꏊ곌볎꟒뫔믘뻚﷜룞鏠蛢蓤鏦賨駪췬鯮駰鋲鯴ퟶ째헺", a_), global::AesOfb.AesOfbConfiguration.b("\udfb2\udab4풶트좼튾ꏀꛂ럄", a_));
				IL_388:
				throw new global::System.InvalidOperationException();
			}
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002A78 File Offset: 0x00000C78
		private byte[] a(byte[] A_0, byte[] A_1)
		{
			short num = (short)602603520;
			switch (num)
			{
			default:
			{
				global::System.Security.Cryptography.Aes aes = global::System.Security.Cryptography.Aes.Create();
				byte[] result;
				try
				{
					aes.KeySize = 128;
					aes.BlockSize = 128;
					aes.Key = A_1;
					aes.IV = this.a;
					global::System.Security.Cryptography.ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
					try
					{
						num = (short)44433409;
						if (num != 0)
						{
						}
						global::System.Security.Cryptography.CryptoStream cryptoStream = new global::System.Security.Cryptography.CryptoStream(memoryStream, transform, global::System.Security.Cryptography.CryptoStreamMode.Write);
						try
						{
							cryptoStream.Write(A_0, 0, A_0.Length);
							result = memoryStream.ToArray();
						}
						finally
						{
							num = (short)575864834;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_120;
								case 1:
									((global::System.IDisposable)cryptoStream).Dispose();
									num = (short)829292544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E8;
									}
									continue;
								}
								IL_E8:
								if (cryptoStream == null)
								{
									break;
								}
								num = (short)320733185;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_120:;
						}
					}
					finally
					{
						num = (short)1282539522;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_18D;
							case 1:
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)82968576;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_155;
								}
								continue;
							}
							IL_155:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)2091253761;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_18D:;
					}
				}
				finally
				{
					num = (short)422772738;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1824875999;
						short num3 = num;
						num = (short)789669343;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_243;
						default:
							num = (short)1401225216;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_243;
							case 1:
								((global::System.IDisposable)aes).Dispose();
								num = (short)1297350656;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_20B;
								}
								continue;
							}
							IL_20B:
							if (aes == null)
							{
								goto IL_245;
							}
							num = (short)1999241217;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_243:
					IL_245:;
				}
				num = (short)1535967232;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002D44 File Offset: 0x00000F44
		private byte[] a(byte[] A_0, int A_1)
		{
			short num = (short)235581686;
			short num2 = num;
			num = (short)1658761462;
			int num3;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C4:
				num = (short)298188801;
				if (num != 0)
				{
				}
				if (num3 >= A_1)
				{
					num = (short)602210306;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					byte b = (byte)((int)A_0[0] ^ ((int)A_0[0] << 2 | A_0[1] >> 6));
					A_0[0] = A_0[1];
					b ^= (byte)((int)A_0[2] << 2 | A_0[3] >> 6);
					A_0[1] = A_0[2];
					A_0[2] = A_0[3];
					b ^= (byte)((int)A_0[3] << 2 | A_0[4] >> 6);
					A_0[3] = A_0[4];
					b ^= (byte)((int)A_0[4] << 5 | A_0[5] >> 3);
					A_0[4] = A_0[5];
					A_0[5] = A_0[6];
					b ^= (byte)((int)A_0[6] << 1 | A_0[7] >> 7);
					A_0[6] = A_0[7];
					A_0[7] = b;
					num3++;
					num = (short)1343750144;
					num4 = (int)((global::System.IntPtr)num);
				}
				break;
			case 1:
				goto IL_5D;
			default:
			{
				num = (short)191365120;
				short num5 = num;
				goto IL_5D;
			}
			}
			for (;;)
			{
				IL_7D:
				switch (num4)
				{
				case 0:
					goto IL_AF;
				case 1:
					goto IL_C4;
				case 2:
					return A_0;
				case 3:
					goto IL_AF;
				}
				goto IL_93;
				IL_AF:
				num = (short)1987641345;
				num4 = (int)((global::System.IntPtr)num);
			}
			return A_0;
			IL_5D:
			num = (short)1768488960;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_93;
			}
			goto IL_7D;
			IL_93:
			num3 = 0;
			num = (short)1947533315;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7D;
		}

		// Token: 0x04000005 RID: 5
		private readonly byte[] a = new byte[16];

		// Token: 0x04000006 RID: 6
		private const int b = 16;
	}
}
