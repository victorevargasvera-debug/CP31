using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x0200003E RID: 62
	public sealed class UnpackDecToHexPackHexToDecStr2 : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x0002B260 File Offset: 0x00029460
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 13;
			short num = (short)1023016961;
			if (num != 0)
			{
			}
			num = (short)1966546230;
			short num2 = num;
			num = (short)1192697142;
			switch (num2 == num)
			{
			}
			num = (short)602603520;
			if (num != 0)
			{
			}
			num = (short)1965424640;
			short num3 = num;
			return ((int)value).ToString(global::AllFeatures.CodeplugGuid.b("雍", a_), global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0002B338 File Offset: 0x00029538
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)647709442;
			short num2 = num;
			num = (short)1958036226;
			switch (num2 == num)
			{
			}
			num = (short)633536513;
			if (num != 0)
			{
			}
			num = (short)211484672;
			if (num != 0)
			{
			}
			num = (short)736296960;
			short num3 = num;
			int num4;
			int.TryParse((string)value, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture, out num4);
			return num4;
		}
	}
}
