using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000A1 RID: 161
	public class RadioStatusToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x0001A060 File Offset: 0x00018260
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)825477640;
			short num2 = num;
			num = (short)1394395656;
			switch (num2 == num)
			{
			default:
			{
				num = (short)936837120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1675558913;
			if (num != 0)
			{
			}
			num = (short)1893597184;
			if (num != 0)
			{
			}
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)value).ToResourceString();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0001A114 File Offset: 0x00018314
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)813229398;
			short num2 = num;
			num = (short)99280214;
			switch (num2 == num)
			{
			default:
			{
				num = (short)968818688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)910622721;
			if (num != 0)
			{
			}
			num = (short)633339904;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
