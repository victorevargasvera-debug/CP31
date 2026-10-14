using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000051 RID: 81
	public class ShowCheckBoxConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060000F6 RID: 246 RVA: 0x0000DB98 File Offset: 0x0000BD98
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)526647300;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)664010752;
					short num3 = num;
					num = (short)414842885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)1364328451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_83;
				case 3:
					if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1978925058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17E;
				case 4:
					num = (short)175833089;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 5:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1779367937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_83;
				}
				goto IL_64;
				IL_6A:
				num = (short)238419968;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_83:
				num = (short)44341577;
				short num4 = num;
				num = (short)1539610953;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6A;
				default:
					goto IL_B8;
				}
				IL_64:
				if (values.Length == 2)
				{
					goto IL_6A;
				}
				goto IL_83;
			}
			IL_B8:
			num = (short)1838874624;
			if (num != 0)
			{
			}
			return false;
			IL_17E:
			return (bool)values[0] & (bool)values[1];
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000DD3C File Offset: 0x0000BF3C
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1545925419;
			short num2 = num;
			num = (short)877261611;
			switch (num2 == num)
			{
			}
			num = (short)423886849;
			if (num != 0)
			{
			}
			num = (short)1735065600;
			if (num != 0)
			{
			}
			num = (short)1801912320;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
