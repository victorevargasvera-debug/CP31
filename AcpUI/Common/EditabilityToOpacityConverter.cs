using System;
using System.Globalization;
using System.Windows.Data;

namespace AcpUI.Common
{
	// Token: 0x02000078 RID: 120
	public class EditabilityToOpacityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060005D7 RID: 1495 RVA: 0x00077DF4 File Offset: 0x00075FF4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			double num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1017315329;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (!(bool)value)
					{
						num2 = (short)1133051907;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_166;
				case 2:
					goto IL_AE;
				case 3:
				{
					num2 = (short)1939144705;
					if (num2 != 0)
					{
					}
					num2 = (short)1519877397;
					short num3 = num2;
					num2 = (short)984120597;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1365377024;
						if (num2 != 0)
						{
						}
						num4 = 0.25;
						num2 = (short)604897282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
				{
					num2 = (short)176685056;
					short num5 = num2;
					if (value is bool)
					{
						num2 = (short)1488322560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_166;
				}
				}
				goto IL_24;
			}
			IL_AE:
			IL_166:
			return num4;
			IL_24:
			num4 = 1.0;
			num2 = (short)2084110340;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00077F70 File Offset: 0x00076170
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 2;
			short num = (short)1715719419;
			short num2 = num;
			num = (short)1131138299;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1707081728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1531248641;
			if (num != 0)
			{
			}
			num = (short)1328873472;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException(global::AcpUI.Common.Utility.c("햗ﾙ쾟욡蒣좥잧\udea9貫잭\uddaf슱\ud8b3펵햷\udfb9튻쪽ꖿꛁ", a_));
		}
	}
}
