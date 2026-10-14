using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000CA RID: 202
	internal class DecimalToHexConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600059B RID: 1435 RVA: 0x00059948 File Offset: 0x00057B48
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 18;
			short num = (short)1674240290;
			short num2 = num;
			num = (short)539484450;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1305018368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2141782016;
			if (num != 0)
			{
			}
			num = (short)1019609089;
			if (num != 0)
			{
			}
			return global::System.Convert.ToInt64(value, global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("", a_), global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x00059A1C File Offset: 0x00057C1C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1954266054;
			short num2 = num;
			num = (short)376748998;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1403256832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)20905985;
			if (num != 0)
			{
			}
			num = (short)417988608;
			if (num != 0)
			{
			}
			return long.Parse((string)value, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.CurrentCulture);
		}
	}
}
