using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200004C RID: 76
	public class CBChannelToEnableConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
			short num;
			for (;;)
			{
				num = (short)1496711168;
				short num2 = num;
				if (!(value as string).Equals(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꿫곭돯뫱뗳룵뛷뿹냻", a_)))
				{
					goto IL_CB;
				}
				num = (short)815267841;
				if (num != 0)
				{
				}
				num = (short)804117916;
				short num3 = num;
				num = (short)1071177116;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_AE;
				}
			}
			IL_AE:
			num = (short)1369047040;
			if (num != 0)
			{
			}
			return false;
			IL_CB:
			return true;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000C788 File Offset: 0x0000A988
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)282113772;
			short num2 = num;
			num = (short)412399340;
			switch (num2 == num)
			{
			}
			num = (short)1039007745;
			if (num != 0)
			{
			}
			num = (short)432209920;
			short num3 = num;
			num = (short)303497216;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
