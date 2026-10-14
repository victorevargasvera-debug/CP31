using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200003A RID: 58
	public class PasswordVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00009D54 File Offset: 0x00007F54
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)909592863;
			short num2 = num;
			num = (short)154880287;
			switch (num2 == num)
			{
			}
			num = (short)959184896;
			if (num != 0)
			{
			}
			num = (short)1922695168;
			short num3 = num;
			num = (short)1047265281;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00009E00 File Offset: 0x00008000
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)502792193;
			if (num != 0)
			{
			}
			num = (short)807203548;
			short num2 = num;
			num = (short)1441133276;
			switch (num2 == num)
			{
			}
			num = (short)676855808;
			short num3 = num;
			num = (short)949420032;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
