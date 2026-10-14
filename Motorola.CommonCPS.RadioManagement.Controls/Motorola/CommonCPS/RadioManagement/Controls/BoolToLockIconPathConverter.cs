using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200000F RID: 15
	internal class BoolToLockIconPathConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00003A7C File Offset: 0x00001C7C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 14;
			short num = (short)750911500;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				bool flag2;
				switch (num2)
				{
				case 0:
				{
					num = (short)1746109365;
					short num3 = num;
					num = (short)780829621;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B3;
					default:
						num = (short)1682898944;
						if (num != 0)
						{
						}
						goto IL_138;
					}
					break;
				}
				case 1:
					if (flag)
					{
						num = (short)36438021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B6;
				case 2:
					num = (short)500629505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (values.Length == 3)
					{
						num = (short)701104135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_138;
				case 4:
					goto IL_1B3;
				case 5:
					goto IL_225;
				case 6:
				{
					global::System.Windows.Controls.Image image = (global::System.Windows.Controls.Image)values[2];
					num = (short)1682571277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					num = (short)1107623945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (flag2)
					{
						num = (short)1131675650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1368260612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (values[2] is global::System.Windows.Controls.Image)
					{
						num = (short)1288044550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_138;
				case 10:
					goto IL_1D1;
				case 11:
					goto IL_B4;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 13:
				{
					global::System.Windows.Controls.Image image;
					image.Name = (flag2 ? global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쪥잧즩잫\uddaf펱펳펵", a_) : global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("펥욧용쎫춭\udbafﮱ\ud9b3ힵ\udfb7\udfb9", a_));
					num = (short)176816128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_65:
				if (values[0] == global::System.Windows.DependencyProperty.UnsetValue)
				{
					num = (short)839057408;
					short num4 = num;
					num = (short)1943076875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag2 = (bool)values[0];
				flag = (bool)values[1];
				num = (short)1479540739;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_138:
				num = (short)273416200;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B3:
				if (!flag)
				{
					goto IL_31F;
				}
				num = (short)1369964554;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B4:
			num = (short)606011393;
			if (num != 0)
			{
			}
			return null;
			IL_B6:
			return global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("잧즩잫슯펱춳ﾵ\udbb7햹튻", a_)];
			IL_1D1:
			return global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud8a7쾩슫펯\uddb1\udab3", a_)];
			IL_225:
			return global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("잧즩잫펯\uddb1\udab3", a_)];
			IL_31F:
			return global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud8a7쾩슫슯펱춳ﾵ\udbb7햹튻", a_)];
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003DC8 File Offset: 0x00001FC8
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1371144193;
			if (num != 0)
			{
			}
			num = (short)1477614092;
			short num2 = num;
			num = (short)1445632524;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1931476992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1890385920;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
