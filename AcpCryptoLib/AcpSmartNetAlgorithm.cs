using System;

namespace AcpCryptoLib
{
	// Token: 0x02000014 RID: 20
	public class AcpSmartNetAlgorithm
	{
		// Token: 0x06000043 RID: 67 RVA: 0x000070B0 File Offset: 0x000052B0
		internal byte[] Encrypt(byte[] input)
		{
			short num = (short)841154560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				int num5;
				int num6;
				int num7;
				byte[] array;
				for (;;)
				{
					IL_27:
					num = (short)244885005;
					short num3 = num;
					num = (short)551527949;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)398393344;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_14C;
						case 1:
						{
							num = (short)247463937;
							if (num != 0)
							{
							}
							num = (short)539230208;
							short num4 = num;
							goto IL_117;
						}
						case 2:
							if (num5 >= num6)
							{
								num = (short)2113667072;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num7 += this.a(input[num5], false, array, num7);
							num5++;
							num = (short)1840250883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_117;
						}
						goto IL_87;
					}
					IL_117:
					num = (short)12582914;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14C:
				byte[] array2 = new byte[num7];
				global::System.Array.Copy(array, array2, num7);
				array2[7] = (byte)array2.Length;
				return array2;
				IL_87:
				array = null;
				num6 = input.Length;
				array = new byte[10 + 2 * num6];
				num7 = 0;
				num7 += this.a(input[0], true, array, num7);
				num5 = 1;
				num = (short)1791229953;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00007254 File Offset: 0x00005454
		private int a(byte A_0, bool A_1, byte[] A_2, int A_3)
		{
			short num = (short)1907949568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				byte b;
				int num5;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_311;
					case 1:
						goto IL_480;
					case 2:
						goto IL_406;
					case 3:
						if ((int)b != -27)
						{
							num = (short)1866137605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					case 4:
						goto IL_193;
					case 5:
						num = (short)153747472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (b != 26)
						{
							num = (short)138280982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147;
					case 7:
					{
						byte snetRandomValue = (byte)this.k.SNetRandomValue;
						num = (short)117768201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						int num3;
						if (num3 >= 9)
						{
							num = (short)710803467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_2[num3] = (byte)this.k.NextSNetRandomValue;
						num3++;
						num = (short)2074411028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_FE;
					case 10:
					{
						if (b == 27)
						{
							num = (short)2045444103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)817555057;
						short num4 = num;
						num = (short)1410721393;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CB;
						default:
							num = (short)1318453248;
							if (num != 0)
							{
							}
							b = 229;
							num = (short)536346624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						goto IL_1CB;
					case 12:
						if (b == 27)
						{
							num = (short)1025114126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CC;
					case 13:
						goto IL_480;
					case 14:
						goto IL_147;
					case 15:
						num = (short)568721426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1242169345;
						if (num != 0)
						{
						}
						if (b != 27)
						{
							num = (short)1923874831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					case 17:
					{
						this.k = new global::AcpCryptoLib.AcpRNGenerator();
						int num3 = 0;
						num = (short)1480196100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (b != 26)
						{
							num = (short)1213988885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE;
					case 19:
						if (A_1)
						{
							num = (short)1129054225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 0;
						num = (short)943456269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_193;
					case 21:
					{
						byte snetRandomValue;
						this.k.SNetRandomValue = (int)snetRandomValue;
						num = (short)1341980674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						num = (short)1954742284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B;
					IL_FE:
					b = (byte)this.k.NextSNetRandomValue;
					num = (short)1813381123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_147:
					A_2[num5 + A_3] = 27;
					num5++;
					num = (short)938344458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_193:
					num = (short)331546632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CB:
					A_2[5] = (byte)this.k.NextSNetRandomValue;
					byte b2 = A_2[5];
					A_2[6] = (byte)this.k.NextSNetRandomValue;
					b2 = (byte)((int)(b2 + A_2[6]) % 256);
					A_2[8] = (byte)this.k.NextSNetRandomValue;
					b2 = (byte)((int)(b2 - A_2[8]) % 256);
					this.k.SNetRandomValue = (int)b2;
					this.d = (byte)this.k.NextSNetRandomValue;
					num5 = 9;
					num = (short)1914044417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_480:
					b = (A_0 ^ this.d);
					num = (short)1372913670;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_311:
				IL_406:
				IL_4CC:
				A_2[num5 + A_3] = b;
				num5++;
				byte b3 = (byte)this.k.NextSNetRandomValue;
				this.d = (byte)((int)(this.d + A_0 + b3) % 256);
				return num5;
				IL_8B:
				num = (short)1275527168;
				short num6 = num;
				long ticks = global::System.DateTime.Now.Ticks;
				num = (short)343801875;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00007764 File Offset: 0x00005964
		internal byte[] Decrypt(byte[] input)
		{
			short num = (short)1609236480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				int num4;
				int num5;
				int num6;
				byte[] array;
				bool a_;
				for (;;)
				{
					IL_27:
					num = (short)622030761;
					short num3 = num;
					num = (short)364933033;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1077280768;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_115;
						case 1:
							goto IL_B6;
						case 2:
							if (num4 >= num5)
							{
								num = (short)435879936;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num6 += this.a(input[num4], array, a_, num6);
							a_ = false;
							num4++;
							num = (short)1312030721;
							if (num != 0)
							{
							}
							num = (short)488308739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_B6;
						}
						goto IL_87;
					}
					IL_B6:
					num = (short)159776768;
					short num7 = num;
					num = (short)200998914;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_115:
				byte[] array2 = new byte[num6];
				global::System.Array.Copy(array, array2, num6);
				return array2;
				IL_87:
				num6 = 0;
				num4 = 0;
				num5 = input.Length;
				array = new byte[num5];
				a_ = true;
				num4 = 0;
				num = (short)1716125697;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000078F8 File Offset: 0x00005AF8
		public int DecryptChar(byte in_buf, out byte decrypt_buffer, bool is_first)
		{
			short num = (short)745649521;
			short num2 = num;
			num = (short)2010887537;
			switch (num2 == num)
			{
			}
			num = (short)433324032;
			short num3 = num;
			num = (short)562561024;
			if (num != 0)
			{
			}
			num = (short)1364918273;
			if (num != 0)
			{
			}
			decrypt_buffer = 0;
			byte[] array = new byte[1];
			int num4 = this.a(in_buf, array, is_first, 0);
			if (num4 > 0)
			{
				decrypt_buffer = array[0];
			}
			return num4;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000079C4 File Offset: 0x00005BC4
		private int a(byte A_0, byte[] A_1, bool A_2, int A_3)
		{
			short num = (short)839909376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				int num3;
				byte b;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_4C4;
					case 1:
						this.e = 0U;
						this.f = false;
						this.g = 0;
						this.h = 0;
						this.i = 0;
						this.d = 0;
						this.j = 0;
						this.k = new global::AcpCryptoLib.AcpRNGenerator();
						num = (short)1691746321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return num3;
					case 3:
						this.j = 26;
						num = (short)734003225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.e < 9U)
						{
							num = (short)656998411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)916193290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1193148416;
						short num4 = num;
						num = (short)1918369805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (A_0 == b)
						{
							num = (short)1815543811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.j = 27;
						num = (short)1031077902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1EE;
					case 8:
					{
						uint num5;
						switch (num5)
						{
						case 5U:
							this.g = A_0;
							num = (short)2011365394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6U:
							this.h = A_0;
							num = (short)840761344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7U:
							goto IL_4C4;
						case 8U:
						{
							this.i = A_0;
							int num6 = (int)this.g;
							num6 = (num6 + (int)this.h) % 256;
							num6 = (num6 - (int)this.i) % 256;
							this.k.SNetRandomValue = num6;
							this.d = (byte)this.k.NextSNetRandomValue;
							goto IL_3AD;
						}
						default:
							num = (short)101646341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						goto IL_4C4;
					case 10:
						if (this.f)
						{
							num = (short)1318977555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)251854860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						uint num5 = this.e;
						num = (short)1741815816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (A_0 == 27)
						{
							num = (short)75563029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.j = A_0;
						num3++;
						num = (short)1400242183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_4C4;
					case 14:
						goto IL_D7;
					case 15:
						goto IL_1EE;
					case 16:
						return num3;
					case 17:
						goto IL_185;
					case 18:
						goto IL_4C4;
					case 19:
						b = 229;
						num = (short)396886022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_1EE;
					case 21:
					{
						num = (short)773915083;
						short num7 = num;
						num = (short)571867595;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3AD;
						default:
							num = (short)2070609920;
							if (num != 0)
							{
							}
							this.f = true;
							num = (short)350355471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 22:
						if (A_2)
						{
							num = (short)989200385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_185;
					case 23:
					{
						this.j ^= this.d;
						int nextSNetRandomValue = this.k.NextSNetRandomValue;
						this.d = (byte)(((int)(this.d + this.j) + nextSNetRandomValue) % 256);
						A_1[A_3] = this.j;
						num = (short)1353580546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (num3 != 0)
						{
							num = (short)738131991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num3;
					case 25:
						goto IL_D7;
					}
					goto IL_96;
					IL_D7:
					this.f = false;
					num3++;
					num = (short)832176148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_185:
					num = (short)1214447620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EE:
					num = (short)792592408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AD:
					num = (short)1346764809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C4:
					num = (short)133627905;
					if (num != 0)
					{
					}
					this.e += 1U;
					num = (short)1201537040;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num3;
				IL_96:
				num3 = 0;
				b = 0;
				num = (short)2061697046;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x04000022 RID: 34
		private const int a = 27;

		// Token: 0x04000023 RID: 35
		private const int b = 26;

		// Token: 0x04000024 RID: 36
		private const int c = 0;

		// Token: 0x04000025 RID: 37
		private byte d;

		// Token: 0x04000026 RID: 38
		private uint e;

		// Token: 0x04000027 RID: 39
		private bool f;

		// Token: 0x04000028 RID: 40
		private byte g;

		// Token: 0x04000029 RID: 41
		private byte h;

		// Token: 0x0400002A RID: 42
		private byte i;

		// Token: 0x0400002B RID: 43
		private byte j;

		// Token: 0x0400002C RID: 44
		private global::AcpCryptoLib.AcpRNGenerator k;
	}
}
