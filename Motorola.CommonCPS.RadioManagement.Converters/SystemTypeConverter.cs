using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000A7 RID: 167
	public class SystemTypeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x0001ADF4 File Offset: 0x00018FF4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1169426661;
			short num2 = num;
			num = (short)806422757;
			switch (num2 == num)
			{
			}
			num = (short)907083776;
			short num3 = num;
			num = (short)1135607809;
			if (num != 0)
			{
			}
			num = (short)1951793152;
			if (num != 0)
			{
			}
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?)value).ToResourceString();
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0001AEA8 File Offset: 0x000190A8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)661218560;
			short num2 = num;
			num = (short)812279040;
			switch (num2 == num)
			{
			}
			num = (short)854327296;
			short num3 = num;
			num = (short)712572929;
			if (num != 0)
			{
			}
			num = (short)1268383744;
			if (num != 0)
			{
			}
			return (global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType?)value;
		}
	}
}
