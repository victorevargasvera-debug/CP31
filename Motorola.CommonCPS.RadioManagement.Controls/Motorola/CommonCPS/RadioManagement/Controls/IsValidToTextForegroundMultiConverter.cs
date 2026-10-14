using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000015 RID: 21
	internal class IsValidToTextForegroundMultiConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00004F48 File Offset: 0x00003148
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			short num2;
			object result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1169293312;
					short num3 = num2;
					if ((bool)values[1])
					{
						num2 = (short)201064451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 1:
					return result;
				case 2:
					if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num2 = (short)1184694279;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_18B;
				case 4:
					if ((bool)values[0])
					{
						num2 = (short)1219231750;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udc9d튟힡힣캥슫\ud8ad톯\udeb1\uddb3튵", a_)];
					num2 = (short)683540481;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return result;
				case 6:
				{
					num2 = (short)843479639;
					short num4 = num2;
					num2 = (short)1875212887;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18B;
					default:
						num2 = (short)1826160640;
						if (num2 != 0)
						{
						}
						num2 = (short)823132162;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					num2 = (short)2076442625;
					if (num2 != 0)
					{
					}
					num2 = (short)2135818240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_39;
				IL_18B:
				result = new global::System.Windows.Media.SolidColorBrush(global::System.Windows.Media.Colors.Black);
				num2 = (short)407306245;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_39:
			result = global::System.Windows.Application.Current.Resources[global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udc9d튟힡힣캥얩슫\udaad슯\uddb1\ud8b3ힷ좹\ud9bb\ud9bd늿귁뇃ꣅ곇苉ꏋ룍뗏ꃑ", a_)];
			num2 = (short)230293508;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000515C File Offset: 0x0000335C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)608797992;
			short num2 = num;
			num = (short)1921353000;
			switch (num2 == num)
			{
			}
			num = (short)1962213376;
			short num3 = num;
			num = (short)831913985;
			if (num != 0)
			{
			}
			num = (short)435224576;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
