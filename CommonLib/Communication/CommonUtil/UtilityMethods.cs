using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Motorola.Common.Communication.CommonUtil.Extensions;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200009C RID: 156
	public static class UtilityMethods
	{
		// Token: 0x06000409 RID: 1033 RVA: 0x000421D0 File Offset: 0x000403D0
		public static string ToHexString(byte[] buffer, int start, int length, bool trim = true)
		{
			int a_ = 5;
			short num = (short)56885249;
			if (num != 0)
			{
			}
			num = (short)215220233;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					goto IL_A4;
				case 1:
					goto IL_1D9;
				case 2:
					length = 200;
					num = (short)1136787467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (num3 >= start + length)
					{
						num = (short)1216741384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					stringBuilder.Append(global::Motorola.Common.Communication.CommonUtil.UtilityMethods.a[buffer[num3] >> 4]);
					stringBuilder.Append(global::Motorola.Common.Communication.CommonUtil.UtilityMethods.a[(int)(buffer[num3] & 15)]);
					num3++;
					num = (short)248381441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1D9;
				case 5:
				{
					if (length <= 200)
					{
						goto IL_A9;
					}
					num = (short)1469392629;
					short num4 = num;
					num = (short)141698805;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D9;
					default:
						num = (short)76283904;
						if (num != 0)
						{
						}
						num = (short)1203109894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					num = (short)1184628743;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (trim)
					{
						num = (short)2107834370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 8:
					goto IL_211;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 10:
					if (buffer.Length < start + length)
					{
						num = (short)280625164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)777584645;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_A9;
				case 12:
					goto IL_169;
				}
				IL_88:
				if (buffer == null)
				{
					num = (short)1576730624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1123614730;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A9:
				stringBuilder = new global::System.Text.StringBuilder(length * 2);
				num3 = start;
				num = (short)217907200;
				short num5 = num;
				num = (short)1179516932;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D9:
				num = (short)273350659;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A4:
			return string.Empty;
			IL_169:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("欈縊欌椎琐愒", a_), global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("欈縊欌椎琐愒㔔搖瀘愚砜㼞䠠倢Ԥ䬦䰨堪帬༮䔰嬲吴夶ᤸጺ丼䬾⁀ㅂㅄ杆扈歊⅌⩎㽐㑒⅔㽖灘", a_));
			IL_211:
			return stringBuilder.ToString();
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000424A8 File Offset: 0x000406A8
		public static byte[] HexString2ByteArray(string hex)
		{
			byte[] array;
			for (;;)
			{
				short num = (short)791412736;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				int num4;
				int length;
				for (;;)
				{
					IL_35:
					int num3;
					switch (num3)
					{
					case 0:
						if (num4 >= length)
						{
							num = (short)428146691;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num4 / 2] = global::System.Convert.ToByte(hex.Substring(num4, 2), 16);
						num4 += 2;
						num = (short)786956290;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_C1;
					case 2:
						num = (short)1181351937;
						if (num != 0)
						{
						}
						goto IL_C1;
					case 3:
						return array;
					}
					break;
					IL_C1:
					num = (short)1063452672;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_4B:
				length = hex.Length;
				array = new byte[length / 2];
				num4 = 0;
				num = (short)197534743;
				short num5 = num;
				num = (short)62858263;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)276627456;
					if (num != 0)
					{
					}
					num = (short)646381569;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_35;
				}
				}
			}
			return array;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0004260C File Offset: 0x0004080C
		public static int CompareBytes(byte[] a, byte[] b)
		{
			int a_ = 13;
			short num = (short)860356608;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 1:
					num = (short)411303949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return 0;
				case 3:
				{
					int num3;
					return num3;
				}
				case 4:
				{
					if (a == b)
					{
						num = (short)1867776002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num4 = 0;
					int num5 = global::System.Math.Min(a.Length, b.Length);
					int num3 = 0;
					num = (short)1578106888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_86;
				case 6:
				{
					int num3;
					if (num3 == 0)
					{
						num = (short)248774657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BE;
				}
				case 7:
					goto IL_192;
				case 8:
					goto IL_86;
				case 9:
					if (b == null)
					{
						num = (short)1279328263;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1038483460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (a.Length == b.Length)
					{
						num = (short)1219166211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C0;
				case 11:
					goto IL_81;
				case 12:
					IL_242:
					goto IL_1BE;
				case 13:
				{
					int num4;
					int num5;
					if (num4 >= num5)
					{
						num = (short)102694924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num3 = (int)(a[num4] - b[num4]);
					num4++;
					num = (short)1542324229;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_65:
				if (a == null)
				{
					num = (short)25231371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)32374793;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_86:
				num = (short)678600984;
				short num6 = num;
				num = (short)732274968;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_242;
				case 1:
					break;
				default:
				{
					num = (short)2005204992;
					short num7 = num;
					break;
				}
				}
				num = (short)699203584;
				if (num != 0)
				{
				}
				num = (short)1944322054;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BE:
				num = (short)1393295370;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_81:
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("瀐", a_));
			IL_192:
			num = (short)960757761;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("猐", a_));
			IL_2C0:
			return a.Length - b.Length;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000428E0 File Offset: 0x00040AE0
		public static void CheckIfParameterIsNull(object parameter, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			while (parameter == null)
			{
				short num = (short)1341610350;
				short num2 = num;
				num = (short)1574197614;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)860356608;
					if (num != 0)
					{
					}
					num = (short)469958657;
					if (num != 0)
					{
					}
					num = (short)1862074368;
					short num3 = num;
					throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
				}
				}
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00042998 File Offset: 0x00040B98
		public static void CheckIfParameterIsZero(int parameter, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			while (parameter == 0)
			{
				short num = (short)1601804210;
				short num2 = num;
				num = (short)2063636402;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1547239425;
					if (num != 0)
					{
					}
					num = (short)592904192;
					if (num != 0)
					{
					}
					num = (short)1505755136;
					short num3 = num;
					throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
				}
				}
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00042A4C File Offset: 0x00040C4C
		public static void CheckIfParameterIsFalse(bool parameter, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			while (!parameter)
			{
				short num = (short)839099903;
				short num2 = num;
				num = (short)1555801599;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)757399553;
					if (num != 0)
					{
					}
					num = (short)1118175232;
					if (num != 0)
					{
					}
					num = (short)138739712;
					short num3 = num;
					throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
				}
				}
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00042B04 File Offset: 0x00040D04
		public static void CheckIfParameterIsNotNull(object parameter, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			while (parameter != null)
			{
				short num = (short)2087019727;
				short num2 = num;
				num = (short)1975346383;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1547829249;
					if (num != 0)
					{
					}
					num = (short)1376518144;
					if (num != 0)
					{
					}
					num = (short)55181312;
					short num3 = num;
					throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
				}
				}
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00042BBC File Offset: 0x00040DBC
		public static void CheckIfThreadIsAlive(global::System.Threading.Thread workThread, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			short num;
			for (;;)
			{
				num = (short)431947777;
				if (num != 0)
				{
				}
				if (workThread.IsAlive)
				{
					return;
				}
				num = (short)1847067776;
				short num2 = num;
				num = (short)1551303808;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_64;
				}
			}
			IL_64:
			num = (short)302907392;
			if (num != 0)
			{
			}
			num = (short)748814336;
			short num3 = num;
			throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00042C78 File Offset: 0x00040E78
		public static void CheckIfParameterIsTrue(bool parameter, global::Motorola.Common.CustomException.CommonErrorCode commonErrorCode)
		{
			while (parameter)
			{
				short num = (short)1444147541;
				short num2 = num;
				num = (short)2031546709;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1172045824;
					if (num != 0)
					{
					}
					num = (short)1259732993;
					if (num != 0)
					{
					}
					num = (short)1843003392;
					short num3 = num;
					throw new global::Motorola.Common.CustomException.CommonException(commonErrorCode);
				}
				}
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00042D2C File Offset: 0x00040F2C
		public static void ValidateArrayStartLength<T>(T[] array, int start, int length)
		{
			short num = (short)1677590529;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1877540865;
				if (num != 0)
				{
				}
				num = (short)2094641104;
				short num3 = num;
				num = (short)56930256;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1956315136;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)1149042688;
						short num4 = num;
						num = (short)40370180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_BF;
						}
						continue;
					case 2:
						if (length >= 0)
						{
							num = (short)1279721472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 3:
						num = (short)291438594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (array.Length < start + length)
						{
							goto IL_12E;
						}
						return;
					case 5:
						goto IL_146;
					case 6:
						if (start >= 0)
						{
							num = (short)340328451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					case 7:
						goto IL_DC;
					case 8:
						num = (short)2063532038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (array.Length != 0)
						{
							num = (short)833880072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_183;
					}
					IL_BF:
					if (array == null)
					{
						num = (short)477364231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1919746057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_12E:
				num = (short)1924530181;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DC:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			IL_146:
			IL_183:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00042F34 File Offset: 0x00041134
		public static bool CheckIfParadiseTuningPathFixupVersions(string ver)
		{
			int a_ = 16;
			short num;
			for (;;)
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				list.Add(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("┓☕⠗⨙", a_));
				list.Add(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("┓☕⠗⬙", a_));
				ver = ver.Substring(0, 4);
				if (!list.Contains(ver))
				{
					return false;
				}
				num = (short)473756724;
				short num2 = num;
				num = (short)1663235124;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_7F;
				}
			}
			IL_7F:
			num = (short)1141899264;
			if (num != 0)
			{
			}
			num = (short)323485697;
			if (num != 0)
			{
			}
			num = (short)1184497664;
			short num3 = num;
			return true;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0004302C File Offset: 0x0004122C
		public static string ReadTuningVersionForParadise(byte[] itemdata)
		{
			short num = (short)1420176206;
			short num2 = num;
			num = (short)1051601742;
			string text;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)741081089;
				if (num != 0)
				{
				}
				num = (short)2103640064;
				if (num != 0)
				{
				}
				text = string.Empty;
				try
				{
					num = (short)937689092;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_F3;
						case 1:
						{
							int num4;
							if (num4 >= 4)
							{
								num = (short)1568538630;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							text += global::System.Convert.ToString(itemdata[num4], 16).PadLeft(2, '0');
							num4++;
							num = (short)1383137280;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							int num4 = 1;
							num = (short)807600131;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_F3;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_BC;
							}
							continue;
						case 5:
							goto IL_175;
						case 6:
							goto IL_15D;
						}
						IL_BC:
						if (itemdata.Length > 4)
						{
							num = (short)685309954;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15D;
						IL_F3:
						num = (short)2126643201;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_15D:
						num = (short)229507077;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_175:;
				}
				catch
				{
				}
				break;
			}
			num = (short)1586233344;
			short num5 = num;
			return text;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000431F0 File Offset: 0x000413F0
		// Note: this type is marked as 'beforefieldinit'.
		static UtilityMethods()
		{
			short num = (short)923708766;
			short num2 = num;
			num = (short)2054204766;
			switch (num2 == num)
			{
			}
			num = (short)911802368;
			short num3 = num;
			num = (short)732561409;
			if (num != 0)
			{
			}
			num = (short)199098368;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.a = new char[]
			{
				'0',
				'1',
				'2',
				'3',
				'4',
				'5',
				'6',
				'7',
				'8',
				'9',
				'A',
				'B',
				'C',
				'D',
				'E',
				'F'
			};
		}

		// Token: 0x040004B6 RID: 1206
		private static readonly char[] a;

		// Token: 0x040004B7 RID: 1207
		public const int TUNING_VERSION_ISH_TYPE = 26896;

		// Token: 0x040004B8 RID: 1208
		public const int TUNING_VERSION_BYTEOFFSET = 1;

		// Token: 0x040004B9 RID: 1209
		public const int TUNING_VERSION_BYTELENGTH = 3;

		// Token: 0x040004BA RID: 1210
		public const string TUNING_PATH_ISSUE_VERSION1 = "1000";

		// Token: 0x040004BB RID: 1211
		public const string TUNING_PATH_ISSUE_VERSION2 = "1001";
	}
}
