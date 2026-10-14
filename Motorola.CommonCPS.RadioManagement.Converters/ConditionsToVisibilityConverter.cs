using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200008D RID: 141
	public class ConditionsToVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060001AB RID: 427 RVA: 0x00015EDC File Offset: 0x000140DC
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1778581510;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_AB;
				case 1:
					goto IL_68;
				case 2:
					num = (short)582680580;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1B7;
				case 4:
					if (values[1] != null)
					{
						num = (short)1035403269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_68;
				case 5:
				{
					num = (short)1277897817;
					short num3 = num;
					num = (short)637217881;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_146;
					default:
						num = (short)609812480;
						if (num != 0)
						{
						}
						num = (short)922812423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 7:
					if (!(bool)values[1])
					{
						goto IL_146;
					}
					num = (short)530579459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_44:
				if ((bool)values[0])
				{
					num = (short)2119892994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_68:
				num = (short)973209600;
				short num4 = num;
				num = (short)472055808;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_146:
				num = (short)480641025;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AB:
			num = (short)1406271489;
			if (num != 0)
			{
			}
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_1BA;
			IL_1B7:
			visibility = global::System.Windows.Visibility.Visible;
			IL_1BA:
			return visibility;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000160A8 File Offset: 0x000142A8
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1439488978;
			short num2 = num;
			num = (short)1804917714;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1641807872;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1353383936;
			if (num != 0)
			{
			}
			num = (short)641728513;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
