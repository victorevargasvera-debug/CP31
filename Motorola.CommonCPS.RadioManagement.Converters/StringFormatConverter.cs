using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000A4 RID: 164
	public class StringFormatConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001F0 RID: 496 RVA: 0x0001A8E0 File Offset: 0x00018AE0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1219297280;
			short num2 = num;
			if (parameter != null)
			{
				num = (short)584999715;
				short num3 = num;
				num = (short)324428579;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)936443905;
					if (num != 0)
					{
					}
					num = (short)14680064;
					if (num != 0)
					{
					}
					break;
				}
				string format = parameter.ToString();
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, value);
			}
			return string.Empty;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0001A9AC File Offset: 0x00018BAC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)941224403;
			short num2 = num;
			num = (short)937357779;
			switch (num2 == num)
			{
			}
			num = (short)103415808;
			short num3 = num;
			num = (short)812908544;
			if (num != 0)
			{
			}
			num = (short)1894252545;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
