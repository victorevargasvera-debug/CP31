using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200007A RID: 122
	public class RegionToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000172 RID: 370 RVA: 0x000138A8 File Offset: 0x00011AA8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value != null)
			{
				short num = (short)279954641;
				short num2 = num;
				num = (short)352044241;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1001193472;
					if (num != 0)
					{
					}
					num = (short)856817665;
					if (num != 0)
					{
					}
					num = (short)1825767424;
					short num3 = num;
					return ((global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName)value).ToResourceString();
				}
				}
			}
			return string.Empty;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00013968 File Offset: 0x00011B68
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			if (!string.IsNullOrEmpty(value as string))
			{
				num = (short)1946618921;
				short num2 = num;
				num = (short)1821641769;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1306591232;
					if (num != 0)
					{
					}
					num = (short)464257024;
					short num3 = num;
					return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ConvertToRegion(value as string);
				}
				}
			}
			num = (short)876019713;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
