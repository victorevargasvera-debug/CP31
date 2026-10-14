using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200000B RID: 11
	public class FontSizeConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000021 RID: 33 RVA: 0x0000333C File Offset: 0x0000153C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1122959360;
			short num2 = num;
			num = (short)352300335;
			short num3 = num;
			num = (short)1572252975;
			switch (num3 == num)
			{
			}
			num = (short)2015297536;
			if (num != 0)
			{
			}
			num = (short)915537921;
			if (num != 0)
			{
			}
			double num4 = global::System.Convert.ToDouble(value);
			int num5 = (int)(num4 * 0.55);
			return num5;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003400 File Offset: 0x00001600
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1270874112;
			short num2 = num;
			num = (short)654639105;
			if (num != 0)
			{
			}
			num = (short)467391029;
			short num3 = num;
			num = (short)1304547893;
			switch (num3 == num)
			{
			}
			num = (short)801177600;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
