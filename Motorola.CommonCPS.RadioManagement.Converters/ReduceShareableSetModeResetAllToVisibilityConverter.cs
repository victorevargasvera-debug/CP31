using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Global;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200001E RID: 30
	public class ReduceShareableSetModeResetAllToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00006078 File Offset: 0x00004278
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
			short num = (short)1858338816;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			global::System.Windows.Visibility visibility;
			for (;;)
			{
				IL_3B:
				int num3;
				switch (num3)
				{
				case 0:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsReduceShareableSetMode)
					{
						goto IL_F1;
					}
					num = (short)134873093;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1929248769;
					if (num != 0)
					{
					}
					visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)1205731336;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)2075590665;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					visibility = global::System.Windows.Visibility.Visible;
					num = (short)2127888391;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_142;
				case 5:
				{
					bool flag;
					if (flag)
					{
						num = (short)868548611;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)499384326;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_1BC;
				case 7:
					goto IL_124;
				case 8:
					goto IL_1D9;
				case 9:
				{
					bool flag;
					if (flag)
					{
						num = (short)63569921;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					visibility = global::System.Windows.Visibility.Visible;
					num = (short)1881210884;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_69;
			}
			IL_124:
			IL_142:
			IL_1BC:
			IL_1D9:
			return visibility;
			IL_69:
			num = (short)956738424;
			short num4 = num;
			num = (short)1891806072;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F1:
				num = (short)129761282;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_3B;
			}
			default:
			{
				num = (short)366018560;
				if (num != 0)
				{
				}
				visibility = global::System.Windows.Visibility.Collapsed;
				bool flag = parameter.ToString() == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뻫语華韱胳뿵雷껹鏻軽叿朁瀃", a_);
				num = (short)1970470912;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_3B;
			}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000062A0 File Offset: 0x000044A0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)594083840;
			short num2 = num;
			num = (short)1136395061;
			short num3 = num;
			num = (short)1770849077;
			switch (num3 == num)
			{
			}
			num = (short)1028718593;
			if (num != 0)
			{
			}
			num = (short)197001216;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
