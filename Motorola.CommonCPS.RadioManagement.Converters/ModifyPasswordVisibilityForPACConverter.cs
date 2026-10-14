using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000034 RID: 52
	public class ModifyPasswordVisibilityForPACConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600009E RID: 158 RVA: 0x00009234 File Offset: 0x00007434
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 7;
			if (parameter.ToString().Contains(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("돱ꟳꋵ꫷뗹", a_)))
			{
				short num;
				for (;;)
				{
					num = (short)607453185;
					if (num != 0)
					{
					}
					num = (short)1448256329;
					short num2 = num;
					num = (short)1032954697;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_87;
					}
				}
				IL_87:
				num = (short)365363200;
				if (num != 0)
				{
				}
				num = (short)2021916672;
				short num3 = num;
				return global::System.Windows.Visibility.Visible;
			}
			return global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00009318 File Offset: 0x00007518
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1066817424;
			short num2 = num;
			num = (short)1753110416;
			switch (num2 == num)
			{
			}
			num = (short)525860865;
			if (num != 0)
			{
			}
			num = (short)2006319104;
			short num3 = num;
			num = (short)966656000;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
