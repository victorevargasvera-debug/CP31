using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000C8 RID: 200
	internal class BoolToWidthConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000595 RID: 1429 RVA: 0x000595AC File Offset: 0x000577AC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)350879744;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					goto IL_12F;
				case 2:
					goto IL_E0;
				case 3:
					num = (short)1539637249;
					if (num != 0)
					{
					}
					num = (short)1967915009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				num = (short)1212212858;
				short num3 = num;
				num = (short)1125181050;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)500170752;
					if (num != 0)
					{
					}
					if (!(bool)value)
					{
						num = (short)969211904;
						short num4 = num;
						num = (short)631504899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				num = (short)1489829890;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E0:
			global::System.Windows.GridLength gridLength = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
			goto IL_136;
			IL_12F:
			gridLength = global::System.Windows.GridLength.Auto;
			IL_136:
			return gridLength;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x000596F4 File Offset: 0x000578F4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)49863689;
			short num2 = num;
			num = (short)663477257;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1292238848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1353449472;
			if (num != 0)
			{
			}
			num = (short)1550647297;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
