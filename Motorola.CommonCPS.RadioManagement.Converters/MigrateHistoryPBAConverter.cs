using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000032 RID: 50
	public class MigrateHistoryPBAConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00008F14 File Offset: 0x00007114
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1389297665;
			if (num != 0)
			{
			}
			num = (short)465542286;
			short num2 = num;
			num = (short)585407630;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1885995008;
				if (num != 0)
				{
				}
				num = (short)1866989568;
				short num3 = num;
				if (!(value is bool))
				{
					return value;
				}
				break;
			}
			}
			return !(bool)value;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00008FD8 File Offset: 0x000071D8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)83556408;
			short num2 = num;
			num = (short)732297272;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1225326593;
				if (num != 0)
				{
				}
				num = (short)939720704;
				if (num != 0)
				{
				}
				num = (short)610009088;
				short num3 = num;
				if (!(value is bool))
				{
					return value;
				}
				break;
			}
			}
			return !(bool)value;
		}
	}
}
