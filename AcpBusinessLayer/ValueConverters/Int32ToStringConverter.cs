using System;
using System.Globalization;
using System.Windows.Data;

namespace AcpBusinessLayer.ValueConverters
{
	// Token: 0x02000041 RID: 65
	public class Int32ToStringConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x00066724 File Offset: 0x00064924
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)46737597;
			short num2 = num;
			num = (short)533866685;
			switch (num2 == num)
			{
			}
			num = (short)1030750208;
			short num3 = num;
			num = (short)2104885249;
			if (num != 0)
			{
			}
			num = (short)199491584;
			if (num != 0)
			{
			}
			return value.ToString();
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000667D4 File Offset: 0x000649D4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)771195124;
			short num2 = num;
			num = (short)171475188;
			switch (num2 == num)
			{
			}
			num = (short)2131296256;
			short num3 = num;
			num = (short)250413057;
			if (num != 0)
			{
			}
			num = (short)1954676736;
			if (num != 0)
			{
			}
			return int.Parse((string)value);
		}
	}
}
