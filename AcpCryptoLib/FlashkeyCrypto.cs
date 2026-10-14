using System;
using System.Collections.Generic;

namespace AcpCryptoLib
{
	// Token: 0x02000019 RID: 25
	public class FlashkeyCrypto
	{
		// Token: 0x06000062 RID: 98 RVA: 0x0000A3E0 File Offset: 0x000085E0
		private static bool a(byte[] A_0, uint A_1)
		{
			short num = (short)697171968;
			short num2 = num;
			num = (short)484507649;
			if (num != 0)
			{
			}
			num = (short)882981182;
			short num3 = num;
			num = (short)1138833726;
			switch (num3 == num)
			{
			}
			num = (short)1594687488;
			if (num != 0)
			{
			}
			uint num4 = A_1 >> 3;
			byte b = A_0[(int)(checked((global::System.IntPtr)(unchecked((long)(A_0.Length - 1) - (long)((ulong)num4)))))];
			uint num5 = A_1 & 7U;
			return (b >> (int)(num5 & 31U) & 1) == 1;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000A4A4 File Offset: 0x000086A4
		private static byte[] a(byte[] A_0, uint A_1, byte[] A_2)
		{
			short num = (short)1008795648;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B0;
				}
				uint num4;
				byte[] array;
				global::System.Collections.Generic.List<uint> list;
				global::System.Collections.Generic.List<uint> list2;
				for (;;)
				{
					IL_29:
					uint num5;
					uint num6;
					uint num7;
					uint num9;
					switch (num2)
					{
					case 0:
					{
						num = (short)2127047349;
						short num3 = num;
						num = (short)1635396277;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_558;
						default:
							num = (short)1467219968;
							if (num != 0)
							{
							}
							goto IL_369;
						}
						break;
					}
					case 1:
						goto IL_21D;
					case 2:
						goto IL_302;
					case 3:
						goto IL_143;
					case 4:
						goto IL_21D;
					case 5:
						if (global::AcpCryptoLib.FlashkeyCrypto.a(A_0, num4))
						{
							num = (short)479264791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_143;
					case 6:
					{
						if (num5 <= 0U)
						{
							num = (short)1624768526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = (uint)(((int)array[3] << 24) + ((int)array[2] << 16) + ((int)array[1] << 8) + (int)array[0]);
						num7 = (uint)(((int)array[7] << 24) + ((int)array[6] << 16) + ((int)array[5] << 8) + (int)array[4]);
						uint num8 = num6 >> (int)list[0];
						num9 = num7 >> (int)list2[0];
						int num10 = 1;
						num = (short)174063636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_100;
					case 8:
						num = (short)254410768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						int num11 = 0;
						num = (short)1354432530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if ((ulong)num4 >= (ulong)((long)(A_0.Length * 8)))
						{
							num = (short)387645461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1652490245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (list2.Count != 0)
						{
							num = (short)1512833043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_558;
					case 12:
						goto IL_57C;
					case 13:
						list2.Add(num4 >> 1);
						num = (short)19005455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_3A1;
					case 15:
					{
						num = (short)986710016;
						short num12 = num;
						goto IL_143;
					}
					case 16:
						if (list.Count != 0)
						{
							num = (short)524353563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)397869087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						int num11;
						if (num11 >= list2.Count)
						{
							num = (short)2067202056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num9 = (num7 >> (int)list2[num11] ^ num9);
						num11++;
						num = (short)1516961799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_100;
					case 19:
					{
						uint num8;
						num9 = (num8 ^ num9);
						num = (short)860684314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_57C;
					case 21:
						array = new byte[A_2.Length];
						global::System.Array.Copy(A_2, array, A_2.Length);
						global::System.Array.Reverse(array);
						num5 = A_1;
						num = (short)146407448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						uint num8;
						num9 = (num8 ^ num9);
						num9 &= 1U;
						num = (short)298123265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)80478237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_369;
					case 25:
						goto IL_302;
					case 26:
						goto IL_558;
					case 27:
						num = (short)2032074763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_21D;
					case 29:
						if ((ulong)num4 >= (ulong)((long)(A_0.Length * 4)))
						{
							num = (short)92995597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list.Add(num4);
						num = (short)196083715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						int num10;
						if (num10 >= list.Count)
						{
							num = (short)203816969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num8 = num6 >> (int)list[num10] ^ num8;
						num10++;
						num = (short)433389580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						if (list2.Count != 0)
						{
							num = (short)428736513;
							if (num != 0)
							{
							}
							num = (short)784728086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num8;
						num9 = (num8 ^ 1U);
						num = (short)1972240388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_B0;
					IL_100:
					num = (short)583794705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_143:
					num4 += 1U;
					num = (short)1311244290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21D:
					uint num13 = num7 << 31 | num6 >> 1;
					uint num14 = num9 << 31 | num7 >> 1;
					array[0] = (byte)num13;
					array[1] = (byte)(num13 >> 8);
					array[2] = (byte)(num13 >> 16);
					array[3] = (byte)(num13 >> 24);
					array[4] = (byte)num14;
					array[5] = (byte)(num14 >> 8);
					array[6] = (byte)(num14 >> 16);
					array[7] = (byte)(num14 >> 24);
					num5 -= 1U;
					num = (short)693501952;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_302:
					num = (short)641662986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_369:
					num = (short)1894121478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_558:
					num9 &= 1U;
					num = (short)1245970460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_57C:
					num = (short)717553694;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3A1:
				global::System.Array.Reverse(array);
				return array;
				IL_B0:
				list = new global::System.Collections.Generic.List<uint>();
				list2 = new global::System.Collections.Generic.List<uint>();
				num4 = 0U;
				num = (short)827916313;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000AB34 File Offset: 0x00008D34
		private static byte[] a(byte[] A_0, byte[] A_1)
		{
			short num = (short)1689190400;
			short num2 = num;
			num = (short)216530945;
			if (num != 0)
			{
			}
			num = (short)1340317153;
			short num3 = num;
			num = (short)1651809761;
			switch (num3 == num)
			{
			}
			num = (short)87490560;
			if (num != 0)
			{
			}
			uint a_ = (uint)A_0[0] + 256U >> 3;
			uint num4 = (uint)(A_0[0] & 3);
			byte[] array = new byte[32];
			byte[] sourceArray = global::AcpCryptoLib.FlashkeyCrypto.a(global::AcpCryptoLib.FlashkeyCrypto.b[(int)(num4 % 4U)], a_, A_0);
			byte[] sourceArray2 = global::AcpCryptoLib.FlashkeyCrypto.a(global::AcpCryptoLib.FlashkeyCrypto.b[(int)((num4 + 1U) % 4U)], a_, A_0);
			byte[] sourceArray3 = global::AcpCryptoLib.FlashkeyCrypto.a(global::AcpCryptoLib.FlashkeyCrypto.b[(int)((num4 + 2U) % 4U)], a_, A_0);
			global::System.Array sourceArray4 = global::AcpCryptoLib.FlashkeyCrypto.a(global::AcpCryptoLib.FlashkeyCrypto.b[(int)((num4 + 3U) % 4U)], a_, A_1 ?? A_0);
			global::System.Array.Copy(sourceArray, 0, array, 0, 8);
			global::System.Array.Copy(sourceArray2, 0, array, 8, 8);
			global::System.Array.Copy(sourceArray3, 0, array, 16, 8);
			global::System.Array.Copy(sourceArray4, 0, array, 24, 8);
			return array;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000AC78 File Offset: 0x00008E78
		public void Init(byte[] serialNum, byte[] wccVals)
		{
			int a_ = 1;
			short num = (short)617807874;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)975568896;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_92;
				case 1:
					IL_D4:
					if (wccVals.Length != 8)
					{
						num = (short)1242759171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_78;
					}
					continue;
				case 3:
					goto IL_F4;
				case 4:
					if (serialNum.Length != 8)
					{
						num = (short)444727303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)180355077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (wccVals != null)
					{
						num = (short)262340614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BE;
				case 6:
					num = (short)467599361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_183;
				}
				IL_78:
				if (serialNum == null)
				{
					num = (short)1730215936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)947912708;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BE:
				num = (short)1981827490;
				short num4 = num;
				num = (short)790514082;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D4;
				default:
					goto IL_1F4;
				}
			}
			IL_92:
			num = (short)214433793;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("珿朁瘃漅椇昉䈋笍紏", a_));
			IL_F4:
			throw new global::System.ArgumentException(global::AcpCryptoLib.XmlEncryptionUtil.b("叿欁縃挅⠇攉樋⸍朏焑眓䀕礗瘙漛㸝匟䨡䔣䨥䐧਩丫䬭ု਱ᐳ吵䄷丹夻䴽", a_), global::AcpCryptoLib.XmlEncryptionUtil.b("矿愁會倅椇昉缋", a_));
			IL_183:
			throw new global::System.ArgumentException(global::AcpCryptoLib.XmlEncryptionUtil.b("叿欁縃挅⠇攉樋⸍挏眑易缕礗瘙创欝䴟ȡ圣严䤧䘩䀫อ刯圱ᐳีᠷ堹䔻䨽┿ㅁ", a_), global::AcpCryptoLib.XmlEncryptionUtil.b("珿朁瘃漅椇昉䈋笍紏", a_));
			IL_1F4:
			num = (short)1962082304;
			if (num != 0)
			{
			}
			this.a.Init(global::AcpCryptoLib.FlashkeyCrypto.a(serialNum, wccVals));
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000AEA0 File Offset: 0x000090A0
		public byte[] Encrypt(byte[] data)
		{
			int a_ = 6;
			short num = (short)856948737;
			if (num != 0)
			{
			}
			num = (short)612892672;
			short num2 = num;
			num = (short)566118626;
			short num3 = num;
			num = (short)1120356578;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)110034944;
				if (num != 0)
				{
				}
				if (data != null)
				{
					return this.a.Encrypt(data);
				}
				break;
			}
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("愄昆紈樊", a_));
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000AF78 File Offset: 0x00009178
		public byte[] Decrypt(byte[] data)
		{
			int a_ = 15;
			short num = (short)1116143617;
			if (num != 0)
			{
			}
			num = (short)1446379520;
			short num2 = num;
			num = (short)599721396;
			short num3 = num;
			num = (short)15533492;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1194917888;
				if (num != 0)
				{
				}
				if (data != null)
				{
					return this.a.Decrypt(data);
				}
				break;
			}
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("樍焏昑甓", a_));
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000B070 File Offset: 0x00009270
		// Note: this type is marked as 'beforefieldinit'.
		static FlashkeyCrypto()
		{
			short num = (short)1455947776;
			short num2 = num;
			num = (short)184959504;
			short num3 = num;
			num = (short)1681408528;
			switch (num3 == num)
			{
			}
			num = (short)690683905;
			if (num != 0)
			{
			}
			num = (short)621674496;
			if (num != 0)
			{
			}
			global::AcpCryptoLib.FlashkeyCrypto.b = new byte[][]
			{
				new byte[]
				{
					0,
					0,
					64,
					0,
					0,
					0,
					1,
					47
				},
				new byte[]
				{
					8,
					0,
					0,
					0,
					0,
					0,
					0,
					123
				},
				new byte[]
				{
					0,
					1,
					0,
					0,
					0,
					0,
					0,
					183
				},
				new byte[]
				{
					64,
					0,
					0,
					0,
					0,
					0,
					0,
					105
				}
			};
		}

		// Token: 0x04000038 RID: 56
		private readonly global::AcpCryptoLib.Blowfish a = new global::AcpCryptoLib.Blowfish(true);

		// Token: 0x04000039 RID: 57
		private static readonly byte[][] b;
	}
}
