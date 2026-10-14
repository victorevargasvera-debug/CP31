using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x0200055C RID: 1372
	public sealed class UnpackDecToHexPackHexToDec : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600B76A RID: 46954 RVA: 0x00AA8028 File Offset: 0x00AA6228
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 4;
			short num = (short)480597442;
			short num2 = num;
			num = (short)1879332290;
			switch (num2 == num)
			{
			}
			num = (short)1323499521;
			if (num != 0)
			{
			}
			num = (short)2085486592;
			if (num != 0)
			{
			}
			num = (short)296026112;
			short num3 = num;
			return ((int)value).ToString(global::AllFeatures.CodeplugGuid.b("鷄", a_), global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x0600B76B RID: 46955 RVA: 0x00AA80FC File Offset: 0x00AA62FC
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)954251280;
			short num2 = num;
			num = (short)1273804816;
			switch (num2 == num)
			{
			}
			num = (short)41156609;
			if (num != 0)
			{
			}
			num = (short)1745747968;
			if (num != 0)
			{
			}
			num = (short)2064384000;
			short num3 = num;
			int num4;
			int.TryParse((string)value, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture, out num4);
			return num4;
		}
	}
}
