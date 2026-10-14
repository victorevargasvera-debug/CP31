using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence
{
	// Token: 0x02000266 RID: 614
	public sealed class ConvertCoorindates : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06006E0E RID: 28174 RVA: 0x00621DC0 File Offset: 0x0061FFC0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			short num = (short)1828499931;
			short num2 = num;
			num = (short)639742427;
			switch (num2 == num)
			{
			}
			num = (short)143261696;
			if (num != 0)
			{
			}
			num = (short)338558977;
			if (num != 0)
			{
			}
			num = (short)1219166208;
			short num3 = num;
			double num4 = global::System.Convert.ToDouble(value);
			return (global::System.Math.Round(num4, 7) / 10000000.0).ToString(global::AllFeatures.CodeplugGuid.b("꫋留", a_));
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x00621EA0 File Offset: 0x006200A0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1599884944;
			short num2 = num;
			num = (short)1660046992;
			double num5;
			int num4;
			int num6;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D3:
				num = (short)1726414848;
				short num3 = num;
				num4 = (int)global::System.Math.Round(num5 * 10000000.0);
				num = (short)667287552;
				num6 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1509163008;
				if (num != 0)
				{
				}
				num = (short)2146435073;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				break;
			}
			for (;;)
			{
				IL_7D:
				switch (num6)
				{
				case 0:
					goto IL_129;
				case 1:
					if (double.TryParse((string)value, out num5))
					{
						num = (short)1970798594;
						num6 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12B;
				case 2:
					goto IL_D3;
				}
				goto IL_8F;
			}
			IL_129:
			IL_12B:
			return num4;
			IL_8F:
			num5 = 0.0;
			num4 = 0;
			num = (short)350158849;
			num6 = (int)((global::System.IntPtr)num);
			goto IL_7D;
		}
	}
}
