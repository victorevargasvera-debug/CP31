using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using AcpCommonLib;

namespace ConstraintHelper
{
	// Token: 0x020005F6 RID: 1526
	public class DynamicZoneXamDataPresenterVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600D0E9 RID: 53481 RVA: 0x00C3AC9C File Offset: 0x00C38E9C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1374814229;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag2;
			for (;;)
			{
				bool flag;
				int num5;
				global::System.Windows.Data.IValueConverter valueConverter;
				switch (num2)
				{
				case 0:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1925185541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54D;
				case 1:
					if (bool.Parse(values[1].ToString()))
					{
						num = (short)1643315220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CF;
				case 2:
					goto IL_17E;
				case 3:
					flag = true;
					goto IL_34F;
				case 4:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1774714887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54D;
				case 5:
					num = (short)1125253143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)311099422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)1443204896;
					short num3 = num;
					num = (short)830246688;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_45C;
					default:
						num = (short)2132475904;
						if (num != 0)
						{
						}
						num = (short)1422262272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					goto IL_3A3;
				case 9:
					if (!flag2)
					{
						num = (short)336920602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1111097347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1708720155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CF;
				case 11:
					goto IL_36C;
				case 12:
					num = (short)1587150849;
					if (num != 0)
					{
					}
					num = (short)222953496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					num = (short)1504116736;
					short num4 = num;
					if (!bool.Parse(values[2].ToString()))
					{
						num = (short)232914959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CF;
				}
				case 14:
					goto IL_2AE;
				case 15:
					goto IL_413;
				case 16:
					num = (short)332660746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (values[4] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1606156300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54D;
				case 18:
					num = (short)1986002953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (num5 >= values.Length)
					{
						num = (short)557711368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)679739417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)412680205;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_A0;
					}
					continue;
				case 22:
					flag = (bool)valueConverter.ConvertBack(values[num5], null, null, culture);
					goto IL_34F;
				case 23:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)314376198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54D;
				case 24:
					if ((bool)values[4])
					{
						num = (short)1104543746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num5 = 5;
					num = (short)603127836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (values[num5] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)563347474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AE;
				case 26:
					num = (short)736362518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_45C;
				case 28:
					goto IL_36C;
				case 29:
					goto IL_DC;
				case 30:
					if (values[3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)793313296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54D;
				}
				IL_A0:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)43647005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag2 = false;
				valueConverter = new global::System.Windows.Controls.BooleanToVisibilityConverter();
				num = (short)43188228;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AE:
				num5++;
				num = (short)1347682315;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CF:
				num = (short)1408040977;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34F:
				flag2 = flag;
				num = (short)295829518;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_36C:
				num = (short)1557725203;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45C:
				num = (short)1544028161;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_DC:
			return false;
			IL_17E:
			return false;
			IL_3A3:
			goto IL_54D;
			IL_413:
			return false;
			IL_54D:
			return flag2;
		}

		// Token: 0x0600D0EA RID: 53482 RVA: 0x00C3B1FC File Offset: 0x00C393FC
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1912992965;
			short num2 = num;
			num = (short)1651307717;
			switch (num2 == num)
			{
			}
			num = (short)1172439041;
			if (num != 0)
			{
			}
			num = (short)1094909952;
			short num3 = num;
			num = (short)1085210624;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
