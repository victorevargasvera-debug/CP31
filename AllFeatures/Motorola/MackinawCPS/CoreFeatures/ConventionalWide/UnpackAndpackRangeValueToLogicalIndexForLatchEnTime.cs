using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000549 RID: 1353
	public sealed class UnpackAndpackRangeValueToLogicalIndexForLatchEnTime : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600B533 RID: 46387 RVA: 0x00A7F578 File Offset: 0x00A7D778
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1108803584;
			short num2 = num;
			num = (short)667712949;
			short num3 = num;
			num = (short)1786543541;
			switch (num3 == num)
			{
			}
			num = (short)937885697;
			if (num != 0)
			{
			}
			num = (short)1532035072;
			if (num != 0)
			{
			}
			int num4 = global::System.Convert.ToInt32(value);
			return (0.0 + (double)num4 * 0.5).ToString();
		}

		// Token: 0x0600B534 RID: 46388 RVA: 0x00A7F644 File Offset: 0x00A7D844
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)739508224;
			short num2 = num;
			num = (short)693043201;
			if (num != 0)
			{
			}
			num = (short)1357246225;
			short num3 = num;
			num = (short)1504177937;
			switch (num3 == num)
			{
			}
			num = (short)1879048192;
			if (num != 0)
			{
			}
			string value2 = (string)value;
			double num4 = global::System.Convert.ToDouble(value2);
			int num5 = global::System.Convert.ToInt32(num4 * 100.0);
			if (num5 % 50 == 0)
			{
				if (global::System.Math.Abs(num4 - (double)((float)num5 / 100f)) <= 1E-09)
				{
					return global::System.Convert.ToInt32(global::System.Math.Round((global::System.Convert.ToDouble(value2) - 0.0) / 0.5));
				}
			}
			throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_UIVALUENOTONSTEP);
		}
	}
}
