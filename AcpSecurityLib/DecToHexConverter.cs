using System;
using System.Globalization;
using System.Windows.Data;

namespace AcpSecurityLib
{
	// Token: 0x02000004 RID: 4
	public class DecToHexConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000023B0 File Offset: 0x000005B0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 5;
			short num = (short)375914496;
			short num2 = num;
			num = (short)143247328;
			short num3 = num;
			num = (short)1137625056;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2065956864;
				if (num != 0)
				{
				}
				if (value is int)
				{
					num = (short)636157953;
					if (num != 0)
					{
					}
					return ((int)value).ToString(global::AcpSecurityLib.KeyWriteProtectEnabledConverter.b("", a_), global::System.Globalization.CultureInfo.CurrentCulture);
				}
				break;
			}
			return value.ToString();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002498 File Offset: 0x00000698
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			short num = (short)1090650112;
			short num2 = num;
			num = (short)1503723521;
			if (num != 0)
			{
			}
			num = (short)18766732;
			short num3 = num;
			num = (short)2070567820;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1852964864;
				if (num != 0)
				{
				}
				if (value is int)
				{
					return ((int)value).ToString(global::AcpSecurityLib.KeyWriteProtectEnabledConverter.b("ﺹ", a_), global::System.Globalization.CultureInfo.CurrentCulture);
				}
				break;
			}
			return value.ToString();
		}
	}
}
