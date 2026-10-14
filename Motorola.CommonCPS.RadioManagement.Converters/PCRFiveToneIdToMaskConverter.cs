using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200003B RID: 59
	public class PCRFiveToneIdToMaskConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x00009EC4 File Offset: 0x000080C4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 8;
			short num = (short)1096482817;
			if (num != 0)
			{
			}
			if ((bool)value)
			{
				for (;;)
				{
					num = (short)35413076;
					short num2 = num;
					num = (short)1365072980;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_76;
					}
				}
				IL_76:
				num = (short)306053120;
				if (num != 0)
				{
				}
				num = (short)1226440704;
				short num3 = num;
				return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("췲軴银釸髺迼엾㤀㤂㔄⨆〈䨊‌䤎氐", a_);
			}
			return null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00009F98 File Offset: 0x00008198
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)792795227;
			short num2 = num;
			num = (short)528488539;
			switch (num2 == num)
			{
			}
			num = (short)1765081088;
			if (num != 0)
			{
			}
			num = (short)924909568;
			short num3 = num;
			num = (short)1442512897;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
