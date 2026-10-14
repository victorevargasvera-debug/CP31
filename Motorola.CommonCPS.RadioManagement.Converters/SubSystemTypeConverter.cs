using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000A6 RID: 166
	public class SubSystemTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001F6 RID: 502 RVA: 0x0001AC78 File Offset: 0x00018E78
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2009595905;
			if (num != 0)
			{
			}
			num = (short)1138333827;
			short num2 = num;
			num = (short)1186961539;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1681260544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1644888064;
			if (num != 0)
			{
			}
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?)value).ToResourceString();
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0001AD2C File Offset: 0x00018F2C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1998043411;
			short num2 = num;
			num = (short)1256896787;
			switch (num2 == num)
			{
			}
			num = (short)1887174656;
			short num3 = num;
			num = (short)1019609088;
			if (num != 0)
			{
			}
			num = (short)1845362689;
			if (num != 0)
			{
			}
			return (global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType?)value;
		}
	}
}
