using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x020001F6 RID: 502
	public class ContactChildTableVisibityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06001871 RID: 6257 RVA: 0x0020D7A8 File Offset: 0x0020B9A8
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2142568451;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_13C;
				case 1:
					if (bool.Parse(values[0].ToString()))
					{
						num = (short)693174272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13E;
				case 2:
					num = (short)330956801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				num = (short)898629632;
				short num3 = num;
				if (values[0] == global::System.Windows.DependencyProperty.UnsetValue)
				{
					goto IL_13E;
				}
				num = (short)2129370240;
				short num4 = num;
				num = (short)1499307136;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_13C;
				default:
					num = (short)1900019713;
					if (num != 0)
					{
					}
					num = (short)1372585984;
					if (num != 0)
					{
					}
					num = (short)1392050178;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_13C:
			return false;
			IL_13E:
			return true;
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0020D8FC File Offset: 0x0020BAFC
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1901760057;
			short num2 = num;
			num = (short)1807978041;
			switch (num2 == num)
			{
			}
			num = (short)1258160129;
			if (num != 0)
			{
			}
			num = (short)1658912768;
			short num3 = num;
			num = (short)1578041344;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
