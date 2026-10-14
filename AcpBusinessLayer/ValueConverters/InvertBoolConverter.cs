using System;
using System.Globalization;
using System.Windows.Data;

namespace AcpBusinessLayer.ValueConverters
{
	// Token: 0x02000047 RID: 71
	public class InvertBoolConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060004CD RID: 1229 RVA: 0x00067694 File Offset: 0x00065894
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)973668352;
			short num2 = num;
			num = (short)480716011;
			short num3 = num;
			num = (short)1695556843;
			switch (num3 == num)
			{
			}
			num = (short)1973420033;
			if (num != 0)
			{
			}
			num = (short)1927938048;
			if (num != 0)
			{
			}
			return !(bool)value;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0006774C File Offset: 0x0006594C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1823473664;
			short num2 = num;
			num = (short)246171490;
			short num3 = num;
			num = (short)1739999074;
			switch (num3 == num)
			{
			}
			num = (short)1316552705;
			if (num != 0)
			{
			}
			num = (short)1746468864;
			if (num != 0)
			{
			}
			return !(bool)value;
		}
	}
}
