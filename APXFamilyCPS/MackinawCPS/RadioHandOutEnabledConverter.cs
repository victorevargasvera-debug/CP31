using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x0200001F RID: 31
	public class RadioHandOutEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600006B RID: 107 RVA: 0x0000D168 File Offset: 0x0000B368
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1095499782;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_199;
				case 2:
					goto IL_FC;
				case 3:
					num2 = (short)1764818948;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					if ((bool)values[2])
					{
						num2 = (short)1423835143;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					bool flag2;
					flag = flag2;
					num2 = (short)1867841537;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					num2 = (short)893648905;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					int num3 = (int)((global::AcpCommonLib.ApplicationMode)values[0]);
					bool flag2 = (bool)values[1];
					if (num3 != 1)
					{
						num2 = (short)1413283840;
						short num4 = num2;
						num2 = (short)1692008451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_71;
				}
				case 7:
					goto IL_71;
				case 8:
					IL_4E:
					if (values.Length == 3)
					{
						num2 = (short)1659699205;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_210;
				case 9:
					if (values[0] is global::AcpCommonLib.ApplicationMode)
					{
						num2 = (short)2010120192;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_210;
				}
				goto IL_38;
				IL_71:
				flag = false;
				num2 = (short)165562941;
				short num5 = num2;
				num2 = (short)891046461;
				switch ((num5 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4E;
				default:
					num2 = (short)1763049473;
					if (num2 != 0)
					{
					}
					num2 = (short)1029898240;
					if (num2 != 0)
					{
					}
					num2 = (short)217972738;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_FC:
			IL_199:
			IL_210:
			return flag;
			IL_38:
			flag = false;
			num2 = (short)1167589384;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000D38C File Offset: 0x0000B58C
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1221066753;
			if (num != 0)
			{
			}
			num = (short)1390178016;
			short num2 = num;
			num = (short)1758555872;
			switch (num2 == num)
			{
			}
			num = (short)1654456320;
			if (num != 0)
			{
			}
			num = (short)2147090432;
			short num3 = num;
			return null;
		}

		// Token: 0x04000033 RID: 51
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
