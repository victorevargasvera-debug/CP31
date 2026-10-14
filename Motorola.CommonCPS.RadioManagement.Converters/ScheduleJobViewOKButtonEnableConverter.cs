using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000079 RID: 121
	public class ScheduleJobViewOKButtonEnableConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600016F RID: 367 RVA: 0x00013604 File Offset: 0x00011804
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1539440647;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)7405568;
					short num3 = num;
					num = (short)1765641274;
					short num4 = num;
					num = (short)545098810;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					default:
						num = (short)835518464;
						if (num != 0)
						{
						}
						num = (short)1684275205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (values.Length == 2)
					{
						num = (short)2034696192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B3;
				case 2:
					num = (short)2038366209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)349634566;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_9C;
				case 5:
					num = (short)948830209;
					if (num != 0)
					{
					}
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1627914243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B3;
				case 6:
					if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						goto IL_86;
					}
					goto IL_1BA;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				}
				IL_45:
				if (values != null)
				{
					num = (short)1071841282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_86:
				num = (short)1297350660;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9C:
			IL_1B3:
			return true;
			IL_1BA:
			return (bool)values[0] | (bool)values[1];
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000137E4 File Offset: 0x000119E4
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2132803754;
			short num2 = num;
			num = (short)343474346;
			switch (num2 == num)
			{
			}
			num = (short)1938489345;
			if (num != 0)
			{
			}
			num = (short)1797586944;
			if (num != 0)
			{
			}
			num = (short)1704001536;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
