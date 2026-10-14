using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000A5 RID: 165
	public class StringValueToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x0001AA70 File Offset: 0x00018C70
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)120586241;
			if (num != 0)
			{
			}
			num = (short)1760296962;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1760231424;
					short num3 = num;
					num = (short)98697217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_BA;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 3:
				{
					num = (short)1733901208;
					short num4 = num;
					num = (short)639646616;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BA;
					default:
						goto IL_114;
					}
					break;
				}
				}
				IL_5C:
				if (value != null)
				{
					num = (short)1480523776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_BA:
				if (!string.IsNullOrEmpty(value.ToString()))
				{
					goto IL_12E;
				}
				num = (short)1799618563;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9E:
			return global::System.Windows.Visibility.Collapsed;
			IL_114:
			num = (short)641597440;
			if (num != 0)
			{
			}
			goto IL_9E;
			IL_12E:
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0001ABB4 File Offset: 0x00018DB4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)732096654;
			short num2 = num;
			num = (short)2045044878;
			switch (num2 == num)
			{
			}
			num = (short)2052784128;
			short num3 = num;
			num = (short)1714225153;
			if (num != 0)
			{
			}
			num = (short)663945216;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
