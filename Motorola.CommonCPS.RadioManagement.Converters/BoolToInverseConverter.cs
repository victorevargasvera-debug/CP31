using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200008C RID: 140
	public class BoolToInverseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001A8 RID: 424 RVA: 0x00015D64 File Offset: 0x00013F64
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1700649320;
			short num2 = num;
			num = (short)1055644008;
			switch (num2 == num)
			{
			default:
			{
				num = (short)256638976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)72679425;
			if (num != 0)
			{
			}
			num = (short)1778057216;
			if (num != 0)
			{
			}
			return !(bool)value;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00015E1C File Offset: 0x0001401C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)505937921;
			if (num != 0)
			{
			}
			num = (short)415694848;
			short num2 = num;
			num = (short)1091010186;
			short num3 = num;
			num = (short)992837258;
			switch (num3 == num)
			{
			}
			num = (short)2093613056;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
