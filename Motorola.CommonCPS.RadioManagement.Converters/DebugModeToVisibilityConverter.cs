using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200000C RID: 12
	public class DebugModeToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00003314 File Offset: 0x00001514
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)443744256;
			short num2 = num;
			num = (short)202019695;
			short num3 = num;
			num = (short)1473221487;
			switch (num3 == num)
			{
			}
			num = (short)453246977;
			if (num != 0)
			{
			}
			num = (short)1191706624;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000033C4 File Offset: 0x000015C4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1410596864;
			short num2 = num;
			num = (short)1014697397;
			short num3 = num;
			num = (short)768085429;
			switch (num3 == num)
			{
			}
			num = (short)542834688;
			if (num != 0)
			{
			}
			num = (short)1187512321;
			if (num != 0)
			{
			}
			return new global::System.NotImplementedException();
		}
	}
}
