using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200020E RID: 526
	public sealed class StringWithoutMnemonicsConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060013A1 RID: 5025 RVA: 0x000455D4 File Offset: 0x000437D4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			string text = value as string;
			if (text == null)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			return global::Infragistics.Windows.Utilities.StripMnemonics(text, false);
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x000455F8 File Offset: 0x000437F8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			return global::System.Windows.Data.Binding.DoNothing;
		}
	}
}
