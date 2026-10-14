using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Comparers
{
	// Token: 0x02000028 RID: 40
	public class AlphanumericalStringComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<string>
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00018284 File Offset: 0x00016484
		public int Compare(object x, object y)
		{
			int a_ = 8;
			short num = (short)757268485;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			string text2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1534066689;
					if (num != 0)
					{
					}
					if (text == null)
					{
						num = (short)1915289611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_292;
				case 1:
					return 1;
				case 2:
					num = (short)914161674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return -1;
				case 4:
					if (text2 == null)
					{
						num = (short)1693712390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = (y as string);
					num = (short)872087552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				case 6:
					goto IL_1D0;
				case 7:
					goto IL_210;
				case 8:
					return 0;
				case 9:
					if (y == null)
					{
						num = (short)1593573377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					text2 = (x as string);
					num = (short)1459159044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					if (y != null)
					{
						goto IL_1F9;
					}
					num = (short)1539041485;
					short num3 = num;
					num = (short)363194573;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_210;
					default:
						num = (short)2023686144;
						if (num != 0)
						{
						}
						num = (short)1413873672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					goto IL_10A;
				}
				IL_5F:
				if (x == null)
				{
					num = (short)2005467138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1F9:
				num = (short)687734791;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_210:
				num = (short)101187584;
				short num4 = num;
				if (x == null)
				{
					num = (short)1769734147;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)906952713;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_10A:
			throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("࡛㙝य़ᅡ䑣୥൧ṩѫŭᑯ剱ݳ͵ࡷ੹፻౽ꒃ꺍ﾕﶙ벛ﾝ튟얡톣쮥춧쒩\ud8ab\uddad麯", a_), global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("╛", a_));
			IL_1D0:
			throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("࡛㙝य़ᅡ䑣୥൧ṩѫŭᑯ剱ݳ͵ࡷ੹፻౽ꒃ꺍ﾕﶙ벛ﾝ튟얡톣쮥춧쒩\ud8ab\uddad麯", a_), global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⑛", a_));
			IL_292:
			return this.Compare(text2, text);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0001852C File Offset: 0x0001672C
		public int Compare(string x, string y)
		{
			short num = (short)1045364747;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (y != null)
					{
						num = (short)843710471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C3;
				case 1:
				{
					num = (short)271297820;
					short num3 = num;
					num = (short)848997660;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_124;
					default:
						num = (short)1003618304;
						if (num != 0)
						{
						}
						num = (short)972357646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					if (x == string.Empty)
					{
						num = (short)1798176769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F2;
				case 3:
					if (x != string.Empty)
					{
						num = (short)712769548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_328;
				case 4:
					return 0;
				case 5:
					num = (short)12451841;
					if (num != 0)
					{
					}
					num = (short)586153984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1061617664;
					short num4 = num;
					num = (short)670826505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					return -1;
				case 8:
					return 1;
				case 9:
					if (y == null)
					{
						num = (short)1240989706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_235;
				case 10:
					return 1;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 12:
					num = (short)389808145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					return -1;
				case 14:
					if (y != string.Empty)
					{
						num = (short)1293877261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F2;
				case 15:
					if (x != null)
					{
						num = (short)697761798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_235;
				case 16:
					if (x == null)
					{
						num = (short)32505861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C3;
				case 17:
					if (y == string.Empty)
					{
						goto IL_124;
					}
					goto IL_328;
				}
				IL_6D:
				if (object.Equals(x, y))
				{
					num = (short)2144665604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2133590032;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_124:
				num = (short)1406468104;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F2:
				num = (short)1364328451;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_235:
				num = (short)1853030402;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C3:
				num = (short)629211151;
				num2 = (int)((global::System.IntPtr)num);
			}
			return 0;
			IL_328:
			string text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.AlphanumericalStringComparer.PadNumbers(x);
			string strB = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.AlphanumericalStringComparer.PadNumbers(y);
			return text.CompareTo(strB);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00018874 File Offset: 0x00016A74
		public static string PadNumbers(string input)
		{
			int a_ = 10;
			short num = (short)825098240;
			short num2 = num;
			num = (short)1533391986;
			short num3 = num;
			num = (short)1053865074;
			switch (num3 == num)
			{
			}
			num = (short)372572161;
			if (num != 0)
			{
			}
			num = (short)424148992;
			if (num != 0)
			{
			}
			return global::System.Text.RegularExpressions.Regex.Replace(input, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("՝偟佡嵣㭥䍧", a_), new global::System.Text.RegularExpressions.MatchEvaluator(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.AlphanumericalStringComparer.<>c.<>9.a));
		}

		// Token: 0x04000242 RID: 578
		public const int MaxNumericLength = 20;
	}
}
