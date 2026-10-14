using System;
using System.Globalization;
using System.Linq;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200000C RID: 12
	internal class AndOperationConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000024 RID: 36 RVA: 0x000034C0 File Offset: 0x000016C0
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)738721792;
			short num2 = num;
			num = (short)2077229057;
			if (num != 0)
			{
			}
			num = (short)2030607448;
			short num3 = num;
			num = (short)771464280;
			switch (num3 == num)
			{
			}
			num = (short)280035328;
			if (num != 0)
			{
			}
			bool flag = values.All(new global::System.Func<object, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.AndOperationConverter.<>c.<>9.a));
			return flag;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003598 File Offset: 0x00001798
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)973537280;
			short num2 = num;
			num = (short)1579986710;
			short num3 = num;
			num = (short)389525270;
			switch (num3 == num)
			{
			}
			num = (short)2120089600;
			if (num != 0)
			{
			}
			num = (short)1662648321;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
