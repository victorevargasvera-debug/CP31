using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200008F RID: 143
	public class BoolToVisibilityInverseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00016364 File Offset: 0x00014564
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1612054529;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_110;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_10D;
				case 3:
					goto IL_128;
				}
				IL_34:
				if (!(bool)value)
				{
					num = (short)556431917;
					short num3 = num;
					num = (short)915831341;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_110;
					case 1:
						break;
					default:
					{
						num = (short)1916665856;
						short num4 = num;
						break;
					}
					}
					num = (short)712376321;
					if (num != 0)
					{
					}
					num = (short)1935802368;
					if (num != 0)
					{
					}
					num = (short)1466302464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1649737730;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_110:
				num = (short)1122304003;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10D:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Collapsed;
			goto IL_12B;
			IL_128:
			visibility = global::System.Windows.Visibility.Visible;
			IL_12B:
			return visibility;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000164A4 File Offset: 0x000146A4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)624312923;
			short num2 = num;
			num = (short)1326596699;
			switch (num2 == num)
			{
			}
			num = (short)1467285504;
			short num3 = num;
			num = (short)1633812480;
			if (num != 0)
			{
			}
			num = (short)1374420993;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
