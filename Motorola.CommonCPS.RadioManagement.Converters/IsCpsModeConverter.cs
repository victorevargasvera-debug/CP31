using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000011 RID: 17
	public class IsCpsModeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000042D0 File Offset: 0x000024D0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)661127168;
			short num2 = num;
			num = (short)921784213;
			short num3 = num;
			num = (short)2004504469;
			switch (num3 == num)
			{
			}
			num = (short)73465857;
			if (num != 0)
			{
			}
			num = (short)27721728;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004380 File Offset: 0x00002580
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1618280448;
			short num2 = num;
			num = (short)1755783877;
			short num3 = num;
			num = (short)2051089093;
			switch (num3 == num)
			{
			}
			num = (short)903675905;
			if (num != 0)
			{
			}
			num = (short)1206648832;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
