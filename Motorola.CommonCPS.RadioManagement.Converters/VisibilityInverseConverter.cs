using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000AC RID: 172
	public class VisibilityInverseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000208 RID: 520 RVA: 0x0001B7D4 File Offset: 0x000199D4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1893203970;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1533542403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_104;
				case 2:
				{
					num = (short)2112771228;
					short num3 = num;
					num = (short)614945948;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C4;
					default:
						num = (short)155385857;
						if (num != 0)
						{
						}
						num = (short)1168048128;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					}
					break;
				}
				case 3:
					goto IL_11F;
				}
				IL_A5:
				if ((global::System.Windows.Visibility)value != global::System.Windows.Visibility.Collapsed)
				{
					num = (short)1114439680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C4:
				num = (short)1963327488;
				short num4 = num;
				num = (short)783810561;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_104:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_122;
			IL_11F:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_122:
			return visibility;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0001B908 File Offset: 0x00019B08
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)947716097;
			if (num != 0)
			{
			}
			num = (short)2043030717;
			short num2 = num;
			num = (short)1267936445;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1123680256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)956563456;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
