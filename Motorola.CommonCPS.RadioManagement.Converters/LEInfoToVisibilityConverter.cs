using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000081 RID: 129
	public class LEInfoToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000187 RID: 391 RVA: 0x000147AC File Offset: 0x000129AC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2051012087;
			short num2 = num;
			num = (short)145618423;
			switch (num2 == num)
			{
			default:
			{
				num = (short)948568064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)74579969;
			if (num != 0)
			{
			}
			num = (short)2134900736;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00014858 File Offset: 0x00012A58
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1214179683;
			short num2 = num;
			num = (short)1301735779;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1276444672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)872742913;
			if (num != 0)
			{
			}
			num = (short)483459072;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
