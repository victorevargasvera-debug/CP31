using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200003D RID: 61
	public class ProductFamilyIdentifierToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x0000A1F8 File Offset: 0x000083F8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1188233217;
			if (num != 0)
			{
			}
			num = (short)1461667681;
			short num2 = num;
			num = (short)1379878753;
			switch (num2 == num)
			{
			}
			num = (short)1886781440;
			short num3 = num;
			num = (short)1115291648;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000A2A8 File Offset: 0x000084A8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1664352257;
			if (num != 0)
			{
			}
			num = (short)379261653;
			short num2 = num;
			num = (short)381752021;
			switch (num2 == num)
			{
			}
			num = (short)837681152;
			short num3 = num;
			num = (short)139329536;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
