using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200002D RID: 45
	public class MFKColorConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00008408 File Offset: 0x00006608
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 5;
			short num = (short)1634140167;
			int num2 = (int)((global::System.IntPtr)num);
			object result2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (values[0] != null)
					{
						goto IL_23F;
					}
					goto IL_2D5;
				case 1:
					num = (short)1145241603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)179830796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					string text;
					if (text == global::RFResourceRepository.RFResources.ID_EMERGENCY)
					{
						num = (short)411893770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					object result;
					return result;
				}
				case 4:
					num = (short)885325824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)109248525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					string text;
					if (text != null)
					{
						num = (short)409993216;
						short num3 = num;
						num = (short)894959617;
						if (num != 0)
						{
						}
						num = (short)2103705601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					object result;
					return result;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 8:
				{
					result2 = (values[1] as global::System.Windows.Controls.Primitives.ToggleButton).FindResource(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뷯등뿳듵跷軹裻釽滿儁瀃缅搇漉伋䘍式怑甓砕缗缙", a_));
					object result = (values[1] as global::System.Windows.Controls.Primitives.ToggleButton).FindResource(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뷯등뿳듵跷軹裻釽滿儁瀃缅搇漉", a_));
					string text = values[0] as string;
					num = (short)1216413702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					num = (short)1270046306;
					short num4 = num;
					num = (short)2122604130;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_23F;
					default:
						num = (short)1422393344;
						if (num != 0)
						{
						}
						num = (short)528744459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					return result2;
				case 11:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)508231685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D5;
				case 12:
					if (values[1] != null)
					{
						num = (short)1865809929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D5;
				case 13:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)133038088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D5;
				}
				IL_66:
				if (values.Length == 2)
				{
					num = (short)1047658500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2D5;
				IL_23F:
				num = (short)2011430914;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result2;
			IL_2D5:
			return null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000086EC File Offset: 0x000068EC
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)793182209;
			if (num != 0)
			{
			}
			num = (short)1639319399;
			short num2 = num;
			num = (short)200869735;
			switch (num2 == num)
			{
			}
			num = (short)1215758336;
			if (num != 0)
			{
			}
			num = (short)1582891008;
			short num3 = num;
			return null;
		}
	}
}
