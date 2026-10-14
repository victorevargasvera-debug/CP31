using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000E5 RID: 229
	internal class ItemsMoverFieldInfoToIconVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000646 RID: 1606 RVA: 0x000648BC File Offset: 0x00062ABC
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1109608597;
			short num2 = num;
			num = (short)237848725;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1878720513;
				if (num != 0)
				{
				}
				num = (short)475594752;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem obj = values[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem;
				global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem listFieldItem = values[1] as global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem;
				if (listFieldItem.Equals(obj))
				{
					num = (short)89128960;
					short num3 = num;
					return global::System.Windows.Visibility.Visible;
				}
				break;
			}
			}
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00064990 File Offset: 0x00062B90
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2126708737;
			if (num != 0)
			{
			}
			num = (short)918579395;
			short num2 = num;
			num = (short)1797220547;
			switch (num2 == num)
			{
			}
			num = (short)315162624;
			short num3 = num;
			num = (short)1720778752;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
