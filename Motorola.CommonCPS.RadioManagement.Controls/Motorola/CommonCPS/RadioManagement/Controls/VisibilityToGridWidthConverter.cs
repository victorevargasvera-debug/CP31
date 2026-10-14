using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000037 RID: 55
	internal class VisibilityToGridWidthConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x0000B9BC File Offset: 0x00009BBC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_13A;
				case 1:
					goto IL_E8;
				case 2:
				{
					global::System.Windows.Visibility visibility;
					if (visibility != global::System.Windows.Visibility.Visible)
					{
						num2 = (short)37683203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)641073153;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)754319360;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_E8:
			num2 = (short)1868693505;
			if (num2 != 0)
			{
			}
			global::System.Windows.GridLength gridLength = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
			goto IL_14A;
			IL_20:
			num2 = (short)1293696613;
			short num3 = num2;
			num2 = (short)1954758245;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_13A:
				gridLength = new global::System.Windows.GridLength(0.0);
				break;
			default:
			{
				num2 = (short)1600847872;
				short num4 = num2;
				num2 = (short)1095237632;
				if (num2 != 0)
				{
				}
				global::System.Windows.Visibility visibility = (global::System.Windows.Visibility)value;
				num2 = (short)1060241410;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			IL_14A:
			return gridLength;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000BB18 File Offset: 0x00009D18
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1451331132;
			short num2 = num;
			num = (short)593530428;
			switch (num2 == num)
			{
			}
			num = (short)322699264;
			short num3 = num;
			num = (short)1800011777;
			if (num != 0)
			{
			}
			num = (short)1699020800;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
