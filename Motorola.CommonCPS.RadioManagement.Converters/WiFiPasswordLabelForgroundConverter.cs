using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200002C RID: 44
	public class WiFiPasswordLabelForgroundConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00008288 File Offset: 0x00006488
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)520768174;
			short num2 = num;
			num = (short)2021608110;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)76087296;
				if (num != 0)
				{
				}
				if ((global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiEncryptionMode)value != global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiEncryptionMode.WiFiEncryptionMode_None)
				{
					return global::System.Windows.Media.Brushes.Black;
				}
				num = (short)1729429504;
				short num3 = num;
				num = (short)1944977409;
				if (num != 0)
				{
				}
				break;
			}
			}
			return global::System.Windows.Media.Brushes.Gray;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00008344 File Offset: 0x00006544
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)808457020;
			short num2 = num;
			num = (short)1503335228;
			switch (num2 == num)
			{
			}
			num = (short)441974785;
			if (num != 0)
			{
			}
			num = (short)2008875008;
			if (num != 0)
			{
			}
			num = (short)854720512;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
