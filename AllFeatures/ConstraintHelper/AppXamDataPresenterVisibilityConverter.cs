using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using AcpCommonLib;
using AllFeatures;

namespace ConstraintHelper
{
	// Token: 0x020005FD RID: 1533
	public class AppXamDataPresenterVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600D107 RID: 53511 RVA: 0x00C3D1D0 File Offset: 0x00C3B3D0
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 7;
			short num = (short)1298268160;
			switch (num)
			{
			default:
			{
				num = (short)106758165;
				int num2 = (int)((global::System.IntPtr)num);
				bool flag;
				for (;;)
				{
					global::System.Windows.Data.IValueConverter valueConverter;
					int num3;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)359202846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_658;
					case 1:
						if (!flag)
						{
							num = (short)849739781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1155399696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!bool.Parse(values[2].ToString()))
						{
							goto IL_38C;
						}
						goto IL_3A7;
					case 3:
						flag2 = (bool)valueConverter.ConvertBack(values[num3], null, null, culture);
						goto IL_54B;
					case 4:
						if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1400766490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A7;
					case 5:
						num = (short)1525612555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						string text;
						if (text.ToUpper().CompareTo(global::AllFeatures.CodeplugGuid.b("軇诉胋鷍闏", a_)) == 0)
						{
							num = (short)22741010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2026045465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_61B;
					case 8:
						goto IL_3A5;
					case 9:
						goto IL_435;
					case 10:
						goto IL_656;
					case 11:
					{
						num = (short)1620240966;
						short num4 = num;
						num = (short)84142662;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38C;
						default:
						{
							num = (short)1081737216;
							if (num != 0)
							{
							}
							string text;
							flag3 = bool.Parse(text);
							goto IL_5FD;
						}
						}
						break;
					}
					case 12:
						goto IL_119;
					case 13:
						if (values[num3] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1991180322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_435;
					case 14:
						goto IL_61B;
					case 15:
						if (values[3] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1664679953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_658;
					case 16:
						flag3 = true;
						goto IL_5FD;
					case 17:
					{
						num = (short)87490560;
						short num5 = num;
						num = (short)1781596164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_1AD;
					case 19:
						if (num3 >= values.Length)
						{
							num = (short)778764298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)578224141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_435;
					case 21:
						switch (0)
						{
						case 0:
							goto IL_DE;
						}
						continue;
					case 22:
						flag2 = true;
						goto IL_54B;
					case 23:
						num = (short)262864899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1127874595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_658;
					case 25:
						if (!flag)
						{
							num = (short)154271767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)499122198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)1850933249;
						if (num != 0)
						{
						}
						num = (short)1398800412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)597884961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_658;
					case 28:
						if (bool.Parse(values[1].ToString()))
						{
							num = (short)1703968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A7;
					case 29:
					{
						string text;
						if (text.ToUpper().CompareTo(global::AllFeatures.CodeplugGuid.b("鳇飉駋词", a_)) != 0)
						{
							num = (short)2061041695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AD;
					}
					case 30:
						num = (short)313589787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)1975517190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)450363394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)994836495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						string text = values[num3].ToString();
						num = (short)1617035293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						num = (short)302383104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DE:
					if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
					{
						num = (short)752287756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = false;
					valueConverter = new global::System.Windows.Controls.BooleanToVisibilityConverter();
					num = (short)148045848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AD:
					num = (short)657719297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38C:
					num = (short)719650824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A7:
					num3 = 4;
					num = (short)671678471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_435:
					num3++;
					num = (short)1400111118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54B:
					flag = flag2;
					num = (short)993787913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FD:
					flag = flag3;
					num = (short)1421869076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_61B:
					num = (short)1859452947;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_119:
				return false;
				IL_3A5:
				return false;
				IL_656:
				IL_658:
				return flag;
			}
			}
		}

		// Token: 0x0600D108 RID: 53512 RVA: 0x00C3D83C File Offset: 0x00C3BA3C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1762657805;
			short num2 = num;
			num = (short)172492301;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1383464960;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1773666305;
			if (num != 0)
			{
			}
			num = (short)1387397120;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
