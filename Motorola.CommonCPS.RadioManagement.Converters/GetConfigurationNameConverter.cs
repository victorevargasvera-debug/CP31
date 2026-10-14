using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200000E RID: 14
	public class GetConfigurationNameConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00003D4C File Offset: 0x00001F4C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1221394433;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				num = (short)750696385;
				short num3 = num;
				num = (short)1715910593;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1551761409;
					if (num != 0)
					{
					}
					num = (short)225640448;
					if (num != 0)
					{
					}
					num = (short)1704460288;
					short num4 = num;
					switch (num2)
					{
					case 0:
						return text;
					case 1:
						goto IL_15;
					case 2:
						if (text != null)
						{
							num = (short)1271267328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F;
					}
					goto IL_CB;
				}
				}
				IL_15:
				switch (0)
				{
				case 0:
					IL_CB:
					text = values.OfType<string>().FirstOrDefault(new global::System.Func<string, bool>(global::Motorola.CommonCPS.RadioManagement.Converters.GetConfigurationNameConverter.<>c.<>9.a));
					num = (short)431161346;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return text;
			IL_12F:
			return string.Empty;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003E90 File Offset: 0x00002090
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1666580480;
			short num2 = num;
			num = (short)916961946;
			short num3 = num;
			num = (short)523090586;
			switch (num3 == num)
			{
			}
			num = (short)241172481;
			if (num != 0)
			{
			}
			num = (short)1858207744;
			if (num != 0)
			{
			}
			return new object[0];
		}
	}
}
