using System;
using System.Globalization;
using System.Windows.Data;
using Common;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000127 RID: 295
	public sealed class EncryptDecryptConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06002E0C RID: 11788 RVA: 0x002D6D78 File Offset: 0x002D4F78
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1848160331;
			short num2 = num;
			num = (short)1893576779;
			switch (num2 == num)
			{
			}
			num = (short)565248000;
			short num3 = num;
			num = (short)1355743232;
			if (num != 0)
			{
			}
			num = (short)1707474945;
			if (num != 0)
			{
			}
			return global::Common.AESCryptoUtil.AESDecryptWithDefKey((string)value);
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x002D6E2C File Offset: 0x002D502C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)249036801;
			if (num != 0)
			{
			}
			num = (short)1140498270;
			short num2 = num;
			num = (short)1378197342;
			switch (num2 == num)
			{
			default:
			{
				num = (short)65536000;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1425145856;
			if (num != 0)
			{
			}
			return global::Common.AESCryptoUtil.AESEncryptWithDefKey((string)value);
		}
	}
}
