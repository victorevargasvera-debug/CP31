using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace AcpUI.Common
{
	// Token: 0x02000079 RID: 121
	public class BooleanToColorConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060005DA RID: 1498 RVA: 0x0007804C File Offset: 0x0007624C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::System.Windows.Media.Brush result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1107820545;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if ((bool)value)
					{
						num2 = (short)1820000259;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					goto IL_A6;
				case 3:
				{
					num2 = (short)1385970953;
					short num3 = num2;
					num2 = (short)1340488969;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)234422272;
						if (num2 != 0)
						{
						}
						result = global::System.Windows.Media.Brushes.Red;
						num2 = (short)1169817602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
				{
					num2 = (short)1673265152;
					short num4 = num2;
					if (value is bool)
					{
						num2 = (short)1469579264;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_24;
			}
			IL_A6:
			num2 = (short)1929510913;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = global::System.Windows.Media.Brushes.Blue;
			num2 = (short)679870468;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x000781B0 File Offset: 0x000763B0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 3;
			short num = (short)656609995;
			short num2 = num;
			num = (short)1776292555;
			switch (num2 == num)
			{
			default:
			{
				num = (short)173670400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1246822401;
			if (num != 0)
			{
			}
			num = (short)1918566400;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException(global::AcpUI.Common.Utility.c("풘ﺚ캠잢薤즦욨\udfaa趬욮\udcb0쎲\ud9b4튶풸\udeba펼쮾꓀Ꟃ", a_));
		}
	}
}
