using System;
using System.Globalization;
using System.Windows.Data;

namespace AcpBusinessLayer.ValueConverters
{
	// Token: 0x02000048 RID: 72
	public class StringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060004D0 RID: 1232 RVA: 0x00067818 File Offset: 0x00065A18
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)956628992;
			short num2 = num;
			num = (short)11149520;
			short num3 = num;
			num = (short)565649616;
			switch (num3 == num)
			{
			}
			num = (short)158072832;
			if (num != 0)
			{
			}
			num = (short)65339393;
			if (num != 0)
			{
			}
			return ((int)value).ToString();
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000678D0 File Offset: 0x00065AD0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1629945856;
			short num2 = num;
			num = (short)114163713;
			if (num != 0)
			{
			}
			num = (short)1493090838;
			short num3 = num;
			num = (short)565101078;
			switch (num3 == num)
			{
			}
			num = (short)1763704832;
			if (num != 0)
			{
			}
			return int.Parse((string)value);
		}
	}
}
