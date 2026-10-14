using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200001B RID: 27
	public class RadioIDEntryFormatConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00005A58 File Offset: 0x00003C58
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 14;
			short num;
			for (;;)
			{
				num = (short)330694656;
				short num2 = num;
				if (value == null)
				{
					break;
				}
				num = (short)1086061901;
				short num3 = num;
				num = (short)311426381;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_70;
				}
			}
			return null;
			IL_70:
			num = (short)1322975233;
			if (num != 0)
			{
			}
			num = (short)122486784;
			if (num != 0)
			{
			}
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("째菺蛼쿾簀", a_), global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.InvariantCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꇸ", a_), global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005B54 File Offset: 0x00003D54
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			for (;;)
			{
				num = (short)1592983552;
				short num2 = num;
				if (value == null)
				{
					break;
				}
				num = (short)1592048200;
				short num3 = num;
				num = (short)468040264;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8C;
				}
			}
			num = (short)1820590081;
			if (num != 0)
			{
			}
			return null;
			IL_8C:
			num = (short)256245760;
			if (num != 0)
			{
			}
			return global::System.Convert.ToInt32(value, global::System.Globalization.CultureInfo.InvariantCulture);
		}
	}
}
