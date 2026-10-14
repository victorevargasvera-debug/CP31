using System;
using System.Globalization;
using System.Windows.Data;

namespace Features.Converters
{
	// Token: 0x02000032 RID: 50
	public sealed class UnpackAndPackAndInvertBooleanField : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00006D7C File Offset: 0x00004F7C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1770782721;
			if (num != 0)
			{
			}
			num = (short)1921354681;
			short num2 = num;
			num = (short)189565881;
			switch (num2 == num)
			{
			}
			num = (short)34471936;
			if (num != 0)
			{
			}
			num = (short)1296826368;
			short num3 = num;
			return !(bool)value;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00006E38 File Offset: 0x00005038
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)997942798;
			short num2 = num;
			num = (short)1482319374;
			switch (num2 == num)
			{
			}
			num = (short)504496128;
			if (num != 0)
			{
			}
			num = (short)633602049;
			if (num != 0)
			{
			}
			num = (short)601948160;
			short num3 = num;
			return !(bool)value;
		}
	}
}
