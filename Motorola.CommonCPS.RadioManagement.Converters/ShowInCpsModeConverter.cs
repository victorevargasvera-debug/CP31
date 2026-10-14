using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000027 RID: 39
	public class ShowInCpsModeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00007998 File Offset: 0x00005B98
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)504533624;
			short num2 = num;
			num = (short)292131448;
			switch (num2 == num)
			{
			}
			num = (short)532938753;
			if (num != 0)
			{
			}
			num = (short)1209729024;
			if (num != 0)
			{
			}
			num = (short)789970944;
			short num3 = num;
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00007A48 File Offset: 0x00005C48
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1879482624;
			short num2 = num;
			num = (short)554868992;
			switch (num2 == num)
			{
			}
			num = (short)1928724481;
			if (num != 0)
			{
			}
			num = (short)360185856;
			if (num != 0)
			{
			}
			num = (short)540868608;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
