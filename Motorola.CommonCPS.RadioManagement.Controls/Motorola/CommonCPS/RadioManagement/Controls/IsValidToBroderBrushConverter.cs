using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200001E RID: 30
	internal class IsValidToBroderBrushConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000072B0 File Offset: 0x000054B0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)268566529;
			if (num != 0)
			{
			}
			if ((bool)value)
			{
				num = (short)100387345;
				short num2 = num;
				num = (short)1847511569;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_30;
				case 1:
					break;
				default:
				{
					num = (short)1834221568;
					short num3 = num;
					break;
				}
				}
				num = (short)1226309632;
				if (num != 0)
				{
				}
				return new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Gray);
			}
			IL_30:
			return new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Red);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00007378 File Offset: 0x00005578
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1112785999;
			short num2 = num;
			num = (short)654558287;
			switch (num2 == num)
			{
			}
			num = (short)1272315905;
			if (num != 0)
			{
			}
			num = (short)1258029056;
			if (num != 0)
			{
			}
			num = (short)279248896;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
