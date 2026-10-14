using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x0200055D RID: 1373
	public sealed class UnpackFactorAndpackFactorCPTotalPretimeWith25 : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600B76D RID: 46957 RVA: 0x00AA81DC File Offset: 0x00AA63DC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1537998849;
			if (num != 0)
			{
			}
			num = (short)1114279940;
			short num2 = num;
			num = (short)954568708;
			switch (num2 == num)
			{
			}
			num = (short)667746304;
			if (num != 0)
			{
			}
			num = (short)1285685248;
			short num3 = num;
			return global::System.Convert.ToInt32(value) * 25;
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x00AA8290 File Offset: 0x00AA6490
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			while (global::System.Convert.ToInt32(value) % 25 != 0)
			{
				short num = (short)1856929700;
				short num2 = num;
				num = (short)1965588388;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)993263617;
					if (num != 0)
					{
					}
					num = (short)456523776;
					if (num != 0)
					{
					}
					num = (short)349569024;
					short num3 = num;
					throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_UIVALUEOUTSTEPSIZE);
				}
				}
			}
			return global::System.Convert.ToInt32(value) / 25;
		}
	}
}
