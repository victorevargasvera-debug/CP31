using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200009E RID: 158
	public class IPAddressDisplayTextConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001DE RID: 478 RVA: 0x00018EBC File Offset: 0x000170BC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 18;
			short num;
			if (value != null)
			{
				num = (short)453115905;
				if (num != 0)
				{
				}
				num = (short)1801911576;
				short num2 = num;
				num = (short)34209048;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1004732416;
					if (num != 0)
					{
					}
					return value.ToString().Replace(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("탼", a_), global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("폼", a_));
				}
			}
			num = (short)298188800;
			short num3 = num;
			return null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00018F9C File Offset: 0x0001719C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2026657559;
			short num2 = num;
			num = (short)894850839;
			switch (num2 == num)
			{
			}
			num = (short)737607681;
			if (num != 0)
			{
			}
			num = (short)1862008832;
			if (num != 0)
			{
			}
			num = (short)2043740160;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
