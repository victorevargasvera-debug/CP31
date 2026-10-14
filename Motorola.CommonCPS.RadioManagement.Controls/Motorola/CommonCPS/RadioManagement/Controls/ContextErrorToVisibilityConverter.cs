using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000C6 RID: 198
	internal class ContextErrorToVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600058D RID: 1421 RVA: 0x00058EA8 File Offset: 0x000570A8
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 17;
			short num = (short)1301544960;
			short num2 = num;
			num = (short)113115139;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)548667400;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_1A4;
				case 2:
					if (values[1].ToString().Equals(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("얪쒬슮킰잲킴펶", a_)))
					{
						num = (short)1125449729;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
				case 3:
				{
					num = (short)1325764037;
					short num4 = num;
					num = (short)269258181;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_133;
					default:
						num = (short)155844608;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CA;
						}
						continue;
					}
					break;
				}
				case 4:
					goto IL_1F6;
				case 5:
					num = (short)1924726786;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (!((string)values[0] == string.Empty))
					{
						num = (short)1188691968;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)683081737;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (values[0] == null)
					{
						num = (short)167837700;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2116026374;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1BD;
				case 9:
					goto IL_151;
				}
				IL_CA:
				if (values[1] != null)
				{
					num = (short)190513157;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1C0:
				num = (short)342294535;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_133:
			return global::System.Windows.Visibility.Visible;
			IL_151:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_221;
			IL_1A4:
			goto IL_133;
			IL_1BD:
			visibility = global::System.Windows.Visibility.Visible;
			goto IL_221;
			IL_1F6:
			num = (short)453378049;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Collapsed;
			IL_221:
			return visibility;
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x000590DC File Offset: 0x000572DC
		public object a(object A_0, global::System.Type A_1, object A_2, global::System.Globalization.CultureInfo A_3)
		{
			short num = (short)537788416;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					goto IL_12E;
				case 2:
					goto IL_112;
				case 3:
					num = (short)431554561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				num = (short)633043282;
				short num3 = num;
				num = (short)1916893522;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1253376001;
					if (num != 0)
					{
					}
					num = (short)171900928;
					if (num != 0)
					{
					}
					num = (short)692715520;
					short num4 = num;
					if (!((string)A_0 == string.Empty))
					{
						num = (short)2077884419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				num = (short)543883266;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_112:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_131;
			IL_12E:
			visibility = global::System.Windows.Visibility.Visible;
			IL_131:
			return visibility;
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x00059220 File Offset: 0x00057420
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)289603585;
			if (num != 0)
			{
			}
			num = (short)923467776;
			short num2 = num;
			num = (short)656289392;
			short num3 = num;
			num = (short)254553712;
			switch (num3 == num)
			{
			}
			num = (short)1161494528;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x000592CC File Offset: 0x000574CC
		public object b(object A_0, global::System.Type A_1, object A_2, global::System.Globalization.CultureInfo A_3)
		{
			short num = (short)510963644;
			short num2 = num;
			num = (short)669036476;
			switch (num2 == num)
			{
			default:
			{
				num = (short)198901760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2013986817;
			if (num != 0)
			{
			}
			num = (short)1056505856;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
