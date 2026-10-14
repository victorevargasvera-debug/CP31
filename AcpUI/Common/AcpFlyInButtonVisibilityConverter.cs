using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace AcpUI.Common
{
	// Token: 0x0200008A RID: 138
	public class AcpFlyInButtonVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x0007C050 File Offset: 0x0007A250
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)980025353;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag;
			for (;;)
			{
				int num3;
				bool flag2;
				switch (num2)
				{
				case 0:
					num = (short)2006188035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_EC;
				case 2:
					if (num3 >= values.Length)
					{
						num = (short)606928897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1465122826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (!flag)
					{
						num = (short)533200903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)395313158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_B4;
				case 5:
					num = (short)1763180545;
					if (num != 0)
					{
					}
					flag2 = bool.Parse(values[num3].ToString());
					goto IL_255;
				case 6:
					flag2 = true;
					goto IL_255;
				case 7:
					num = (short)460849157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_91;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 10:
				{
					if (values[num3] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						goto IL_96;
					}
					num = (short)1999457259;
					short num4 = num;
					num = (short)958024683;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_256;
					default:
					{
						num = (short)670892032;
						if (num != 0)
						{
						}
						num = (short)141819904;
						short num5 = num;
						num = (short)152174592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 11:
					goto IL_96;
				case 12:
					goto IL_B4;
				}
				IL_5A:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)702742536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag = false;
				num3 = 0;
				num = (short)1457061900;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_96:
				num3++;
				num = (short)976945156;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B4:
				num = (short)2034302978;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_256:
				num = (short)951451659;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_255:
				flag = flag2;
				goto IL_256;
			}
			IL_91:
			return global::System.Windows.Visibility.Collapsed;
			IL_EC:
			return ((global::System.Windows.Data.IValueConverter)new global::System.Windows.Controls.BooleanToVisibilityConverter()).Convert(flag, null, null, culture);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0007C300 File Offset: 0x0007A500
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1423045857;
			short num2 = num;
			num = (short)1409217761;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1789329408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1427177473;
			if (num != 0)
			{
			}
			num = (short)895811584;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
