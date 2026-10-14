using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200002A RID: 42
	public class WiFiEncryptionModeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000080 RID: 128 RVA: 0x00007F88 File Offset: 0x00006188
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)229167627;
			short num2 = num;
			num = (short)1489490443;
			switch (num2 == num)
			{
			}
			num = (short)1558773761;
			if (num != 0)
			{
			}
			num = (short)953614336;
			if (num != 0)
			{
			}
			num = (short)77791232;
			short num3 = num;
			return (int)value;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00008040 File Offset: 0x00006240
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)714370522;
			short num2 = num;
			num = (short)732786138;
			switch (num2 == num)
			{
			}
			num = (short)224854017;
			if (num != 0)
			{
			}
			num = (short)1343619072;
			if (num != 0)
			{
			}
			num = (short)1789919232;
			short num3 = num;
			return (global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiEncryptionMode)value;
		}
	}
}
