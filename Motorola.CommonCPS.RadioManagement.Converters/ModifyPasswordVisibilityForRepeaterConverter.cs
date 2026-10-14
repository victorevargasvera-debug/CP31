using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000035 RID: 53
	public class ModifyPasswordVisibilityForRepeaterConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x000093DC File Offset: 0x000075DC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1902510081;
			if (num != 0)
			{
			}
			num = (short)1832035688;
			short num2 = num;
			num = (short)160081256;
			switch (num2 == num)
			{
			}
			num = (short)798687232;
			short num3 = num;
			num = (short)57212928;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00009490 File Offset: 0x00007690
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1529508012;
			short num2 = num;
			num = (short)660893868;
			switch (num2 == num)
			{
			}
			num = (short)1221525505;
			if (num != 0)
			{
			}
			num = (short)1525874688;
			short num3 = num;
			num = (short)1579941888;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
