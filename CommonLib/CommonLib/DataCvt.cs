using System;
using System.Collections;
using System.Globalization;
using System.Text;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.CommonLib
{
	// Token: 0x0200000E RID: 14
	public class DataCvt
	{
		// Token: 0x06000035 RID: 53 RVA: 0x0000934C File Offset: 0x0000754C
		public string GetString(object val)
		{
			short num;
			int num3;
			string result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)427426763;
					short num2 = num;
					num = (short)333317067;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A2;
					default:
						num = (short)48889856;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							return result;
						case 1:
							if (val != null)
							{
								num = (short)1439760387;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 2:
						{
							global::System.Array array;
							if (array != null)
							{
								num = (short)685178885;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = global::System.Convert.ToString(val, global::System.Globalization.CultureInfo.InvariantCulture);
							num = (short)2037907460;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::System.Array array = val as global::System.Array;
							num = (short)537657346;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							return result;
						case 5:
						{
							global::System.Array array;
							result = this.a(array);
							num = (short)1187184640;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_72;
					}
				}
				return result;
			}
			IL_72:
			num = (short)1059192832;
			short num4 = num;
			result = string.Empty;
			IL_A2:
			num = (short)1091043329;
			if (num != 0)
			{
			}
			num = (short)771620865;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000094E4 File Offset: 0x000076E4
		public uint HexStringToDec(string sHex)
		{
			short num = (short)1000669184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				uint num5;
				for (;;)
				{
					IL_1E:
					switch (0)
					{
					case 0:
						goto IL_B4;
					}
					int num6;
					int length;
					for (;;)
					{
						IL_28:
						num = (short)2021720064;
						short num3 = num;
						num = (short)1214181772;
						short num4 = num;
						num = (short)801042828;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E;
						default:
							num = (short)34734080;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								return num5;
							case 1:
								goto IL_DA;
							case 2:
							{
								num = (short)1148518401;
								if (num != 0)
								{
								}
								if (num6 >= length)
								{
									num = (short)1165426688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								uint num7 = (uint)this.a(global::System.Convert.ToChar(sHex.Substring(num6, 1), global::System.Globalization.CultureInfo.InvariantCulture));
								num5 += num7 * global::System.Convert.ToUInt32(global::System.Math.Pow(16.0, (double)(length - 1 - num6)));
								num6++;
								num = (short)1318256643;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_DA;
							}
							goto IL_B4;
							IL_DA:
							num = (short)1554513922;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_B4:
					num5 = 0U;
					length = sHex.Length;
					num6 = 0;
					num = (short)1025966081;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				return num5;
			}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00009688 File Offset: 0x00007888
		public string ConvertDecToHexString(ulong ulVal, int length)
		{
			short num = (short)1153040384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				global::System.Text.StringBuilder stringBuilder;
				ulong num4;
				int num8;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						int num3;
						if (num3 >= length - stringBuilder.ToString().Length)
						{
							num = (short)761397254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stringBuilder.Insert(0, '0');
						num3++;
						num = (short)1509228548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_6C;
					case 2:
					{
						int num3 = 0;
						num = (short)854392837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (num4 == 0UL)
						{
							num = (short)491978754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E1;
					case 4:
						goto IL_14A;
					case 5:
						goto IL_14A;
					case 6:
					{
						num = (short)726990848;
						short num5 = num;
						num = (short)1267625564;
						short num6 = num;
						num = (short)1950903900;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6C;
						default:
							goto IL_1F0;
						}
						break;
					}
					}
					goto IL_4C;
					IL_E1:
					int num7 = (int)global::System.Math.Pow(16.0, (double)num8);
					int a_ = (int)num4 % num7;
					char value = this.a(a_);
					stringBuilder.Insert(0, value);
					num4 /= (ulong)((long)num7);
					num = (short)1233977347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C:
					num = (short)1299906561;
					if (num != 0)
					{
					}
					goto IL_E1;
					IL_14A:
					num = (short)2036269056;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F0:
				num = (short)1945239552;
				if (num != 0)
				{
				}
				return stringBuilder.ToString();
				IL_4C:
				stringBuilder = new global::System.Text.StringBuilder();
				num4 = ulVal;
				num8 = 1;
				num = (short)1014890497;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000098A4 File Offset: 0x00007AA4
		public void ConvertHexStringToByteArray(string shex, out byte[] bDB)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
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
					return;
				case 1:
					goto IL_47;
				case 2:
				{
					if (num2 >= shex.Length / 2)
					{
						goto IL_106;
					}
					string a_ = shex.Substring(num2 * 2, 2);
					byte b;
					this.a(a_, out b);
					bDB[num2] = b;
					num2++;
					num3 = (short)1926496259;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 3:
					goto IL_47;
				}
				goto IL_20;
				IL_47:
				num3 = (short)297404498;
				short num4 = num3;
				num3 = (short)763168850;
				switch ((num4 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_106:
					num3 = (short)174587904;
					num = (int)((global::System.IntPtr)num3);
					break;
				default:
				{
					num3 = (short)718536704;
					short num5 = num3;
					num3 = (short)1870069760;
					if (num3 != 0)
					{
					}
					num3 = (short)1814102017;
					if (num3 != 0)
					{
					}
					num3 = (short)148504578;
					num = (int)((global::System.IntPtr)num3);
					break;
				}
				}
			}
			return;
			IL_20:
			bDB = new byte[shex.Length / 2];
			num2 = 0;
			num3 = (short)1021706241;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00009A0C File Offset: 0x00007C0C
		public string ConvertByteArrayToHexString(byte[] bBCD)
		{
			int a_ = 12;
			short num = (short)1846738944;
			switch (num)
			{
			default:
			{
				num = (short)1484849152;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Text.StringBuilder stringBuilder;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 1:
						goto IL_BF;
					case 2:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_E9;
							}
							int num3;
							for (;;)
							{
								IL_CE:
								switch (num2)
								{
								case 0:
									goto IL_15E;
								case 1:
									goto IL_15E;
								case 2:
								{
									if (num3 >= bBCD.Length)
									{
										num = (short)233242628;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num4 = (int)(bBCD[num3] / 16);
									char c = this.a(num4);
									int a_2 = (int)bBCD[num3] - num4 * 16;
									char c2 = this.a(a_2);
									stringBuilder.Append(c.ToString()).Append(c2.ToString());
									num3++;
									num = (short)361627648;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_1AF;
								case 4:
									num = (short)2048262147;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_E9;
								IL_15E:
								num = (short)705757186;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1AF:
							goto IL_240;
							IL_E9:
							num3 = 0;
							num = (short)593559553;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_CE;
						}
						catch
						{
							throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("甏怑易礕樗", a_));
						}
						goto IL_1C9;
					}
					IL_59:
					num = (short)1878470208;
					short num5 = num;
					num = (short)974925376;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)860815360;
						if (num != 0)
						{
						}
						if (bBCD == null)
						{
							num = (short)1442119681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_1C9:
					num = (short)1795555328;
					short num6 = num;
					stringBuilder = new global::System.Text.StringBuilder();
					num = (short)210567170;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BF:
				num = (short)311885825;
				if (num != 0)
				{
				}
				return string.Empty;
				IL_240:
				return stringBuilder.ToString();
			}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00009C70 File Offset: 0x00007E70
		public void ConvertNum2ByteArray(object value, byte[] legacyArray)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			byte[] bytes;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_B7;
				case 1:
					global::System.Array.Reverse(bytes);
					num2 = (short)1189347330;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_11D;
				}
				goto IL_1C;
			}
			IL_B7:
			if (global::System.BitConverter.IsLittleEndian)
			{
				goto IL_BE;
			}
			IL_11D:
			this.a(legacyArray, bytes);
			return;
			IL_1C:
			num2 = (short)1960378369;
			if (num2 != 0)
			{
			}
			bytes = global::System.BitConverter.GetBytes(global::System.Convert.ToInt64(value, global::System.Globalization.CultureInfo.InvariantCulture));
			num2 = (short)1461935284;
			short num3 = num2;
			num2 = (short)1791909044;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BE:
				num2 = (short)1847590912;
				short num4 = num2;
				num2 = (short)1866792961;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1550712832;
				if (num2 != 0)
				{
				}
				num2 = (short)330366976;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00009DA4 File Offset: 0x00007FA4
		public object ConvertByteArray2Num(byte[] byteArray, global::System.Type legacyType)
		{
			short num = (short)2074214400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_EB;
				}
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						num = (short)697565219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_707;
					case 2:
						goto IL_67F;
					case 3:
						num = (short)1888944158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_4B4;
					case 5:
						goto IL_5F3;
					case 6:
						goto IL_5FD;
					case 7:
						num = (short)2072707077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (legacyType == typeof(short))
						{
							num = (short)1599537193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)572194853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1859780640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_37D;
					case 11:
						if (byteArray.Length > 4)
						{
							num = (short)1326776346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)74186762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)996802593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (legacyType == typeof(int))
						{
							num = (short)1579286548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1881931791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_1FC;
					case 15:
						if (legacyType == typeof(uint))
						{
							num = (short)850460703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)938016790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_69A;
					case 17:
						if (byteArray.Length > 2)
						{
							num = (short)1468858380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1977090064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1318977565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_35E;
					case 20:
					{
						num = (short)1705684957;
						short num3 = num;
						num = (short)1659285469;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6EF;
						default:
							num = (short)2061959168;
							if (num != 0)
							{
							}
							num = (short)630652929;
							if (num != 0)
							{
							}
							num = (short)1906573350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
						if (byteArray.Length > 8)
						{
							num = (short)311754759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)274661421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (legacyType == typeof(long))
						{
							num = (short)1747582979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)201130012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (global::System.BitConverter.IsLittleEndian)
						{
							num = (short)1180893218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FD;
					case 24:
						if (legacyType == typeof(sbyte))
						{
							num = (short)1271595008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1696071688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_594;
					case 26:
						num = (short)447676420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)449708053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (legacyType == typeof(ulong))
						{
							num = (short)1234436123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_83B;
					case 29:
						goto IL_436;
					case 30:
						if (byteArray.Length > 8)
						{
							num = (short)971046921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)374800403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)868483083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_274;
					case 33:
						goto IL_193;
					case 34:
						global::System.Array.Reverse(byteArray);
						num = (short)438173702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (byteArray.Length == 0)
						{
							num = (short)1716453378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_410;
					case 36:
						if (legacyType == typeof(byte))
						{
							num = (short)591527982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1724055576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (legacyType == typeof(ushort))
						{
							num = (short)678756394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1566244877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (byteArray.Length > 4)
						{
							num = (short)230162471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)452001817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num = (short)545194027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (byteArray.Length > 2)
						{
							num = (short)1745027090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2023751694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)447545384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)458620945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_171;
					case 44:
						if (byteArray.Length == 0)
						{
							goto IL_6EF;
						}
						goto IL_768;
					case 45:
						goto IL_6B8;
					case 46:
						num = (short)1700593708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
					IL_5FD:
					num = (short)622329892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6EF:
					num = (short)1745092609;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_171:
				int num4 = byteArray.Length - 4;
				goto IL_44E;
				IL_193:
				int num5 = byteArray.Length - 2;
				goto IL_202;
				IL_1FC:
				int num6 = 0;
				goto IL_6BE;
				IL_202:
				int startIndex = num5;
				return global::System.BitConverter.ToUInt16(byteArray, startIndex);
				IL_274:
				int num7 = byteArray.Length - 8;
				goto IL_70C;
				IL_35E:
				num7 = 0;
				goto IL_70C;
				IL_37D:
				int num8 = 0;
				goto IL_440;
				IL_410:
				return (sbyte)byteArray[byteArray.Length - 1];
				IL_436:
				num6 = byteArray.Length - 2;
				goto IL_6BE;
				IL_440:
				int startIndex2 = num8;
				return global::System.BitConverter.ToUInt32(byteArray, startIndex2);
				IL_44E:
				int startIndex3 = num4;
				return global::System.BitConverter.ToInt32(byteArray, startIndex3);
				IL_4B4:
				num8 = byteArray.Length - 4;
				goto IL_440;
				IL_594:
				num4 = 0;
				goto IL_44E;
				IL_5F3:
				int num9 = byteArray.Length - 8;
				goto IL_79D;
				IL_67F:
				return 0;
				IL_69A:
				num5 = 0;
				goto IL_202;
				IL_6B8:
				num9 = 0;
				goto IL_79D;
				IL_6BE:
				int startIndex4 = num6;
				return global::System.BitConverter.ToInt16(byteArray, startIndex4);
				IL_707:
				return 0;
				IL_70C:
				int startIndex5 = num7;
				return global::System.BitConverter.ToInt64(byteArray, startIndex5);
				IL_768:
				num = (short)874905600;
				short num10 = num;
				return byteArray[byteArray.Length - 1];
				IL_79D:
				int startIndex6 = num9;
				return global::System.BitConverter.ToUInt64(byteArray, startIndex6);
				IL_83B:
				return null;
				IL_EB:
				byteArray = (byteArray.Clone() as byte[]);
				num = (short)1981546519;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000A5F0 File Offset: 0x000087F0
		private void a(byte[] A_0, byte[] A_1)
		{
			short num = (short)988151808;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1795162113;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 1:
				{
					num = (short)2016608690;
					short num3 = num;
					num = (short)1382285746;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F8;
					case 1:
						goto IL_D3;
					}
					goto Block_2;
				}
				case 2:
					goto IL_12E;
				case 3:
					if (A_0.Length > A_1.Length)
					{
						num = (short)978321410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_131;
				}
				IL_5A:
				if (A_1.Length == 0)
				{
					num = (short)1392312321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F8:
				num = (short)1617887235;
				num2 = (int)((global::System.IntPtr)num);
			}
			Block_2:
			num = (short)1653997568;
			short num4 = num;
			IL_D3:
			num = (short)796786688;
			if (num != 0)
			{
			}
			return;
			IL_12E:
			global::System.Array.Copy(A_1, 0, A_0, 0, A_1.Length);
			return;
			IL_131:
			global::System.Array.Copy(A_1, A_1.Length - A_0.Length, A_0, 0, A_0.Length);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000A740 File Offset: 0x00008940
		private string a(global::System.Array A_0)
		{
			int a_ = 17;
			short num = (short)858390528;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				byte[] array;
				string text;
				for (;;)
				{
					IL_32:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)215220225;
						if (num != 0)
						{
						}
						num = (short)470451192;
						short num3 = num;
						num = (short)1261929464;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11B;
						case 1:
							break;
						default:
						{
							num = (short)2116550656;
							short num4 = num;
							break;
						}
						}
						num = (short)1264320512;
						if (num != 0)
						{
						}
						if (array != null)
						{
							num = (short)1194000385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_309;
					}
					case 1:
						goto IL_11B;
					case 2:
						try
						{
							num = (short)699858949;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::System.Array array2;
									text += this.a(array2);
									num = (short)147456006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::System.Array array2;
									if (array2 != null)
									{
										num = (short)633536513;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj;
									text += obj.ToString();
									num = (short)1054015496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2010513412;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object obj = enumerator.Current;
									global::System.Array array2 = obj as global::System.Array;
									num = (short)364314626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)2013921287;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_16B;
									}
									continue;
								case 6:
									goto IL_1B2;
								case 7:
									goto IL_28E;
								case 8:
									goto IL_1B2;
								}
								goto IL_16B;
								IL_1B2:
								text += global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㤔", a_);
								num = (short)1000603648;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E1:
								num = (short)186580995;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16B:
								goto IL_1E1;
							}
							IL_28E:
							goto IL_359;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2B0;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_29D:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)711458817;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_308;
								case 1:
									disposable.Dispose();
									num = (short)1334640642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_306;
								}
								goto IL_2B0;
							}
							IL_306:
							IL_308:
							goto EndFinally_8;
							IL_2B0:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1306787840;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_29D;
							EndFinally_8:;
						}
						goto IL_309;
					}
					goto IL_45;
					IL_309:
					text = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("渔", a_);
					enumerator = A_0.GetEnumerator();
					num = (short)649658370;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				return global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("└伖", a_) + this.ConvertByteArrayToHexString(array);
				IL_359:
				text += global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("栔", a_);
				return text;
				IL_45:
				array = (A_0 as byte[]);
				num = (short)1213726720;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000AAD8 File Offset: 0x00008CD8
		private int a(char A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			int result;
			char c;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1752498177;
					if (num2 != 0)
					{
					}
					if (A_0 <= 'F')
					{
						num2 = (short)122224643;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13D;
				case 1:
					return result;
				case 2:
					result = (int)global::System.Convert.ToInt16(c.ToString(), global::System.Globalization.CultureInfo.InvariantCulture);
					num2 = (short)4259844;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					result = (int)(global::System.Convert.ToInt16(A_0) - 65 + 10);
					num2 = (short)1974075393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				case 5:
					if (char.IsDigit(c))
					{
						num2 = (short)1385627650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A4;
				case 6:
					if (A_0 >= 'A')
					{
						num2 = (short)2140405767;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13D;
				case 7:
				{
					num2 = (short)1980104704;
					short num3 = num2;
					num2 = (short)960167936;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					return result;
				}
				goto IL_34;
				IL_13D:
				num2 = (short)1244909766;
				short num4 = num2;
				num2 = (short)1613615302;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1A4:
					num2 = (short)640090118;
					num = (int)((global::System.IntPtr)num2);
					break;
				default:
					num2 = (short)470155264;
					if (num2 != 0)
					{
					}
					result = 0;
					num2 = (short)1391067144;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			return result;
			IL_34:
			c = global::System.Convert.ToChar(A_0.ToString().ToUpperInvariant(), global::System.Globalization.CultureInfo.InvariantCulture);
			num2 = (short)926613509;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000ACF0 File Offset: 0x00008EF0
		public double FrequencyConvertFromCP2GUI(object cpValue, bool kiloHertz)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			double result;
			short num2;
			for (;;)
			{
				IL_0A:
				double num3;
				switch (num)
				{
				case 0:
					return result;
				case 1:
					if (kiloHertz)
					{
						num2 = (short)163774466;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3 /= 200000.0;
					num2 = (short)478216197;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_185;
				case 3:
				{
					num3 = global::System.Convert.ToDouble(cpValue, global::System.Globalization.CultureInfo.InvariantCulture);
					num2 = (short)1485672261;
					short num4 = num2;
					num2 = (short)970886981;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_185;
					default:
					{
						num2 = (short)1275920384;
						short num5 = num2;
						num2 = (short)167641089;
						if (num2 != 0)
						{
						}
						num2 = (short)384172032;
						if (num2 != 0)
						{
						}
						num2 = (short)1977548801;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 4:
					goto IL_68;
				case 5:
					goto IL_68;
				case 6:
					if (cpValue != null)
					{
						num2 = (short)1226506243;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_187;
				}
				goto IL_2C;
				IL_68:
				result = num3;
				num2 = (short)1928200192;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_185:
				num3 /= 200.0;
				num2 = (short)1519255556;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_187:
			throw new global::System.ArgumentException();
			IL_2C:
			result = 0.0;
			num2 = (short)1601503238;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000AEB4 File Offset: 0x000090B4
		private char a(int A_0)
		{
			int a_ = 9;
			char result = '\0';
			short num;
			try
			{
				num = (short)1650655241;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						result = A_0.ToString(global::System.Globalization.CultureInfo.InvariantCulture)[0];
						num = (short)1462829058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1624834053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_19C;
					case 3:
						goto IL_201;
					case 4:
						goto IL_162;
					case 5:
						IL_141:
						if (A_0 <= 9)
						{
							num = (short)1899823104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99;
					case 6:
						if (A_0 >= 0)
						{
							num = (short)1131872257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99;
					case 7:
						goto IL_19C;
					case 8:
						if (A_0 < 0)
						{
							num = (short)866451466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_162;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 10:
						goto IL_7D;
					case 11:
						num = (short)2038235144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_62:
					if (A_0 <= 15)
					{
						num = (short)537198603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7D:
					A_0 = 0;
					num = (short)833224708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_99:
					result = global::System.Convert.ToChar(65 + A_0 - 10);
					num = (short)1826357255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19C:
					num = (short)978042286;
					short num3 = num;
					num = (short)172473774;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
						num = (short)1295646720;
						if (num != 0)
						{
						}
						num = (short)1778450435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_162:
					num = (short)7733254;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_201:;
			}
			catch
			{
				throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䤌渎攐爒㔔吖瘘甚欜稞匠圢Ԥ䈦嬨太䈬崮", a_));
			}
			num = (short)2078474241;
			if (num != 0)
			{
			}
			num = (short)1364787200;
			short num4 = num;
			return result;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000B14C File Offset: 0x0000934C
		private void a(string A_0, out byte A_1)
		{
			int a_ = 9;
			short num = (short)1128923136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)236388353;
				if (num != 0)
				{
				}
				num = (short)162791424;
				short num3 = num;
				int num4 = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_E0;
					}
					int num6;
					int num7;
					int num8;
					for (;;)
					{
						IL_85:
						switch (num2)
						{
						case 0:
							goto IL_2E6;
						case 1:
							goto IL_2E6;
						case 2:
							goto IL_2E6;
						case 3:
							num = (short)51576851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1E7;
						case 5:
						{
							char c;
							if (!c.Equals('X'))
							{
								num = (short)1332477964;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_40A;
						}
						case 6:
							goto IL_2E6;
						case 7:
							goto IL_2E6;
						case 8:
						{
							num = (short)792075089;
							short num5 = num;
							num = (short)1360272209;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_33C;
							default:
								num = (short)1433075712;
								if (num != 0)
								{
								}
								num = (short)565706772;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
						{
							char c;
							if (!c.Equals('x'))
							{
								num = (short)1030356995;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_40A;
						}
						case 10:
							goto IL_33C;
						case 11:
							goto IL_1E7;
						case 12:
							num = (short)261750793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							if (num6 < 0)
							{
								num = (short)496959505;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							char c = A_0[num6];
							num = (short)1447428101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
						{
							char c;
							num7 = (int)(c - '0');
							num = (short)1891631111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							num = (short)762052622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							goto IL_2E6;
						case 17:
							goto IL_40A;
						case 18:
							goto IL_423;
						case 19:
						{
							char c;
							switch (c)
							{
							case 'A':
								goto IL_33E;
							case 'B':
								goto IL_3C8;
							case 'C':
								goto IL_225;
							case 'D':
								goto IL_3E8;
							case 'E':
								goto IL_1C7;
							case 'F':
								goto IL_321;
							default:
								num = (short)1867317256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 20:
						{
							char c;
							switch (c)
							{
							case 'a':
								goto IL_33E;
							case 'b':
								goto IL_3C8;
							case 'c':
								goto IL_225;
							case 'd':
								goto IL_3E8;
							case 'e':
								goto IL_1C7;
							case 'f':
								goto IL_321;
							default:
								num = (short)1560805391;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_E0;
						IL_1C7:
						num7 = 14;
						num = (short)255000592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1E7:
						num = (short)1144455181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_225:
						num7 = 12;
						num = (short)1834090497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2E6:
						num4 += (int)global::System.Math.Pow(16.0, (double)(num8 - num6 - 1)) * num7;
						num6--;
						num = (short)171114500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_33C:
						goto IL_2E6;
						IL_321:
						num7 = 15;
						num = (short)2075656202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_33E:
						num7 = 10;
						num = (short)573374466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3C8:
						num7 = 11;
						num = (short)1323433984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3E8:
						num7 = 13;
						num = (short)1799684102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_40A:
						num = (short)1262157842;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_423:
					goto IL_43A;
					IL_E0:
					num8 = 0;
					num8 = A_0.Length;
					num7 = 0;
					num6 = num8 - 1;
					num = (short)1514995723;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_85;
				}
				catch
				{
					throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䤌渎攐爒㔔吖瘘甚欜稞匠圢Ԥ䈦嬨太䈬崮", a_));
				}
				IL_43A:
				A_1 = (byte)num4;
				return;
			}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000B5B4 File Offset: 0x000097B4
		public int CvtByteArray2Integer(byte[] uiCPValue, bool bBigEndian)
		{
			int a_ = 6;
			short num = (short)1104347136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1561657345;
				if (num != 0)
				{
				}
				num = (short)1272905728;
				short num3 = num;
				int num4 = 0;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_BB;
					}
					int num8;
					for (;;)
					{
						IL_84:
						switch (num2)
						{
						case 0:
							goto IL_28A;
						case 1:
							num = (short)1090060288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							int num5;
							if (num5 < 0)
							{
								num = (short)369885189;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num6 = (int)uiCPValue[num5];
							num4 += (int)global::System.Math.Pow(256.0, (double)num5) * num6;
							num5--;
							goto IL_158;
						}
						case 3:
							goto IL_2A4;
						case 4:
							goto IL_24F;
						case 5:
							goto IL_28A;
						case 6:
						{
							int num7;
							if (num7 >= num8)
							{
								num = (short)491323393;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num9 = (int)uiCPValue[num7];
							num4 += (int)global::System.Math.Pow(256.0, (double)(num8 - num7 - 1)) * num9;
							num7++;
							num = (short)1757741060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							num = (short)4018745;
							short num10 = num;
							num = (short)982864441;
							switch ((num10 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_158;
							default:
								num = (short)1453981696;
								if (num != 0)
								{
								}
								goto IL_1F9;
							}
							break;
						}
						case 8:
							goto IL_24F;
						case 9:
						{
							if (bBigEndian)
							{
								num = (short)1069547531;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num5 = num8 - 1;
							num = (short)2088566794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_1F9;
						case 11:
						{
							int num7 = 0;
							num = (short)338624520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_BB;
						IL_158:
						num = (short)430768135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F9:
						num = (short)1046020098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_24F:
						num = (short)801701894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_28A:
						num = (short)2082406403;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2A4:
					return num4;
					IL_BB:
					num8 = uiCPValue.Length;
					num = (short)1255997449;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_84;
				}
				catch
				{
					throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("三洋稍焏㈑圓礕瘗氙礛氝吟ȡ䄣吥娧䔩師", a_));
				}
				return num4;
			}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000B89C File Offset: 0x00009A9C
		public byte[] CvtInt2ByteArray(int iCPValue, int iLength, bool bBigEndian)
		{
			int a_ = 14;
			byte[] array = new byte[iLength];
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				int num;
				int num4;
				for (;;)
				{
					IL_1C:
					switch (num)
					{
					case 0:
						num2 = (short)352649222;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						checked
						{
							int num3 = iCPValue / (int)global::System.Math.Pow(256.0, (double)num4);
							iCPValue -= num3 * (int)global::System.Math.Pow(256.0, (double)num4);
							num2 = (short)304480260;
						}
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_117;
					case 3:
						goto IL_A4;
					case 4:
						goto IL_117;
					case 5:
					{
						if (num4 < 0)
						{
							num2 = (short)346095616;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						int num3 = 0;
						num2 = (short)808845319;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 6:
						goto IL_1DA;
					case 7:
						if (bBigEndian)
						{
							num2 = (short)1507917825;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_18B;
					case 8:
						goto IL_A4;
					}
					goto IL_46;
					IL_A4:
					num2 = (short)722468869;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_117:
					num2 = (short)784990858;
					short num5 = num2;
					num2 = (short)943784586;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_18B:
						int num3 = checked(iCPValue - iCPValue / 256 * 256);
						iCPValue /= 256;
						num2 = (short)372834306;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					default:
						num2 = (short)630587392;
						if (num2 != 0)
						{
						}
						checked
						{
							int num3;
							array[iLength - 1 - num4] = (byte)num3;
							num4--;
							num2 = (short)1442840579;
						}
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_1DA:
				goto IL_1F1;
				IL_46:
				num4 = checked(iLength - 1);
				num2 = (short)1131282440;
				num = (int)((global::System.IntPtr)num2);
				goto IL_1C;
			}
			catch
			{
				throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("嘑甓戕礗㨙弛焝丟吡䄣吥尧਩䤫尭䈯崱䘳", a_));
			}
			IL_1F1:
			num2 = (short)1429143553;
			if (num2 != 0)
			{
			}
			num2 = (short)634126336;
			short num6 = num2;
			return array;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000BB08 File Offset: 0x00009D08
		public byte[] CvtULong2ByteArray(ulong lCPValue, int iLength, bool bBigEndian)
		{
			int a_ = 7;
			byte[] array = new byte[iLength];
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				int num;
				int num4;
				for (;;)
				{
					IL_1C:
					switch (num)
					{
					case 0:
						num2 = (short)301858822;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						checked
						{
							ulong num3 = lCPValue / (ulong)global::System.Math.Pow(256.0, (double)num4);
							lCPValue -= num3 * (ulong)global::System.Math.Pow(256.0, (double)num4);
							num2 = (short)109772804;
						}
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_11C;
					case 3:
						goto IL_A6;
					case 4:
						goto IL_11C;
					case 5:
					{
						if (num4 < 0)
						{
							num2 = (short)1362493440;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						ulong num3 = 0UL;
						num2 = (short)370606087;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 6:
						goto IL_208;
					case 7:
						if (bBigEndian)
						{
							num2 = (short)306905089;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B9;
					case 8:
						goto IL_A6;
					}
					goto IL_46;
					IL_A6:
					num2 = (short)259260421;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_11C:
					num2 = (short)515240287;
					short num5 = num2;
					num2 = (short)1266807135;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_1B9:
						ulong num3 = checked(lCPValue - lCPValue / 256UL * 256UL);
						lCPValue /= 256UL;
						num2 = (short)553779202;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					default:
						num2 = (short)947847169;
						if (num2 != 0)
						{
						}
						num2 = (short)881524736;
						if (num2 != 0)
						{
						}
						checked
						{
							ulong num3;
							array[iLength - 1 - num4] = (byte)num3;
							num4--;
							num2 = (short)1780023299;
						}
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_208:
				goto IL_21F;
				IL_46:
				num4 = checked(iLength - 1);
				num2 = (short)1584070664;
				num = (int)((global::System.IntPtr)num2);
				goto IL_1C;
			}
			catch
			{
				throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("伊氌笎瀐㌒嘔砖眘洚砜洞唠̢䀤唦嬨䐪弬", a_));
			}
			IL_21F:
			num2 = (short)492830720;
			short num6 = num2;
			return array;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000BD7C File Offset: 0x00009F7C
		public ulong CvtByteArray2UInt64(byte[] uiCPValue, bool bBigEndian)
		{
			int a_ = 4;
			short num = (short)1844903936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1973288961;
				if (num != 0)
				{
				}
				num = (short)2108882944;
				short num3 = num;
				ulong num4 = 0UL;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_BF;
					}
					int num8;
					for (;;)
					{
						IL_88:
						switch (num2)
						{
						case 0:
							goto IL_291;
						case 1:
							num = (short)2051211264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							int num5;
							if (num5 < 0)
							{
								num = (short)233242629;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							ulong num6 = (ulong)uiCPValue[num5];
							num4 += (ulong)global::System.Math.Pow(256.0, (double)num5) * num6;
							num5--;
							goto IL_15E;
						}
						case 3:
							goto IL_2A9;
						case 4:
							goto IL_257;
						case 5:
							goto IL_291;
						case 6:
						{
							int num7;
							if (num7 >= num8)
							{
								num = (short)76152833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							ulong num9 = (ulong)uiCPValue[num7];
							num4 += (ulong)global::System.Math.Pow(256.0, (double)(num8 - num7 - 1)) * num9;
							num7++;
							num = (short)146604036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							num = (short)213552937;
							short num10 = num;
							num = (short)1362071337;
							switch ((num10 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_15E;
							default:
								num = (short)1762394112;
								if (num != 0)
								{
								}
								goto IL_201;
							}
							break;
						}
						case 8:
							goto IL_257;
						case 9:
						{
							if (bBigEndian)
							{
								num = (short)999227403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num5 = num8 - 1;
							num = (short)1066598410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_201;
						case 11:
						{
							int num7 = 0;
							num = (short)1687945224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_BF;
						IL_15E:
						num = (short)162398215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_201:
						num = (short)1695285250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_257:
						num = (short)804978694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_291:
						num = (short)2040397827;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2A9:
					return num4;
					IL_BF:
					num8 = uiCPValue.Length;
					num = (short)270991369;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_88;
				}
				catch
				{
					throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䰇欉砋漍』儑笓砕渗缙減樝\u001f䜡嘣吥䜧堩", a_));
				}
				return num4;
			}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000C068 File Offset: 0x0000A268
		public string CvtByteArray2String(byte[] arCPValue)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			int num2;
			short num3;
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_149;
				case 1:
					goto IL_7C;
				case 2:
					if (num2 >= arCPValue.Length)
					{
						num3 = (short)1091698692;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)77725696;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
				{
					num3 = (short)1340713783;
					short num4 = num3;
					num3 = (short)439921463;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_149;
					default:
					{
						num3 = (short)1560215552;
						if (num3 != 0)
						{
						}
						char value = (char)arCPValue[num2];
						stringBuilder.Append(value);
						num2++;
						num3 = (short)190382081;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					}
					break;
				}
				case 4:
					goto IL_B5;
				case 5:
					goto IL_7C;
				}
				goto IL_28;
				IL_7C:
				num3 = (short)1561657346;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_149:
				if (arCPValue[num2] == 0)
				{
					break;
				}
				num3 = (short)1339424768;
				short num5 = num3;
				num3 = (short)1018822659;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_B5:
			return stringBuilder.ToString();
			IL_28:
			stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Remove(0, stringBuilder.Length);
			num2 = 0;
			num3 = (short)1099825153;
			if (num3 != 0)
			{
			}
			num3 = (short)193658885;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000C210 File Offset: 0x0000A410
		public byte[] CvtString2ByteArray(string sGUIValue, int iLength)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			int num5;
			byte[] array;
			for (;;)
			{
				IL_0A:
				char c;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1641746415;
					short num3 = num2;
					num2 = (short)1554190319;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18A;
					case 1:
						break;
					default:
					{
						num2 = (short)699662336;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1870594048;
					if (num2 != 0)
					{
					}
					c = sGUIValue[num5];
					num2 = (short)529203205;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return array;
				case 2:
					if (num5 >= iLength)
					{
						goto IL_18A;
					}
					num2 = (short)385875974;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_16B;
				case 4:
					goto IL_52;
				case 5:
					goto IL_52;
				case 6:
					if (num5 < sGUIValue.Length)
					{
						num2 = (short)1993015296;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					c = '\0';
					num2 = (short)1847066628;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_16B;
				}
				goto IL_30;
				IL_52:
				num2 = (short)1910374401;
				if (num2 != 0)
				{
				}
				array[num5] = (byte)c;
				num5++;
				num2 = (short)231735299;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_16B:
				num2 = (short)1933443074;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_18A:
				num2 = (short)2105212929;
				num = (int)((global::System.IntPtr)num2);
			}
			return array;
			IL_30:
			array = new byte[iLength];
			num5 = 0;
			num2 = (short)952893447;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000C3E8 File Offset: 0x0000A5E8
		public byte[] CvtBCD2ByteArray(string sBCDText, int iLength)
		{
			int a_ = 4;
			short num = (short)1820590080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1263730689;
				if (num != 0)
				{
				}
				byte[] array = new byte[iLength];
				try
				{
					switch (0)
					{
					case 0:
						goto IL_8B;
					}
					int num3;
					int num6;
					for (;;)
					{
						IL_60:
						switch (num2)
						{
						case 0:
							goto IL_22C;
						case 1:
							goto IL_E9;
						case 2:
							checked
							{
								num3 = 2 * iLength;
								byte b = 0;
								int num4 = iLength - 1;
								num = (short)1152647174;
							}
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_AB;
						case 4:
						{
							int num4;
							if (num4 >= 0)
							{
								checked
								{
									byte b;
									this.a(sBCDText.Substring(num3 - num4 * 2 - 2, 2), out b);
									array[iLength - 1 - num4] = b;
									num4--;
									num = (short)1328873473;
								}
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)132868474;
							short num5 = num;
							num = (short)1133472122;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)414318592;
								if (num != 0)
								{
								}
								num = (short)1122762760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_AB;
						case 6:
							goto IL_E9;
						case 7:
							if (num6 >= checked(2 * iLength))
							{
								num = (short)1740570626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							sBCDText += global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("㠇", a_);
							checked
							{
								num6++;
								num = (short)1345454085;
							}
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							num = (short)1966997504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8B;
						IL_AB:
						num = (short)925827079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_E9:
						num = (short)1741094916;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_22C:
					goto IL_243;
					IL_8B:
					num3 = sBCDText.Length;
					num6 = num3;
					num = (short)135331843;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_60;
				}
				catch
				{
					throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䰇欉砋漍』儑笓砕渗缙減樝\u001f䜡嘣吥䜧堩", a_));
				}
				IL_243:
				num = (short)208470016;
				short num7 = num;
				return array;
			}
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000C680 File Offset: 0x0000A880
		public string CvtByteArray2BCD(byte[] bBCD)
		{
			int a_ = 1;
			short num = (short)95485952;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)532873217;
				if (num != 0)
				{
				}
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Remove(0, stringBuilder.Length);
				goto IL_63;
				try
				{
					for (;;)
					{
						IL_63:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						int num3;
						for (;;)
						{
							IL_6D:
							switch (num2)
							{
							case 0:
								goto IL_19D;
							case 1:
								goto IL_100;
							case 2:
								num = (short)873070592;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_100;
							case 4:
							{
								if (num3 < bBCD.Length)
								{
									int num4 = (int)(bBCD[num3] / 16);
									char c = this.a(num4);
									int a_2 = (int)bBCD[num3] - num4 * 16;
									char c2 = this.a(a_2);
									stringBuilder.Append(c.ToString());
									stringBuilder.Append(c2.ToString());
									num3++;
									num = (short)2107179009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1139848354;
								short num5 = num;
								num = (short)516142242;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_63;
								default:
									num = (short)42074112;
									if (num != 0)
									{
									}
									num = (short)125239298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							break;
							IL_100:
							num = (short)1380974596;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_88:
						num3 = 0;
						num = (short)1610809347;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_6D;
					}
					IL_19D:;
				}
				catch
				{
					throw new global::System.Exception(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䄄昆紈樊ⴌ䰎縐紒挔爖欘漚㴜稞匠儢䨤唦", a_));
				}
				num = (short)394854400;
				short num6 = num;
				return stringBuilder.ToString();
			}
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000C88C File Offset: 0x0000AA8C
		public void ConvertStringToAsciiBytes(string masterKey, out byte[] masterKeyInBytes)
		{
			short num = (short)1861262932;
			short num2 = num;
			num = (short)1283956308;
			switch (num2 == num)
			{
			}
			num = (short)2144337921;
			if (num != 0)
			{
			}
			num = (short)1058734080;
			if (num != 0)
			{
			}
			num = (short)331481088;
			short num3 = num;
			masterKeyInBytes = global::System.Text.Encoding.ASCII.GetBytes(masterKey);
		}

		// Token: 0x04000038 RID: 56
		private const string a = "0";

		// Token: 0x04000039 RID: 57
		private const string b = "1";

		// Token: 0x0400003A RID: 58
		private const string c = "F";

		// Token: 0x0400003B RID: 59
		private const char d = 'A';

		// Token: 0x0400003C RID: 60
		private const char e = 'B';

		// Token: 0x0400003D RID: 61
		private const char f = 'C';

		// Token: 0x0400003E RID: 62
		private const char g = 'D';

		// Token: 0x0400003F RID: 63
		private const char h = 'E';

		// Token: 0x04000040 RID: 64
		private const char i = 'F';

		// Token: 0x04000041 RID: 65
		private const char j = 'a';

		// Token: 0x04000042 RID: 66
		private const char k = 'b';

		// Token: 0x04000043 RID: 67
		private const char l = 'c';

		// Token: 0x04000044 RID: 68
		private const char m = 'd';

		// Token: 0x04000045 RID: 69
		private const char n = 'e';

		// Token: 0x04000046 RID: 70
		private const char o = 'f';

		// Token: 0x04000047 RID: 71
		private const char p = 'X';

		// Token: 0x04000048 RID: 72
		private const char q = 'x';

		// Token: 0x04000049 RID: 73
		private const char r = '0';

		// Token: 0x0400004A RID: 74
		private const int s = 10;

		// Token: 0x0400004B RID: 75
		private const int t = 8;

		// Token: 0x0400004C RID: 76
		private const int u = 256;
	}
}
