using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000125 RID: 293
	public sealed class ConvertTxPowerLevelValues : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06002E06 RID: 11782 RVA: 0x002D66AC File Offset: 0x002D48AC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 10;
			short num = (short)136007296;
			short num2 = num;
			num = (short)436555392;
			switch (num2 == num)
			{
			}
			num = (short)550764544;
			short num3 = num;
			num = (short)1135411201;
			if (num != 0)
			{
			}
			num = (short)125108224;
			if (num != 0)
			{
			}
			int num4 = (int)value;
			return global::System.Math.Round(global::System.Math.Pow(10.0, (double)num4 * 1.0 / 10000.0) / 1000.0, 2).ToString(global::AllFeatures.CodeplugGuid.b("귊ￌ", a_));
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x002D67B0 File Offset: 0x002D49B0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num3;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					double num2;
					if (double.TryParse((string)value, out num2))
					{
						num3 = (short)998703105;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_BD;
				}
				case 1:
				{
					double num2;
					num4 = (int)global::System.Math.Round(10000.0 * global::System.Math.Log10(num2 * 1000.0));
					num3 = (short)1882456066;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 2:
					goto IL_BD;
				}
				goto IL_1C;
				IL_BD:
				num3 = (short)718644789;
				short num5 = num3;
				num3 = (short)442213941;
				switch ((num5 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_F1;
				}
			}
			IL_F1:
			num3 = (short)186908673;
			if (num3 != 0)
			{
			}
			num3 = (short)1097728000;
			if (num3 != 0)
			{
			}
			return num4;
			IL_1C:
			num4 = 0;
			num3 = (short)1195311104;
			short num6 = num3;
			num3 = (short)81854464;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}
	}
}
