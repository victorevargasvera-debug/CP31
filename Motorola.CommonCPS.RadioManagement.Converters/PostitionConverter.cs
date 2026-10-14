using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200008B RID: 139
	public class PostitionConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001A5 RID: 421 RVA: 0x00015BE4 File Offset: 0x00013DE4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			if ((int)parameter == 0)
			{
				num = (short)141428369;
				short num2 = num;
				num = (short)622528145;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)591855616;
					if (num != 0)
					{
					}
					return value;
				}
			}
			num = (short)622395392;
			short num3 = num;
			num = (short)910295041;
			if (num != 0)
			{
			}
			return (int)value + 1;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00015CA4 File Offset: 0x00013EA4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)117597739;
			short num2 = num;
			num = (short)893085227;
			switch (num2 == num)
			{
			default:
			{
				num = (short)802422784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1947009024;
			if (num != 0)
			{
			}
			num = (short)1945239553;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
