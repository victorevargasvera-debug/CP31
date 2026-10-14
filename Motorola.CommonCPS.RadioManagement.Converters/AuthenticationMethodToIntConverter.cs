using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000082 RID: 130
	public class AuthenticationMethodToIntConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00014918 File Offset: 0x00012B18
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)201139848;
			short num2 = num;
			num = (short)1120675464;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1684275200;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1952645121;
			if (num != 0)
			{
			}
			num = (short)1744502784;
			if (num != 0)
			{
			}
			return (int)value;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x000149CC File Offset: 0x00012BCC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1586178417;
			short num2 = num;
			num = (short)1132865905;
			switch (num2 == num)
			{
			default:
			{
				num = (short)487063552;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1956642817;
			if (num != 0)
			{
			}
			num = (short)776601600;
			if (num != 0)
			{
			}
			return (global::Motorola.CommonCPS.RadioManagement.UIModels.AuthenticationMethod)value;
		}
	}
}
