using System;
using System.Globalization;
using System.Net;
using System.Text;
using Motorola.Common.CustomException;
using SharedUtility.Arguments;

namespace SharedUtility
{
	// Token: 0x0200000C RID: 12
	public static class Utility
	{
		// Token: 0x0600005F RID: 95 RVA: 0x0000F7DC File Offset: 0x0000D9DC
		public static bool IsSameNetworkID(string ipA, string ipB, ref int ipClass)
		{
			short num = (short)1761673216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B2;
				}
				byte[] array;
				bool result;
				string[] array4;
				int num4;
				int num5;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						byte[] array2;
						if (array[0] == array2[0])
						{
							num = (short)1340211226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 1:
					{
						byte[] array2;
						if (array[1] == array2[1])
						{
							num = (short)988610579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					}
					case 2:
						if (array[0] >= 192)
						{
							num = (short)2077097998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
						goto IL_4A8;
					case 4:
					{
						byte[] array2;
						if (array[1] == array2[1])
						{
							num = (short)77004811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 5:
						num = (short)1624506368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_2FC;
					case 7:
						goto IL_2FC;
					case 8:
						num = (short)1779236894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return result;
					case 10:
					{
						byte[] array2;
						if (array[2] == array2[2])
						{
							num = (short)1295319060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 11:
						num = (short)851574794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (array[0] <= 191)
						{
							num = (short)1704263688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					case 13:
					{
						string[] array3 = ipB.Split(new char[]
						{
							'.'
						});
						byte[] array2 = new byte[4];
						int num3 = 0;
						array4 = array3;
						num4 = 0;
						num = (short)1318518791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)1340997664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)363528208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (array[0] <= 127)
						{
							num = (short)1921646617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58E;
					case 17:
						return result;
					case 18:
					{
						if (num4 >= array4.Length)
						{
							num = (short)770506765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string value = array4[num4];
						array[num5++] = global::System.Convert.ToByte(value, global::System.Globalization.CultureInfo.InvariantCulture);
						num4++;
						num = (short)1689649155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						num = (short)877133824;
						short num6 = num;
						result = true;
						ipClass = 1;
						num = (short)1111687195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						result = true;
						ipClass = 2;
						num = (short)926482441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1570701324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_405;
					case 23:
						if (array[0] >= 128)
						{
							num = (short)747700225;
							if (num != 0)
							{
							}
							num = (short)1596325909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					case 24:
						num = (short)1530396673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)1293418518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						num = (short)710488959;
						short num7 = num;
						num = (short)1653551999;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_405;
						default:
							num = (short)1771110400;
							if (num != 0)
							{
							}
							num = (short)1387855876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 27:
						return result;
					case 28:
						goto IL_4A8;
					case 29:
						result = true;
						ipClass = 0;
						num = (short)327745553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						byte[] array2;
						if (array[0] == array2[0])
						{
							num = (short)338821144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					}
					case 31:
					{
						if (num4 >= array4.Length)
						{
							num = (short)365101071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string value2 = array4[num4];
						byte[] array2;
						int num3;
						array2[num3++] = global::System.Convert.ToByte(value2, global::System.Globalization.CultureInfo.InvariantCulture);
						num4++;
						num = (short)1296236550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						if (array[0] <= 223)
						{
							num = (short)1083113477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_B2;
					IL_F0:
					num = (short)516620290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FC:
					num = (short)1100677151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_405:
					if (array[0] == array[0])
					{
						num = (short)1014366237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_58E;
					IL_4A8:
					num = (short)1605894162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58E:
					num = (short)661127191;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_B2:
				result = false;
				string[] array5 = ipA.Split(new char[]
				{
					'.'
				});
				array = new byte[4];
				num5 = 0;
				array4 = array5;
				num4 = 0;
				num = (short)1170341916;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000FDE4 File Offset: 0x0000DFE4
		public static bool IPValidateHelper(string value, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_C8;
			}
			int num;
			short num2;
			global::System.Net.IPAddress ipaddress;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					byte[] addressBytes;
					if (addressBytes[2] == 0)
					{
						num2 = (short)160366602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_398;
				}
				case 1:
				{
					byte b;
					if (b == 0)
					{
						num2 = (short)2014052353;
						if (num2 != 0)
						{
						}
						num2 = (short)249692199;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)757334053;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					byte[] addressBytes;
					if (addressBytes[3] != 0)
					{
						num2 = (short)740622339;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3DB;
				}
				case 3:
					goto IL_398;
				case 4:
					goto IL_41F;
				case 5:
					num2 = (short)1545273356;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1347289124;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					byte[] addressBytes;
					if (addressBytes[3] == 0)
					{
						num2 = (short)229638170;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_71F;
				}
				case 8:
					goto IL_6E7;
				case 9:
					goto IL_106;
				case 10:
					num2 = (short)414515202;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					byte[] addressBytes;
					if (addressBytes[2] != 0)
					{
						num2 = (short)1266221081;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_523;
				}
				case 12:
				{
					byte[] addressBytes;
					if (addressBytes[2] == 255)
					{
						num2 = (short)898039838;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_71F;
				}
				case 13:
				{
					byte[] addressBytes;
					if (addressBytes[2] == 0)
					{
						num2 = (short)990052381;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_71F;
				}
				case 14:
				{
					byte[] addressBytes;
					if (addressBytes[3] == 255)
					{
						num2 = (short)1396834326;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_71F;
				}
				case 15:
					num2 = (short)1463943208;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
				{
					byte b;
					if (b != 127)
					{
						num2 = (short)1092223014;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_42D;
				}
				case 17:
				{
					byte[] addressBytes;
					if (addressBytes[3] != 0)
					{
						num2 = (short)1255473197;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_523;
				}
				case 18:
					num2 = (short)1666514960;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
				{
					byte b;
					if (b <= 223)
					{
						num2 = (short)1119420434;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_42D;
				}
				case 20:
					num2 = (short)1101660160;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
				{
					num2 = (short)1134147356;
					short num3 = num2;
					num2 = (short)1447409436;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_58B;
					default:
						num2 = (short)233832448;
						if (num2 != 0)
						{
						}
						goto IL_6A7;
					}
					break;
				}
				case 22:
					goto IL_659;
				case 23:
					num2 = (short)1956315147;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
				{
					byte b;
					if (b == 192)
					{
						num2 = (short)77201408;
						short num4 = num2;
						num2 = (short)369360902;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5E2;
				}
				case 25:
					goto IL_5E2;
				case 26:
					goto IL_141;
				case 27:
				{
					byte[] addressBytes;
					if (addressBytes[3] != 255)
					{
						goto IL_58B;
					}
					goto IL_2A7;
				}
				case 28:
				{
					byte[] addressBytes;
					if (addressBytes[2] == 255)
					{
						num2 = (short)622460960;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6E7;
				}
				case 29:
					num2 = (short)764608519;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					num2 = (short)1909063694;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					num2 = (short)1517420568;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					num2 = (short)1459027995;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
				{
					byte[] addressBytes;
					if (addressBytes[1] == 255)
					{
						num2 = (short)1503133701;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_71F;
				}
				case 34:
					num2 = (short)1371930667;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
				{
					byte b;
					if (b >= 128)
					{
						num2 = (short)123207695;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1696399402;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 36:
				{
					byte[] addressBytes;
					if (addressBytes[1] == 0)
					{
						num2 = (short)1646657559;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5E2;
				}
				case 37:
				{
					byte b;
					if (b >= 192)
					{
						num2 = (short)585760799;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1398800419;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 38:
					num2 = (short)1075183617;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 39:
					goto IL_2A2;
				case 40:
				{
					byte b;
					if (b == 128)
					{
						num2 = (short)1850867746;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6A7;
				}
				case 41:
				{
					if (ipaddress == null)
					{
						num2 = (short)1338048521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					byte[] addressBytes = ipaddress.GetAddressBytes();
					byte b = addressBytes[0];
					num2 = (short)1363804179;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 42:
				{
					byte[] addressBytes;
					if (addressBytes[1] == 0)
					{
						num2 = (short)421396500;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_398;
				}
				case 43:
				{
					byte[] addressBytes;
					if (addressBytes[1] != 0)
					{
						num2 = (short)482017301;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2A7;
				}
				case 44:
				{
					byte[] addressBytes;
					if (addressBytes[3] == 255)
					{
						num2 = (short)700055556;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_71F;
				}
				case 45:
					num2 = (short)274137132;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_C8;
				IL_398:
				num2 = (short)363003937;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_58B:
				num2 = (short)528809992;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5E2:
				num2 = (short)527695889;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_6A7:
				num2 = (short)1584201756;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_6E7:
				num2 = (short)727121933;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_106:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IP_NotProperFormat;
			return false;
			IL_141:
			goto IL_2A7;
			IL_2A2:
			goto IL_42D;
			IL_2A7:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IP_NotProperClassBFormat;
			return false;
			IL_3DB:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IP_NotProperClassAFormat;
			return false;
			IL_41F:
			goto IL_523;
			IL_42D:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IPFirstPart_NotProperNumber;
			return false;
			IL_523:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IP_NotProperClassCFormat;
			return false;
			IL_659:
			goto IL_3DB;
			IL_71F:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			return true;
			IL_C8:
			ipaddress = null;
			ipaddress = global::SharedUtility.Utility.a(value);
			num2 = (short)1664090153;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00010514 File Offset: 0x0000E714
		public static bool ValidateIPFormat(string ipValue, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			bool result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_2C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_67;
					case 1:
						num2 = (short)265748481;
						if (num2 != 0)
						{
						}
						if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num2 = (short)1643642882;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
					{
						num2 = (short)1769734144;
						short num3 = num2;
						result = false;
						num2 = (short)1914961924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						goto IL_67;
					case 4:
						return result;
					case 5:
					{
						if (string.IsNullOrEmpty(ipValue))
						{
							num2 = (short)534642694;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)95085905;
						short num4 = num2;
						num2 = (short)835773777;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)772734976;
							if (num2 != 0)
							{
							}
							global::SharedUtility.Utility.IPValidateHelper(ipValue, out error);
							num2 = (short)1753677824;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 6:
						error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IP_NotProperFormat;
						num2 = (short)639303683;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
					IL_67:
					num2 = (short)1787559937;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_2C:
				result = true;
				error = global::Motorola.Common.CustomException.CommonErrorCode.None;
				num2 = (short)1258684421;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000106C0 File Offset: 0x0000E8C0
		internal static global::System.Net.IPAddress a(string A_0)
		{
			global::System.Net.IPAddress result = null;
			if (global::System.Net.IPAddress.TryParse(A_0, out result))
			{
				short num = (short)259629665;
				short num2 = num;
				num = (short)1096393313;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1360134144;
					if (num != 0)
					{
					}
					num = (short)1321926657;
					if (num != 0)
					{
					}
					num = (short)1266352128;
					short num3 = num;
					break;
				}
				}
				return result;
			}
			return null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0001077C File Offset: 0x0000E97C
		public static bool IsIPValid(bool? bluetoothEnable, ref string ip, bool autoCorrect = true)
		{
			int a_ = 15;
			short num = (short)1163788288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1BC;
				}
				bool result;
				for (;;)
				{
					IL_31:
					int num4;
					int num3;
					string text;
					int num6;
					switch (num2)
					{
					case 0:
						if (autoCorrect)
						{
							num = (short)2125594665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)1241120795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return false;
					case 2:
						return result;
					case 3:
					{
						bool? flag = bluetoothEnable;
						bool flag2 = true;
						num = (short)289079357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num3 = ip.IndexOf(global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("ꒉ", a_), num4, global::System.StringComparison.Ordinal);
						num = (short)2091057235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						bool? flag = bluetoothEnable;
						bool flag2 = false;
						num = (short)757923869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return result;
					case 7:
						goto IL_343;
					case 8:
						goto IL_9DF;
					case 9:
					{
						int num5;
						if (num5 == 127)
						{
							num = (short)747831351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DF;
					}
					case 10:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1379336242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF5;
					}
					case 11:
						if (text.StartsWith(global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("몉", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)2050359342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_305;
					case 12:
						if (num6 == 0)
						{
							num = (short)66912348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1946550366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_1079;
					case 14:
						num = (short)1969291321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_496;
					case 16:
						return false;
					case 17:
					{
						bool? flag = bluetoothEnable;
						bool flag2 = false;
						num = (short)937361418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_9DF;
					case 19:
					{
						string text2;
						ip = ip.Substring(0, num4) + text2 + ip.Substring(num3);
						num3 -= text.Length - text2.Length;
						num = (short)106233942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (ip != null)
						{
							num = (short)1965359134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)1714290694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (text.StartsWith(global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("몉", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)1093599304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54F;
					case 22:
						goto IL_9DF;
					case 23:
						goto IL_A02;
					case 24:
						num = (short)1508245504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						string text3;
						if (text3.Length != text.Length)
						{
							num = (short)1260847168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_305;
					}
					case 26:
					{
						string text3;
						if (text3.Length == 0)
						{
							num = (short)1596391508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A8A;
					}
					case 27:
						goto IL_9DF;
					case 28:
						num = (short)935919654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)275972097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1037;
					}
					case 30:
					{
						num3 = -1;
						char[] trimChars = new char[]
						{
							'0'
						};
						num6 = 0;
						num = (short)682033165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						num = (short)744030223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)436731920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DF;
					}
					case 33:
						if (num6 != 3)
						{
							num = (short)553123844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = ip.Substring(num4);
						num = (short)1171652666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						char[] trimChars;
						string text3 = text.TrimStart(trimChars);
						num = (short)1838612506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						result = false;
						num = (short)441188354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_305;
					case 37:
					{
						string text2 = global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("몉", a_);
						num = (short)640548871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						if (autoCorrect)
						{
							num = (short)43319363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1291124781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						num = (short)1783103489;
						if (num != 0)
						{
						}
						bool? flag = bluetoothEnable;
						bool flag2 = true;
						num = (short)148111392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						text = global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("뢉릋뮍", a_);
						ip = ip.Substring(0, num4) + text + ip.Substring(num3);
						num = (short)1737228296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						text = global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("뢉릋붍", a_);
						ip = ip.Substring(0, num4) + text;
						num = (short)791347288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_B4A;
					case 43:
					{
						string text2;
						if (text2.Length != text.Length)
						{
							num = (short)222232595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54F;
					}
					case 44:
						num = (short)1401028689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						int num5;
						if (num5 > 255)
						{
							num = (short)614334469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1037;
					}
					case 46:
						num = (short)370737221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						return result;
					case 48:
					{
						int num5;
						if (num5 > 254)
						{
							num = (short)1972699175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DF;
					}
					case 49:
						if (num6 >= 4)
						{
							num = (short)280625183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = num3 + 1;
						num = (short)1980629025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						text = global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("뢉릋뮍", a_);
						ip = ip.Substring(0, num4) + text + ip.Substring(num3);
						num = (short)332726347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						if (autoCorrect)
						{
							num = (short)115343423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)876937311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (autoCorrect)
						{
							num = (short)796917851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 53:
					{
						int num5;
						if (num5 > 223)
						{
							num = (short)1738997836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2028077126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
						goto IL_853;
					case 55:
						num = (short)522125368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (autoCorrect)
						{
							num = (short)21233718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 57:
					{
						int num5;
						if (num5 > 255)
						{
							num = (short)928383035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DF;
					}
					case 58:
					{
						if (text.Length == 0)
						{
							num = (short)126943300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = global::System.Convert.ToInt32(text, global::System.Globalization.NumberFormatInfo.InvariantInfo);
						num = (short)1581784271;
						short num7 = num;
						num = (short)1287134415;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_853;
						default:
							num = (short)1665990656;
							if (num != 0)
							{
							}
							num = (short)195362827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 59:
						num = (short)1305870432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						if (text.Length == 0)
						{
							num = (short)911147074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = global::System.Convert.ToInt32(text, global::System.Globalization.NumberFormatInfo.InvariantInfo);
						num = (short)387776524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)949813321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DF;
					}
					case 62:
						goto IL_A02;
					case 63:
						text = global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("뮉", a_);
						ip = ip.Substring(0, num4) + text;
						num = (short)1788084242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
					{
						string text3;
						ip = ip.Substring(0, num4) + text3;
						num = (short)2056192036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 65:
						num = (short)1348599859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						result = false;
						num = (short)1153171498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						num = (short)1314652250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						result = false;
						num = (short)2089484335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (text.Length > 0)
						{
							num = (short)512294946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_305;
					case 70:
					{
						int num5;
						if (num5 < 1)
						{
							num = (short)1304035372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A02;
					}
					case 71:
					{
						char[] trimChars;
						string text2 = text.TrimStart(trimChars);
						num = (short)296878159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 72:
						num = (short)599130197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						text = global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("뢉릋몍", a_);
						ip = ip.Substring(0, num4) + text + ip.Substring(num3);
						num = (short)1739587606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						goto IL_1079;
					case 75:
						goto IL_9DF;
					case 76:
						num = (short)1840578612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						goto IL_A8A;
					case 78:
					{
						int num5;
						if (num5 > 253)
						{
							num = (short)416808984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DF;
					}
					case 79:
					{
						string text2;
						if (text2.Length == 0)
						{
							num = (short)514261029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_343;
					}
					case 80:
						if (num6 == 2)
						{
							num = (short)104923164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DF;
					case 81:
						if (autoCorrect)
						{
							num = (short)112525394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 82:
						text = global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("뮉", a_);
						ip = ip.Substring(0, num4) + text + ip.Substring(num3);
						num = (short)1516175383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						if (num3 == -1)
						{
							num = (short)22216739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = ip.Substring(num4, num3 - num4);
						num = (short)1743192085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
					{
						string text3 = global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("몉", a_);
						num = (short)1157562445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
						if (text.Length > 1)
						{
							num = (short)2023489607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54F;
					case 86:
						goto IL_54F;
					case 87:
						goto IL_9DF;
					case 88:
						goto IL_9DF;
					case 89:
					{
						int num5;
						if (num5 > 254)
						{
							num = (short)851971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DF;
					}
					case 90:
					{
						int num5;
						if (num5 > 255)
						{
							num = (short)169017361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF5;
					}
					case 91:
						text = global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("뢉뺋붍", a_);
						ip = ip.Substring(0, num4) + text + ip.Substring(num3);
						num = (short)58130494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						num = (short)547356725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
					{
						int num5;
						if (num5 < 1)
						{
							num = (short)1927872577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)472383566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 94:
						if (num6 == 1)
						{
							num = (short)339410958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1714946128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						goto IL_9DF;
					case 96:
						if (autoCorrect)
						{
							num = (short)1787494440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_1BC;
					IL_305:
					num = (short)2050555997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_343:
					num = (short)273088555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54F:
					num = (short)1949368380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_853:
					text = global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("뮉떋벍", a_);
					ip = ip.Substring(0, num4) + text + ip.Substring(num3);
					num = (short)409731159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9DF:
					num6++;
					num = (short)776994890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A02:
					num = (short)1614544905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A8A:
					num = (short)161153049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EF5:
					num = (short)1909522521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1037:
					num = (short)1077739568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1079:
					num = (short)67829809;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_496:
				return result;
				IL_B4A:
				return result;
				IL_1BC:
				num = (short)498663424;
				short num8 = num;
				result = true;
				num = (short)1563623444;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00011864 File Offset: 0x0000FA64
		public static string ConvertByteArrayToHexString(byte[] bBCD)
		{
			int a_ = 6;
			short num = (short)1003552768;
			switch (num)
			{
			default:
			{
				num = (short)256442369;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Text.StringBuilder stringBuilder;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_C6;
							}
							int num3;
							for (;;)
							{
								IL_AB:
								switch (num2)
								{
								case 0:
									goto IL_135;
								case 1:
									num = (short)1926758403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (num3 >= bBCD.Length)
									{
										num = (short)1798889541;
										short num4 = num;
										num = (short)376889413;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)185794560;
											if (num != 0)
											{
											}
											num = (short)317849601;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									else
									{
										int num5 = (int)(bBCD[num3] / 16);
										char c = global::SharedUtility.Utility.a(num5);
										char c2 = global::SharedUtility.Utility.a((int)bBCD[num3] - num5 * 16);
										stringBuilder.Append(c.ToString()).Append(c2.ToString());
										num3++;
									}
									num = (short)589496324;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1D2;
								case 4:
									goto IL_135;
								}
								goto IL_C6;
								IL_135:
								num = (short)1769474;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1D2:
							goto IL_239;
							IL_C6:
							num3 = 0;
							num = (short)1284702208;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_AB;
						}
						catch
						{
							throw new global::System.Exception(global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("ﮈ", a_));
						}
						goto IL_1E9;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 2:
						goto IL_9C;
					}
					IL_58:
					if (bBCD == null)
					{
						num = (short)1223163904;
						short num6 = num;
						num = (short)1868234754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1E9:
					num = (short)2136997889;
					if (num != 0)
					{
					}
					stringBuilder = new global::System.Text.StringBuilder();
					num = (short)1602813952;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9C:
				return string.Empty;
				IL_239:
				return stringBuilder.ToString();
			}
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00011ACC File Offset: 0x0000FCCC
		private static char a(int A_0)
		{
			int a_ = 4;
			char result = '\0';
			short num;
			try
			{
				num = (short)2032533505;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (A_0 <= 9)
						{
							num = (short)1628307461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4;
					case 1:
						num = (short)1501560833;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 2:
						goto IL_231;
					case 3:
						goto IL_21A;
					case 4:
						goto IL_126;
					case 5:
					{
						num = (short)1343740583;
						short num3 = num;
						num = (short)872471207;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_126;
						default:
							num = (short)200802304;
							if (num != 0)
							{
							}
							result = A_0.ToString(global::System.Globalization.CultureInfo.InvariantCulture)[0];
							num = (short)1466499080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						num = (short)1249509376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1548222475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_21A;
					case 9:
						if (A_0 >= 0)
						{
							num = (short)153550854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4;
					case 10:
						goto IL_1E0;
					case 11:
						if (A_0 < 0)
						{
							num = (short)457244676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E0;
					}
					IL_89:
					if (A_0 <= 15)
					{
						num = (short)441516039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A6:
					A_0 = 0;
					num = (short)665124874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_126:
					goto IL_A6;
					IL_C4:
					result = global::System.Convert.ToChar(65 + A_0 - 10);
					num = (short)1774583811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E0:
					num = (short)1837236233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21A:
					num = (short)1386217474;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_231:;
			}
			catch
			{
				throw new global::System.Exception(global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("㭾Ꞇ쪈年랖ﲘ펠", a_));
			}
			num = (short)1073807360;
			short num4 = num;
			return result;
		}
	}
}
