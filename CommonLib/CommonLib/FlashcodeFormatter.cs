using System;
using System.Text;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.CommonLib
{
	// Token: 0x02000011 RID: 17
	public class FlashcodeFormatter
	{
		// Token: 0x0600006C RID: 108 RVA: 0x0000F640 File Offset: 0x0000D840
		public string FormatFlashcodeString(byte[] flashcode, int nSize)
		{
			int a_ = 17;
			short num = (short)144441344;
			switch (num)
			{
			default:
				for (;;)
				{
					IL_27:
					num = (short)749142021;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						byte[] array;
						uint num3;
						global::Motorola.Common.CommonLib.FlashcodeMapping flashcodeMapping;
						uint num4;
						uint num5;
						int num7;
						uint num8;
						byte b3;
						string text;
						string result;
						uint num9;
						byte b4;
						uint num11;
						byte b5;
						switch (num2)
						{
						case 0:
						{
							byte b;
							array[(int)num3++] = (byte)flashcodeMapping.a((int)b);
							num = (short)204013593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_6CE;
						case 2:
							goto IL_7E9;
						case 3:
							goto IL_9E2;
						case 4:
							array[(int)num3++] = global::System.Convert.ToByte('-');
							num = (short)139526182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_157;
							}
							continue;
						case 6:
							goto IL_3B6;
						case 7:
							goto IL_6CE;
						case 8:
							if (nSize == 6)
							{
								num = (short)870842414;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num4 = 1U;
							num5 = 6U;
							num = (short)849281027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							uint num6;
							if (num6 <= 0U)
							{
								num = (short)584646677;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)930283561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_494;
						case 11:
						{
							if (num7 % 2 == 0)
							{
								num = (short)786104356;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte b;
							byte b2 = b / 10 + b % 10;
							num8 += (uint)b2;
							num = (short)1817641000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							if (num7 >= nSize)
							{
								num = (short)357040184;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte b = flashcode[num7];
							num = (short)115146763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							array[(int)num3++] = b3 - 10 + 65;
							num = (short)42926117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
						{
							byte[] array2 = new byte[24];
							global::System.Array.Copy(flashcode, 0, array2, 0, 12);
							global::System.Array.Copy(flashcode, 13, array2, 12, 12);
							flashcode = array2;
							nSize = flashcode.Length;
							num = (short)589103136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							goto IL_3B6;
						case 16:
						{
							byte b;
							if (b < 64)
							{
								num = (short)109117440;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array = null;
							num = (short)1824915458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							if ((long)nSize % (long)((ulong)num5) > 0L)
							{
								num = (short)1732771868;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_40A;
						case 18:
							if (b3 > 9)
							{
								num = (short)1714028557;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array[(int)num3++] = b3 + 48;
							num = (short)565706762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							goto IL_B8E;
						case 20:
							goto IL_363;
						case 21:
							num = (short)237568062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							array[(int)num3++] = global::System.Convert.ToByte('-');
							num = (short)1922695222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
						{
							string value = text.Substring(text.Length - 2, 2);
							result = text.Remove(text.Length - 2, 2).Insert(13, value);
							num = (short)1197998106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
							goto IL_1A0;
						case 25:
							num = (short)729022522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							return result;
						case 27:
							num = (short)778371107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							num9 = (uint)((ulong)num5 - (ulong)((long)nSize % (long)((ulong)num5)));
							num = (short)1233387584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
						{
							num = (short)330615293;
							short num10 = num;
							num = (short)1710672381;
							switch ((num10 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_27;
							default:
								num = (short)1816854528;
								if (num != 0)
								{
								}
								goto IL_549;
							}
							break;
						}
						case 30:
							array[(int)num3++] = b4 - 10 + 65;
							num = (short)1536753671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							goto IL_321;
						case 32:
							goto IL_A47;
						case 33:
							goto IL_7E9;
						case 34:
							if (text.Length == 29)
							{
								num = (short)416546839;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 35:
							if (num9 > 0U)
							{
								num = (short)2015363094;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_93F;
						case 36:
							num = (short)898564140;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
							goto IL_494;
						case 38:
							goto IL_17B;
						case 39:
							goto IL_B01;
						case 40:
							goto IL_B01;
						case 41:
						{
							uint num6;
							num11 = 10U - num6;
							goto IL_A26;
						}
						case 42:
							goto IL_176;
						case 43:
						{
							uint num6 = num8 % 10U;
							num = (short)175898633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 44:
						{
							byte b;
							if (b * 2 >= 100)
							{
								num = (short)1379336255;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							b5 = b * 2 / 10 + b * 2 % 10;
							num = (short)361562136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 45:
							if (flashcode.Length == 25)
							{
								num = (short)465960974;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A47;
						case 46:
						{
							num4 = 2U;
							num5 = 3U;
							num = (short)450297856;
							short num12 = num;
							num = (short)959184948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 47:
							if (nSize == 6)
							{
								num = (short)699138101;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							b5 = 0;
							num7 = 0;
							num = (short)281280562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 48:
							goto IL_1A0;
						case 49:
							goto IL_321;
						case 50:
							goto IL_B8E;
						case 51:
							if (b4 > 9)
							{
								num = (short)2083258398;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array[(int)num3++] = b4 + 48;
							num = (short)192413697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 52:
							goto IL_9E2;
						case 53:
							num7 = 0;
							num = (short)978649094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 54:
							goto IL_93F;
						case 55:
							num = (short)1020985377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 56:
							goto IL_7E9;
						case 57:
						{
							if (num7 >= nSize)
							{
								num = (short)228786231;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte b6 = flashcode[num7];
							b3 = (byte)(b6 >> 4);
							b4 = (b6 & 15);
							num = (short)1805254674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 58:
							num = (short)1322713089;
							if (num != 0)
							{
							}
							if ((long)(num7 + 1) % (long)((ulong)num5) <= 0L)
							{
								num = (short)607125508;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_17B;
						case 59:
							if ((long)(num7 + 1) % (long)((ulong)num5) <= 0L)
							{
								num = (short)1088028733;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_549;
						case 60:
							if ((long)num7 >= (long)((ulong)(num9 * 2U)))
							{
								num = (short)871694363;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							array[(int)num3++] = global::System.Convert.ToByte('0');
							num7++;
							num = (short)1254686769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 61:
							array[(int)num3++] = global::System.Convert.ToByte('-');
							num = (short)2142437405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 62:
						{
							uint num6;
							num11 = num6;
							goto IL_A26;
						}
						case 63:
						{
							byte b;
							b5 = b * 2 / 100 + b * 2 % 100 / 10 + b * 2 % 100 % 10;
							num = (short)341966896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 64:
							goto IL_40A;
						case 65:
							if (array != null)
							{
								num = (short)1275396139;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_363;
						}
						IL_157:
						if (flashcode == null)
						{
							num = (short)1402077226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1539113005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_17B:
						num7++;
						num = (short)430506003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A0:
						num8 += (uint)b5;
						num = (short)1897070631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_321:
						num = (short)655556668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_363:
						text = new global::System.Text.ASCIIEncoding().GetString(array);
						result = text;
						num = (short)551551010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3B6:
						num = (short)557580345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_40A:
						uint num13 = (uint)(((long)nSize + (long)((ulong)num9)) / (long)((ulong)num5));
						array = new byte[((long)nSize + (long)((ulong)num9)) * (long)((ulong)num4) + (long)((ulong)num13) + 1L];
						num = (short)1814822959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_494:
						num = (short)1452408883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_549:
						b3 = b3 * 2 / 10 + b3 * 2 % 10;
						b4 = b4 / 10 + b4 % 10;
						num8 = num8 + (uint)b3 + (uint)b4;
						num7++;
						num = (short)769327119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6CE:
						num = (short)1541013563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7E9:
						num = (short)1404305473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_93F:
						array[(int)num3++] = (byte)(num8 + 48U);
						num = (short)403505172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9E2:
						num = (short)520224785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A26:
						num8 = num11;
						num7 = 0;
						num = (short)2012545055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A47:
						text = "";
						num8 = 0U;
						num3 = 0U;
						num9 = 0U;
						num7 = 0;
						num = (short)972161032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B01:
						flashcodeMapping = new global::Motorola.Common.CommonLib.FlashcodeMapping();
						num = (short)243335184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B8E:
						num = (short)249626636;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_176:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("猔笖砘栚甜簞丠䜢䀤", a_));
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00010240 File Offset: 0x0000E440
		public byte CalculateFlashCodeCheckDigit(string flashCode)
		{
			short num = (short)1255079936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8A;
				}
				byte b;
				byte[] array;
				byte b3;
				global::Motorola.Common.CommonLib.FlashcodeDecoder flashcodeDecoder;
				for (;;)
				{
					IL_27:
					byte b2;
					int num3;
					switch (num2)
					{
					case 0:
						if (b * 2 >= 100)
						{
							num = (short)644808710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b2 = b * 2 / 10 + b * 2 % 10;
						num = (short)1494155286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_266;
					case 2:
						if (num3 >= array.Length)
						{
							num = (short)1154482186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b = array[num3];
						num = (short)2097152009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1F3;
					case 4:
						return b3;
					case 5:
						if (array != null)
						{
							num = (short)1020526605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b3 = byte.MaxValue;
						num = (short)380502020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						b2 = b * 2 / 100 + b * 2 % 100 / 10 + b * 2 % 100 % 10;
						num = (short)1768620053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (flashCode.Length <= 15)
						{
							num = (short)1420623886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CF;
					case 8:
						return b3;
					case 9:
					{
						if (num3 % 2 == 0)
						{
							num = (short)1426915348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b4 = b / 10 + b % 10;
						b3 += b4;
						num = (short)1502937103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						num = (short)1572405248;
						short num4 = num;
						byte b5 = b3 % 10;
						num = (short)1388052499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						byte b5;
						b3 = 10 - b5;
						num = (short)2002386952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_12C;
					case 13:
						num = (short)1526661121;
						if (num != 0)
						{
						}
						num3 = 0;
						num = (short)1414529036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						flashcodeDecoder.Decode(flashCode, ref array);
						num = (short)1750728722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_1F3;
					case 16:
						return b3;
					case 17:
						goto IL_12C;
					case 18:
						goto IL_266;
					case 19:
					{
						byte b5;
						if (b5 > 0)
						{
							num = (short)1180893195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b3 = b5;
						num = (short)73465872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)1317273600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_16D;
					case 22:
						goto IL_16D;
					}
					goto IL_8A;
					IL_12C:
					num = (short)1436352514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16D:
					b3 += b2;
					num = (short)477102083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F3:
					num3++;
					num = (short)1947992081;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_266:
					num = (short)638124037;
					num2 = (int)((global::System.IntPtr)num);
				}
				return b3;
				IL_8A:
				b3 = 0;
				b = 0;
				array = new byte[0];
				flashcodeDecoder = new global::Motorola.Common.CommonLib.FlashcodeDecoder();
				num = (short)1215464639;
				short num5 = num;
				num = (short)129139903;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1CF:
					flashcodeDecoder.DecodeExpandedFlashcode(flashCode, ref array);
					num = (short)1932525569;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				default:
					num = (short)655228928;
					if (num != 0)
					{
					}
					num = (short)2135687175;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}
	}
}
