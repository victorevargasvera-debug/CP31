using System;
using System.Text;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000F1 RID: 241
	public static class FlashcodeFormatter
	{
		// Token: 0x06000DEB RID: 3563 RVA: 0x001335B0 File Offset: 0x001317B0
		public static string FormatFlashcodeString(byte[] flashcode, int nSize)
		{
			int a_ = 8;
			short num = (short)615776256;
			switch (num)
			{
			default:
			{
				num = (short)925564947;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					uint num4;
					byte[] array;
					uint num5;
					byte b;
					uint num6;
					string text;
					uint num8;
					uint num9;
					byte b3;
					uint num10;
					byte b4;
					string text2;
					switch (num2)
					{
					case 0:
						if ((long)num3 >= (long)((ulong)(num4 * 2U)))
						{
							num = (short)803209261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[(int)num5++] = global::System.Convert.ToByte('0');
						num3++;
						goto IL_281;
					case 1:
						num = (short)2058813463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (nSize == 6)
						{
							num = (short)628621378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b = 0;
						num3 = 0;
						num = (short)747896884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						array[(int)num5++] = global::System.Convert.ToByte('-');
						num = (short)1144127499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_6A9;
					case 5:
						goto IL_330;
					case 6:
						if ((long)(num3 + 1) % (long)((ulong)num6) <= 0L)
						{
							num = (short)1632108547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E2;
					case 7:
						if (text.Length == 29)
						{
							num = (short)318177323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1630535726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_185;
					case 9:
						if ((long)nSize % (long)((ulong)num6) > 0L)
						{
							num = (short)1284243505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_627;
					case 10:
						if (array != null)
						{
							num = (short)690159641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_866;
					case 11:
						goto IL_2E2;
					case 12:
						goto IL_746;
					case 13:
						goto IL_527;
					case 14:
					{
						byte b2;
						b = b2 * 2 / 100 + b2 * 2 % 100 / 10 + b2 * 2 % 100 % 10;
						num = (short)79364161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						uint num7;
						if (num7 <= 0U)
						{
							num = (short)552468522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1704198204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						uint num7;
						num8 = num7;
						goto IL_687;
					}
					case 17:
					{
						byte b2;
						if (b2 < 64)
						{
							num = (short)753598508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array = null;
						num = (short)177733680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)1801650217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						switch (0)
						{
						case 0:
							goto IL_162;
						}
						continue;
					case 20:
						goto IL_866;
					case 21:
						num9 = 2U;
						num6 = 3U;
						num = (short)1605238820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						array[(int)num5++] = b3 - 10 + 65;
						num = (short)1647050756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_AD9;
					case 24:
					{
						byte[] array2 = new byte[24];
						global::System.Array.Copy(flashcode, 0, array2, 0, 12);
						global::System.Array.Copy(flashcode, 13, array2, 12, 12);
						flashcode = array2;
						nSize = flashcode.Length;
						num = (short)1015480383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						uint num7 = num10 % 10U;
						num = (short)1188560911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_BA6;
					case 27:
						if (b4 > 9)
						{
							num = (short)2081423400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[(int)num5++] = b4 + 48;
						num = (short)650117148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_49A;
					case 29:
						goto IL_180;
					case 30:
						if (num4 > 0U)
						{
							num = (short)1975386173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_305;
					case 31:
						goto IL_AD9;
					case 32:
					{
						if (num3 >= nSize)
						{
							num = (short)1013186561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b5 = flashcode[num3];
						b4 = (byte)(b5 >> 4);
						b3 = (b5 & 15);
						num = (short)1146880027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						if (num3 % 2 == 0)
						{
							num = (short)704118802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1278214145;
						if (num != 0)
						{
						}
						byte b2;
						byte b6 = b2 / 10 + b2 % 10;
						num10 += (uint)b6;
						num = (short)1168834611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						return text2;
					case 35:
						goto IL_29F;
					case 36:
						goto IL_29F;
					case 37:
						if ((long)(num3 + 1) % (long)((ulong)num6) <= 0L)
						{
							num = (short)1652031555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_566;
					case 38:
						goto IL_566;
					case 39:
						if (flashcode.Length == 25)
						{
							num = (short)1737752600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A50;
					case 40:
						array[(int)num5++] = b4 - 10 + 65;
						num = (short)1999896638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						byte b2;
						if (b2 * 2 >= 100)
						{
							num = (short)1147994126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b = b2 * 2 / 10 + b2 * 2 % 10;
						num = (short)1889992716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						num = (short)1599012880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						string value = text.Substring(text.Length - 2, 2);
						text2 = text.Remove(text.Length - 2, 2).Insert(13, value);
						num = (short)1962147893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
					{
						byte b2;
						array[(int)num5++] = (byte)global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeCharValue((int)b2);
						num = (short)263389241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						num = (short)830865438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (text.Length == 15)
						{
							num = (short)1384906816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text2;
					case 47:
						goto IL_527;
					case 48:
						goto IL_AD9;
					case 49:
						num4 = (uint)((ulong)num6 - (ulong)((long)nSize % (long)((ulong)num6)));
						num = (short)268828731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
					{
						if (b3 > 9)
						{
							num = (short)1250361366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[(int)num5++] = b3 + 48;
						num = (short)493748224;
						short num11 = num;
						num = (short)893452343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
						goto IL_330;
					case 52:
						goto IL_185;
					case 53:
						return text2;
					case 54:
					{
						if (num3 >= nSize)
						{
							num = (short)1004666911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b2 = flashcode[num3];
						num = (short)1061027873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						goto IL_6A9;
					case 56:
						if (nSize == 6)
						{
							num = (short)244580373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num9 = 1U;
						num6 = 6U;
						num = (short)2078539811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						num = (short)80936966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						goto IL_305;
					case 59:
						goto IL_627;
					case 60:
					{
						uint num7;
						num8 = 10U - num7;
						goto IL_687;
					}
					case 61:
						array[(int)num5++] = global::System.Convert.ToByte('-');
						num = (short)643694650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_49A;
					case 63:
						goto IL_A50;
					case 64:
						text2 += global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("Ꚋ붌뾎ꆐꎒꖔꞖ뒘ꮚ궜꾞醠鎢閤", a_);
						num = (short)733347874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_746;
					case 66:
						num3 = 0;
						num = (short)1463943215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
					{
						array[(int)num5++] = global::System.Convert.ToByte('-');
						num = (short)574150941;
						short num12 = num;
						num = (short)491510045;
						switch ((num12 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_281;
						default:
							num = (short)1242824704;
							if (num != 0)
							{
							}
							num = (short)899547174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 68:
						goto IL_BA6;
					}
					IL_162:
					if (flashcode == null)
					{
						num = (short)106561565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1185677351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_185:
					num = (short)1318846518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_281:
					num = (short)1309802522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29F:
					num = (short)1888419849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E2:
					num3++;
					num = (short)301203464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_305:
					array[(int)num5++] = (byte)(num10 + 48U);
					num = (short)450560020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_330:
					num = (short)334364689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49A:
					num = (short)1347223602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_527:
					num = (short)1907884064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_566:
					b4 = b4 * 2 / 10 + b4 * 2 % 10;
					b3 = b3 / 10 + b3 % 10;
					num10 = num10 + (uint)b4 + (uint)b3;
					num3++;
					num = (short)1357316109;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_627:
					uint num13 = (uint)(((long)nSize + (long)((ulong)num4)) / (long)((ulong)num6));
					array = new byte[((long)nSize + (long)((ulong)num4)) * (long)((ulong)num9) + (long)((ulong)num13) + 1L];
					num = (short)1285226498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_687:
					num10 = num8;
					num3 = 0;
					num = (short)1772421188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6A9:
					num = (short)1873281061;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_746:
					num10 += (uint)b;
					num = (short)739180549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_866:
					text = new global::System.Text.ASCIIEncoding().GetString(array);
					text2 = text;
					num = (short)1988034567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A50:
					text = "";
					num10 = 0U;
					num5 = 0U;
					num4 = 0U;
					num3 = 0;
					num = (short)331743288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD9:
					num = (short)1154940938;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BA6:
					num = (short)893976576;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_180:
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﮒﶘﺚ", a_));
			}
			}
		}
	}
}
