using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace SpecialFeatures.DVRSFiles.List
{
	// Token: 0x0200012D RID: 301
	public class DVRSFileParentControlVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000FDE RID: 4062 RVA: 0x00164374 File Offset: 0x00162574
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1035730949;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1589051409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1535770625;
					if (num != 0)
					{
					}
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						goto IL_243;
					}
					goto IL_1E8;
				case 2:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)751501312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_320;
				case 3:
					if (!bool.Parse(values[4].ToString()))
					{
						num = (short)2119565326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_162;
				case 4:
					num = (short)1353515019;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 6:
					if (values[3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1813184516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_320;
				case 7:
					num = (short)1438515203;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)2035417094;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1763049488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)128909313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (values[4] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)2083979274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_320;
				case 12:
					num = (short)1481965581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (bool.Parse(values[2].ToString()))
					{
						num = (short)1047724039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_162;
				case 14:
					goto IL_D5;
				case 15:
				{
					num = (short)1191641088;
					short num3 = num;
					num = (short)1514668034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 16:
					if (bool.Parse(values[1].ToString()))
					{
						num = (short)967442444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E8;
				case 17:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1729953800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_320;
				}
				IL_6D:
				if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
				{
					num = (short)1285226511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_320;
				IL_243:
				num = (short)258211849;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_320:
				num = (short)2031841430;
				short num4 = num;
				num = (short)636645526;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_243;
				default:
					goto IL_355;
				}
			}
			IL_D5:
			return false;
			IL_162:
			return bool.Parse(values[3].ToString());
			IL_1E8:
			return bool.Parse(values[3].ToString());
			IL_355:
			num = (short)657915904;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x001646F4 File Offset: 0x001628F4
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)377245921;
			short num2 = num;
			num = (short)1126977761;
			switch (num2 == num)
			{
			}
			num = (short)688586753;
			if (num != 0)
			{
			}
			num = (short)2127429632;
			short num3 = num;
			num = (short)184418304;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
