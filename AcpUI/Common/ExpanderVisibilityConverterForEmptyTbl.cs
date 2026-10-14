using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AcpUI.Common
{
	// Token: 0x02000091 RID: 145
	public class ExpanderVisibilityConverterForEmptyTbl : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000622 RID: 1570 RVA: 0x0007E180 File Offset: 0x0007C380
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)215941120;
			switch (num)
			{
			default:
			{
				num = (short)789381132;
				int num2 = (int)((global::System.IntPtr)num);
				bool flag3;
				for (;;)
				{
					bool flag;
					int num3;
					int num4;
					int num5;
					int num6;
					bool flag2;
					bool flag5;
					switch (num2)
					{
					case 0:
						goto IL_1D7;
					case 1:
						num = (short)5242904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)128450582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_125;
					case 4:
						if (!flag)
						{
							num = (short)78315549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1519058955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_47C;
					case 6:
						num3 = 1;
						num = (short)1558642718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_5DF;
					case 8:
						goto IL_37A;
					case 9:
						if (num4 >= values.Length)
						{
							num = (short)86310919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1934753807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (num5 > num6 * 2)
						{
							num = (short)1235681285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)348127259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						flag2 = true;
						goto IL_41B;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_E3;
						}
						continue;
					case 13:
						goto IL_53C;
					case 14:
						goto IL_5A4;
					case 15:
						if (values[num4] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)901120002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29C;
					case 16:
						goto IL_125;
					case 17:
						if (num3 > num6)
						{
							num = (short)485163009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)540475428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_120;
					case 19:
					{
						bool flag4;
						flag3 = (flag3 || flag4);
						num = (short)1665990687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						flag5 = true;
						goto IL_51D;
					case 21:
						num = (short)155582492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						bool flag4;
						if (bool.TryParse(values[num4].ToString(), out flag4))
						{
							num = (short)1671102483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29C;
					}
					case 23:
					{
						num = (short)204897861;
						short num7 = num;
						num = (short)1390444101;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D7;
						default:
							num = (short)1281818624;
							if (num != 0)
							{
							}
							num = (short)1145372705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 24:
						goto IL_47C;
					case 25:
						if (!flag)
						{
							num = (short)355074071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1249902612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						flag3 = false;
						num4 = num6 * 2 + 1;
						num = (short)782958606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (values[num5] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1405878309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					case 28:
						if (bool.Parse(values[0].ToString()))
						{
							num = (short)2059862022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = num6 + 1;
						num = (short)1221918723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)792657955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_37A;
					case 31:
						goto IL_29C;
					case 32:
						goto IL_5A4;
					case 33:
						flag5 = bool.Parse(values[num5].ToString());
						goto IL_51D;
					case 34:
						goto IL_27A;
					case 35:
						flag2 = bool.Parse(values[num3].ToString());
						goto IL_41B;
					case 36:
						if (values[num3] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1688010752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53C;
					case 37:
						num = (short)2017984537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (flag)
						{
							num = (short)1425080320;
							short num8 = num;
							num = (short)210567194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BC;
					case 39:
						if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)596246549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47C;
					}
					IL_E3:
					if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
					{
						num = (short)971178002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = false;
					num6 = global::System.Convert.ToInt32(parameter);
					num = (short)2138308647;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_125:
					num = (short)1616510986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D7:
					num = (short)1491861508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27A:
					num5++;
					num = (short)942800912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29C:
					num4++;
					num = (short)767688705;
					if (num != 0)
					{
					}
					num = (short)698417184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37A:
					num = (short)364183569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41B:
					flag = flag2;
					num = (short)1751580685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47C:
					num = (short)1050738726;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51D:
					flag = flag5;
					num = (short)1364918306;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53C:
					num3++;
					num = (short)1121779720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A4:
					num = (short)1807810569;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_120:
				return false;
				IL_5DF:
				return flag3;
				IL_6BC:
				return false;
			}
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0007E850 File Offset: 0x0007CA50
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1729691649;
			if (num != 0)
			{
			}
			num = (short)993001472;
			short num2 = num;
			num = (short)146612519;
			short num3 = num;
			num = (short)482615591;
			switch (num3 == num)
			{
			}
			num = (short)775290880;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
