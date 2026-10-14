using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ConstraintHelper
{
	// Token: 0x020005FC RID: 1532
	public class ToUpperConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600D104 RID: 53508 RVA: 0x00C3CF20 File Offset: 0x00C3B120
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)846135297;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1719533570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				case 2:
					if (value != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1386610691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13C;
				case 3:
				{
					num = (short)966459392;
					short num3 = num;
					num = (short)1670155841;
					short num4 = num;
					num = (short)1306431041;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
						goto IL_DD;
					}
					break;
				}
				}
				goto IL_36;
				IL_64:
				num = (short)775946240;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_36:
				num = (short)2054619137;
				if (num != 0)
				{
				}
				if (value != null)
				{
					goto IL_64;
				}
				goto IL_13C;
			}
			IL_DD:
			num = (short)1984757760;
			if (num != 0)
			{
			}
			return value.ToString().ToUpper();
			IL_13C:
			return string.Empty;
		}

		// Token: 0x0600D105 RID: 53509 RVA: 0x00C3D070 File Offset: 0x00C3B270
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)728236033;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2020802562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					if (value != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1293680643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_137;
				case 3:
				{
					num = (short)2099310044;
					short num3 = num;
					num = (short)1895820764;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					case 1:
						goto IL_B1;
					}
					goto Block_1;
				}
				}
				goto IL_34;
				IL_3A:
				num = (short)498139136;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34:
				if (value != null)
				{
					goto IL_3A;
				}
				goto IL_137;
			}
			Block_1:
			num = (short)1068564480;
			short num4 = num;
			IL_B1:
			num = (short)501284864;
			if (num != 0)
			{
			}
			num = (short)2137063425;
			if (num != 0)
			{
			}
			return value.ToString().ToUpper();
			IL_137:
			return string.Empty;
		}
	}
}
