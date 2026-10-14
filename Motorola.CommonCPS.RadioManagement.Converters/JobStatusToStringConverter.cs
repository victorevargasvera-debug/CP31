using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000031 RID: 49
	public class JobStatusToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00008D78 File Offset: 0x00006F78
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1761922887;
			short num2 = num;
			num = (short)237096775;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1278935041;
				if (num != 0)
				{
				}
				num = (short)1275985920;
				if (num != 0)
				{
				}
				num = (short)943849472;
				short num3 = num;
				if (value != null)
				{
					return ((global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus)value).ToResourceString();
				}
				break;
			}
			}
			return string.Empty;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00008E38 File Offset: 0x00007038
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1953297937;
			short num2 = num;
			num = (short)1075443217;
			global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)578617345;
				if (num != 0)
				{
				}
				num = (short)1091371008;
				if (num != 0)
				{
				}
				num = (short)1002110976;
				short num3 = num;
				if (!global::System.Enum.TryParse<global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus>(value as string, true, out uijobStatus))
				{
					return string.Empty;
				}
				break;
			}
			}
			return uijobStatus;
		}
	}
}
