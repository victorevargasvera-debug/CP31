using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000088 RID: 136
	public class IsMismatchAndDelaySyncNeedFixToForegroundConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600019C RID: 412 RVA: 0x000154A4 File Offset: 0x000136A4
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)909574157;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2050293761;
				if (num != 0)
				{
				}
				bool flag2;
				switch (num2)
				{
				case 0:
				{
					bool flag = (bool)values[0];
					num = (short)989331458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					bool flag;
					if (flag)
					{
						goto IL_D2;
					}
					num = (short)1313406990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_AB;
				case 3:
				{
					num = (short)1141345097;
					short num3 = num;
					num = (short)63671113;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D2;
					default:
						goto IL_206;
					}
					break;
				}
				case 4:
					goto IL_2C8;
				case 5:
					goto IL_197;
				case 6:
					goto IL_1D0;
				case 7:
					if (values.Length != 2)
					{
						num = (short)100990982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)282001418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)2049048588;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (values[0] != null)
					{
						num = (short)811270144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB;
				case 10:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)402587656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_228;
				case 11:
					num = (short)1860435975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)2141519876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					bool flag = false;
					num = (short)3670016;
					short num4 = num;
					num = (short)1498480649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 14:
					if (flag2)
					{
						num = (short)1120731141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CD;
				}
				IL_88:
				if (values != null)
				{
					num = (short)1156120587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_AB:
				flag2 = (bool)values[1];
				num = (short)737017857;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D2:
				num = (short)555679747;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_159:
			return string.Empty;
			IL_197:
			return global::System.Windows.Media.Brushes.Red;
			IL_1D0:
			goto IL_159;
			IL_206:
			num = (short)1743454208;
			if (num != 0)
			{
			}
			return global::System.Windows.Media.Brushes.Green;
			IL_228:
			return null;
			IL_2C8:
			goto IL_228;
			IL_2CD:
			return global::System.Windows.Media.Brushes.Black;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00015784 File Offset: 0x00013984
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)587295879;
			short num2 = num;
			num = (short)1749904519;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1208025088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1593638913;
			if (num != 0)
			{
			}
			num = (short)400031744;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
