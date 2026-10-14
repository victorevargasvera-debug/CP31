using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x0200054A RID: 1354
	public sealed class UnpackDecToHexPackHexToDecStr4 : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600B536 RID: 46390 RVA: 0x00A7F778 File Offset: 0x00A7D978
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			short num = (short)1217593344;
			short num2 = num;
			num = (short)262796127;
			short num3 = num;
			num = (short)1115812703;
			switch (num3 == num)
			{
			}
			num = (short)1395720192;
			if (num != 0)
			{
			}
			num = (short)1072037889;
			if (num != 0)
			{
			}
			return ((int)value).ToString(global::AllFeatures.CodeplugGuid.b("鿆﷈", a_), global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x0600B537 RID: 46391 RVA: 0x00A7F848 File Offset: 0x00A7DA48
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)312672256;
			short num2 = num;
			num = (short)969439035;
			short num3 = num;
			num = (short)21526331;
			switch (num3 == num)
			{
			}
			num = (short)1316814849;
			if (num != 0)
			{
			}
			num = (short)303235072;
			if (num != 0)
			{
			}
			int num4;
			int.TryParse((string)value, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture, out num4);
			return num4;
		}
	}
}
