using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x020000A3 RID: 163
	public class ProgressToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001ED RID: 493 RVA: 0x0001A67C File Offset: 0x0001887C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_52;
			}
			short num;
			int num3;
			double num4;
			for (;;)
			{
				IL_0A:
				num = (short)242024448;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (num4 != 0.0)
					{
						goto IL_85;
					}
					goto IL_9E;
				case 1:
					goto IL_B6;
				case 2:
					goto IL_D4;
				case 3:
					num = (short)1107165186;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1382762427;
					short num5 = num;
					num = (short)1900890043;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_85;
					default:
						num = (short)1339162625;
						if (num != 0)
						{
						}
						num = (short)1311178752;
						if (num != 0)
						{
						}
						num = (short)1468465157;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (num4 != 100.0)
					{
						num = (short)897974275;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
				}
				goto IL_52;
				IL_85:
				num = (short)1175650308;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_9E:
				num = (short)2099118081;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_B6:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_18F;
			IL_D4:
			visibility = global::System.Windows.Visibility.Visible;
			IL_18F:
			return visibility;
			IL_52:
			num4 = double.Parse(value.ToString(), global::System.Globalization.CultureInfo.CurrentCulture);
			num = (short)1109327872;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0001A820 File Offset: 0x00018A20
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1377718078;
			short num2 = num;
			num = (short)1518882622;
			switch (num2 == num)
			{
			}
			num = (short)1634467840;
			short num3 = num;
			num = (short)1210843136;
			if (num != 0)
			{
			}
			num = (short)889585665;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
