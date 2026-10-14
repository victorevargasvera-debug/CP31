using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;
using CommonResources;

namespace Features.Converters
{
	// Token: 0x02000035 RID: 53
	public sealed class UnpackFactorDblAndPackFactorDblWith10ForCustomRange : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00007390 File Offset: 0x00005590
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)501284864;
			short num2 = num;
			num = (short)440532993;
			if (num != 0)
			{
			}
			num = (short)997164230;
			short num3 = num;
			num = (short)1434617030;
			switch (num3 == num)
			{
			}
			num = (short)870318080;
			if (num != 0)
			{
			}
			return ((double)((int)value) / 10.0).ToString();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00007450 File Offset: 0x00005650
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 4;
			short num = (short)105054208;
			short num2 = num;
			num = (short)853213185;
			if (num != 0)
			{
			}
			num = (short)1525091089;
			short num3 = num;
			num = (short)1374620433;
			switch (num3 == num)
			{
			}
			num = (short)2010841088;
			if (num != 0)
			{
			}
			char c = ' ';
			double num4 = double.Parse(value.ToString());
			if (value.ToString().Contains(global::AllFeatures.CodeplugGuid.b("", a_)))
			{
				c = '.';
			}
			else if (value.ToString().Contains(global::AllFeatures.CodeplugGuid.b("", a_)))
			{
				c = ',';
			}
			string text = value.ToString();
			if (c != ' ')
			{
				int length = text.Substring(text.IndexOf(c) + 1).Length;
				if (length > 1 || length <= 0)
				{
					throw new global::System.ArgumentException(global::CommonResources.AcgResources.ID_UIVALUENOTONSTEP);
				}
			}
			return (int)(num4 * 10.0);
		}
	}
}
