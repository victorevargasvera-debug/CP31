using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001DB RID: 475
	internal class FixedFarConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06001B6B RID: 7019 RVA: 0x000753F6 File Offset: 0x000735F6
		private FixedFarConverter()
		{
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x00075400 File Offset: 0x00073600
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

		// Token: 0x06001B6D RID: 7021 RVA: 0x00075474 File Offset: 0x00073674
		object[] global::System.Windows.Data.IMultiValueConverter.ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return null;
		}

		// Token: 0x04000B50 RID: 2896
		internal static readonly global::Infragistics.Windows.DataPresenter.FixedFarConverter Instance = new global::Infragistics.Windows.DataPresenter.FixedFarConverter();
	}
}
