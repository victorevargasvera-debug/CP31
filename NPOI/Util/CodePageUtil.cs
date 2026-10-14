using System;
using System.Text;

namespace NPOI.Util
{
	// Token: 0x02000264 RID: 612
	public class CodePageUtil
	{
		// Token: 0x06000FE4 RID: 4068 RVA: 0x00030E94 File Offset: 0x0002F094
		public static byte[] GetBytesInCodePage(string string1, int codepage)
		{
			string name = global::NPOI.Util.CodePageUtil.CodepageToEncoding(codepage);
			global::System.Text.Encoding encoding;
			try
			{
				encoding = global::System.Text.Encoding.GetEncoding(name);
			}
			catch (global::System.Exception)
			{
				encoding = global::System.Text.Encoding.ASCII;
			}
			return encoding.GetBytes(string1);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00030ED4 File Offset: 0x0002F0D4
		public static string GetStringFromCodePage(byte[] string1, int codepage)
		{
			return global::NPOI.Util.CodePageUtil.GetStringFromCodePage(string1, 0, string1.Length, codepage);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00030EE1 File Offset: 0x0002F0E1
		public static string GetStringFromCodePage(byte[] string1, int offset, int length, int codepage)
		{
			return global::System.Text.Encoding.GetEncoding(global::NPOI.Util.CodePageUtil.CodepageToEncoding(codepage)).GetString(string1, offset, length);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00030EF8 File Offset: 0x0002F0F8
		public static string CodepageToEncoding(int codepage)
		{
			if (codepage <= 0)
			{
				throw new global::System.ArgumentException("Codepage number may not be " + codepage.ToString());
			}
			if (codepage <= 20127)
			{
				if (codepage <= 1201)
				{
					if (codepage <= 936)
					{
						if (codepage == 37)
						{
							return "cp037";
						}
						if (codepage == 932)
						{
							return "SJIS";
						}
						if (codepage != 936)
						{
							goto IL_365;
						}
						return "GBK";
					}
					else
					{
						if (codepage == 949)
						{
							return "ms949";
						}
						if (codepage == 1200)
						{
							return "UTF-16";
						}
						if (codepage != 1201)
						{
							goto IL_365;
						}
						return "UTF-16BE";
					}
				}
				else if (codepage <= 10021)
				{
					switch (codepage)
					{
					case 1250:
						return "windows-1250";
					case 1251:
						return "windows-1251";
					case 1252:
						break;
					case 1253:
						return "windows-1253";
					case 1254:
						return "windows-1254";
					case 1255:
						return "windows-1255";
					case 1256:
						return "windows-1256";
					case 1257:
						return "windows-1257";
					case 1258:
						return "windows-1258";
					default:
						if (codepage == 1361)
						{
							return "johab";
						}
						switch (codepage)
						{
						case 10000:
							goto IL_299;
						case 10001:
							return "SJIS";
						case 10002:
							return "Big5";
						case 10003:
							return "EUC-KR";
						case 10004:
							return "MacArabic";
						case 10005:
							return "MacHebrew";
						case 10006:
							return "MacGreek";
						case 10007:
							return "MacCyrillic";
						case 10008:
							return "EUC_CN";
						case 10009:
						case 10011:
						case 10012:
						case 10013:
						case 10014:
						case 10015:
						case 10016:
						case 10018:
						case 10019:
						case 10020:
							goto IL_365;
						case 10010:
							return "MacRomania";
						case 10017:
							return "MacUkraine";
						case 10021:
							return "MacThai";
						default:
							goto IL_365;
						}
						break;
					}
				}
				else
				{
					if (codepage == 10029)
					{
						return "MacCentralEurope";
					}
					switch (codepage)
					{
					case 10079:
						return "MacIceland";
					case 10080:
						goto IL_365;
					case 10081:
						return "MacTurkish";
					case 10082:
						return "MacCroatian";
					default:
						if (codepage != 20127)
						{
							goto IL_365;
						}
						goto IL_2F9;
					}
				}
			}
			else if (codepage <= 50225)
			{
				if (codepage <= 32768)
				{
					if (codepage == 20866)
					{
						return "KOI8-R";
					}
					switch (codepage)
					{
					case 28591:
						return "ISO-8859-1";
					case 28592:
						return "ISO-8859-2";
					case 28593:
						return "ISO-8859-3";
					case 28594:
						return "ISO-8859-4";
					case 28595:
						return "ISO-8859-5";
					case 28596:
						return "ISO-8859-6";
					case 28597:
						return "ISO-8859-7";
					case 28598:
						return "ISO-8859-8";
					case 28599:
						return "ISO-8859-9";
					default:
						if (codepage != 32768)
						{
							goto IL_365;
						}
						goto IL_299;
					}
				}
				else if (codepage != 32769)
				{
					if (codepage - 50220 <= 2)
					{
						return "ISO-2022-JP";
					}
					if (codepage != 50225)
					{
						goto IL_365;
					}
					return "ISO-2022-KR";
				}
			}
			else if (codepage <= 52936)
			{
				if (codepage == 51932)
				{
					return "EUC-JP";
				}
				if (codepage == 51949)
				{
					return "EUC-KR";
				}
				if (codepage != 52936)
				{
					goto IL_365;
				}
				return "GB2312";
			}
			else
			{
				if (codepage == 54936)
				{
					return "GB18030";
				}
				if (codepage == 65000)
				{
					goto IL_2F9;
				}
				if (codepage != 65001)
				{
					goto IL_365;
				}
				return "UTF-8";
			}
			return "windows-1252";
			IL_299:
			return "MacRoman";
			IL_2F9:
			return "US-ASCII";
			IL_365:
			return "cp" + codepage.ToString();
		}

		// Token: 0x040006E8 RID: 1768
		public const int CP_037 = 37;

		// Token: 0x040006E9 RID: 1769
		public const int CP_SJIS = 932;

		// Token: 0x040006EA RID: 1770
		public const int CP_GBK = 936;

		// Token: 0x040006EB RID: 1771
		public const int CP_MS949 = 949;

		// Token: 0x040006EC RID: 1772
		public const int CP_UTF16 = 1200;

		// Token: 0x040006ED RID: 1773
		public const int CP_UTF16_BE = 1201;

		// Token: 0x040006EE RID: 1774
		public const int CP_WINDOWS_1250 = 1250;

		// Token: 0x040006EF RID: 1775
		public const int CP_WINDOWS_1251 = 1251;

		// Token: 0x040006F0 RID: 1776
		public const int CP_WINDOWS_1252 = 1252;

		// Token: 0x040006F1 RID: 1777
		public const int CP_WINDOWS_1252_BIFF23 = 32769;

		// Token: 0x040006F2 RID: 1778
		public const int CP_WINDOWS_1253 = 1253;

		// Token: 0x040006F3 RID: 1779
		public const int CP_WINDOWS_1254 = 1254;

		// Token: 0x040006F4 RID: 1780
		public const int CP_WINDOWS_1255 = 1255;

		// Token: 0x040006F5 RID: 1781
		public const int CP_WINDOWS_1256 = 1256;

		// Token: 0x040006F6 RID: 1782
		public const int CP_WINDOWS_1257 = 1257;

		// Token: 0x040006F7 RID: 1783
		public const int CP_WINDOWS_1258 = 1258;

		// Token: 0x040006F8 RID: 1784
		public const int CP_JOHAB = 1361;

		// Token: 0x040006F9 RID: 1785
		public const int CP_MAC_ROMAN = 10000;

		// Token: 0x040006FA RID: 1786
		public const int CP_MAC_ROMAN_BIFF23 = 32768;

		// Token: 0x040006FB RID: 1787
		public const int CP_MAC_JAPAN = 10001;

		// Token: 0x040006FC RID: 1788
		public const int CP_MAC_CHINESE_TRADITIONAL = 10002;

		// Token: 0x040006FD RID: 1789
		public const int CP_MAC_KOREAN = 10003;

		// Token: 0x040006FE RID: 1790
		public const int CP_MAC_ARABIC = 10004;

		// Token: 0x040006FF RID: 1791
		public const int CP_MAC_HEBREW = 10005;

		// Token: 0x04000700 RID: 1792
		public const int CP_MAC_GREEK = 10006;

		// Token: 0x04000701 RID: 1793
		public const int CP_MAC_CYRILLIC = 10007;

		// Token: 0x04000702 RID: 1794
		public const int CP_MAC_CHINESE_SIMPLE = 10008;

		// Token: 0x04000703 RID: 1795
		public const int CP_MAC_ROMANIA = 10010;

		// Token: 0x04000704 RID: 1796
		public const int CP_MAC_UKRAINE = 10017;

		// Token: 0x04000705 RID: 1797
		public const int CP_MAC_THAI = 10021;

		// Token: 0x04000706 RID: 1798
		public const int CP_MAC_CENTRAL_EUROPE = 10029;

		// Token: 0x04000707 RID: 1799
		public const int CP_MAC_ICELAND = 10079;

		// Token: 0x04000708 RID: 1800
		public const int CP_MAC_TURKISH = 10081;

		// Token: 0x04000709 RID: 1801
		public const int CP_MAC_CROATIAN = 10082;

		// Token: 0x0400070A RID: 1802
		public const int CP_US_ACSII = 20127;

		// Token: 0x0400070B RID: 1803
		public const int CP_KOI8_R = 20866;

		// Token: 0x0400070C RID: 1804
		public const int CP_ISO_8859_1 = 28591;

		// Token: 0x0400070D RID: 1805
		public const int CP_ISO_8859_2 = 28592;

		// Token: 0x0400070E RID: 1806
		public const int CP_ISO_8859_3 = 28593;

		// Token: 0x0400070F RID: 1807
		public const int CP_ISO_8859_4 = 28594;

		// Token: 0x04000710 RID: 1808
		public const int CP_ISO_8859_5 = 28595;

		// Token: 0x04000711 RID: 1809
		public const int CP_ISO_8859_6 = 28596;

		// Token: 0x04000712 RID: 1810
		public const int CP_ISO_8859_7 = 28597;

		// Token: 0x04000713 RID: 1811
		public const int CP_ISO_8859_8 = 28598;

		// Token: 0x04000714 RID: 1812
		public const int CP_ISO_8859_9 = 28599;

		// Token: 0x04000715 RID: 1813
		public const int CP_ISO_2022_JP1 = 50220;

		// Token: 0x04000716 RID: 1814
		public const int CP_ISO_2022_JP2 = 50221;

		// Token: 0x04000717 RID: 1815
		public const int CP_ISO_2022_JP3 = 50222;

		// Token: 0x04000718 RID: 1816
		public const int CP_ISO_2022_KR = 50225;

		// Token: 0x04000719 RID: 1817
		public const int CP_EUC_JP = 51932;

		// Token: 0x0400071A RID: 1818
		public const int CP_EUC_KR = 51949;

		// Token: 0x0400071B RID: 1819
		public const int CP_GB2312 = 52936;

		// Token: 0x0400071C RID: 1820
		public const int CP_GB18030 = 54936;

		// Token: 0x0400071D RID: 1821
		public const int CP_US_ASCII2 = 65000;

		// Token: 0x0400071E RID: 1822
		public const int CP_UTF8 = 65001;

		// Token: 0x0400071F RID: 1823
		public const int CP_UNICODE = 1200;
	}
}
