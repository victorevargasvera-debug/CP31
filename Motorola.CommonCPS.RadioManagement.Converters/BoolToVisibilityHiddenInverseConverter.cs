using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000049 RID: 73
	public class BoolToVisibilityHiddenInverseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000DD RID: 221 RVA: 0x0000C080 File Offset: 0x0000A280
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)874119168;
			short num2 = num;
			num = (short)63111169;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)1123184071;
					short num4 = num;
					num = (short)49638855;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_C6;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 2:
					num = (short)1865613315;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_120;
				}
				IL_5C:
				if (!(bool)value)
				{
					num = (short)1374355458;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)878772224;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_C6:
			num = (short)998309889;
			if (num != 0)
			{
			}
			num = (short)903413760;
			if (num != 0)
			{
			}
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Hidden;
			goto IL_123;
			IL_120:
			visibility = global::System.Windows.Visibility.Visible;
			IL_123:
			return visibility;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000C1B8 File Offset: 0x0000A3B8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)434713035;
			short num2 = num;
			num = (short)1330196939;
			switch (num2 == num)
			{
			}
			num = (short)1631059969;
			if (num != 0)
			{
			}
			num = (short)1536229376;
			short num3 = num;
			num = (short)801701888;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
