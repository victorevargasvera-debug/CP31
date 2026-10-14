using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200002B RID: 43
	public class WiFiPasswordEnabledConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00008104 File Offset: 0x00006304
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1000204917;
			short num2 = num;
			num = (short)55700085;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1380712448;
				if (num != 0)
				{
				}
				num = (short)246743041;
				if (num != 0)
				{
				}
				num = (short)744292352;
				short num3 = num;
				if ((global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiEncryptionMode)value != global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiEncryptionMode.WiFiEncryptionMode_None)
				{
					return true;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000081C4 File Offset: 0x000063C4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)95929084;
			short num2 = num;
			num = (short)1576452860;
			switch (num2 == num)
			{
			}
			num = (short)1415512064;
			if (num != 0)
			{
			}
			num = (short)1982136321;
			if (num != 0)
			{
			}
			num = (short)1402339328;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
