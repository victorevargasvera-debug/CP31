using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000AB RID: 171
	public class VisibilityByRecordCountConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000205 RID: 517 RVA: 0x0001B494 File Offset: 0x00019694
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			string a;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꟪賬跮铰鿲", a_)))
					{
						num2 = (short)388956168;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)48103430;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_84;
				case 2:
					if (value != null)
					{
						num2 = (short)1171324932;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21F;
				case 3:
					goto IL_194;
				case 4:
					num2 = (short)618725383;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_151;
				case 6:
				{
					num2 = (short)925639219;
					short num3 = num2;
					num2 = (short)1316889139;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					default:
						goto IL_11E;
					}
					break;
				}
				case 7:
					if ((int)value > 0)
					{
						num2 = (short)669974529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21F;
				case 8:
					num2 = (short)1895301125;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1223950347;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (!(a != global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꟪賬跮铰鿲", a_)))
					{
						num2 = (short)701235209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2104295425;
					if (num2 != 0)
					{
					}
					num2 = (short)1467023363;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_216;
				}
				goto IL_49;
				IL_84:
				num2 = (short)14680074;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_21F:
				num2 = (short)679149568;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_11E:
			num2 = (short)1015283712;
			if (num2 != 0)
			{
			}
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_26B;
			IL_151:
			visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_26B;
			IL_194:
			num2 = (short)862453760;
			short num4 = num2;
			global::System.Windows.Visibility visibility2 = global::System.Windows.Visibility.Visible;
			goto IL_219;
			IL_216:
			visibility2 = global::System.Windows.Visibility.Collapsed;
			IL_219:
			return visibility2;
			IL_26B:
			return visibility;
			IL_49:
			a = (string)parameter;
			num2 = (short)152109058;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0001B714 File Offset: 0x00019914
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1579417601;
			if (num != 0)
			{
			}
			num = (short)1592642248;
			short num2 = num;
			num = (short)2015873736;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1401683968;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)876478464;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
