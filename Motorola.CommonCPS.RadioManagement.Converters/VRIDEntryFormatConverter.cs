using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000029 RID: 41
	public class VRIDEntryFormatConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00007DAC File Offset: 0x00005FAC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 8;
			short num = (short)468258099;
			short num2 = num;
			num = (short)1046416691;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)215285761;
				if (num != 0)
				{
				}
				num = (short)2046754816;
				if (num != 0)
				{
				}
				num = (short)511115264;
				short num3 = num;
				if (value != null)
				{
					return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("쏲跴賶째蛺", a_), global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.InvariantCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꯲", a_), global::System.Globalization.CultureInfo.InvariantCulture));
				}
				break;
			}
			}
			return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("쏲跴쟶", a_);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007EB0 File Offset: 0x000060B0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1023934465;
			if (num != 0)
			{
			}
			num = (short)1230809159;
			short num2 = num;
			num = (short)2104469575;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)429916160;
				if (num != 0)
				{
				}
				num = (short)1516306432;
				short num3 = num;
				if (value != null)
				{
					return global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				break;
			}
			}
			return 0;
		}
	}
}
