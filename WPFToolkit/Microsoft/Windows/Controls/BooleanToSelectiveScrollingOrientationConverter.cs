using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000049 RID: 73
	[global::System.Windows.Localizability(global::System.Windows.LocalizationCategory.NeverLocalize)]
	internal sealed class BooleanToSelectiveScrollingOrientationConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060005A0 RID: 1440 RVA: 0x00016404 File Offset: 0x00014604
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			if (value is bool && parameter is global::Microsoft.Windows.Controls.SelectiveScrollingOrientation)
			{
				bool flag = (bool)value;
				global::Microsoft.Windows.Controls.SelectiveScrollingOrientation selectiveScrollingOrientation = (global::Microsoft.Windows.Controls.SelectiveScrollingOrientation)parameter;
				if (flag)
				{
					return selectiveScrollingOrientation;
				}
			}
			return global::Microsoft.Windows.Controls.SelectiveScrollingOrientation.Both;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0001643F File Offset: 0x0001463F
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			throw new global::System.NotImplementedException();
		}
	}
}
