using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x0200027A RID: 634
	public sealed class UnpackNonListStringStripBlanksAndpackStringtoUpper : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060070DD RID: 28893 RVA: 0x00646480 File Offset: 0x00644680
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)985497025;
			short num2 = num;
			num = (short)157253057;
			switch (num2 == num)
			{
			}
			num = (short)2030436352;
			if (num != 0)
			{
			}
			num = (short)1523384320;
			short num3 = num;
			num = (short)649003009;
			if (num != 0)
			{
			}
			return global::System.Convert.ToString(value).TrimEnd(global::System.Array.Empty<char>());
		}

		// Token: 0x060070DE RID: 28894 RVA: 0x00646538 File Offset: 0x00644738
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1183361018;
			short num2 = num;
			num = (short)871999482;
			switch (num2 == num)
			{
			}
			num = (short)1178861568;
			if (num != 0)
			{
			}
			num = (short)897122304;
			short num3 = num;
			num = (short)686817281;
			if (num != 0)
			{
			}
			return global::System.Convert.ToString(global::System.Convert.ToString(value).TrimEnd(global::System.Array.Empty<char>())).ToUpper();
		}
	}
}
