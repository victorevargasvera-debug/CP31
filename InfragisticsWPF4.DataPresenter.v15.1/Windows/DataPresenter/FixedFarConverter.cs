using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000204 RID: 516
	internal class FixedFarConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06001F7E RID: 8062 RVA: 0x000892CB File Offset: 0x000874CB
		private FixedFarConverter()
		{
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x000892D4 File Offset: 0x000874D4
		object global::System.Windows.Data.IMultiValueConverter.Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (values.Length != 3)
			{
				return global::System.Windows.Data.Binding.DoNothing;
			}
			for (int i = 0; i < 3; i++)
			{
				if (!(values[i] is double))
				{
					return global::System.Windows.Data.Binding.DoNothing;
				}
			}
			double num = (double)values[0];
			double num2 = (double)values[1];
			double num3 = (double)values[2];
			if (num2 < num3)
			{
				return -global::System.Math.Max(num3 - num2 - num, 0.0);
			}
			return 0;
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x00089348 File Offset: 0x00087548
		object[] global::System.Windows.Data.IMultiValueConverter.ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x04000D3E RID: 3390
		internal static readonly global::Infragistics.Windows.DataPresenter.FixedFarConverter Instance = new global::Infragistics.Windows.DataPresenter.FixedFarConverter();
	}
}
