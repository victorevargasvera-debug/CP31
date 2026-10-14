using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200004B RID: 75
	public class ButtonBarModeToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x0000C528 File Offset: 0x0000A728
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1969422337;
			if (num != 0)
			{
			}
			num = (short)1238916875;
			short num2 = num;
			num = (short)1353277195;
			switch (num2 == num)
			{
			}
			num = (short)220528640;
			short num3 = num;
			num = (short)1487273984;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ButtonBarModeConverter.GetResouce((global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum)value);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000C5DC File Offset: 0x0000A7DC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)140643043;
			short num2 = num;
			num = (short)480709347;
			switch (num2 == num)
			{
			}
			num = (short)1774780417;
			if (num != 0)
			{
			}
			num = (short)846659584;
			short num3 = num;
			num = (short)1797718016;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.ButtonBarModeConverter.GetQueryType(value.ToString());
		}
	}
}
