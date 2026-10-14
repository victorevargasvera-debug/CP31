using System;
using System.Globalization;
using System.Windows.Data;
using ASK.Interface;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200006A RID: 106
	public class KeyTypeToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000142 RID: 322 RVA: 0x0001178C File Offset: 0x0000F98C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2060517376;
			short num2 = num;
			num = (short)45572098;
			short num3 = num;
			num = (short)162816002;
			switch (num3 == num)
			{
			}
			num = (short)1074200576;
			if (num != 0)
			{
			}
			num = (short)1848311809;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.KeyTypeAndResouceConverter.GetResouce((global::ASK.Interface.KeyType)value);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00011844 File Offset: 0x0000FA44
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1739653120;
			short num2 = num;
			num = (short)1695725040;
			short num3 = num;
			num = (short)248755696;
			switch (num3 == num)
			{
			}
			num = (short)4325377;
			if (num != 0)
			{
			}
			num = (short)1299775488;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.ConvertorExtensions.Enum2ResourceString.KeyTypeAndResouceConverter.GetKeyType(value as string);
		}
	}
}
