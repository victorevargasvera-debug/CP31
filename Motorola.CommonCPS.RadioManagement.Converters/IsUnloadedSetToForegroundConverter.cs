using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000085 RID: 133
	public class IsUnloadedSetToForegroundConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00014F10 File Offset: 0x00013110
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			if ((bool)value)
			{
				num = (short)1800187618;
				short num2 = num;
				num = (short)1815719650;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1974927361;
					if (num != 0)
					{
					}
					num = (short)111149056;
					if (num != 0)
					{
					}
					return global::System.Windows.Media.Brushes.Blue;
				}
			}
			num = (short)1143865344;
			short num3 = num;
			return global::System.Windows.Media.Brushes.Black;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00014FD0 File Offset: 0x000131D0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2050490369;
			if (num != 0)
			{
			}
			num = (short)1867382784;
			short num2 = num;
			num = (short)704701905;
			short num3 = num;
			num = (short)460711377;
			switch (num3 == num)
			{
			}
			num = (short)283049984;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
