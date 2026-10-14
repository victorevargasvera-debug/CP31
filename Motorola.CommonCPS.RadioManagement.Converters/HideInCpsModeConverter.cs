using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000026 RID: 38
	public class HideInCpsModeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000074 RID: 116 RVA: 0x00007824 File Offset: 0x00005A24
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1957577533;
			short num2 = num;
			num = (short)735068989;
			switch (num2 == num)
			{
			}
			num = (short)1050738688;
			if (num != 0)
			{
			}
			num = (short)186449921;
			if (num != 0)
			{
			}
			num = (short)860422144;
			short num3 = num;
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000078D4 File Offset: 0x00005AD4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1991478192;
			short num2 = num;
			num = (short)1703513008;
			switch (num2 == num)
			{
			}
			num = (short)624623617;
			if (num != 0)
			{
			}
			num = (short)89587712;
			if (num != 0)
			{
			}
			num = (short)1826160640;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
