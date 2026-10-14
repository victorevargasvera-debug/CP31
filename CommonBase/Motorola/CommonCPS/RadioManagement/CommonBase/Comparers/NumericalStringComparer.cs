using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Comparers
{
	// Token: 0x0200002A RID: 42
	public class NumericalStringComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<string>
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00018AF4 File Offset: 0x00016CF4
		public int Compare(object x, object y)
		{
			int a_ = 16;
			short num = (short)680525829;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			string text2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (text == null)
					{
						num = (short)209715211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_287;
				case 1:
					return 1;
				case 2:
					num = (short)2022178826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return -1;
				case 4:
					if (text2 == null)
					{
						num = (short)612892678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = (y as string);
					num = (short)1738276864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 6:
					goto IL_1A1;
				case 7:
					goto IL_1E1;
				case 8:
					return 0;
				case 9:
					if (y == null)
					{
						num = (short)777650177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text2 = (x as string);
					num = (short)202768388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					if (y != null)
					{
						goto IL_1CA;
					}
					num = (short)1428552888;
					short num3 = num;
					num = (short)910687416;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E1;
					default:
						num = (short)821362688;
						if (num != 0)
						{
						}
						num = (short)983891976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					goto IL_DA;
				}
				IL_5D:
				if (x == null)
				{
					num = (short)1513029634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1CA:
				num = (short)561446919;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E1:
				if (x == null)
				{
					num = (short)1788018688;
					short num4 = num;
					num = (short)663683075;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)2109800449;
					if (num != 0)
					{
					}
					num = (short)1451294729;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_DA:
			throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("っ๥ŧᥩ䱫ͭᕯٱᱳ᥵ᱷ婹ཻ୽ﲇ黎겋ﺏﺑ뚕캟얡蒣장\udaa7충\ud9ab쎭햯\udcb1삳억隷", a_), global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᵣ", a_));
			IL_1A1:
			throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("っ๥ŧᥩ䱫ͭᕯٱᱳ᥵ᱷ婹ཻ୽ﲇ黎겋ﺏﺑ뚕캟얡蒣장\udaa7충\ud9ab쎭햯\udcb1삳억隷", a_), global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᱣ", a_));
			IL_287:
			return this.Compare(text2, text);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00018D90 File Offset: 0x00016F90
		public int Compare(string x, string y)
		{
			short num = (short)932511744;
			switch (num)
			{
			default:
			{
				num = (short)150405127;
				int num2 = (int)((global::System.IntPtr)num);
				bool flag;
				bool flag2;
				long a_;
				bool flag3;
				long a_2;
				bool flag4;
				long a_3;
				long a_4;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!string.IsNullOrWhiteSpace(y))
						{
							num = (short)1085341698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DE;
					case 1:
					{
						num = (short)906161060;
						short num3 = num;
						num = (short)1422257060;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_201;
						default:
							num = (short)754909184;
							if (num != 0)
							{
							}
							num = (short)1508900865;
							if (num != 0)
							{
							}
							num = (short)823328779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_2CC;
					case 3:
						return 0;
					case 4:
						if (flag || flag2)
						{
							num = (short)1947271181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag3 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.NumericalStringComparer.TryConvertFromDecimal(x, out a_);
						flag4 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.NumericalStringComparer.TryConvertFromDecimal(y, out a_2);
						num = (short)1420951557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (flag3 || flag4)
						{
							num = (short)633208838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FA;
					case 6:
						goto IL_1C2;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					case 8:
						if (!string.IsNullOrWhiteSpace(x))
						{
							goto IL_201;
						}
						goto IL_A3;
					case 9:
						num = (short)1177354240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (string.IsNullOrWhiteSpace(x))
						{
							num = (short)1198915593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DE;
					case 11:
						if (string.IsNullOrWhiteSpace(y))
						{
							num = (short)1306656780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A3;
					case 12:
						return 1;
					case 13:
						goto IL_EE;
					}
					IL_7B:
					if (object.Equals(x, y))
					{
						num = (short)1228603395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)722993162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A3:
					flag = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.NumericalStringComparer.TryConvertFromHex(x, out a_3);
					flag2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.NumericalStringComparer.TryConvertFromHex(y, out a_4);
					num = (short)277020676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DE:
					num = (short)748748808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_201:
					num = (short)1381564417;
					num2 = (int)((global::System.IntPtr)num);
				}
				return 0;
				IL_EE:
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.NumericalStringComparer.a(flag, a_3, flag2, a_4);
				IL_1C2:
				return global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.NumericalStringComparer.b(flag3, a_, flag4, a_2);
				IL_2CC:
				num = (short)2102460416;
				short num4 = num;
				return -1;
				IL_2FA:
				return string.Compare(x, y);
			}
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000190A0 File Offset: 0x000172A0
		public static bool TryConvertFromHex(string literal, out long value)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!global::System.Text.RegularExpressions.Regex.IsMatch(literal, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("୔罖楘⍚⅜潞㥠䩢㹤٦䑨൪ⱬ䉮㝰䍲塴乶⑸偺奼", a_)))
					{
						num2 = (short)851247106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_144;
				case 1:
					num2 = (short)143392769;
					if (num2 != 0)
					{
					}
					if (literal == null)
					{
						num2 = (short)1940520963;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)463470592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return false;
				case 3:
					goto IL_AD;
				}
				goto IL_29;
			}
			IL_AD:
			num2 = (short)1197333517;
			short num3 = num2;
			num2 = (short)2004081677;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			default:
				num2 = (short)960167936;
				if (num2 != 0)
				{
				}
				return false;
			}
			IL_144:
			value = global::System.Convert.ToInt64(literal, 16);
			return true;
			IL_29:
			num2 = (short)1515978752;
			short num4 = num2;
			value = 0L;
			num2 = (short)1005715457;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000191FC File Offset: 0x000173FC
		public static bool TryConvertFromDecimal(string literal, out long value)
		{
			short num = (short)1697382400;
			short num2 = num;
			num = (short)1334715959;
			short num3 = num;
			num = (short)279062071;
			switch (num3 == num)
			{
			}
			num = (short)717946881;
			if (num != 0)
			{
			}
			num = (short)996933632;
			if (num != 0)
			{
			}
			return long.TryParse(literal, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out value);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000192B4 File Offset: 0x000174B4
		private static int b(bool A_0, long A_1, bool A_2, long A_3)
		{
			short num = (short)472711168;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)257759412;
					short num3 = num;
					num = (short)66197684;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1689583617;
						if (num != 0)
						{
						}
						num = (short)1300758528;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B3;
						}
						continue;
					}
					break;
				}
				case 1:
					if (!A_2)
					{
						num = (short)1155465219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC;
				case 2:
					goto IL_FD;
				case 3:
					return -1;
				case 4:
					if (!A_0 && A_2)
					{
						num = (short)1212219394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15D;
				case 5:
					num = (short)843579393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B3:
				if (A_0)
				{
					num = (short)2047410181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CC:
				num = (short)1274085380;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FD:
			num = (short)1929641984;
			short num4 = num;
			return 1;
			IL_15D:
			return A_1.CompareTo(A_3);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00019428 File Offset: 0x00017628
		private static int a(bool A_0, long A_1, bool A_2, long A_3)
		{
			short num = (short)1333264384;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1032754863;
					short num3 = num;
					num = (short)1276745391;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)2004680704;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					}
					break;
				}
				case 1:
					if (!A_2)
					{
						num = (short)1296826371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A4;
				case 2:
					goto IL_DA;
				case 3:
					goto IL_111;
				case 4:
					if (!A_0 && A_2)
					{
						num = (short)314310658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_165;
				case 5:
					num = (short)1628307457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_89:
				if (A_0)
				{
					num = (short)210370565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A4:
				num = (short)1204944900;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DA:
			num = (short)808779776;
			short num4 = num;
			return 1;
			IL_111:
			num = (short)642908161;
			if (num != 0)
			{
			}
			return -1;
			IL_165:
			return A_1.CompareTo(A_3);
		}
	}
}
