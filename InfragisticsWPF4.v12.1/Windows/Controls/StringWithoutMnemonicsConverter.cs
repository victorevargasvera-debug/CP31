using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020001E0 RID: 480
	public sealed class StringWithoutMnemonicsConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060011CD RID: 4557 RVA: 0x0003FD2C File Offset: 0x0003DF2C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			string text = value as string;
			if (text == null)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			return global::Infragistics.Windows.Utilities.StripMnemonics(text, false);
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x0003FD50 File Offset: 0x0003DF50
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}
	}
}
