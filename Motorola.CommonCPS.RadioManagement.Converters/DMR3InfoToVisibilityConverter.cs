using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000054 RID: 84
	public class DMR3InfoToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000FF RID: 255 RVA: 0x0000E2AC File Offset: 0x0000C4AC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)306233529;
			short num2 = num;
			num = (short)2138489017;
			switch (num2 == num)
			{
			}
			num = (short)818544641;
			if (num != 0)
			{
			}
			num = (short)978583552;
			if (num != 0)
			{
			}
			num = (short)127664128;
			short num3 = num;
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000E35C File Offset: 0x0000C55C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1117216489;
			short num2 = num;
			num = (short)1843617513;
			switch (num2 == num)
			{
			}
			num = (short)768671745;
			if (num != 0)
			{
			}
			num = (short)618070016;
			if (num != 0)
			{
			}
			num = (short)967114752;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
