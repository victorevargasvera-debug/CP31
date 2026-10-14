using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000C9 RID: 201
	internal class DecimalToOctConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000598 RID: 1432 RVA: 0x000597B8 File Offset: 0x000579B8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1514829319;
			short num2 = num;
			num = (short)843740679;
			switch (num2 == num)
			{
			default:
			{
				num = (short)304807936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1825505281;
			if (num != 0)
			{
			}
			num = (short)2018312192;
			if (num != 0)
			{
			}
			return global::System.Convert.ToString(global::System.Convert.ToInt64(value, global::System.Globalization.CultureInfo.CurrentCulture), 8);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x00059874 File Offset: 0x00057A74
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2082668545;
			if (num != 0)
			{
			}
			num = (short)1436942336;
			short num2 = num;
			num = (short)1760093146;
			short num3 = num;
			num = (short)1897456602;
			switch (num3 == num)
			{
			}
			num = (short)810221568;
			if (num != 0)
			{
			}
			long num4 = global::System.Convert.ToInt64((string)value, 8);
			return num4;
		}
	}
}
