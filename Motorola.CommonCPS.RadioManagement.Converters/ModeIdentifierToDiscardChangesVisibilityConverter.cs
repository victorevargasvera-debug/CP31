using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200002E RID: 46
	public class ModeIdentifierToDiscardChangesVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600008C RID: 140 RVA: 0x000087B0 File Offset: 0x000069B0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)469106689;
			if (num != 0)
			{
			}
			num = (short)1281637443;
			short num2 = num;
			num = (short)792411203;
			switch (num2 == num)
			{
			}
			num = (short)452067328;
			if (num != 0)
			{
			}
			num = (short)1505951744;
			short num3 = num;
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00008864 File Offset: 0x00006A64
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1890328626;
			short num2 = num;
			num = (short)2022187058;
			switch (num2 == num)
			{
			}
			num = (short)1831665664;
			if (num != 0)
			{
			}
			num = (short)2142633985;
			if (num != 0)
			{
			}
			num = (short)587268096;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
