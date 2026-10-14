using System;
using System.Globalization;
using System.Windows.Data;

namespace MackinawCPS
{
	// Token: 0x02000024 RID: 36
	public class POP25BatchSchedulerMenuEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600007C RID: 124 RVA: 0x0000E89C File Offset: 0x0000CA9C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			int num;
			short num2;
			bool flag3;
			for (;;)
			{
				IL_0A:
				bool flag;
				bool flag2;
				switch (num)
				{
				case 0:
					num2 = (short)324403227;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)231997454;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (values[0] is bool)
					{
						num2 = (short)1758527488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_52D;
				case 3:
					flag = false;
					goto IL_446;
				case 4:
					goto IL_528;
				case 5:
					num2 = (short)277610514;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)646447133;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if ((bool)values[0])
					{
						num2 = (short)1646133249;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_383;
				case 8:
					num2 = (short)103284760;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_37E;
				case 10:
					if (values[2] is bool)
					{
						num2 = (short)250609686;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_52D;
				case 11:
					num2 = (short)355467266;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if ((bool)values[2])
					{
						num2 = (short)108527616;
						short num3 = num2;
						num2 = (short)708050967;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_237;
				case 13:
					num2 = (short)1356398599;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if ((bool)values[1])
					{
						num2 = (short)599130117;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_383;
				case 15:
					if ((bool)values[1])
					{
						num2 = (short)471072788;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_237;
				case 16:
					if (values[2] is bool)
					{
						num2 = (short)1497038861;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_254;
				case 17:
				{
					num2 = (short)1917723024;
					short num4 = num2;
					num2 = (short)1863655824;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_528;
					default:
						num2 = (short)743899136;
						if (num2 != 0)
						{
						}
						goto IL_254;
					}
					break;
				}
				case 18:
					flag = (bool)values[2];
					goto IL_446;
				case 19:
					num2 = (short)1745485839;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					num2 = (short)2035810316;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					if ((bool)values[0])
					{
						num2 = (short)2004615187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_237;
				case 22:
					num2 = (short)1571946517;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					num2 = (short)578945052;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					if (values[0] is bool)
					{
						num2 = (short)1425801222;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_254;
				case 25:
					flag2 = false;
					goto IL_33D;
				case 26:
					num2 = (short)1505230864;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					if (values[1] is bool)
					{
						num2 = (short)1707343876;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_52D;
				case 28:
					flag2 = (values[3] == null);
					goto IL_33D;
				case 29:
					if (values[1] is bool)
					{
						num2 = (short)1473839130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_254;
				case 30:
					if (values.Length == 4)
					{
						num2 = (short)1157890059;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_52D;
				case 31:
					if (values.Length == 3)
					{
						num2 = (short)854392840;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_254;
				}
				goto IL_90;
				IL_237:
				num2 = (short)1822359577;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_254:
				num2 = (short)1808072734;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_33D:
				flag3 = flag2;
				num2 = (short)1550581761;
				if (num2 != 0)
				{
				}
				num2 = (short)1142554633;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_383:
				num2 = (short)1140064259;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_446:
				flag3 = flag;
				num2 = (short)798949393;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_528:
				num2 = (short)2010775562;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_37E:
			IL_52D:
			return flag3;
			IL_90:
			flag3 = false;
			num2 = (short)1191051295;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000EDDC File Offset: 0x0000CFDC
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)396168612;
			short num2 = num;
			num = (short)715984292;
			switch (num2 == num)
			{
			}
			num = (short)2139357184;
			if (num != 0)
			{
			}
			num = (short)1617952768;
			short num3 = num;
			num = (short)1467351041;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x04000039 RID: 57
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
