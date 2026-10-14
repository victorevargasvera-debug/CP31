using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000064 RID: 100
	public class MultiBindingToObjectParamsConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000130 RID: 304 RVA: 0x00010950 File Offset: 0x0000EB50
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1222126532;
			short num2 = num;
			num = (short)264317892;
			switch (num2 == num)
			{
			}
			num = (short)1541406721;
			if (num != 0)
			{
			}
			num = (short)1741357056;
			short num3 = num;
			num = (short)93388800;
			if (num != 0)
			{
			}
			return values.ToList<object>();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00010A04 File Offset: 0x0000EC04
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2108948481;
			if (num != 0)
			{
			}
			num = (short)755661213;
			short num2 = num;
			num = (short)934705565;
			switch (num2 == num)
			{
			}
			num = (short)1277755392;
			short num3 = num;
			num = (short)568852480;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
