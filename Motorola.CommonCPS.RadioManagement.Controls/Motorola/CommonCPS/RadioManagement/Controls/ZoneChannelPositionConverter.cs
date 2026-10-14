using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200003C RID: 60
	public class ZoneChannelPositionConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x0000C450 File Offset: 0x0000A650
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1089258608;
			short num2 = num;
			num = (short)398640240;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A7;
			case 1:
				break;
			default:
			{
				num = (short)1366097920;
				short num3 = num;
				break;
			}
			}
			num = (short)1213923329;
			if (num != 0)
			{
			}
			num = (short)991166464;
			if (num != 0)
			{
			}
			int num4 = (int)value;
			if (num4 != -1)
			{
				return num4 + 1;
			}
			IL_A7:
			return null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000C510 File Offset: 0x0000A710
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1294139393;
			if (num != 0)
			{
			}
			num = (short)1361429606;
			short num2 = num;
			num = (short)525321318;
			switch (num2 == num)
			{
			default:
			{
				num = (short)356253696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)349634560;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
