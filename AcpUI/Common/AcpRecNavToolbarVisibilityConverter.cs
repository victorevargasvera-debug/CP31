using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace AcpUI.Common
{
	// Token: 0x02000089 RID: 137
	public class AcpRecNavToolbarVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600060A RID: 1546 RVA: 0x0007BB18 File Offset: 0x00079D18
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1557790723;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag2;
			for (;;)
			{
				bool flag;
				int num3;
				switch (num2)
				{
				case 0:
					num = (short)2055143448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)283181063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E2;
				case 2:
					num = (short)972292107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					continue;
				case 4:
					goto IL_254;
				case 5:
					flag = true;
					goto IL_43F;
				case 6:
					goto IL_3FF;
				case 7:
					num = (short)1910177809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_3FF;
				case 9:
					num = (short)1272446989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					flag = bool.Parse(values[num3].ToString());
					goto IL_43F;
				case 11:
					if (!flag2)
					{
						num = (short)312606736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1400373253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_127;
				case 13:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1341521920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E2;
				case 14:
				{
					num = (short)1474822144;
					short num4 = num;
					num = (short)460193793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					num = (short)1478754324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)2059403274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (bool.Parse(values[1].ToString()))
					{
						num = (short)758775823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E2;
				case 18:
					if (values[num3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1911291906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_254;
				case 19:
					goto IL_436;
				case 20:
					if (!bool.Parse(values[2].ToString()))
					{
						num = (short)842792972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_438;
				case 21:
					goto IL_C3;
				case 22:
				{
					num = (short)1122828358;
					short num5 = num;
					num = (short)166658118;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1127284737;
						if (num != 0)
						{
						}
						num = (short)1813577728;
						if (num != 0)
						{
						}
						if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)688783369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E2;
					}
					break;
				}
				case 23:
					if (num3 >= values.Length)
					{
						num = (short)733937683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)825819154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1270153230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E2;
				}
				IL_88:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)195690517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag2 = false;
				num = (short)857341974;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_254:
				num3++;
				num = (short)360054792;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E2:
				num3 = 3;
				num = (short)1984364550;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3FF:
				num = (short)1624506391;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_43F:
				flag2 = flag;
				num = (short)736624644;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C3:
			return false;
			IL_127:
			return false;
			IL_436:
			return flag2;
			IL_438:
			return true;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0007BF88 File Offset: 0x0007A188
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1551174354;
			short num2 = num;
			num = (short)2051607250;
			switch (num2 == num)
			{
			default:
			{
				num = (short)702873600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2124218369;
			if (num != 0)
			{
			}
			num = (short)1297940480;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
