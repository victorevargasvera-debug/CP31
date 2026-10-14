using System;
using System.Globalization;
using System.Windows.Data;

namespace Features.Converters
{
	// Token: 0x02000034 RID: 52
	public sealed class UnpackAndPackRangeTextBoxSpinnerFields : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000720C File Offset: 0x0000540C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1956904960;
			short num2 = num;
			num = (short)1130852654;
			short num3 = num;
			num = (short)1941074222;
			switch (num3 == num)
			{
			}
			num = (short)1411383297;
			if (num != 0)
			{
			}
			num = (short)422117376;
			if (num != 0)
			{
			}
			return value.ToString();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000072C0 File Offset: 0x000054C0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)5046272;
			short num2 = num;
			num = (short)737394277;
			short num3 = num;
			num = (short)1295957605;
			switch (num3 == num)
			{
			}
			num = (short)940638208;
			if (num != 0)
			{
			}
			num = (short)166854657;
			if (num != 0)
			{
			}
			return int.Parse(global::System.Convert.ToString(value));
		}
	}
}
