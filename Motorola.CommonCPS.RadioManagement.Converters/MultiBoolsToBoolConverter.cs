using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000016 RID: 22
	public class MultiBoolsToBoolConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00004D70 File Offset: 0x00002F70
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)319684608;
			short num2 = num;
			num = (short)574160897;
			if (num != 0)
			{
			}
			num = (short)925433469;
			short num3 = num;
			num = (short)846855805;
			switch (num3 == num)
			{
			}
			num = (short)2023096320;
			if (num != 0)
			{
			}
			return values.All(new global::System.Func<object, bool>(global::Motorola.CommonCPS.RadioManagement.Converters.MultiBoolsToBoolConverter.<>c.<>9.a));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004E48 File Offset: 0x00003048
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1085472768;
			short num2 = num;
			num = (short)1086167269;
			short num3 = num;
			num = (short)1756928229;
			switch (num3 == num)
			{
			}
			num = (short)1897857025;
			if (num != 0)
			{
			}
			num = (short)269615104;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
