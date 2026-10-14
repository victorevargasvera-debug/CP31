using System;
using System.Globalization;
using System.Windows.Data;

namespace AcpBusinessLayer.ValueConverters
{
	// Token: 0x02000042 RID: 66
	public class DummyConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060004BC RID: 1212 RVA: 0x0006688C File Offset: 0x00064A8C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1337733103;
			short num2 = num;
			num = (short)596127727;
			switch (num2 == num)
			{
			}
			num = (short)1738735616;
			short num3 = num;
			num = (short)1121255424;
			if (num != 0)
			{
			}
			num = (short)835452929;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00066934 File Offset: 0x00064B34
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)40207888;
			short num2 = num;
			num = (short)1838056976;
			switch (num2 == num)
			{
			}
			num = (short)291373056;
			short num3 = num;
			num = (short)364773376;
			if (num != 0)
			{
			}
			num = (short)536674305;
			if (num != 0)
			{
			}
			return value;
		}
	}
}
