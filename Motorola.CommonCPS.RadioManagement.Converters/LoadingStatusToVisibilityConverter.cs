using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000A2 RID: 162
	public class LoadingStatusToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001EA RID: 490 RVA: 0x0001A1D8 File Offset: 0x000183D8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 14;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				int num;
				short num2;
				string a;
				int num4;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						num2 = (short)256442368;
						short num3 = num2;
						num2 = (short)1375862803;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꫸迺鳼跾甀", a_)))
						{
							num2 = (short)1996554245;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2CE;
					case 2:
						goto IL_208;
					case 3:
						if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꧸髺裼賾搀", a_)))
						{
							num2 = (short)1154220047;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)2067922956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (num4 != 6)
						{
							num2 = (short)1539571721;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)2024603649;
						if (num2 != 0)
						{
						}
						num2 = (short)1334444049;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						num2 = (short)1888550928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (num4 != 1)
						{
							num2 = (short)505413632;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)76480515;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						num2 = (short)720909;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						num2 = (short)990314500;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						num2 = (short)619642882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						goto IL_242;
					case 11:
						goto IL_1A4;
					case 12:
						goto IL_182;
					case 13:
						goto IL_225;
					case 14:
						goto IL_F3;
					case 15:
						num2 = (short)722665482;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 16:
						if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꫸迺鋼迾", a_)))
						{
							num2 = (short)559415316;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2CE;
					case 17:
						if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꫸迺鳼跾甀", a_)))
						{
							num2 = (short)1947926535;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1770520590;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 18:
						goto IL_332;
					case 19:
						if (num4 != 4)
						{
							num2 = (short)568459272;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)181141505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 20:
						num2 = (short)1595277323;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
					IL_2CE:
					num2 = (short)507557788;
					short num5 = num2;
					num2 = (short)2117646236;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_09;
					default:
						num2 = (short)1511587840;
						if (num2 != 0)
						{
						}
						num2 = (short)247267346;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_6D:
				a = (string)parameter;
				num4 = (int)value;
				num2 = (short)478216198;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			IL_F3:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_3C5;
			IL_182:
			global::System.Windows.Visibility visibility2 = global::System.Windows.Visibility.Visible;
			IL_185:
			return visibility2;
			IL_1A4:
			global::System.Windows.Visibility visibility3 = global::System.Windows.Visibility.Collapsed;
			goto IL_371;
			IL_208:
			return global::System.Windows.Visibility.Collapsed;
			IL_225:
			visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_3C5;
			IL_242:
			visibility2 = global::System.Windows.Visibility.Collapsed;
			goto IL_185;
			IL_332:
			visibility3 = global::System.Windows.Visibility.Visible;
			IL_371:
			return visibility3;
			IL_3C5:
			return visibility;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0001A5B8 File Offset: 0x000187B8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)933877548;
			short num2 = num;
			num = (short)1754322732;
			switch (num2 == num)
			{
			}
			num = (short)817758208;
			short num3 = num;
			num = (short)1769865216;
			if (num != 0)
			{
			}
			num = (short)1008599041;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
