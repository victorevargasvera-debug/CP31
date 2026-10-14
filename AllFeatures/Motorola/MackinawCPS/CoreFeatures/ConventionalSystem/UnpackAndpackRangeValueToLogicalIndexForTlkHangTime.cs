using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x0200055E RID: 1374
	public sealed class UnpackAndpackRangeValueToLogicalIndexForTlkHangTime : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600B770 RID: 46960 RVA: 0x00AA8378 File Offset: 0x00AA6578
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 17;
			short num = (short)1569124101;
			short num2 = num;
			num = (short)2000744197;
			switch (num2 == num)
			{
			}
			num = (short)1700659200;
			if (num != 0)
			{
			}
			num = (short)519503873;
			if (num != 0)
			{
			}
			num = (short)1144520704;
			short num3 = num;
			int num4 = global::System.Convert.ToInt32(value);
			return (0.0 + (double)num4 * 0.025).ToString(global::AllFeatures.CodeplugGuid.b("듑", a_));
		}

		// Token: 0x0600B771 RID: 46961 RVA: 0x00AA845C File Offset: 0x00AA665C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			for (;;)
			{
				string s = global::System.Convert.ToString(value);
				try
				{
					double.Parse(s);
					goto IL_0C;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.ArgumentException(ex.ToString());
				}
				goto IL_DB;
				IL_0C:
				num = (short)849912248;
				short num2 = num;
				num = (short)2046861752;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_41;
				}
			}
			IL_41:
			num = (short)683278336;
			short num3 = num;
			num = (short)767819776;
			if (num != 0)
			{
			}
			num = (short)382795777;
			if (num != 0)
			{
			}
			double num4 = global::System.Convert.ToDouble(value);
			if (global::System.Convert.ToInt32(num4 * 1000.0) % 25 == 0)
			{
				return (int)(num4 * 1000.0 / 25.0);
			}
			IL_DB:
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_UIVALUEOUTSTEPSIZE);
		}
	}
}
