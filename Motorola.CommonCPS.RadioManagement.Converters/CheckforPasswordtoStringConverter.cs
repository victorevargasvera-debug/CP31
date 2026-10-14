using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200004E RID: 78
	public class CheckforPasswordtoStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000ED RID: 237 RVA: 0x0000D1C8 File Offset: 0x0000B3C8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value != null)
			{
				short num = (short)2086117310;
				short num2 = num;
				num = (short)1552588734;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_05;
				case 1:
					break;
				default:
				{
					num = (short)941096960;
					short num3 = num;
					break;
				}
				}
				num = (short)374145025;
				if (num != 0)
				{
				}
				num = (short)1244987392;
				if (num != 0)
				{
				}
				return ((global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy)value).ToResourceString();
			}
			IL_05:
			return string.Empty;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000D288 File Offset: 0x0000B488
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (string.IsNullOrEmpty(value as string))
			{
				short num = (short)153419777;
				if (num != 0)
				{
				}
			}
			else
			{
				short num = (short)597295104;
				short num2 = num;
				num = (short)214945269;
				short num3 = num;
				num = (short)990039541;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1031274496;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ConvertToCheckforPassword(value as string);
				}
			}
			return null;
		}
	}
}
