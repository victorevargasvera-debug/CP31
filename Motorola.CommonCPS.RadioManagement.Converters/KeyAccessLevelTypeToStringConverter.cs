using System;
using System.Globalization;
using System.Windows.Data;
using ASK.Interface;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000068 RID: 104
	public class KeyAccessLevelTypeToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00011358 File Offset: 0x0000F558
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2020081664;
			short num2 = num;
			num = (short)1178047928;
			short num3 = num;
			num = (short)72521144;
			switch (num3 == num)
			{
			}
			num = (short)175177728;
			if (num != 0)
			{
			}
			num = (short)1517748225;
			if (num != 0)
			{
			}
			return ((global::ASK.Interface.KeyAccessLevelType)value).ToResourceString();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0001140C File Offset: 0x0000F60C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)129433600;
			short num2 = num;
			num = (short)1593996192;
			short num3 = num;
			num = (short)1311077280;
			switch (num3 == num)
			{
			}
			num = (short)1380450305;
			if (num != 0)
			{
			}
			num = (short)1601372160;
			if (num != 0)
			{
			}
			return (global::ASK.Interface.KeyAccessLevelType)value;
		}
	}
}
