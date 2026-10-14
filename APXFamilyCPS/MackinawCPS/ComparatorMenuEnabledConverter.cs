using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using DevComponents.WpfRibbon;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x02000022 RID: 34
	public class ComparatorMenuEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000076 RID: 118 RVA: 0x0000E27C File Offset: 0x0000C47C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			bool flag2;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (values.Length == 2)
					{
						goto IL_62;
					}
					goto IL_225;
				case 1:
				{
					global::System.Windows.FrameworkElement frameworkElement = (global::DevComponents.WpfRibbon.PaneItem)values[0];
					bool flag = (bool)values[1];
					if (!(frameworkElement.Name == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꟤鋦鷨鿪苬臮맰鳲飴鋶", a_)))
					{
						flag2 = flag;
						num2 = (short)1558118405;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1672087435;
					short num3 = num2;
					num2 = (short)1566115723;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_62;
					default:
					{
						num2 = (short)39911425;
						if (num2 != 0)
						{
						}
						num2 = (short)547028992;
						short num4 = num2;
						num2 = (short)1486225408;
						if (num2 != 0)
						{
						}
						num2 = (short)2006056962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					flag2 = false;
					num2 = (short)1158414340;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (values[0] != null)
					{
						num2 = (short)757727241;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_225;
				case 4:
					goto IL_93;
				case 5:
					goto IL_1E6;
				case 6:
					if (values[0] is global::DevComponents.WpfRibbon.PaneItem)
					{
						num2 = (short)1314979848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_225;
				case 7:
					num2 = (short)1629356035;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)514457601;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)323092486;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_41;
				IL_62:
				num2 = (short)1589379079;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_93:
			IL_1E6:
			IL_225:
			return flag2;
			IL_41:
			flag2 = false;
			num2 = (short)413728768;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000E4B4 File Offset: 0x0000C6B4
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1646395393;
			if (num != 0)
			{
			}
			num = (short)551045707;
			short num2 = num;
			num = (short)1397508683;
			switch (num2 == num)
			{
			default:
			{
				num = (short)143720448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)202833920;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x04000037 RID: 55
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
