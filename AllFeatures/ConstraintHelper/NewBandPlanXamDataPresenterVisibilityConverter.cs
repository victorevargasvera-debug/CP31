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
	// Token: 0x020005F4 RID: 1524
	public class NewBandPlanXamDataPresenterVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600D0E3 RID: 53475 RVA: 0x00C3A164 File Offset: 0x00C38364
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 0;
			short num = (short)1060438016;
			switch (num)
			{
			default:
			{
				num = (short)1988362242;
				int num2 = (int)((global::System.IntPtr)num);
				bool flag2;
				for (;;)
				{
					int num4;
					global::System.Windows.Data.IValueConverter valueConverter;
					bool flag;
					switch (num2)
					{
					case 0:
						if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1050083357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_726;
					case 1:
						goto IL_374;
					case 2:
					{
						num = (short)1305149440;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_118;
						}
						continue;
					}
					case 3:
						if (values[num4] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1673789477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_289;
					case 4:
						num = (short)2016280586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if ((global::AcpCommonLib.ApplicationMode)values[0] == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1566965777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B6;
					case 6:
						num = (short)713555996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)100466688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)765788169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						int num5;
						if (num5 != 1)
						{
							goto IL_709;
						}
						goto IL_158;
					}
					case 10:
						if (values[3] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)2006581286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_726;
					case 11:
						num = (short)132710439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_153;
					case 13:
						if (parameter.ToString() == global::AllFeatures.CodeplugGuid.b("迀ꛂ닄", a_))
						{
							num = (short)1793589256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_158;
					case 14:
						goto IL_374;
					case 15:
						if (num4 >= values.Length)
						{
							num = (short)1647837218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1952710659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (values[4] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)749404183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_158;
					case 17:
					{
						num = (short)1231156394;
						short num6 = num;
						num = (short)274199722;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_709;
						default:
							num = (short)285409280;
							if (num != 0)
							{
							}
							num = (short)349700116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 18:
						goto IL_627;
					case 19:
						if (!bool.Parse(values[2].ToString()))
						{
							num = (short)265355282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B6;
					case 20:
						if (bool.Parse(values[1].ToString()))
						{
							num = (short)686555171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B6;
					case 21:
						flag = (bool)valueConverter.ConvertBack(values[num4], null, null, culture);
						goto IL_676;
					case 22:
						if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1846673412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_726;
					case 23:
					{
						int num5 = (int)values[4];
						num = (short)1406992424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_289;
					case 25:
						num = (short)182190101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_721;
					case 27:
						num = (short)1611268129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						int num5;
						if (num5 != 0)
						{
							num = (short)2027946016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_591;
					}
					case 29:
						num = (short)1439498262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (!flag2)
						{
							num = (short)1548615705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1114505252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)357564423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_726;
					case 32:
						goto IL_2E2;
					case 33:
						if (parameter.ToString() == global::AllFeatures.CodeplugGuid.b("軀꿂ꇄ", a_))
						{
							num = (short)802029574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_591;
					case 34:
						goto IL_3B1;
					case 35:
						num = (short)1499987987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1457848321;
						if (num != 0)
						{
						}
						flag = true;
						goto IL_676;
					case 37:
						num = (short)1332805662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)373096453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (parameter != null)
						{
							num = (short)786169883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_158;
					case 40:
					{
						int num5;
						if (num5 != -1)
						{
							num = (short)246939659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_158;
					}
					}
					IL_118:
					if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
					{
						num = (short)72482828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag2 = false;
					valueConverter = new global::System.Windows.Controls.BooleanToVisibilityConverter();
					num = (short)1104216095;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_158:
					num4 = 5;
					num = (short)1303248910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_289:
					num4++;
					num = (short)200015873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_374:
					num = (short)1936064527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B6:
					num = (short)1316421648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_591:
					num = (short)94633997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_676:
					flag2 = flag;
					num = (short)674365464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_709:
					num = (short)1411121178;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_153:
				return false;
				IL_2E2:
				return false;
				IL_3B1:
				goto IL_726;
				IL_627:
				return false;
				IL_721:
				return false;
				IL_726:
				return flag2;
			}
			}
		}

		// Token: 0x0600D0E4 RID: 53476 RVA: 0x00C3A8A0 File Offset: 0x00C38AA0
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)67404029;
			short num2 = num;
			num = (short)364544253;
			switch (num2 == num)
			{
			}
			num = (short)1961164801;
			if (num != 0)
			{
			}
			num = (short)78708736;
			short num3 = num;
			num = (short)288489472;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
