using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000015 RID: 21
	public class ModeIdentifierToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00004BFC File Offset: 0x00002DFC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2034499584;
			short num2 = num;
			num = (short)1733960552;
			short num3 = num;
			num = (short)1439703912;
			switch (num3 == num)
			{
			}
			num = (short)1936916481;
			if (num != 0)
			{
			}
			num = (short)1225064448;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004CAC File Offset: 0x00002EAC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)946536448;
			short num2 = num;
			num = (short)1661662783;
			short num3 = num;
			num = (short)1962997311;
			switch (num3 == num)
			{
			}
			num = (short)605683712;
			if (num != 0)
			{
			}
			num = (short)341704705;
			if (num != 0)
			{
			}
			return new global::System.NotImplementedException();
		}
	}
}
