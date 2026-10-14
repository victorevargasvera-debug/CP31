using System;
using System.Globalization;
using System.Windows.Data;

namespace SpecialFeatures.POP25BatchProgrammer
{
	// Token: 0x0200009C RID: 156
	public class IntToBusyStateConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000B03 RID: 2819 RVA: 0x000D1624 File Offset: 0x000CF824
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::BusyStates busyStates;
			short num2;
			int num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					busyStates = global::BusyStates.NOT_BUSY;
					num2 = (short)2042167296;
					short num3 = num2;
					num2 = (short)1306263553;
					if (num2 != 0)
					{
					}
					num2 = (short)848297995;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					busyStates = global::BusyStates.BUSY;
					num2 = (short)1801388042;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_5D;
				case 3:
					goto IL_94;
				case 4:
				{
					num2 = (short)647302645;
					short num4 = num2;
					num2 = (short)1442319861;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5D;
					default:
						num2 = (short)93388800;
						if (num2 != 0)
						{
						}
						if (num5 == 3)
						{
							num2 = (short)2073821193;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_236;
					}
					break;
				}
				case 5:
					if (num5 == 2)
					{
						num2 = (short)1249968135;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)861732868;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_122;
				case 7:
					busyStates = global::BusyStates.COMPLETE_NO_ERROR;
					num2 = (short)2073362435;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (num5 == 1)
					{
						num2 = (short)1349844993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1124335621;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					busyStates = global::BusyStates.COMPLETE_WITH_ERROR;
					num2 = (short)1841496070;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_234;
				case 11:
					goto IL_190;
				}
				goto IL_40;
				IL_5D:
				if (num5 == 0)
				{
					num2 = (short)2022244352;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)2124349448;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_94:
			IL_122:
			IL_190:
			IL_234:
			IL_236:
			return busyStates;
			IL_40:
			busyStates = global::BusyStates.NOT_BUSY;
			num5 = (int)value;
			num2 = (short)1434845186;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x000D1870 File Offset: 0x000CFA70
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)33161216;
			short num2 = num;
			num = (short)1837171324;
			short num3 = num;
			num = (short)1932984956;
			switch (num3 == num)
			{
			}
			num = (short)774832128;
			if (num != 0)
			{
			}
			num = (short)1466630145;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
