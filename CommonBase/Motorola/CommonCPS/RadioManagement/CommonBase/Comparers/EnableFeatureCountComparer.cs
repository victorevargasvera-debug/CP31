using System;
using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Comparers
{
	// Token: 0x0200002B RID: 43
	public class EnableFeatureCountComparer : global::System.Collections.IComparer
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x000195B8 File Offset: 0x000177B8
		public int Compare(object x, object y)
		{
			int a_ = 9;
			short num;
			int result;
			try
			{
				num = (short)1064763392;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					string text;
					string text2;
					for (;;)
					{
						IL_32:
						switch (num2)
						{
						case 0:
						{
							int num3 = int.Parse(text, global::System.Globalization.CultureInfo.CurrentCulture);
							int num4 = int.Parse(text2, global::System.Globalization.CultureInfo.CurrentCulture);
							num = (short)770244610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_22D;
						case 2:
						{
							int num3;
							int num4;
							if (num3 > num4)
							{
								num = (short)1939472389;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2074083336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							bool flag = global::System.Text.RegularExpressions.Regex.IsMatch(text, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("͜ў䩠乢㡤塦㕨ཪ䝬䭮", a_));
							bool flag2 = global::System.Text.RegularExpressions.Regex.IsMatch(text2, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("͜ў䩠乢㡤塦㕨ཪ䝬䭮", a_));
							if (flag && flag2)
							{
								num = (short)1081540608;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = string.Compare(text, text2, false, global::System.Globalization.CultureInfo.CurrentCulture);
							num = (short)1765212161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_1E7;
						case 5:
							result = 1;
							num = (short)955973639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_D2;
						case 7:
							goto IL_204;
						case 8:
						{
							int num3;
							int num4;
							if (num3 >= num4)
							{
								result = 0;
								num = (short)1738342404;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)634658995;
							short num5 = num;
							num = (short)1039409331;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D2;
							default:
								num = (short)1909850112;
								if (num != 0)
								{
								}
								num = (short)1707081734;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_ED;
						}
						goto IL_61;
						IL_D2:
						result = -1;
						num = (short)1594359817;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_ED:
					IL_1E7:
					IL_204:
					IL_22D:
					break;
					IL_61:
					text = (x as string);
					text2 = (y as string);
					num = (short)603193347;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				}
			}
			catch
			{
				result = 0;
			}
			num = (short)2121728001;
			if (num != 0)
			{
			}
			num = (short)1168769024;
			short num6 = num;
			return result;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0001987C File Offset: 0x00017A7C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(910088715 + A_1) + (global::System.IntPtr)18 + (global::System.IntPtr)54);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}
	}
}
