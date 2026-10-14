using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000071 RID: 113
	public sealed class UnpackAndpackRangeValueToLogicalIndexForMaxSlotSize : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000C70 RID: 3184 RVA: 0x000CE998 File Offset: 0x000CCB98
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2046673998;
			short num2 = num;
			num = (short)449233998;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1127153664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1300824065;
			if (num != 0)
			{
			}
			num = (short)1574109184;
			if (num != 0)
			{
			}
			int num4 = global::System.Convert.ToInt32(value);
			return (37.5 + (double)num4 * 7.5).ToString();
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000CEA64 File Offset: 0x000CCC64
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (global::System.Convert.ToDouble(value) % 7.5 != 0.0)
			{
				short num;
				for (;;)
				{
					num = (short)730212260;
					short num2 = num;
					num = (short)1517168548;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_55;
					}
				}
				IL_55:
				num = (short)908197889;
				if (num != 0)
				{
				}
				num = (short)901578752;
				if (num != 0)
				{
				}
				num = (short)1378287616;
				short num3 = num;
				throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_UIVALUEOUTSTEPSIZE);
			}
			return (int)((global::System.Convert.ToDouble(value) - 37.5) / 7.5);
		}
	}
}
