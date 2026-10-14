using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000006 RID: 6
	public class AndOrToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600000B RID: 11 RVA: 0x000026F0 File Offset: 0x000008F0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)256114688;
			short num2 = num;
			num = (short)252510209;
			if (num != 0)
			{
			}
			if (value != null)
			{
				num = (short)1237804563;
				short num3 = num;
				num = (short)484861459;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1671364608;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningAndORConverter.GetResouce((global::Motorola.CommonCPS.Server.CommonDBConstants.AndOR)value);
				}
			}
			return string.Empty;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000027B4 File Offset: 0x000009B4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1396484825;
			short num2 = num;
			num = (short)545434329;
			switch (num2 == num)
			{
			}
			num = (short)41877505;
			if (num != 0)
			{
			}
			num = (short)436011008;
			if (num != 0)
			{
			}
			num = (short)2056519680;
			short num3 = num;
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.DataMiningAndORConverter.GetAndOR(value.ToString());
		}
	}
}
