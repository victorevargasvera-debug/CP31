using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000040 RID: 64
	public class ProductFamilyToInvisibleConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000C2 RID: 194 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::System.Collections.Generic.IEnumerable<string> source = (parameter as string).ToUpper(global::System.Globalization.CultureInfo.CurrentCulture).Split(new char[]
			{
				';'
			});
			string value2 = value.ToString().ToUpper(global::System.Globalization.CultureInfo.CurrentCulture);
			short num;
			if (source.Contains(value2))
			{
				for (;;)
				{
					num = (short)1680608872;
					short num2 = num;
					num = (short)335154792;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_70;
					}
				}
				IL_70:
				num = (short)791674880;
				if (num != 0)
				{
				}
				return global::System.Windows.Visibility.Collapsed;
			}
			num = (short)742653952;
			short num3 = num;
			num = (short)1738604545;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2113256554;
			short num2 = num;
			num = (short)515882090;
			switch (num2 == num)
			{
			}
			num = (short)2035220481;
			if (num != 0)
			{
			}
			num = (short)335216640;
			short num3 = num;
			num = (short)1720975360;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
