using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AcpUI.Common
{
	// Token: 0x02000090 RID: 144
	public class SRecViewVisibilityConverterForEmptyTbl : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600061F RID: 1567 RVA: 0x0007DAFC File Offset: 0x0007BCFC
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1091108864;
			switch (num)
			{
			default:
			{
				num = (short)2015363079;
				int num2 = (int)((global::System.IntPtr)num);
				bool flag;
				for (;;)
				{
					int num4;
					int num3;
					bool flag2;
					bool flag3;
					int num5;
					switch (num2)
					{
					case 0:
						if (bool.Parse(values[1].ToString()))
						{
							num = (short)372178970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = 2 + num4;
						num = (short)2022309898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1690435597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B0;
					case 2:
						if (!flag)
						{
							num = (short)90767375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)304021512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						flag2 = true;
						goto IL_2B5;
					case 4:
						goto IL_208;
					case 5:
						goto IL_389;
					case 6:
						num = (short)1357774864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_C8;
						}
						continue;
					case 8:
						flag3 = true;
						goto IL_54E;
					case 9:
						num = (short)2026504217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_389;
					case 11:
						goto IL_103;
					case 12:
						goto IL_24E;
					case 13:
						num = (short)707919872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (num5 >= 2 + num4)
						{
							num = (short)1862795292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1931804694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)556662813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (!bool.Parse(values[0].ToString()))
						{
							num = (short)901971985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B0;
					case 17:
						num = (short)576847873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1770782741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (values[num3] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)659488792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D3;
					case 20:
					{
						num = (short)1840840704;
						short num6 = num;
						if (num3 >= 2 + num4 * 2)
						{
							num = (short)1880489985;
							if (num != 0)
							{
							}
							num = (short)1803878427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1735720979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						flag2 = bool.Parse(values[num5].ToString());
						goto IL_2B5;
					case 22:
						if (values[num5] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1683292169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E;
					case 23:
						goto IL_208;
					case 24:
						num = (short)1674444802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (!flag)
						{
							num = (short)672071698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2050818051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num5 = 2;
						num = (short)759889943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_418;
					case 28:
					{
						num = (short)928677580;
						short num7 = num;
						num = (short)273645260;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2A3;
						default:
							num = (short)866385920;
							if (num != 0)
							{
							}
							num = (short)2068774942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 29:
						goto IL_2A3;
					case 30:
						goto IL_527;
					case 31:
						if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1750138886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B0;
					case 32:
						goto IL_2D3;
					}
					IL_C8:
					if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
					{
						num = (short)1248985099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = false;
					num4 = global::System.Convert.ToInt32(parameter);
					num = (short)660013087;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_208:
					num = (short)103153678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24E:
					num5++;
					num = (short)1268645892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B5:
					flag = flag2;
					num = (short)1452539916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D3:
					num3++;
					num = (short)828571653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_389:
					num = (short)1437204500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54E:
					flag = flag3;
					num = (short)1562640416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A3:
					flag3 = bool.Parse(values[num3].ToString());
					goto IL_54E;
				}
				IL_103:
				return false;
				IL_418:
				IL_527:
				IL_5B0:
				return flag;
			}
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0007E0C0 File Offset: 0x0007C2C0
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)755138553;
			short num2 = num;
			num = (short)1584627705;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1168703488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)660865025;
			if (num != 0)
			{
			}
			num = (short)411762688;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
