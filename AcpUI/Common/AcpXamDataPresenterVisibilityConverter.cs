using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x0200008B RID: 139
	public class AcpXamDataPresenterVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000610 RID: 1552 RVA: 0x0007C3C4 File Offset: 0x0007A5C4
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1380450307;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag2;
			for (;;)
			{
				global::System.Windows.Data.IValueConverter valueConverter;
				int num3;
				bool flag;
				switch (num2)
				{
				case 0:
					if (!bool.Parse(values[2].ToString()))
					{
						num = (short)131989520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_408;
				case 1:
					flag = (bool)valueConverter.ConvertBack(values[num3], null, null, culture);
					goto IL_48B;
				case 2:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1266614281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A9;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_90;
					}
					continue;
				case 4:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1419771930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A9;
				case 5:
					goto IL_424;
				case 6:
					goto IL_27A;
				case 7:
					goto IL_131;
				case 8:
					flag = true;
					goto IL_48B;
				case 9:
					num = (short)1869414404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)13107217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (values[num3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)755171338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27A;
				case 12:
					if (bool.Parse(values[1].ToString()))
					{
						num = (short)1788215318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_408;
				case 13:
				{
					num = (short)66071703;
					short num4 = num;
					num = (short)183053463;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_131;
					default:
						num = (short)1058865152;
						if (num != 0)
						{
						}
						num = (short)1236860929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1811283987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_408;
				case 15:
					goto IL_424;
				case 16:
					goto IL_31B;
				case 17:
					if (!flag2)
					{
						num = (short)606404621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)898564104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (values[3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)627245063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A9;
				case 19:
					num = (short)1372585996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)978583554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_45B;
				case 22:
					num = (short)1580990464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_CA;
				case 24:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)577765396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A9;
				case 25:
					if (num3 >= values.Length)
					{
						num = (short)651100181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1003749387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					num = (short)1549008914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_90:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)1609105431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag2 = false;
				valueConverter = new global::System.Windows.Controls.BooleanToVisibilityConverter();
				num = (short)1528627200;
				short num5 = num;
				num = (short)260702232;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_131:
				num = (short)670760974;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27A:
				num3++;
				num = (short)183500815;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_408:
				num3 = 4;
				num = (short)981532677;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_424:
				num = (short)376897561;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_48B:
				flag2 = flag;
				num = (short)805765126;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CA:
			return false;
			IL_31B:
			return false;
			IL_45B:
			num = (short)477757441;
			if (num != 0)
			{
			}
			IL_4A9:
			return flag2;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0007C880 File Offset: 0x0007AA80
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)102301697;
			if (num != 0)
			{
			}
			num = (short)686489600;
			short num2 = num;
			num = (short)680993603;
			short num3 = num;
			num = (short)1679237955;
			switch (num3 == num)
			{
			}
			num = (short)1317470208;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
