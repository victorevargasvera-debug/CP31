using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace SpecialFeatures.SystemCertificates.List
{
	// Token: 0x020001AD RID: 429
	public class SystemCertificateParentControlVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600144D RID: 5197 RVA: 0x001D4534 File Offset: 0x001D2734
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1756233728;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 1:
					num = (short)94437381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)195887105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_258;
				case 3:
					if (values[3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1710096394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36B;
				case 4:
					num = (short)1186791440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (bool.Parse(values[1].ToString()))
					{
						num = (short)684326916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_258;
				case 6:
					num = (short)624623623;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1989017617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36B;
				case 8:
					if (values[4] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)915275790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36B;
				case 9:
					num = (short)1410727948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)2053373960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (!bool.Parse(values[4].ToString()))
					{
						num = (short)549584911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FE;
				case 12:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)911605766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36B;
				case 13:
					num = (short)852361227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_366;
				case 15:
					goto IL_147;
				case 16:
					if (bool.Parse(values[2].ToString()))
					{
						num = (short)73072653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FE;
				case 17:
					num = (short)1669988355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6C:
				num = (short)992777255;
				short num3 = num;
				num = (short)2033095719;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_366:
					num = (short)1603534850;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)939917313;
					if (num != 0)
					{
					}
					num = (short)1967521792;
					if (num != 0)
					{
					}
					if (values[0] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						goto IL_36B;
					}
					num = (short)1837563913;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_147:
			num = (short)765919232;
			short num4 = num;
			return false;
			IL_1FE:
			return bool.Parse(values[3].ToString());
			IL_258:
			return bool.Parse(values[3].ToString());
			IL_36B:
			return true;
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x001D48B4 File Offset: 0x001D2AB4
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)783263064;
			short num2 = num;
			num = (short)530425176;
			switch (num2 == num)
			{
			default:
			{
				num = (short)415039488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1889206273;
			if (num != 0)
			{
			}
			num = (short)508887040;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
