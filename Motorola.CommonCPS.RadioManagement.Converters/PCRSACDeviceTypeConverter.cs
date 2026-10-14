using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200003C RID: 60
	public class PCRSACDeviceTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x0000A05C File Offset: 0x0000825C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1750222016;
			short num2 = num;
			num = (short)1605846208;
			switch (num2 == num)
			{
			}
			num = (short)201981953;
			if (num != 0)
			{
			}
			num = (short)929300480;
			short num3 = num;
			num = (short)435814400;
			if (num != 0)
			{
			}
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType)global::System.Enum.Parse(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType), (string)value)).ToResourceString();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000A124 File Offset: 0x00008324
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)158841359;
			short num2 = num;
			num = (short)719305231;
			switch (num2 == num)
			{
			}
			num = (short)1587085313;
			if (num != 0)
			{
			}
			num = (short)108527616;
			short num3 = num;
			num = (short)866451456;
			if (num != 0)
			{
			}
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.SACDeviceType)value).ToString();
		}
	}
}
