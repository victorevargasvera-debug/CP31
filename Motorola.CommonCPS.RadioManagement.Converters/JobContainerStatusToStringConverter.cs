using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000012 RID: 18
	public class JobContainerStatusToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00004444 File Offset: 0x00002644
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)668985283;
			short num2 = num;
			num = (short)1235085251;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1141440513;
				if (num != 0)
				{
				}
				num = (short)1187315712;
				if (num != 0)
				{
				}
				if (value == null)
				{
					return string.Empty;
				}
				break;
			}
			num = (short)148045824;
			short num3 = num;
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus)value).ToResourceString();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004504 File Offset: 0x00002704
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1292991813;
			short num2 = num;
			num = (short)163282245;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1914372096;
				if (num != 0)
				{
				}
				num = (short)836829185;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus jobContainerStatus;
				if (global::System.Enum.TryParse<global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus>(value as string, true, out jobContainerStatus))
				{
					return jobContainerStatus;
				}
				break;
			}
			}
			num = (short)1577451520;
			short num3 = num;
			return string.Empty;
		}
	}
}
