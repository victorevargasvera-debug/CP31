using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000CC RID: 204
	public class MaxValueToMaxLengthConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060005A1 RID: 1441 RVA: 0x00059D00 File Offset: 0x00057F00
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1214734848;
			short num2 = num;
			num = (short)2122736128;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1115815936;
				if (num != 0)
				{
				}
				num = (short)436338689;
				if (num != 0)
				{
				}
				if (value == global::System.Windows.DependencyProperty.UnsetValue)
				{
					return 0;
				}
				break;
			}
			num = (short)1510277120;
			short num3 = num;
			int value2 = global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.CurrentCulture);
			string text = global::System.Convert.ToString(value2, 2);
			return text.Length;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00059DD8 File Offset: 0x00057FD8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)286320741;
			short num2 = num;
			num = (short)2126702693;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1289814016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)98041857;
			if (num != 0)
			{
			}
			num = (short)126943232;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
