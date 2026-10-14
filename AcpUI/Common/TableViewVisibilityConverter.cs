using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AcpUI.Common
{
	// Token: 0x0200008C RID: 140
	public class TableViewVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000613 RID: 1555 RVA: 0x0007C944 File Offset: 0x0007AB44
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)96272395;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag;
			for (;;)
			{
				int num4;
				bool flag2;
				switch (num2)
				{
				case 0:
					num = (short)973144065;
					if (num != 0)
					{
					}
					goto IL_21C;
				case 1:
				{
					if (flag)
					{
						num = (short)1137901577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1776137206;
					short num3 = num;
					num = (short)285389814;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20D;
					default:
						num = (short)638844928;
						if (num != 0)
						{
						}
						num = (short)1172307972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_9D;
				case 3:
					goto IL_9D;
				case 4:
					num = (short)1921449996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (bool.Parse(values[0].ToString()))
					{
						num = (short)536150030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DF;
				case 6:
					goto IL_D4;
				case 7:
					if (num4 >= values.Length)
					{
						num = (short)770703366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1662320653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)1884880897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					flag2 = true;
					goto IL_23C;
				case 10:
					goto IL_98;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 12:
					goto IL_20D;
				case 13:
					if (values[num4] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)654114824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21C;
				case 14:
					num4 = 1;
					num = (short)1840644099;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_61:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)2041839626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag = false;
				num = (short)1404370944;
				short num5 = num;
				num = (short)589627397;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9D:
				num = (short)1455554567;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21C:
				num4++;
				num = (short)1882128386;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_23C:
				flag = flag2;
				num = (short)114884608;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20D:
				flag2 = bool.Parse(values[num4].ToString());
				goto IL_23C;
			}
			IL_98:
			return false;
			IL_D4:
			IL_2DF:
			return flag;
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0007CC38 File Offset: 0x0007AE38
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)754598016;
			short num2 = num;
			num = (short)1597980800;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1659240448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)628490240;
			if (num != 0)
			{
			}
			num = (short)1621360641;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
