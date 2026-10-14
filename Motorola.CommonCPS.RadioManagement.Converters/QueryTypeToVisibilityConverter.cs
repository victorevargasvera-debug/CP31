using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000077 RID: 119
	public class QueryTypeToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00013274 File Offset: 0x00011474
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1762131971;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1079050240;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_106;
				case 1:
				{
					num = (short)1817650542;
					short num4 = num;
					num = (short)1793926510;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						goto IL_D5;
					}
					break;
				}
				case 2:
					num = (short)929562624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_15;
				}
				goto IL_5E;
				IL_15:
				switch (0)
				{
				case 0:
					IL_5E:
					if (!(value.ToString() == parameter.ToString()))
					{
						num = (short)3735554;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1151926273;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_D5:
			num = (short)1898971136;
			if (num != 0)
			{
			}
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_131;
			IL_106:
			num = (short)395116545;
			if (num != 0)
			{
			}
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_131:
			return visibility;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000133B8 File Offset: 0x000115B8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)52703213;
			short num2 = num;
			num = (short)370028525;
			switch (num2 == num)
			{
			}
			num = (short)1745223681;
			if (num != 0)
			{
			}
			num = (short)616497152;
			if (num != 0)
			{
			}
			num = (short)1466368000;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
